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
    public partial class Form4 : Form
    {
        OracleConnection con;
        string hall;
        string sizee;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            this.Hide();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(1000, 2000);
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "INSERT INTO student VALUES(\'" + maskedTextBox1.Text.ToString() + "\',\'" + textBox1.Text.ToString() + "\',\'" + textBox2.Text.ToString() + "\',\'" + maskedTextBox3.Text.ToString() + "\'," + textBox6.Text.ToString() + ",\'" + maskedTextBox2.Text.ToString() + "\',\'" + textBox7.Text.ToString() + "\',\'" + hall + "\',\'" + sizee + "\'," + num + ",\'" + textBox3.Text.ToString() + "\')";
            insertEmp.CommandType = CommandType.Text;
            int rows = insertEmp.ExecuteNonQuery();
            if (rows > 0)
               MessageBox.Show("STUDENT Inserted Successfully!");
            con.Close();
            con.Open();
            OracleCommand insertstd = con.CreateCommand();
            insertstd.CommandText = "INSERT INTO stdroom values(\'" + maskedTextBox1.Text.ToString() + "\',\'" + hall + "\',\'" + textBox7.Text.ToString() + "\',\'" + sizee + "\')";
            insertstd.CommandType = CommandType.Text;
            rows = insertstd.ExecuteNonQuery();
            if(rows>0)
            {
                MessageBox.Show("Building Table Updated");
            }
            con.Close();
            con.Open();
            OracleCommand std = con.CreateCommand();
            std.CommandText = "INSERT INTO login values(\'" + maskedTextBox1.Text.ToString() + "\'," + num + ")";
            std.CommandType = CommandType.Text;
            rows = std.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Building Table Updated");
            }
            con.Close();

            con.Open();
            OracleCommand insertbuild = con.CreateCommand();
            insertbuild.CommandText = "UPDATE building SET seats = seats - 1 where name = \'" + hall + "\' AND  ROOMSIZE = \'" + sizee + "\'";
            insertbuild.CommandType = CommandType.Text;
            rows = insertbuild.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Building Info UPDATED Successfully!");
            con.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            hall = "Jinnah Hall";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            hall = "Iqbal Hall";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            hall = "Faculty Hall";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            hall = "Girls Hall";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            sizee = "Full Size";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            sizee = "Single";
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            sizee = "Double";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "DELETE FROM STUDENT WHERE sid = \'" + maskedTextBox1.Text.ToString() + "\'";
            insertEmp.CommandType = CommandType.Text;
            int rows = insertEmp.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Student Deleted Successfully!");
            con.Close();
            con.Open();
            OracleCommand insertstd = con.CreateCommand();
            insertstd.CommandText = "delete from stdroom where sid = \'" + maskedTextBox1.Text.ToString() + "\'";
            insertstd.CommandType = CommandType.Text;
            rows = insertstd.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Building Table Updated");
            }
            con.Close();
            con.Open();
            OracleCommand insertbuild = con.CreateCommand();
            insertbuild.CommandText = "UPDATE building SET seats = seats + 1 where name = \'" + hall + "\' AND  ROOMSIZE = \'" + sizee + "\'";
            insertbuild.CommandType = CommandType.Text;
            rows = insertbuild.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Building Info UPDATED Successfully!");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "UPDATE STUDENT SET SID = \'" + maskedTextBox1.Text.ToString() + "\',NAME =\'" + textBox1.Text.ToString() + "\',FNAME=\'" + textBox2.Text.ToString() + "\',DOB=\'" + maskedTextBox3.Text.ToString() + "\',SEMESTER=" + textBox6.Text.ToString() + ",CNIC=\'" + maskedTextBox2.Text.ToString() + "\',ROOMNO=\'" + textBox7.Text.ToString() + "\',BUILDING=\'" + hall + "\',ROOMSIZE=\'" + sizee + "\' where sid = \'" + maskedTextBox1.Text.ToString() + "\'";
            insertEmp.CommandType = CommandType.Text;
            int rows = insertEmp.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Student UPDATED Successfully!");
            con.Close();
            con.Open();
            OracleCommand insertstd = con.CreateCommand();
            insertstd.CommandText = "UPDATE stdroom SET sid =\'" + maskedTextBox1.Text.ToString() + "\',build = \'" + hall + "\',roomno=\'" + textBox7.Text.ToString() + "\',roomsize=\'" + sizee + "\'where sid = \'" + maskedTextBox1.Text.ToString() + "\'";
            insertstd.CommandType = CommandType.Text;
            rows = insertstd.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Building Table Updated");
            }
            con.Close();
          
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            if (maskedTextBox1.Text.ToString() != "   -")
            {
                insertEmp.CommandText = "Insert into gym values(\'" + maskedTextBox1.Text.ToString() + "\',\'" + DateTime.Now.ToShortDateString() + "\')";
                insertEmp.CommandType = CommandType.Text;
                int rows = insertEmp.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Congratulation!! you now own GYM Membership!");
            }
            else
            {
                MessageBox.Show("Error!! No Roll Number Entered...");
            }
            
            con.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
