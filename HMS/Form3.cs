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
    public partial class Form3 : Form
    {
        OracleConnection con;
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            Form11 fm = new Form11();
            this.Hide();
            fm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form12 fm = new Form12();
            this.Hide();
            fm.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSf8ntieupK-tbWufrSMinFAgxHBwpn7ezvAqDSi0rFUsgMsKQ/viewform?pli=1&pli=1");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox6.Image= Image.FromFile(@"D:\HaseeB LibrarY\FAST\5th Semester\DBMS\HMS\Pictures\mess menu.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "select * from student where SID =\'" + Form11.id + "\'";
            insertEmp.CommandType = CommandType.Text;
            OracleDataReader empDR = insertEmp.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "select * from gym where SID =\'" + Form11.id + "\'";
            insertEmp.CommandType = CommandType.Text;
            OracleDataReader empDR = insertEmp.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "select * from mess where SID =\'" + Form11.id + "\'";
            insertEmp.CommandType = CommandType.Text;
            OracleDataReader empDR = insertEmp.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "select * from stdroom where roomno IN ( select roomno from student where sid = \'" + Form11.id + "\')";
            insertEmp.CommandType = CommandType.Text;
            OracleDataReader empDR = insertEmp.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }
    }
}
