using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Rhivarius
{
    public partial class Form1 : Form
    {
        public string errors;

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataAdapter da;
        String dbNmae = "arhiv.sqlite3";

        public Form1()
        {
            InitializeComponent();
        }

        public void createDB()
        {
            con = new SQLiteConnection();
            cmd = new SQLiteCommand();
            da = new SQLiteDataAdapter();
            con.ConnectionString = "datasource=" + dbNmae + "; Version=3";
            string sq = "CREATE TABLE if not exists `peredacha` (`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,"+
	                        "`fio`	TEXT,"+
	                        "`prichina`	TEXT,"+
	                        "`dates`	NUMERIC,"+
	                        "`updates`	NUMERIC,"+
	                        "`peredacha_id`	INTEGER,"+
	                        "FOREIGN KEY(`peredacha_id`) REFERENCES `arhiv_ud`(`id`)); \n";

            sq += " CREATE  TABLE if not exists `arhiv_ud` (`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,"
	                        +"`organ`	TEXT,"+"`god_ud`	TEXT,"+"`nomer_ud`	TEXT,"+"`statya_UK`	INTEGER,"+"`chast_statya`	INTEGER,"+"`punkt_statya`	INTEGER,"
	                        +"`date_vozb_ud`	NUMERIC,"+"`punkt`	INTEGER,"+"`guit`	INTEGER,"+"`fabula`	TEXT,"+"`poterpevshiy`	TEXT,"+"`sledovatel`	TEXT,"+"`primechanie`	TEXT,"+"`ud_id`	INTEGER); ";

            if (!File.Exists(dbNmae))
            {
                SQLiteConnection.CreateFile(dbNmae);
                try
                {
                    cmd.CommandText = sq;
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException e)
                {
                    errors = e.Message;
                }
                finally
                {
                    con.Close();
                }
            }
        }
        void insert(string organ, string god_ud, string nomer_ud, string statya_uk, string chast_statya, string punkt_statya, DateTime date_vozb_organ, string punkt, bool guit, string fabula, string terpila, string sledovatel, string primechanie)
        {
            con = new SQLiteConnection();
            cmd = new SQLiteCommand();
            da = new SQLiteDataAdapter();
            con.ConnectionString = "datasource=" + dbNmae + "; Version=3";
            try
            {
                cmd.CommandText = "INSERT INTO arhiv_ud (organ, god_ud,  nomer_ud, statya_UK, chast_statya, punkt_statya, date_vozb_ud, punkt, guit, fabula, poterpevshiy, sledovatel, primechanie) VALUES"
                    +"('"+organ+"', '"+god_ud+ "', '" + nomer_ud + "', '" + statya_uk + "', '" + chast_statya + "', '" + punkt_statya + "', '@date_vozb_organ', '" + punkt + "', '@guit', '" + fabula + "', '" + terpila + "', '" + sledovatel + "', '" + primechanie + "')";
                cmd.Parameters.Add(new SQLiteParameter("@date_vozb_organ", date_vozb_organ));
                cmd.Parameters.Add(new SQLiteParameter("@guit", guit));
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                errors = ex.Message;
            }
            finally
            {
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createDB();
        }
    }
}
