using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace SEGP
{
    public partial class InsertDataManually : DevExpress.XtraEditors.XtraUserControl
    {
        String ImagePath,ImagePathTeacher;
        static String connectionString = "Server=localhost; Database=segp; Uid=root; pwd=";
        MySqlConnection conn = new MySqlConnection(connectionString);

        public InsertDataManually()
        {
            InitializeComponent();
        }

        private void checkBoxStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStudent.Checked == true)
            {
                checkBoxStudent.Checked = true;
                checkBoxTeachers.Checked = false;
                PanelStudent.Visible = true;
                PanelTeacher.Visible = false;
            }
            else
            {
                checkBoxTeachers.Checked = true;
                PanelStudent.Visible = false;
                PanelTeacher.Visible = true;
            }
        }

        private void checkBoxTeachers_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTeachers.Checked == true)
            {
                checkBoxTeachers.Checked = true;
                checkBoxStudent.Checked = false;
                PanelStudent.Visible = false;
                PanelTeacher.Visible = true;
            }
            else
            {
                checkBoxStudent.Checked = true;
                PanelStudent.Visible = true;
                PanelTeacher.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImagePath = ofd.FileName;
                pictureBox1.ImageLocation = ImagePath;
            }
        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            String UoB = UoBtxt.Text;
            String Name = Nametxt.Text;
            String Fname = Fnametxt.Text;
            String Programme = Programmetxt.Text;
            String Email = Emailtxt.Text;
            String Contact = Contacttxt.Text;
            String Year = Yeartxt.Text;
            String PAT = PATtxt.Text;

            byte[] image = null;
            FileStream fs = new FileStream(ImagePath,FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            image = br.ReadBytes((int)fs.Length);

            var validatorUoB = new Regex("^1[0-9]{7}$");
            var validatorEmail = new Regex("^([a-z]+[0-9]+[@]{1}namal.edu.pk)$");
            var validatorContact = new Regex("^[0-9]{4}-[0-9]{7}$");
            var validatorYear = new Regex("^Year-[1-4]{1}$");
            if (validatorUoB.IsMatch(UoB) && validatorYear.IsMatch(Year) && validatorEmail.IsMatch(Email) && validatorContact.IsMatch(Contact))
            {
                String ss = "insert into Students(UoB,Name,FatherName,Programme,EmailAddress,Contact,Year,Image,PAT)" + "values('" + UoB + "','" + Name + "','" + Fname + "','" + Programme + "','" + Email + "','" + Contact + "','" + Year + "',@IMG,'" + PAT + "') ;";
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(ss, conn);
                    MySqlDataReader reader;
                    command.Parameters.Add(new MySqlParameter("@IMG", image));
                    reader = command.ExecuteReader();
                    MessageBox.Show("Data Inserted");
                    conn.Close();

                    UoBtxt.Text = "";
                    Nametxt.Text = "";
                    Fnametxt.Text = "";
                    Programmetxt.Text = "";
                    Emailtxt.Text = "";
                    Contacttxt.Text = "";
                    Yeartxt.Text = "";
                    PATtxt.Text = "";
                }
                catch (Exception a)
                {
                    MessageBox.Show("Can't Insert Data" + a.ToString());
                }
            }
            else
            {
                MessageBox.Show("Your Entered Data is Not Correct");
            }
        }

        private void UoBtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImagePathTeacher = ofd.FileName;
                pictureBox2.ImageLocation = ImagePathTeacher;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Name = Tname.Text;
            String Fname = TFname.Text;
            String Qualification = TQuali.Text;
            String Field = TField.Text;
            String Email = Temail.Text;
            String Contact = Tcontact.Text;
            String Address = TAddress.Text;
            String Load = TLoad.Text;

            byte[] image = null;
            FileStream fs = new FileStream(ImagePathTeacher, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            image = br.ReadBytes((int)fs.Length);

            var validatorEmail = new Regex("^([a-z]+[0-9]+[@]{1}namal.edu.pk)$");
            var validatorContact = new Regex("^[0-9]{4}-[0-9]{7}$");
            var validaorLoad = new Regex("^[P][F]{1}$");

            if (validatorEmail.IsMatch(Email) && validatorContact.IsMatch(Contact) && validaorLoad.IsMatch(Load))
            {
                String ss = "insert into Teachers(Name,FatherName,Qualification,Field,EmailAddress,Contact,Address,Status,Image)" + "values('"+ Name + "','" + Fname + "','" + Qualification + "','"+Field+"','" + Email + "','" + Contact + "','" + Address + "','"+Load+"',@IMG) ;";
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(ss, conn);
                    MySqlDataReader reader;
                    command.Parameters.Add(new MySqlParameter("@IMG", image));
                    reader = command.ExecuteReader();
                    MessageBox.Show("Data Inserted");
                    conn.Close();

                    Tname.Text = "";
                    TFname.Text = "";
                    TQuali.Text = "";
                    TField.Text = "";
                    Temail.Text = "";
                    Tcontact.Text = "";
                    TAddress.Text = "";
                }
                catch (Exception a)
                {
                    MessageBox.Show("Can't Insert Data" + a.ToString());
                }
            }
            else
            {
                MessageBox.Show("Your Entered Data is Not Correct");
            }
        }

        private void Tname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
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

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
            button2.BackColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
            button2.BackColor = Color.DarkGreen;
        }







    }
}
