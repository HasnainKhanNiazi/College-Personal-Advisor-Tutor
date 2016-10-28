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
using System.Text.RegularExpressions;

namespace SEGP
{
    public partial class TeacherEdit : DevExpress.XtraEditors.XtraUserControl
    {
        String oldname, oldfather,oldemail,oldstatus;
        int NOSMax;
        int NewNOSInt;
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


        private void button1_Click(object sender, EventArgs e)
        {
            String Name = Nametxt.Text;
            String Fname = Fnametxt.Text;
            String Email = Emailtxt.Text;
            String contact = Contacttxt.Text;
            String quali = Qualificationtxt.Text;
            String Field = fieldtxt.Text;
            String Address = Addresstxt.Text;
            String Status = Statustxt.Text;
            String NOS = NOStxt.Text;
            MySqlCommand command = new MySqlCommand();
            try
            {
                
                var validatorEmail = new Regex("^([a-z]+[0-9]+[@]{1}namal.edu.pk)$");
                var validatorContact = new Regex("^[0-9]{4}-[0-9]{7}$");
                
                if (Status.Equals(oldstatus))
                {
                    if (oldstatus == "P")
                    {
                        NOSMax = 4;
                        NewNOSInt = Convert.ToInt32(NOS);
                    }
                    else if (oldstatus == "F")
                    {
                        NOSMax = 8;
                        NewNOSInt = Convert.ToInt32(NOS);
                    }
                }
                else if (Status != oldstatus)
                {
                    if (Status == "P")
                    {
                        NewNOSInt = Convert.ToInt32(NOS);
                        NOSMax = 4;
                        
                    }
                    else if (Status == "F")
                    {
                        NewNOSInt = Convert.ToInt32(NOS);
                        NOSMax = 8;
                    }
                }
                
                if (NewNOSInt <= NOSMax)
                {
                    if (validatorEmail.IsMatch(Email) && validatorContact.IsMatch(contact))
                    {
                        conn.Open();
                        command = conn.CreateCommand();
                        command.CommandText = "Update Teachers SET Name='" + Name + "',FatherName='" + Fname + "',EmailAddress='" + Email + "',Contact='" + contact + "', Address='" + Address + "',Field='" + Field + "', Qualification='" + quali + "',Status='" + Status + "',NOS='" + NOS + "'  where Name='" + oldname + "' AND FatherName='" + oldfather + "' AND EmailAddress='" + oldemail + "' ";
                        command.ExecuteNonQuery();
                        conn.Close();
                        Nametxt.Text = "";
                        Fnametxt.Text = "";
                        Emailtxt.Text = "";
                        Qualificationtxt.Text = "";
                        Contacttxt.Text = "";
                        fieldtxt.Text = "";
                        Addresstxt.Text = "";
                        textBox8.Text = "";
                        Statustxt.Text = "";
                        NOStxt.Text = "";
                        MessageBox.Show("Data Updated");
                    }
                }
                else
                {
                    MessageBox.Show("Number of Students is Full");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Something is Wrong " + a.ToString());
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
                        Nametxt.Text = reader.GetString(1);
                        Fnametxt.Text = reader.GetString(2);
                        Emailtxt.Text = reader.GetString(5);
                        Contacttxt.Text = reader.GetString(6);
                        Qualificationtxt.Text = reader.GetString(3);
                        fieldtxt.Text = reader.GetString(4);
                        Addresstxt.Text = reader.GetString(7);
                        Statustxt.Text = reader.GetString(8);
                        NOStxt.Text = reader.GetString(9);
                        oldfather = reader.GetString(2);
                        oldname = reader.GetString(1);
                        oldemail = reader.GetString(5);
                        oldstatus = reader.GetString(8);
                    }
                    conn.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show("Something is Wrong" + a.ToString());
                }
            }
        }

        private void Nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void Fnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        

    }
}
