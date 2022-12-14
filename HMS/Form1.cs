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
    public partial class Form1 : Form
    {
        OracleConnection con;
        string user = "admin";
        string pass = "12345";
    
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=HASEEB;PASSWORD=123456";
            con = new OracleConnection(conStr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 fm = new Form11();
            this.Hide();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.pss.Text == pass && this.admin.Text == user) //checking PIN
            {
                MessageBox.Show("\nAccess is granted!");
                Form2 fm = new Form2();
                this.Hide();
                fm.Show();
            }
            else
            {
                MessageBox.Show("Wrong Admin ID or Password!\nAccess is not granted!");
            }
        }

        private void admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                pss.UseSystemPasswordChar = false;
            }
            else
            {
                pss.UseSystemPasswordChar = true;
            }
        }
    }
}
