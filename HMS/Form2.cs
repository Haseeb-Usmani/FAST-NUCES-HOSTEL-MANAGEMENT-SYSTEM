using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 fm = new Form4();
            this.Hide();
            fm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 fm = new Form5();
            this.Hide();
            fm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 fm = new Form6();
            this.Hide();
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 fm = new Form7();
            this.Hide();
            fm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form9 fm = new Form9();
            this.Hide();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form8 fm = new Form8();
            this.Hide();
            fm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Form10 fm = new Form10();
            this.Hide();
            fm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form13 fm = new Form13();
            this.Hide();
            fm.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form16 fm = new Form16();
            this.Hide();
            fm.Show();
        }
    }
}
