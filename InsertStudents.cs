using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace SEGP
{
    public partial class InsertStudents : DevExpress.XtraEditors.XtraUserControl
    {
        static String connectionString = "Server=localhost; Database=segp; Uid=root; pwd=";
        MySqlConnection conn1 = new MySqlConnection(connectionString);
        MySqlCommand mysqlcommand;
        String FilePath;

        public InsertStudents()
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
                String Sheet = "Sheet2";
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from [" + Sheet + "$]", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                gggbackend.DataSource = dt;

                mysqlcommand = conn1.CreateCommand();
                conn1.Open();
                for (int i = 0; i < gggbackend.Rows.Count; i++)
                {
                    String ub = gggbackend.Rows[i].Cells["UoB"].Value.ToString();
                    String name = gggbackend.Rows[i].Cells["Name"].Value.ToString();
                    String father_name = gggbackend.Rows[i].Cells["Father Name"].Value.ToString();
                    String programme = gggbackend.Rows[i].Cells["Programme"].Value.ToString();
                    String email = gggbackend.Rows[i].Cells["Email Address"].Value.ToString();
                    String contact = gggbackend.Rows[i].Cells["contact"].Value.ToString();
                    String Year = gggbackend.Rows[i].Cells["Year"].Value.ToString();
                    String PAT = gggbackend.Rows[i].Cells["PAT"].Value.ToString();

                    mysqlcommand.CommandText = "insert into students set UoB='" + ub + "',Name='" + name + "',Fathername='" + father_name + "',Programme='" + programme + "',Emailaddress = '" + email + "',Contact='" + contact + "',Year='" + Year + "', PAT='"+PAT+"'";
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
                MessageBox.Show("Data inserted");


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

                    //start

                    gggbackend.DataSource = null;
                    String path = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FilePath + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
                    OleDbConnection conn = new OleDbConnection(path);
                    String Sheet = "Sheet2";
                    OleDbDataAdapter adapter = new OleDbDataAdapter("select * from [" + Sheet + "$]", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    gggbackend.DataSource = dt;

                    mysqlcommand = conn1.CreateCommand();
                    conn1.Open();
                    for (int i = 0; i < gggbackend.Rows.Count; i++)
                    {
                        String ub = gggbackend.Rows[i].Cells["UoB"].Value.ToString();
                        String name = gggbackend.Rows[i].Cells["Name"].Value.ToString();
                        String father_name = gggbackend.Rows[i].Cells["Father Name"].Value.ToString();
                        String programme = gggbackend.Rows[i].Cells["Programme"].Value.ToString();
                        String email = gggbackend.Rows[i].Cells["Email Address"].Value.ToString();
                        String contact = gggbackend.Rows[i].Cells["contact"].Value.ToString();
                        String Year = gggbackend.Rows[i].Cells["Year"].Value.ToString();
                        String PAT = gggbackend.Rows[i].Cells["PAT"].Value.ToString();

                        mysqlcommand.CommandText = "insert into students set UoB='" + ub + "',Name='" + name + "',Fathername='" + father_name + "',Programme='" + programme + "',Emailaddress = '" + email + "',Contact='" + contact + "',Year='" + Year + "',PAT='"+PAT+"' ";
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
                    MessageBox.Show("data inserted");
                    //end
                }

            }
        }



    }
}