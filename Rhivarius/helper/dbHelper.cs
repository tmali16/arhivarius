using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Rhivarius.helper
{
    class dbHelper
    {
        SQLiteCommand cmd;
        SQLiteConnection con;
        SQLiteDataReader dr;
        
        string conn = "datasource=arhiv.sqlite3; Version=3";
        Form1 f1 = new Form1();
        ErrorForm ef = new ErrorForm();
        public Boolean InsertQuery(string query)
        {
            con = new SQLiteConnection();
            cmd = new SQLiteCommand();
            con.Close();
            con.ConnectionString = conn;
            cmd.Connection = con;
            cmd.CommandText = query;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SQLiteException e)
            {
                ef.textBox1.Text = e.Message;
                ef.ShowDialog();
                return false;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            
        }
        public Int32 Last_id()
        {
            con = new SQLiteConnection();
            cmd = new SQLiteCommand();

            con.Close();
            con.ConnectionString = conn;
            cmd.Connection = con;
            cmd.CommandText = "SELECT MAX(id) FROM arhiv_ud";
            try
            {
                int res = 0;
                con.Open();
                               
                res = Convert.ToInt32(cmd.ExecuteScalar());
                return res;              
            }
            catch (SQLiteException e)
            {
                ef.textBox1.Text = e.Message;
                ef.ShowDialog();
                return 0;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}
