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
    public partial class Form9 : Form
    {
        OracleConnection con;

        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 fm = new Form2();
            this.Hide();
            fm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        void updategrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            if(radioButton1.Checked)
            {
                getEmps.CommandText = "SELECT * FROM visitor where hall = \'Jinnah Hall\'";
            }
            else if(radioButton2.Checked)
            {
                getEmps.CommandText = "SELECT * FROM visitor where hall = \'Iqbal Hall\'";
            }
            else if(radioButton3.Checked)
            {
                getEmps.CommandText = "SELECT * FROM visitor where hall = \'Faculty Hall\'";
            }
            else if(radioButton4.Checked)
            {
                getEmps.CommandText = "SELECT * FROM visitor where hall = \'Girls Hall\'";
            }
            else
            {
                getEmps.CommandText = "SELECT * FROM visitor";
            }
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            updategrid();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            updategrid();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            updategrid();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            updategrid();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            updategrid();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
