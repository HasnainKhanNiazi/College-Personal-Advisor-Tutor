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

namespace SEGP
{
    public partial class InsertTeachers : DevExpress.XtraEditors.XtraUserControl
    {
        static String connectionString = "Server=localhost; Database=segp; Uid=root; pwd=";
        MySqlConnection conn = new MySqlConnection(connectionString);
        MySqlCommand mysqlcommand;

        public InsertTeachers()
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

        private void OneStd_Click(object sender, EventArgs e)
        {
            PanelManualStd.Visible = true;
        }


        private void INsertManstd_Click(object sender, EventArgs e)
        {
            try
            {
                String Name = NameStdManul.Text;
                String FatherName = FatherStdManul.Text;
                String Email = EmailStdManul.Text;
                String Contact = ContactStdManul.Text;
                NameStdManul.Text = "";
                FatherStdManul.Text = "";
                EmailStdManul.Text = "";
                ContactStdManul.Text = "";

                mysqlcommand = conn.CreateCommand();
                conn.Open();
                mysqlcommand.CommandText = "insert into Students set Name='" + Name + "',Fathername='" + FatherName + "',Emailaddress = '" + Email + "',Contact='" + Contact + "' ";
                MessageBox.Show("Data Inserted");
                conn.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("Something is Wrong" + a.ToString());
            }
        }

        private void Clearmanstd_Click(object sender, EventArgs e)
        {
            NameStdManul.Text = "";
            FatherStdManul.Text = "";
            EmailStdManul.Text = "";
            ContactStdManul.Text = "";
        }

        private void InsertTeachers_Load(object sender, EventArgs e)
        {
            PanelManualStd.Visible = false;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            mysqlcommand = conn.CreateCommand();
            conn.Open();
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
            conn.Close();
            MessageBox.Show("data inserted");
        }

        //private void Browse_MouseEnter(object sender, EventArgs e)
        //{
        //    Browse.BackColor = Color.White;
         
        //}

        //private void Browse_MouseLeave(object sender, EventArgs e)
        //{
        //    Browse.ForeColor = Color.PaleTurquoise;
        //}


    }
}
