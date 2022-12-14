using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;



namespace HMS
{
    public partial class Form11 : Form
    {
        public static string id;
        OracleConnection con;
        OracleCommand com;
        OracleDataAdapter orada;
        string str;
        DataTable dt;
        int RowCount;
        //string pss;
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string UserName = maskedTextBox1.Text.Trim();
            string Password = maskedTextBox2.Text.Trim();
            //OracleConnection con;
            con.Open();
            str = "Select * from Login";
            com = new OracleCommand(str);
            orada = new OracleDataAdapter(com.CommandText, con);
            dt = new DataTable();
            orada.Fill(dt);
            RowCount = dt.Rows.Count;

            for (int i = 0; i < RowCount; i++)
            {
                UserName = dt.Rows[i]["UserName"].ToString();
                Password = dt.Rows[i]["Password"].ToString();
                if (UserName == maskedTextBox1.Text && Password == maskedTextBox2.Text)
                {

                    Form3 fm = new Form3();
                    this.Hide();
                    fm.Show();
                    id = UserName;
                    // pss = Password;

                    break;
                }
                else
                {
                    //MessageBox.Show("Wrong Username or Password!");
                    //break;
                }
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                maskedTextBox2.UseSystemPasswordChar = false;
            }
            else
            {
                maskedTextBox2.UseSystemPasswordChar = true;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        
    }
}
