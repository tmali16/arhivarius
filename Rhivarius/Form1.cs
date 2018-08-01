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
using System.Security.Cryptography;

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

        private void userLabelClick(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            con = new SQLiteConnection();
            cmd = new SQLiteCommand();
            da = new SQLiteDataAdapter();
            con.ConnectionString = "datasource=users.db3; Version=3";

            con.Open();
            cmd.CommandText = "select * from polzovatel where id = " + Convert.ToInt32(lb.Name);
            cmd.Connection = con;
            try
            {
cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            }
            catch (SQLiteException ex)
            {

                ef = new ErrorForm();
                ef.textBox1.Text = ex.Message;
            }
            

            while (dr.Read())
            {
                user_fio_txt.Text = dr[1].ToString();
                user_username_txt.Text = dr.GetString(2);
                user_pass.Text = dr.GetString(3);
                create_date_label.Text = "Дата создания: " + dr[4].ToString() + "\n\nДата обновления: " + dr.GetDateTime(5).ToString() + "\n\nСтатус: " + (dr.GetInt32(7) == 1 ? "Активный" : "Не активный") + "\n\nПользователь: " + (dr.GetInt32(6) == 1 ? "Администратор" : "Обычный");
                user_isAdmin.Checked = (dr.GetInt32(6) == 1 ? true : false);
                user_isActive.Checked = (dr.GetInt32(7) == 1 ? true : false);
                user_lbl_id.Text = Convert.ToString(dr.GetInt32(0));
                
            }
            con.Close();
        }

        void users_label(string name, int y, int lblName)
        {
            user_list = new Label();
            u_cont.Controls.Add(user_list);
            user_list.Height = 30;
            user_list.Width = u_cont.Width;
            user_list.TextAlign = ContentAlignment.MiddleCenter;
            user_list.ForeColor = Color.White;
            user_list.BackColor = Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            user_list.Margin = new Padding(0, 0, 0, 10);
            //user_list.Location = new Point(0, y);
            user_list.Top = y;
            user_list.Text = name;
            user_list.Click += userLabelClick;
            user_list.Name = lblName.ToString();
            
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
            int Yuser = 0;
            while (dr.Read()) 
            {
                user_list = new Label();
                u_cont.Controls.Add(user_list);
                user_list.Height = 30;
                user_list.Width = u_cont.Width;
                user_list.TextAlign = ContentAlignment.MiddleCenter;
                user_list.ForeColor = Color.White;
                user_list.BackColor = Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
                user_list.Margin = new Padding(0, 0, 0, 10);
                //user_list.Location = new Point(0, y);
                user_list.Top = Yuser;
                user_list.Text = dr.GetString(2);
                user_list.Click += userLabelClick;
                user_list.Name = dr.GetInt32(0).ToString();
                Yuser += 30 + 5;
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
            sign_in.FlatStyle = FlatStyle.Flat;
            sign_in.FlatAppearance.BorderSize = 0;
            subPnl.BorderStyle = BorderStyle.FixedSingle;
            subPnl.BackColor = Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            sign.BackColor = Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(149)))), ((int)(((byte)(167)))));
            sign_in.BackColor = Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(219)))), ((int)(((byte)(251)))));
            user.Name = "username";
            pass.Name = "password";
            //rgba(72, 219, 251,1.0)
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
           
            subPnl.Location = new Point((this.Width / 2) - 150, (this.Height / 2) - 150);
            
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
                cmd.CommandText = "select * from polzovatel where username='" + user.Text.Trim() + "' and pass='" + MD5Hash(pass.Text.Trim())+"'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                if(user.Text.Length > 0 || pass.Text.Length > 0) {
                    if (dr.Read())
                    {
                        if (dr.GetInt32(0) >= 1)
                        {
                            if (dr.GetInt32(7) != 0)
                            {
                                excep_txt.Text = "";
                                user.BackColor = Color.White;
                                pass.BackColor = Color.White;
                                sign.Visible = false;
                                menuStrip1.Enabled = true;
                                if (dr.GetInt32(6) == 1) { };
                            }
                            else
                            {
                                excep_txt.Text = "Пользоваетль не активен обратитесь к администратору";
                            }
                        }
                        else
                        {
                            excep_txt.Text = "Неверный логин или пароль! "+dr.GetInt32(0).ToString();
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
            //Sign_in();
            gridFill();
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
            if (!sign.Visible) { 
            subPnl.Location = new Point((this.Width / 2)-150, (this.Height / 2) - 150);
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            user.Text = "";
            pass.Text = "";
            sign.Visible = true;
            menuStrip1.Enabled = false;
        }

        private void user_update_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            user_fio_txt.Enabled = true;
            user_username_txt.Enabled = true;
            user_pass.Enabled = true;
            user_pass.Text = "";
            user_pass_chng_pnl.Visible = true;
            user_save_btn.Visible = true;
            user_isActive.Visible = true;
            user_isAdmin.Visible = true;
        }

        private void user_save_btn_Click(object sender, EventArgs e)
        {
            con = new SQLiteConnection();
            cmd = new SQLiteCommand();
            da = new SQLiteDataAdapter();
            con.ConnectionString = "datasource=users.db3; Version=3";
            int isadmin = user_isAdmin.Checked ? 1 : 0;
            int isactive = user_isActive.Checked ? 1 : 0;
            con.Open();
            cmd.CommandText = "UPDATE polzovatel SET fio = '"+user_fio_txt.Text.Trim()+"', username = '"+user_username_txt.Text+"', pass = '"+MD5Hash(user_pass.Text)+"', up_date = datetime('now'), isAdmin = '"+isadmin+"', isActive = '"+isactive+"' WHERE id = '"+user_lbl_id.Text+"' ;";
            
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();

            user_fio_txt.Enabled = false;
            user_username_txt.Enabled = false;
            user_pass.Enabled = false;
            user_pass.Text = "";
            user_pass_chng_pnl.Visible = false;
            user_save_btn.Visible = false;
        }
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
        bool username_exists(string username)
        {
            con = new SQLiteConnection();
            cmd = new SQLiteCommand();
            da = new SQLiteDataAdapter();
            con.ConnectionString = "datasource=users.db3; Version=3";

            con.Open();
            cmd.CommandText = "select username from polzovatel where username='"+username+"'";

            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return false;
            }
            return true;
            con.Close();
            
        }
        private void user_username_txt_TextChanged(object sender, EventArgs e)
        {
            //if (username_exists(user_username_txt.Text) && (user_username_error.Text).Length >= 4)
            //{
            //    user_username_error.Text = "";
            //}
            //else
            //{
            //    user_username_error.Text = "имя пользователя существует";
            //}
        }
        void gridFill()
        {
            con = new SQLiteConnection();
            cmd = new SQLiteCommand();
            da = new SQLiteDataAdapter();
            con.ConnectionString = "datasource="+dbNmae+"; Version=3";
            try
            {
                con.Open();
                cmd.CommandText = "select * from arhiv_ud ";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                int rowCount = 0;
                while (dr.Read())
                {
                    grid_view.Rows.Add();
                    grid_view.Rows[rowCount].Cells[0].Value = dr.GetString(1) + "-"+ dr.GetString(2)+"-"+dr.GetString(3);
                    grid_view.Rows[rowCount].Cells[1].Value = dr.GetString(4);
                    grid_view.Rows[rowCount].Cells[2].Value = (dr.GetInt32(8) == 1 ? true : false);
                    grid_view.Rows[rowCount].Cells[3].Value = dr.GetString(5);
                    grid_view.Rows[rowCount].Cells[4].Value = dr.GetString(11);
                    grid_view.Rows[rowCount].Cells[5].Value = dr.GetString(10);
                    grid_view.Rows[rowCount].Cells[6].Value = dr[12].ToString();
                    rowCount++;
                }
            }
            catch(SQLiteException e)
            {
                ef = new ErrorForm();
                ef.textBox1.Text = e.Message;
                ef.ShowDialog();
            }
        }
    }
}
