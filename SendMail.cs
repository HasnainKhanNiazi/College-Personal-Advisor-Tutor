using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace SEGP
{
    public partial class SendMail : UserControl
    {
        int n = 1;

        public SendMail()
        {
            InitializeComponent();
            passwordtxt.PasswordChar = '*';
        }

        private void Send_Email_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage(Fromtxt.Text, Totxt.Text, Subjecttxt.Text, Body.Text);
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(Fromtxt.Text, passwordtxt.Text);
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Mail Sent");
        }

        private void Body_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (n == 1)
            {
                Body.Text = "";
                n++;
            }
        }


    }
}
