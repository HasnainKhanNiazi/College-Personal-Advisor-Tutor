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
    public partial class StudentEdit : DevExpress.XtraEditors.XtraUserControl
    {
        String olduob, oldname, oldfather, oldemail, oldcontact, oldyear, oldprograme,oldPAT;
        static String connectionString = "Server=localhost; Database=segp; Uid=root; pwd=";
        MySqlConnection conn = new MySqlConnection(connectionString);

        public StudentEdit()
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
            String Uob = textBox1.Text;
            String Name = textBox2.Text;
            String Fname = textBox3.Text;
            String Email = textBox4.Text;
            String contact = textBox5.Text;
            String Year = textBox6.Text;
            String Programme = textBox7.Text;
            String NewPAT = textBox9.Text;
            var validatorUoB = new Regex("^1[0-9]{7}$");
            var validatorEmail = new Regex("^([a-z]+[0-9]+[@]{1}namal.edu.pk)$");
            var validatorContact = new Regex("^[0-9]{4}-[0-9]{7}$");
            var validatorYear = new Regex("^Year-[1-4]{1}$");
            if (validatorUoB.IsMatch(Uob) && validatorYear.IsMatch(Year) && validatorEmail.IsMatch(Email) && validatorContact.IsMatch(contact))
            {
                MySqlCommand command = new MySqlCommand();
                try
                {
                    conn.Open();
                    command = conn.CreateCommand();
                    command.CommandText = "Update Students SET UoB='" + Uob + "',Name='" + Name + "',FatherName='" + Fname + "',Programme='" + Programme + "',EmailAddress='" + Email + "',Contact='" + contact + "',Year='" + Year + "',PAT='"+NewPAT+"' where Name='" + oldname + "' AND FatherName='" + oldfather + "' AND Programme='" + oldprograme + "' AND EmailAddress='" + oldemail + "' AND Contact='" + oldcontact + "' AND Year='" + oldyear + "'    ";
                    command.ExecuteNonQuery();
                    conn.Close();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    MessageBox.Show("Data Updated");
                }
                catch (Exception a)
                {
                    MessageBox.Show("Something is Wrong " + a.ToString());
                }   
            }
            else
            {
                MessageBox.Show("Your Input is False");
            }
            
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MySqlCommand command = new MySqlCommand();
                try
                {
                    String Uobsearch = textBox8.Text;
                    conn.Open();
                    command = conn.CreateCommand();
                    command.CommandText = "Select * from Students where UoB='" + Uobsearch + "' ";
                    command.ExecuteNonQuery();
                    command.Connection = conn;
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        textBox1.Text = reader.GetString(1);
                        textBox2.Text = reader.GetString(2);
                        textBox3.Text = reader.GetString(3);
                        textBox4.Text = reader.GetString(5);
                        textBox5.Text = reader.GetString(6);
                        textBox6.Text = reader.GetString(7);
                        textBox7.Text = reader.GetString(4);
                        textBox9.Text = reader.GetString(9);
                        olduob = reader.GetString(1);
                        oldname = reader.GetString(2);
                        oldfather = reader.GetString(3);
                        oldemail = reader.GetString(5);
                        oldcontact = reader.GetString(6);
                        oldyear = reader.GetString(7);
                        oldprograme = reader.GetString(4);
                        oldPAT = reader.GetString(9);
                    }
                    conn.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show("Something is Wrong" + a.ToString());
                }


            }
        }


    }
}
