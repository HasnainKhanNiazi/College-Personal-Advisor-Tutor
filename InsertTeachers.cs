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
using System.Data.OleDb;
using System.IO;

namespace SEGP
{
    public partial class InsertTeachers : DevExpress.XtraEditors.XtraUserControl
    {
        static String connectionString = "Server=localhost; Database=segp; Uid=root; pwd=";
        MySqlConnection conn1 = new MySqlConnection(connectionString);
        MySqlCommand mysqlcommand;
        String FilePath;

        public InsertTeachers()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FilePath = opd.FileName;


                gggbackend.DataSource = null;
                String path = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FilePath + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
                OleDbConnection conn = new OleDbConnection(path);
                String sheet = "Sheet1";
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from [" + sheet + "$]", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                gggbackend.DataSource = dt;


                mysqlcommand = conn1.CreateCommand();
                conn1.Open();
                for (int i = 0; i < gggbackend.Rows.Count; i++)
                {
                    String name = gggbackend.Rows[i].Cells["Name"].Value.ToString();
                    String Qualification = gggbackend.Rows[i].Cells["Qualification"].Value.ToString();
                    String field = gggbackend.Rows[i].Cells["Field"].Value.ToString();
                    String father_name = gggbackend.Rows[i].Cells["Father Name"].Value.ToString();
                    String email = gggbackend.Rows[i].Cells["Email Address"].Value.ToString();
                    String contact = gggbackend.Rows[i].Cells["Contact"].Value.ToString();
                    String Address = gggbackend.Rows[i].Cells["Address"].Value.ToString();

                    mysqlcommand.CommandText = "insert into Teachers set Name='" + name + "',Fathername='" + father_name + "',Qualification='" + Qualification + "',Field='" + field + "',Emailaddress = '" + email + "',Contact='" + contact + "',Address='" + Address + "' ";
                    try
                    {
                        mysqlcommand.ExecuteNonQuery();
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("something is wrong" + a.ToString());
                    }
                }
                conn1.Close();
                MessageBox.Show("Data Inserted");
            }


        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.Move;
                e.Effect = DragDropEffects.All;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string filePath in files)
                {
                    FilePath = filePath;
                    MessageBox.Show(filePath);

                    //start

                    gggbackend.DataSource = null;
                    String path = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FilePath + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
                    OleDbConnection conn = new OleDbConnection(path);
                    String sheet = "Sheet1";
                    OleDbDataAdapter adapter = new OleDbDataAdapter("select * from [" + sheet + "$]", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    gggbackend.DataSource = dt;


                    mysqlcommand = conn1.CreateCommand();
                    conn1.Open();
                    for (int i = 0; i < gggbackend.Rows.Count; i++)
                    {
                        String name = gggbackend.Rows[i].Cells["Name"].Value.ToString();
                        String Qualification = gggbackend.Rows[i].Cells["Qualification"].Value.ToString();
                        String field = gggbackend.Rows[i].Cells["Field"].Value.ToString();
                        String father_name = gggbackend.Rows[i].Cells["Father Name"].Value.ToString();
                        String email = gggbackend.Rows[i].Cells["Email Address"].Value.ToString();
                        String contact = gggbackend.Rows[i].Cells["Contact"].Value.ToString();
                        String Address = gggbackend.Rows[i].Cells["Address"].Value.ToString();

                        mysqlcommand.CommandText = "insert into Teachers set Name='" + name + "',Fathername='" + father_name + "',Qualification='" + Qualification + "',Field='" + field + "',Emailaddress = '" + email + "',Contact='" + contact + "',Address='" + Address + "' ";
                        try
                        {
                            mysqlcommand.ExecuteNonQuery();
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("something is wrong" + a.ToString());
                        }
                    }
                    conn1.Close();
                    MessageBox.Show("Data Inserted");

                    //end

                }
            }
        }
    }
}

