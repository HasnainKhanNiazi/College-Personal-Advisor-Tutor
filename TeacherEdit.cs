using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;

namespace SEGP
{
    public partial class TeacherEdit : DevExpress.XtraEditors.XtraUserControl
    {
        String oldname, oldfather,oldemail;
        static String connectionString = "Server=localhost; Database=segp; Uid=root; pwd=";
        MySqlConnection conn = new MySqlConnection(connectionString);

        public TeacherEdit()
        {
            InitializeComponent();
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

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                MySqlCommand command = new MySqlCommand();
                try
                {
                    String NameSearch = textBox8.Text;
                    conn.Open();
                    command = conn.CreateCommand();
                    command.CommandText = "Select * from Teachers where Name='" + NameSearch + "' ";
                    command.ExecuteNonQuery();
                    command.Connection = conn;
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Nametxt.Text = reader.GetString(0);
                        Fnametxt.Text = reader.GetString(1);
                        Emailtxt.Text = reader.GetString(4);
                        Contacttxt.Text = reader.GetString(5);
                        Qualificationtxt.Text = reader.GetString(2);
                        fieldtxt.Text = reader.GetString(3);
                        Addresstxt.Text = reader.GetString(6);
                        oldfather = reader.GetString(1);
                        oldname = reader.GetString(0);
                        oldemail = Emailtxt.Text;
                    }
                    conn.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show("Something is Wrong" + a.ToString());
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            String Name = Nametxt.Text;
            String Fname = Fnametxt.Text;
            String Email = Emailtxt.Text;
            String contact = Contacttxt.Text;
            String quali = Qualificationtxt.Text;
            String Field = fieldtxt.Text;
            String Address = Addresstxt.Text;
            MySqlCommand command = new MySqlCommand();
            try
            {
                conn.Open();
                command = conn.CreateCommand();
                command.CommandText = "Update Teachers SET Name='" + Name + "',FatherName='" + Fname + "',EmailAddress='" + Email + "',Contact='" + contact + "', Address='"+Address+"',Field='"+Field+"', Qualification='"+quali+"'  where Name='" + oldname + "' AND FatherName='" + oldfather+"' AND EmailAddress='"+oldemail+"' ";
                command.ExecuteNonQuery();
                conn.Close();
                Nametxt.Text = "";
                Fnametxt.Text = "";
                Emailtxt.Text = "";
                Qualificationtxt.Text = "";
                Contacttxt.Text = "";
                fieldtxt.Text = "";
                Addresstxt.Text = "";
                MessageBox.Show("Data Updated");
            }
            catch (Exception a)
            {
                MessageBox.Show("Something is Wrong " + a.ToString());
            }
        }
    }
}
