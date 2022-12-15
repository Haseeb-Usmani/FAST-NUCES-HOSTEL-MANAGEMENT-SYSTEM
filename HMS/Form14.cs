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
    public partial class Form14 : Form
    {
        OracleConnection con;
        OracleCommand com;
        OracleDataAdapter orada;
        string str;
        DataTable dt;
        int RowCount;
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = Form11.id;
            string Password = maskedTextBox1.Text.Trim();
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
                if (UserName == Form11.id && Password == maskedTextBox1.Text)
                {
                    if (maskedTextBox2.Text == maskedTextBox3.Text && maskedTextBox2.Text.ToString() != "") 
                    {
                        OracleCommand insertEmp = con.CreateCommand();
                        insertEmp.CommandText = "UPDATE STUDENT SET password = \'" + maskedTextBox3.Text.ToString() + "\' where sid = \'" + Form11.id + "\'";
                        insertEmp.CommandType = CommandType.Text;
                        int rows = insertEmp.ExecuteNonQuery();
                        if (rows > 0)
                            MessageBox.Show("Password UPDATED Successfully!");

                        OracleCommand Emp = con.CreateCommand();
                        Emp.CommandText = "UPDATE login SET password = \'" + maskedTextBox3.Text.ToString() + "\' where username = \'" + Form11.id + "\'";
                        Emp.CommandType = CommandType.Text;
                        Emp.ExecuteNonQuery();
                        //if (rrows > 0)
                           // MessageBox.Show("Password UPDATED Successfully!");
                        Form3 fm = new Form3();
                        this.Hide();
                        fm.Show();
                        // id = UserName;
                        // pss = Password;

                        break;
                    }
                    else
                    {
                        MessageBox.Show("New & Confirm Password are different!");
                        break;
                    }
                }
                else
                {
                    //MessageBox.Show("Wrong Username or Password!");
                    //break;
                }
            }
            con.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                maskedTextBox1.UseSystemPasswordChar = false;
                maskedTextBox2.UseSystemPasswordChar = false;
                maskedTextBox3.UseSystemPasswordChar = false; 
            }
            else
            {
               maskedTextBox1.UseSystemPasswordChar = true;
               maskedTextBox2.UseSystemPasswordChar = true;
               maskedTextBox3.UseSystemPasswordChar = true;
            }
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            this.Hide();
            fm.Show();
        }
    }
}
