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
        String FileSendpath;

        public SendMail()
        {
            InitializeComponent();
        }

        private void Send_Email_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage("hasikhan144@gmail.com", Totxt.Text, Subjecttxt.Text, Body.Text);
            mail.Attachments.Add(new Attachment(FileSendpath));
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("hasikhan144@gmail.com", "yoyohasikhan1111mhk");
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

        private void Send_Email_MouseEnter(object sender, EventArgs e)
        {
            Send_Email.ForeColor = Color.Black;
            Send_Email.BackColor = Color.White;
        }

        private void Send_Email_MouseLeave(object sender, EventArgs e)
        {
            Send_Email.ForeColor = Color.White;
            Send_Email.BackColor = Color.DarkGreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String path = ofd.FileName.ToString();
                FileSendpath = path;
                label1.Visible = true;
            }
        }



    }
}
