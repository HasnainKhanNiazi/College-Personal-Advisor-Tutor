using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SEGP
{
    public partial class LogIn : Form
    {
        String Password, username;
        static String connectionString = "Server=localhost; Database=segp; Uid=root; pwd=";
        MySqlConnection conn = new MySqlConnection(connectionString);

        public LogIn()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor,true);
            User_Nametxt.Focus();
        }

        private void LogInbtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                username = User_Nametxt.Text;
                Password = Passwrodtxt.Text;
                try
                {
                    String ss = "select * from teachers where UserName='" + username + "' AND Password='" + Password + "'  ";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(ss, conn);
                    MySqlCommandBuilder command = new MySqlCommandBuilder(adapter);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    BindingSource binding = new BindingSource();
                    binding.DataSource = table;
                    ggglogin.DataSource = binding;

                    if (table.Rows.Count != 0)
                    {
                            Form1 f = new Form1();
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
                    MessageBox.Show("Something is wrong "+a.ToString());
                }
            }

        }

        private void User_Nametxt_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(User_Nametxt.Text))
            {
                e.Cancel = true;
                User_Nametxt.Focus();
                errorProvider1.SetError(User_Nametxt, "Please Enter Your User Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(User_Nametxt, null);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(204, 217, 230, 242)), panel1.ClientRectangle);
        }

    }
}