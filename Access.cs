using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.IO;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheProject
{
    public static class Access
    {
        public static DataTable Get(string fields, string db)
        {
            OleDbConnection conn;
            string strConn = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Database1.accdb ;Persist Security Info=False;";
            conn = new OleDbConnection(strConn);
            DataTable data;
            data = new DataTable();

            try
            {
                conn.Open();
                OleDbCommand dataAdapter = new OleDbCommand("Select " + fields + " FROM " + db + "", conn);
                OleDbDataAdapter excelDataAdapter = new OleDbDataAdapter();
                excelDataAdapter.SelectCommand = dataAdapter;
                excelDataAdapter.Fill(data);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                conn.Close();
            }

            return data;
        }

        public static void Query(string query)
        {
            OleDbConnection conn;
            string strConn = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Database1.accdb ;Persist Security Info=False;";
            conn = new OleDbConnection(strConn);

            try
            {
                conn.Open();

                OleDbCommand dataAdapter = new OleDbCommand(query, conn);
                dataAdapter.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                conn.Close();
            }
        }

        public static void Insert(string fields, string values)
        {
            Query("INSERT INTO " + fields + " VALUES(" + values + ")");
        }

        public static void Update(string db, string values)
        {
            Query("Update " + db + " Set " + values + "");
        }

        public static void Delete(string db, string values)
        {
            Query("Delete * From " + db + "" + values + "");
        }


        public static int Add(string who,int y)
        {
            OleDbConnection connect1 = new OleDbConnection();
            connect1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
            connect1.Open();
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = connect1;
            command1.CommandText = "SELECT cash FROM members where user = '" + who + "'";
            OleDbDataReader reader1 = command1.ExecuteReader();
            reader1.Read();
            int x = Convert.ToInt32(reader1["cash"].ToString());
            x = x + y;
            OleDbCommand commmand1 = new OleDbCommand("UPDATE members SET cash='" + x + "' WHERE user= '" + who + "'", connect1);
            commmand1.ExecuteNonQuery();
            connect1.Close();
            return x;
        }


    }
}

