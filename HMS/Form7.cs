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
    public partial class Form7 : Form
    {
        OracleConnection con;
        string meal, m1;
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 fm = new Form2();
            this.Hide();
            fm.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        void updategrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT * FROM mess";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT * FROM mess where dated = \'" + dateTimePicker1.Text.ToString() + "\' and ( meal = \' " + meal + "\' or meal = \'" + m1 + "\') ";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT * FROM mess where sid = \'" + maskedTextBox1.Text.ToString() + "\'";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            updategrid();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            meal = "Breakfast";
            m1 = "breakfast";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            meal = "Lunch";
            m1 = "lunch";
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            meal = "Dinner";
            m1 = "dinner";
        }
    }
}
