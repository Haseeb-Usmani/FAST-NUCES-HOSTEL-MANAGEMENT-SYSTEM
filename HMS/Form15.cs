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
using System.Net;
using System.Net.Mail;

namespace HMS
{
    public partial class Form15 : Form
    {
        OracleConnection con;
        int num;
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=HASEEB;PASSWORD=123456";
            con = new OracleConnection(conStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string to, from, pass, messageBody;
            Random rand = new Random();
            num = (rand.Next(1000, 99999));
            MailMessage message = new MailMessage();
            to = textBox1.Text.ToString();
            from = "usmani.haseeb09@gmail.com";
            pass = "haseebusmani.9";
            messageBody = "your reset code is " + num;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password Reseting Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new System.Net.NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("code send successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 fm = new Form11();
            this.Hide();
            fm.Show();
        }
    }
}
