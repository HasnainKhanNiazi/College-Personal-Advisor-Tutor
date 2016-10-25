﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SEGP
{
    public partial class Year1 : DevExpress.XtraEditors.XtraUserControl
    {
        String oldUob, oldname;
        ContextMenu contextmenu = new ContextMenu();
        MenuItem menuMail = new MenuItem("Mail");
        MenuItem menuPDF = new MenuItem("Generate PDF");
        MenuItem menudelete = new MenuItem("Delete Row");
        MenuItem menuedit = new MenuItem("Save Data");
        static String connectionString = "Server=localhost; Database=segp; Uid=root; pwd=";
        MySqlConnection conn = new MySqlConnection(connectionString);
        String ss = "select * from Students where Year='Year-1'";

        public Year1()
        {
            InitializeComponent();
            contextmenu.MenuItems.AddRange(new MenuItem[] { menuMail, menudelete, menuedit ,menuPDF});
            gggcy1.ContextMenu = contextmenu;
            menudelete.Click += new System.EventHandler(this.menudeleteClick);
            menuedit.Click += new System.EventHandler(this.menueditClick);
            menuPDF.Click += new System.EventHandler(this.menuPDFClick);
        }
        private void menudeleteClick(object sender,System.EventArgs e)
        {
            System.Data.DataRow row = gridView1y1.GetDataRow(gridView1y1.FocusedRowHandle);
            String Uob = row[0].ToString();
            DataOperations d = new DataOperations();
            d.deleterow(Uob);
            gridView1y1.DeleteRow(gridView1y1.FocusedRowHandle);
        }

        private void menuPDFClick(object sender, System.EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER,10,10,42,35);
            PdfWriter writer = PdfWriter.GetInstance(doc,new FileStream("Year1.pdf",FileMode.Create));
            doc.Open();

            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
            PdfPCell cell = new PdfPCell(new Phrase("Year-1", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLUE)));
            cell.Colspan = 7;
            cell.BackgroundColor = new iTextSharp.text.BaseColor(Color.Coral);
            cell.HorizontalAlignment = 1;
            table.AddCell(cell);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                table.AddCell(new Phrase(dataGridView1.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 7f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.GRAY)));
            }

            table.HeaderRows = 1 ;

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

        private void menueditClick(object sender, System.EventArgs e)
        {
            System.Data.DataRow row = gridView1y1.GetDataRow(gridView1y1.FocusedRowHandle);
            String Uob = row[0].ToString();
            String Name = row[1].ToString();
            String FName = row[2].ToString();
            String Programme = row[3].ToString();
            String Email = row[4].ToString();
            String Contact = row[5].ToString();
            String Year = row[6].ToString();

            DataOperations d = new DataOperations();
            d.edit(Uob, Name, FName, Programme, Email, Contact, Year, oldUob, oldname);
        }

        private void Year1_Load(object sender, EventArgs e)
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
                gggcy1.DataSource = bindingSource1;
                dataGridView1.DataSource = bindingSource1;
            }
            catch (Exception a)
            {
                MessageBox.Show("Something is Wrong"+a.ToString());
            }
        }

        private void gridView1y1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                System.Data.DataRow row = gridView1y1.GetDataRow(gridView1y1.FocusedRowHandle);
                oldUob = row[0].ToString();
                oldname = row[1].ToString();
                contextmenu.Show(gggcy1, new Point(e.X, e.Y));
            }
            
            
        }
    }
}