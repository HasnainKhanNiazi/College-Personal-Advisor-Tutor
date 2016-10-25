using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SEGP
{
    public partial class PartialTeacher : UserControl
    {
        static String connectionString = "Server=localhost; Database=segp; Uid=root; pwd=";
        MySqlConnection conn = new MySqlConnection(connectionString);
        String ss = "select * from Teachers where Status='P'";

        public PartialTeacher()
        {
            InitializeComponent();
        }

        private void PartialTeacher_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(ss, conn);
                MySqlCommandBuilder commad = new MySqlCommandBuilder(adapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = table;
                ggg.DataSource = bindingSource1;
            }
            catch (Exception a)
            {
                MessageBox.Show("Something is Wrong",a.ToString());
            }
        }
    }
}
