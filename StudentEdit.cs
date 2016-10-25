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
    public partial class StudentEdit : DevExpress.XtraEditors.XtraUserControl
    {
        String olduob, oldname, oldfather, oldemail, oldcontact, oldyear, oldprograme;
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
            MySqlCommand command = new MySqlCommand();
            try
            {
                conn.Open();
                command = conn.CreateCommand();
                command.CommandText = "Update Students SET UoB='" + Uob + "',Name='" + Name + "',FatherName='" + Fname + "',Programme='" + Programme + "',EmailAddress='" + Email + "',Contact='" + contact + "',Year='" + Year + "' where Name='" + oldname + "' AND FatherName='" + oldfather + "' AND Programme='" + oldprograme + "' AND EmailAddress='" + oldemail + "' AND Contact='" + oldcontact + "' AND Year='" + oldyear + "'    ";
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
                MessageBox.Show("Data Updated");
            }
            catch (Exception a)
            {
                MessageBox.Show("Something is Wrong "+ a.ToString());
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
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
                        textBox1.Text = reader.GetString(0);
                        textBox2.Text = reader.GetString(1);
                        textBox3.Text = reader.GetString(2);
                        textBox4.Text = reader.GetString(4);
                        textBox5.Text = reader.GetString(5);
                        textBox6.Text = reader.GetString(6);
                        textBox7.Text = reader.GetString(3);
                        olduob = reader.GetString(0);
                        oldname = reader.GetString(1);
                        oldfather = reader.GetString(2);
                        oldemail = reader.GetString(4);
                        oldcontact = reader.GetString(5);
                        oldyear = reader.GetString(6);
                        oldprograme = reader.GetString(3);
                    }
                    conn.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show("Something is Wrong"+a.ToString());
                }
            }
        }

    }
}
