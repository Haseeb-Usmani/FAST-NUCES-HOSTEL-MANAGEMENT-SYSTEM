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
    public partial class Form12 : Form
    {
        OracleConnection con;
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            this.Hide();
            fm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT * FROM request";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(100, 1000);
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            if (radioButton1.Checked)
            {
                getEmps.CommandText = "INSERT INTO REQUEST VALUES(\'Electricity\',\'" + num + "\',\'" + Form11.id + "\')";
            }
            else if (radioButton2.Checked)
            {
                getEmps.CommandText = "INSERT INTO REQUEST VALUES(\'Sanitary\',\'" + num + "\',\'" + Form11.id + "\')";
            }
            else if (radioButton3.Checked)
            {
                getEmps.CommandText = "INSERT INTO REQUEST VALUES(\'Sweeper\',\'" + num + "\',\'" + Form11.id + "\')";
            }
            else if (radioButton4.Checked)
            {
                getEmps.CommandText = "INSERT INTO REQUEST VALUES(\'Room Maker\',\'" + num + "\',\'" + Form11.id + "\')";
            }
            else
            {
                getEmps.CommandText = "INSERT INTO REQUEST VALUES(\'Gate Pass\',\'" + num + "\',\'" + Form11.id + "\')";
            }
            getEmps.CommandType = CommandType.Text;
            int rows = getEmps.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Request Generated Successfully! \n You are served Shortly!");
            }
            con.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT * FROM request where type = \'Electricity\'";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT * FROM request where type = \'Sanitary\'";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT * FROM request where type = \'Sweeper\'";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT * FROM request where type = \'Room Maker\'";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT * FROM request where type = \'Gate Pass\'";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }
    }
}
