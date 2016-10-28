using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SEGP
{
    public partial class Login : Form
    {
        String username;
        String password;
        static String connectionString = "Server=localhost; Database=segp; Uid=root; pwd=";
        MySqlConnection conn = new MySqlConnection(connectionString);

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            UserNametxt.Focus();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            p1.BackColor = Color.DimGray;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            p1.BackColor = Color.WhiteSmoke;
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            p2.BackColor = Color.DimGray;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            p2.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                username = UserNametxt.Text;
                password = UserPasswordtxt.Text;
                try
                {
                    String ss = "select * from Login where UserName='" + username + "' AND Password='" + password + "'  ";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(ss, conn);
                    MySqlCommandBuilder command = new MySqlCommandBuilder(adapter);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    BindingSource binding = new BindingSource();
                    binding.DataSource = table;
                    ggglogin.DataSource = binding;

                    if (table.Rows.Count != 0)
                    {
                        SEGP.Form1 f = new SEGP.Form1();
                        this.Hide();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Your UserName/Password is Wrong");
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show("Something is wrong " + a.ToString());
                }
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
            button1.BackColor = Color.Lime;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {

            pictureBox4.BackColor = Color.Red;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.White;
        }

        private void UserNametxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(UserNametxt.Text))
            {
                e.Cancel = true;
                UserNametxt.Focus();
                errorProvider1.SetError(UserNametxt, "Please Enter Your User Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(UserNametxt, null);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MySqlCommand commad = new MySqlCommand();
            conn.Open();
            commad = conn.CreateCommand();
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            String randomstring = new string(Enumerable.Repeat(chars, 10).Select(s => s[random.Next(10)]).ToArray());
            commad.CommandText = "Update Login";
            new MailClass("hasikhan144@gmail.com","This is an automated generate email There is no need to reply \n Just copy the given token and paste it in the Password Field and then Reset your password Token='"+randomstring+"'","Reset Your Password");
            
        }

        private void p2_MouseEnter(object sender, EventArgs e)
        {

        }
       
      
    }
}
