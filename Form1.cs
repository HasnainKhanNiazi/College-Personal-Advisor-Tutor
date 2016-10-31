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
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        static String connectionString = "Server=localhost; Database=segp; Uid=root; pwd=";
        MySqlConnection conn = new MySqlConnection(connectionString);
        String NumberofTeachers;
        int NOT;
        String ID, Status, NOS,TName;
        int k;
        int count = 1;
        int countTeahers = 1;

        public Form1()
        {
            InitializeComponent();
            // Handling the QueryControl event that will populate all automatically generated Documents
            this.windowsUIView1.QueryControl += windowsUIView1_QueryControl;

        }

        // Assigning a required content for each auto generated Document
        void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            if (e.Document == year2Document)
                e.Control = new SEGP.Year2();
            if (e.Document == year1Document)
                e.Control = new SEGP.Year1();
            if (e.Document == year4Document)
                e.Control = new SEGP.Year4();
            if (e.Document == year3Document)
                e.Control = new SEGP.Year3();
            if (e.Document == sendMailDocument)
                e.Control = new SEGP.SendMail();
            if (e.Document == partialTeacherDocument)
                e.Control = new SEGP.PartialTeacher();
            if (e.Document == fullLoadDocument)
                e.Control = new SEGP.FullLoad();
            if (e.Document == teacherEditDocument)
                e.Control = new SEGP.TeacherEdit();
            if (e.Document == studentEditDocument)
                e.Control = new SEGP.StudentEdit();
            if (e.Document == insertStudentsDocument)
                e.Control = new SEGP.InsertStudents();
            if (e.Document == insertTeachersDocument)
                e.Control = new SEGP.InsertTeachers();
            if (e.Document == CreditsDocument)
                e.Control = new SEGP.Developers();
            if (e.Document == helpDocument)
                e.Control = new SEGP.Help();
            if (e.Document == insertDataManuallyDocument)
                e.Control = new SEGP.InsertDataManually();
            if (e.Document == pATListDocument)
                e.Control = new SEGP.PATList();
            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        public void NOTMethod()
        {
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand();
                command = conn.CreateCommand();
                command.CommandText = "Select count(*) from Teachers";
                command.Connection = conn;
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                NumberofTeachers = reader.GetString(0);
                NOT = Convert.ToInt32(NumberofTeachers);
                conn.Close();

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        public void TeacherMethod()
        {
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand();
                command = conn.CreateCommand();
                command.CommandText = "Select * from Teachers where ID='"+countTeahers+"' ";
                command.Connection = conn;
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                ID = reader.GetString(0);
                TName = reader.GetString(1);
                Status = reader.GetString(8);
                NOS = reader.GetString(9);
                conn.Close();
                countTeahers++;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void PAT_Click(object sender, DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileClickEventArgs e)
        {
            NOTMethod();
            conn.Close();

            for (int i = 1; i <= NOT; i++)
            {
                TeacherMethod();
                conn.Close();

                if(Status == "P")
                {
                    k = 4;
                }
                else if (Status == "F")
                {
                    k = 8;
                }
                for (int j = 1; j <= k; j++)
                {
                    MySqlCommand command = new MySqlCommand();
                    conn.Open();
                    command = conn.CreateCommand();
                    command.CommandText = "select * from students where ID='" + count + "' ";
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    String UOB = reader.GetString(1);
                    String PAT = reader.GetString(9);
                    reader.Close();
                    command.CommandText = "UPDATE students SET PAT='" + TName + "' where UoB='" + UOB + "' ";
                    command.ExecuteNonQuery();
                    command.CommandText = "UPDATE Teachers SET NOS=" + j + " where ID='" + ID + "' ";
                    command.ExecuteNonQuery();
                    count++;
                    conn.Close();
                }
            }
            MessageBox.Show("Data Inserted");



        }


    }

}
