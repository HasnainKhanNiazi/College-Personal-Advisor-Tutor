using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Text.RegularExpressions;

namespace SEGP
{
    public partial class FullLoad : UserControl
    {
        String OLFFname,OLDName;
        ContextMenu contextmenu = new ContextMenu();
        MenuItem menuMail = new MenuItem("Mail");
        MenuItem menuPDF = new MenuItem("Generate PDF");
        MenuItem menudelete = new MenuItem("Delete Data");
        MenuItem menuedit = new MenuItem("Save Data");
        static String connectionString = "Server=localhost; Database=segp; Uid=root; pwd=";
        MySqlConnection conn = new MySqlConnection(connectionString);
        String ss = "select Name,FatherName,Qualification,Field,EmailAddress,Contact,Address,NOS,Image from Teachers where Status='F'";

        public FullLoad()
        {
            InitializeComponent();
            contextmenu.MenuItems.AddRange(new MenuItem[] { menuMail, menudelete, menuedit, menuPDF });
            ggg.ContextMenu = contextmenu;
            menudelete.Click += new System.EventHandler(this.menudeleteClick);
            menuedit.Click += new System.EventHandler(this.menueditClick);
            menuPDF.Click += new System.EventHandler(this.menuPDFClick);
            menuMail.Click += new System.EventHandler(this.menuMailClick);
        }

        private void menuPDFClick(object sender, System.EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Teachers.pdf", FileMode.Create));
            doc.Open();

            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
            PdfPCell cell = new PdfPCell(new Phrase("Teachers", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLUE)));
            cell.Colspan = 9;
            cell.BackgroundColor = new iTextSharp.text.BaseColor(Color.Coral);
            cell.HorizontalAlignment = 1;
            table.AddCell(cell);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                table.AddCell(new Phrase(dataGridView1.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 7f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.GRAY)));
            }

            table.HeaderRows = 1;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1[j, i].Value != null)
                    {
                        table.AddCell(new Phrase(dataGridView1[j, i].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 6f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLUE)));
                    }
                }
            }
            doc.Add(table);
            doc.Close();
        }

        private void menuMailClick(object sender, System.EventArgs e)
        {
            MailGoogle m = new MailGoogle();
            System.Data.DataRow row = layoutView1.GetDataRow(layoutView1.FocusedRowHandle);
            String tomail = row[4].ToString();
            m.Totxt.Text = tomail;
            m.Show();
        }

        private void menudeleteClick(object sender, System.EventArgs e)
        {
            System.Data.DataRow row = layoutView1.GetDataRow(layoutView1.FocusedRowHandle);
            String Teacher = row[0].ToString();
            String TeacherFName = row[1].ToString();
            DataOperations d = new DataOperations();
            d.deleterowTeacher(Teacher,TeacherFName);
            layoutView1.DeleteRow(layoutView1.FocusedRowHandle);
        }

        private void FullLoad_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter dataadapter = new MySqlDataAdapter(ss, conn);
                MySqlCommandBuilder mscb = new MySqlCommandBuilder(dataadapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataadapter.Fill(table);
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = table;
                ggg.DataSource = bindingSource1;
                dataGridView1.DataSource = bindingSource1;
            }
            catch (Exception a)
            {
                MessageBox.Show("Something is Wrong" + a.ToString());
            }
        }

        private void menueditClick(object sender, System.EventArgs e)
        {
            System.Data.DataRow row = layoutView1.GetDataRow(layoutView1.FocusedRowHandle);
            String Name = row[0].ToString();
            String FName = row[1].ToString();
            String Quali = row[2].ToString();
            String Field = row[3].ToString();
            String Email = row[4].ToString();
            String Contact = row[5].ToString();
            String Address = row[6].ToString();
            String NOSE = row[7].ToString();

            var validatorEmail = new Regex("^([a-z]+[0-9]+[@]{1}namal.edu.pk)$");
            var validatorContact = new Regex("^[0-9]{4}-[0-9]{7}$");
            var validatorName = new Regex("^[a-zA-Z\\s]+$");

            if (validatorName.IsMatch(Name) && validatorName.IsMatch(FName) && validatorName.IsMatch(Quali) && validatorName.IsMatch(Field) && validatorEmail.IsMatch(Email) && validatorContact.IsMatch(Contact))
            {
                DataOperations d = new DataOperations();
                d.editTeachers(Name, FName,Quali, Field, Email, Contact,Address,NOSE, OLDName, OLFFname);
            }
            else
            {
                MessageBox.Show("Your Entered Data Is Not Correct");
            }
        }

        private void layoutView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                System.Data.DataRow row = layoutView1.GetDataRow(layoutView1.FocusedRowHandle);
                OLDName = row[0].ToString();
                OLFFname = row[1].ToString();
                contextmenu.Show(ggg, new Point(e.X, e.Y));
            }
        }
    }
}
