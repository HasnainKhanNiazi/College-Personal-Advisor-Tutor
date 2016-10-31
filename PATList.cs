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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace SEGP
{
    public partial class PATList : DevExpress.XtraEditors.XtraUserControl
    {
        static String connectionString = "Server=localhost; Database=segp; Uid=root; pwd=";
        MySqlConnection conn = new MySqlConnection(connectionString);
        String ss = "select UoB,Name,EmailAddress,Year,PAT from Students";
        ContextMenu contextmenu = new ContextMenu();
        MenuItem menuPDF = new MenuItem("Generate PDF");

        public PATList()
        {
            InitializeComponent();
            contextmenu.MenuItems.AddRange(new MenuItem[] { menuPDF });
            gridControl1.ContextMenu = contextmenu;
            menuPDF.Click += new System.EventHandler(this.menuPDFClick);

        }

        private void PATList_Load(object sender, EventArgs e)
        {
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.GroupPanelText = "";
            try
            {
                MySqlDataAdapter dataadapter = new MySqlDataAdapter(ss, conn);
                MySqlCommandBuilder mscb = new MySqlCommandBuilder(dataadapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataadapter.Fill(table);
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = table;
                gridControl1.DataSource = bindingSource1;
                dataGridView1.DataSource = bindingSource1;
            }
            catch(Exception a)
            {
                MessageBox.Show("Something is Wrong"+a.ToString());
            }
        }

        private void menuPDFClick(object sender, System.EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("ListOfPAT.pdf", FileMode.Create));
            doc.Open();

            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
            PdfPCell cell = new PdfPCell(new Phrase("LISTOFPAT", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLUE)));
            cell.Colspan = 5;
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

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                contextmenu.Show(gridControl1, new Point(e.X, e.Y));
            }
        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                contextmenu.Show(gridControl1, new Point(e.X, e.Y));
            }
        }





    }
}
