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
    public partial class Form10 : Form
    {
        OracleConnection con;

        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            this.Hide();
            fm.Show();
        }
        void updategrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            if (radioButton1.Checked)
            {
                getEmps.CommandText = "SELECT * FROM bill where status = \'paid\'";
            }
            else if (radioButton2.Checked)
            {
                getEmps.CommandText = "SELECT * FROM bill where status = \'unpaid\'";
            }
            else
            {
                getEmps.CommandText = "SELECT * FROM bill";
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

        private void Form10_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            updategrid();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            updategrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT * FROM bill where sid = \'" + maskedTextBox1.Text.ToString() + "\'";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }
    }
}
