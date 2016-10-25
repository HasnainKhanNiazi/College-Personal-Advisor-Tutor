using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SEGP
{
    class DataOperations
    {
        static String connectionString = "Server=localhost; Database=segp; Uid=root; pwd=";
        MySqlConnection conn = new MySqlConnection(connectionString);

        public void deleterow(String UoB)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command = conn.CreateCommand();
                conn.Open();
                command.CommandText = "Delete from students where UoB='" + UoB + "'";
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Row Deleted");
            }
            catch(Exception a)
            {
                a.ToString();
            }
        }


        public void edit(String Uob,String Name,String FName,String Programme,String Email,String Contact,String Year,String oldUob,String oldname)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                conn.Open();
                command = conn.CreateCommand();
                command.CommandText = "Update students SET Uob='" + Uob + "',Name='" + Name + "',FatherName='" + FName + "',Programme='" + Programme + "',EmailAddress='" + Email + "',Contact='" + Contact + "',Year='" + Year + "' where UoB='" + oldUob + "' AND Name='" + oldname + "'  ";
                command.ExecuteNonQuery();
                MessageBox.Show("Data Updated ");
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Something is Wrong"+e.ToString());
            }
        }

    }
}
