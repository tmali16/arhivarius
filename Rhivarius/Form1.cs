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
        SQLiteDataReader dr;
        String dbNmae = "arhiv.sqlite3";
        Form2 f2;
        ErrorForm ef;
        Panel sign;
        Panel subPnl;
        TextBox user;
        TextBox pass;
        Button sign_in;
        Label user_txt;
        Label pass_txt;
        Label excep_txt;
        Label user_list;
        public Form1()
        {
            InitializeComponent();
            sign = new Panel();
            sign_in = new Button();
            sign_in.Click += Sign_in_Click;
        }
        void list_user()
        {
            con = new SQLiteConnection();
            cmd = new SQLiteCommand();
            da = new SQLiteDataAdapter();
            con.ConnectionString = "datasource=users.db3; Version=3";
                        
            con.Open();
            cmd.CommandText = "select * from polzovatel";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                user_list = new Label();
                user_list.Height = 30;
                user_list.Width = u_cont.Width;
                user_list.TextAlign = ContentAlignment.MiddleCenter;
                user_list.ForeColor = Color.White;
                user_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
                user_list.Margin = new Padding(0, 0, 0, 10);
                user_list.Text = dr.GetString(2);
                u_cont.Controls.Add(user_list);
            }
        }
        public void createDB()
        {
            con = new SQLiteConnection();
            cmd = new SQLiteCommand();
            da = new SQLiteDataAdapter();
            con.ConnectionString = "datasource=" + dbNmae + "; Version=3";
            string sq = "CREATE TABLE if not exists arhiv_ud ("+
                            "id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,"+
                            "organ TEXT,"+
                            "god_ud TEXT,"+
                            "nomer_ud TEXT,"+
                            "date_vozb_ud  DATE,"+
                           " punkt_stadiya INT,"+
                            "rd_nomer VARCHAR,"+
                            "rd_fio TEXT,"+
                            "guit BOOLEAN,"+
                            "fabula TEXT,"+
                            "poterpevshiy TEXT,"+
                            " sledovatel TEXT,"+
                            "primechanie TEXT,"+
                            " statya_id INTEGER,"+
                            "perdacha_id   INTEGER); ";

            sq += " CREATE  TABLE if not exists statya (id INTEGER UNIQUE NOT NULL," +
                                    "statya INTEGER,"+
                                    "statya_chast INTEGER,"+
                                    "chast_punkt INTEGER,"+
                                    "ud_id INTEGER," +
                                    "FOREIGN KEY(ud_id) " +
                                    "REFERENCES arhiv_ud(id) ON DELETE CASCADE,"+
                                    "PRIMARY KEY(id)); ";

            sq += " CREATE TABLE if not exists peredacha ( id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                    "fio TEXT,"+
                    "prichina TEXT,"+
                    "dates date,"+
                    "updates date,"+
                    "ud_id INTEGER,"+
                    "FOREIGN KEY(ud_id)"+
                    "REFERENCES arhiv_ud(id) ON DELETE CASCADE);";

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
                    ef = new ErrorForm();
                    ef.textBox1.Text = e.Message;
                    ef.ShowDialog();
                }
                finally
                {
                    con.Close();
                }
            }
        }
        void insert(string organ, string god_ud, string nomer_ud, string rd_nomer, string rd_fio, string statya_uk, string punkt_stadiya, DateTime date_vozb_organ, string punkt, bool guit, string fabula, string terpila, string sledovatel, string primechanie)
        {
            con = new SQLiteConnection();
            cmd = new SQLiteCommand();
            da = new SQLiteDataAdapter();
            con.ConnectionString = "datasource=" + dbNmae + "; Version=3";
            try
            {
                string insert = "INSERT INTO arhiv_ud (organ, god_ud, nomer_ud,date_vozb_ud,punkt_stadiya,rd_nomer,rd_fio,guit,fabula,poterpevshiy,sledovatel,primechanie,statya_id,perdacha_id)" +
                     "VALUES(@organ, @god_ud,@nomer_ud, @date_vozb_ud, @punkt_stadiya, @rd_nomer, @rd_fio, @guit, @fabula," +
                     " @poterpevshiy, @sledovatel, @primechanie, @statya_id, @perdacha_id); ";
                cmd.CommandText = insert;
                cmd.Parameters.Add(new SQLiteParameter("@organ", date_vozb_organ));
                cmd.Parameters.Add(new SQLiteParameter("@god_ud", god_ud));
                cmd.Parameters.Add(new SQLiteParameter("@nomer_ud", nomer_ud));
                cmd.Parameters.Add(new SQLiteParameter("@date_vozb_ud", date_vozb_organ));
                cmd.Parameters.Add(new SQLiteParameter("@punkt_stadiya", punkt_stadiya));
                cmd.Parameters.Add(new SQLiteParameter("@rd_nomer", rd_nomer));
                cmd.Parameters.Add(new SQLiteParameter("@rd_fio", rd_fio));
                cmd.Parameters.Add(new SQLiteParameter("@fabula", fabula));
                cmd.Parameters.Add(new SQLiteParameter("@poterpevshiy", terpila));
                cmd.Parameters.Add(new SQLiteParameter("@sledovatel", sledovatel));
                cmd.Parameters.Add(new SQLiteParameter("@primechanie", primechanie));
                cmd.Parameters.Add(new SQLiteParameter("@sledovatel", guit));
                cmd.Parameters.Add(new SQLiteParameter("@statya_id", guit));
                cmd.Parameters.Add(new SQLiteParameter("@perdacha_id", guit));
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
        void Sign_in()
        {
            menuStrip1.Enabled = false;
            subPnl = new Panel();
            user = new TextBox();
            pass = new TextBox();
            
            user_txt = new Label();
            pass_txt = new Label();
            excep_txt = new Label();
            subPnl.Controls.Add(user);
            subPnl.Controls.Add(pass);
            subPnl.Controls.Add(sign_in);
            subPnl.Controls.Add(user_txt);
            subPnl.Controls.Add(pass_txt);
            subPnl.Controls.Add(excep_txt);
            sign.Controls.Add(subPnl);
            this.Controls.Add(sign);
            subPnl.Font = new Font(FontFamily.GenericSansSerif, 12);
            user_txt.Text = "Имя пользователя";
            pass_txt.Text = "Пароль";
            
            sign.Dock = DockStyle.Fill;
            sign.BringToFront();
            user.Width = 200;
            pass.Width = 200;
            subPnl.Width = 300;
            subPnl.Height = 220;
            subPnl.BorderStyle = BorderStyle.FixedSingle;
            user.Name = "username";
            pass.Name = "password";

            user_txt.AutoSize = true;
            excep_txt.AutoSize = false;
            excep_txt.Height = 37;
            excep_txt.Width = subPnl.Width;
            excep_txt.Font = new Font(FontFamily.GenericSansSerif, 9);
            excep_txt.Location = new Point(2, 2);
            excep_txt.TextAlign = ContentAlignment.MiddleCenter;

            user_txt.Location = new Point(50, 38);
            user.Location = new Point(50, 60);

            pass_txt.Location = new Point(50, 100);
            pass.Location = new Point(50, 125);
            pass.PasswordChar = Convert.ToChar("*");
            sign_in.Location = new Point(100, 160);
            sign_in.Size = new Size(100, 35);
            sign_in.Text = "Войти";

            subPnl.Location = new Point((this.Width / 2)-150, (this.Height/2)-100);
            sign.Name = "Main_pnl";
            sign.Width = this.Width;
            sign.Height = this.Height;
            excep_txt.Name = "explain_txt";
            excep_txt.ForeColor = Color.Red;
        }

        private void Sign_in_Click(object sender, EventArgs e)
        {
            con = new SQLiteConnection();
            cmd = new SQLiteCommand();
            da = new SQLiteDataAdapter();
            con.ConnectionString = "datasource=users.db3; Version=3";
            try
            {
                con.Open();
                cmd.CommandText = "select count(*) from polzovatel where username='" + user.Text.Trim() + "' and pass='" + pass.Text.Trim()+"'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                if(user.Text.Length > 0 || pass.Text.Length > 0) {
                    if (dr.Read())
                    {
                        if (dr.GetInt32(0) > 0)
                        {
                            excep_txt.Text = "";
                            user.BackColor = Color.White;
                            pass.BackColor = Color.White;
                            sign.Visible = false;
                            menuStrip1.Enabled = true;
                        }
                        else
                        {
                            excep_txt.Text = "Неверный логин или пароль!";
                            user.BackColor = Color.Red;
                            pass.BackColor = Color.Red;
                        }
                    }
                    
                }else
                    {
                        excep_txt.Text = "Имя пользователя или пароль не может быть пустым";
                    }
                
            }
            catch (SQLiteException exs)
            {
                ef = new ErrorForm();
                ef.textBox1.Text = exs.Message;
            }
            finally
            {
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createDB();
            Sign_in();
            list_user();
            //user_list.Text = "Admin";
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.ShowDialog();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void add_btn_Click_1(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.ShowDialog();
        }

        private void grid_view_Paint(object sender, PaintEventArgs e)
        {
            this.grid_view.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.grid_view.AlternatingRowsDefaultCellStyle.BackColor =
                Color.Beige;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            subPnl.Location = new Point((this.Width / 2)-150, (this.Height / 2) - 150);
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            user.Text = "";
            pass.Text = "";
            sign.Visible = true;
            menuStrip1.Enabled = false;
        }
    }
}
