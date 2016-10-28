using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace SEGP
{
    public partial class MailGoogle : Form
    {
        int count = 1;
        int n = 1;
        String FileSendpath;

        public MailGoogle()
        {
            InitializeComponent();
            var main = this.Location;
            this.Location = new Point((main.X + 1030), (main.Y+250));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.White;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Gray;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count % 2 != 0)
            {
                if (this.Size.Height <= 40)
                {
                    var main = this.Location;
                    this.Location = new Point((main.X + 0), (main.Y + 440));
                    count++;
                    this.timer1.Stop();
                }
                else
                {
                    this.Height -= 12;
                }
            }
            else
            {
                this.timer1.Enabled = false;
                this.timer1.Stop();
                this.Size = new Size(335,480);
                var main = this.Location;
                this.Location = new Point((main.X + 0), (main.Y + (-440)));
                count++;
                
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void Body_Enter(object sender, EventArgs e)
        {
            if (n == 1)
            {
                Body.Text = "";
                n++;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String path = ofd.FileName.ToString();
                FileSendpath = path;
                label4.Visible = true;
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            button1.BackColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
            button1.BackColor = Color.DarkGreen;
        }
    }
}