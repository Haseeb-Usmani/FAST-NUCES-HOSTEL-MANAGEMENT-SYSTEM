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
    public partial class Form5 : Form
    {
        OracleConnection con;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 fm = new Form2();
            this.Hide();
            fm.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            if (checkBox2.Checked && checkBox1.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Jinnah Hall\' or name = \'Iqbal Hall\' ";
            }
            else if(checkBox3.Checked && checkBox1.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Jinnah Hall\' or name = \'Faculty Hall\' ";
            }
            else if(checkBox4.Checked && checkBox1.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Jinnah Hall\' or name = \'Girls Hall\' ";
            }
            else if(checkBox1.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Jinnah Hall\'";
            }
            else if (checkBox2.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Iqbal Hall\'";
            }
            else if (checkBox3.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Faculty Hall\'";
            }
            else if (checkBox4.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Girls Hall\'";
            }
            else
            {
                getEmps.CommandText = "SELECT * FROM building";
            }
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            if (checkBox1.Checked && checkBox2.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Iqbal Hall\' or name = \'Jinnah Hall\' ";
            }
            else if (checkBox3.Checked && checkBox2.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Iqbal Hall\' or name = \'Faculty Hall\' ";
            }
            else if (checkBox4.Checked && checkBox2.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Iqbal Hall\' or name = \'Girls Hall\' ";
            }
            else if (checkBox2.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Iqbal Hall\'";
            }
            else if (checkBox3.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Faculty Hall\'";
            }
            else if (checkBox1.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Jinnah Hall\'";
            }
            else if (checkBox4.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Girls Hall\'";
            }
            else
            {
                getEmps.CommandText = "SELECT * FROM building";
            }
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            if (checkBox2.Checked && checkBox3.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Faculty Hall\' or name = \'Iqbal Hall\' ";
            }
            else if (checkBox3.Checked && checkBox1.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Faculty Hall\' or name = \'Jinnah Hall\' ";
            }
            else if (checkBox4.Checked && checkBox3.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Faculty Hall\' or name = \'Girls Hall\' ";
            }
            else if (checkBox3.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Faculty Hall\'";
            }
            else if(checkBox2.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Iqbal Hall\'";
            }
            else if (checkBox1.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Jinnah Hall\'";
            }
            else if (checkBox4.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Girls Hall\'";
            }
            else
            {
                getEmps.CommandText = "SELECT * FROM building";
            }

            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            if (checkBox2.Checked && checkBox4.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Girls Hall\' or name = \'Iqbal Hall\' ";
            }
            else if (checkBox3.Checked && checkBox4.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Girls Hall\' or name = \'Faculty Hall\' ";
            }
            else if (checkBox1.Checked && checkBox4.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Girls Hall\' or name = \'Jinnah Hall\' ";
            }
            else if (checkBox4.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Girls Hall\'";
            }
            else if (checkBox2.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Iqbal Hall\'";
            }
            else if (checkBox1.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Jinnah Hall\'";
            }
            else if (checkBox3.Checked)
            {
                getEmps.CommandText = "SELECT * FROM building where name = \'Faculty Hall\'";
            }
            else
            {
                getEmps.CommandText = "SELECT * FROM building";
            }
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "select * from stdroom where SID =\'" + maskedTextBox1.Text.ToString() + "\'";
            insertEmp.CommandType = CommandType.Text;
            OracleDataReader empDR = insertEmp.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            if (checkBox5.Checked)
            {
                insertEmp.CommandText = "select * from building where roomsize =\'Full Size\'";
            }
            else
            {
                insertEmp.CommandText = "SELECT * FROM building";
            }
            insertEmp.CommandType = CommandType.Text;
            OracleDataReader empDR = insertEmp.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            if (checkBox6.Checked)
            {
                insertEmp.CommandText = "select * from building where roomsize =\'Single\'";
            }
            else
            {
                insertEmp.CommandText = "SELECT * FROM building";
            }
            insertEmp.CommandType = CommandType.Text;
            OracleDataReader empDR = insertEmp.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            if (checkBox7.Checked)
            {
                insertEmp.CommandText = "select * from building where roomsize =\'Double\'";
            }
            else
            {
                insertEmp.CommandText = "SELECT * FROM building";
            }
            insertEmp.CommandType = CommandType.Text;
            OracleDataReader empDR = insertEmp.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }
    }
}
