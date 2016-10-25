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
        MySqlConnection conn = new MySqlConnection(connectionString);
        MySqlCommand mysqlcommand;

        public InsertStudents()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Browsetxt.Text = opd.FileName;
            }
        }

        private void LoadSheetbtn_Click(object sender, EventArgs e)
        {
            gggbackend.DataSource = null;
            ggg.DataSource = null;
            ggg1.Columns.Clear();
            String path = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Browsetxt.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(path);
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from [" + Sheettxt.Text + "$]", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ggg.DataSource = dt;
            gggbackend.DataSource = dt;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            mysqlcommand = conn.CreateCommand();
            conn.Open();
            for (int i = 0; i < gggbackend.Rows.Count; i++)
            {
                    String ub = gggbackend.Rows[i].Cells["UoB"].Value.ToString();
                    String name = gggbackend.Rows[i].Cells["Name"].Value.ToString();
                    String father_name = gggbackend.Rows[i].Cells["Father Name"].Value.ToString();
                    String programme = gggbackend.Rows[i].Cells["Programme"].Value.ToString();
                    String email = gggbackend.Rows[i].Cells["Email Address"].Value.ToString();
                    String contact = gggbackend.Rows[i].Cells["contact"].Value.ToString();
                    String Year = gggbackend.Rows[i].Cells["Year"].Value.ToString();

                    mysqlcommand.CommandText = "insert into students set UoB='" + ub + "',Name='" + name + "',Fathername='" + father_name + "',Programme='" + programme + "',Emailaddress = '" + email + "',Contact='" + contact + "',Year='" + Year + "' ";
                    try
                    {
                        mysqlcommand.ExecuteNonQuery();
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("something is wrong" + a.ToString());
                    }
                }
                conn.Close();
                MessageBox.Show("data inserted");
            }

        private void OneStd_Click(object sender, EventArgs e)
        {
            PanelManualStd.Visible = true;
        }

        private void InsertStudents_Click(object sender, EventArgs e)
        {
            PanelManualStd.Visible = false;
        }

        private void Clearmanstd_Click(object sender, EventArgs e)
        {
            UobStdManul.Text = "";
            NameStdManul.Text = "";
            FatherStdManul.Text = "";
            ProgrameStdManul.Text = "";
            EmailStdManul.Text = "";
            ContactStdManul.Text = "";
            YearStdManul.Text = "";
        }

        private void INsertManstd_Click(object sender, EventArgs e)
        {
            try
            {
                String Ub = UobStdManul.Text;
                String Name = NameStdManul.Text;
                String FatherName = FatherStdManul.Text;
                String Programme = ProgrameStdManul.Text;
                String Email = EmailStdManul.Text;
                String Contact = ContactStdManul.Text;
                String Year = YearStdManul.Text;
                UobStdManul.Text = "";
                NameStdManul.Text = "";
                FatherStdManul.Text = "";
                ProgrameStdManul.Text = "";
                EmailStdManul.Text = "";
                ContactStdManul.Text = "";
                YearStdManul.Text = "";

                mysqlcommand = conn.CreateCommand();
                conn.Open();
                mysqlcommand.CommandText = "insert into Students set UoB='" + Ub + "',Name='" + Name + "',Fathername='" + FatherName + "',Programme='" + Programme + "',Emailaddress = '" + Email + "',Contact='" + Contact + "',Year='" + Year + "' ";
                MessageBox.Show("Data Inserted");
                conn.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("Something is Wrong"+a.ToString());
            }
        }
    }
}