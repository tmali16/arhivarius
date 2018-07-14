using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SQLite;

namespace Rhivarius
{
    public partial class Form2 : Form
    {
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataAdapter da;
        SQLiteDataReader dr;
        String dbNmae = "arhiv.sqlite3";
        ErrorForm ef;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int WParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void f_close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void f_max_btn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void organ_ud_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void groupBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            
        }
        void txtError(Control c)
        {
                c.BackColor = c.Text.Length <= 0 ? Color.Red : Color.White;            
        }
        bool txt_len_0(Control t)
        {
            return t.Text.Length <= 0 ? true : false;
        }

        private void god_vozb_txt_TextChanged(object sender, EventArgs e)
        {
            if (god_vozb_txt.Text.Length == 4)
            {
                date_vozb_txt.Value = Convert.ToDateTime("01.01." + god_vozb_txt.Text);
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void upk_pnkt_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (upk_pnkt_txt.SelectedIndex) {
                case 0:
                    rd_panel.Visible = true;
                    stadiya_gb.Height = 160;
                    break;
                case 1:

                    break;
                case 2:
                    rd_panel.Visible = false;
                    stadiya_gb.Height = 55;
                    break;
                case 3:

                    break;
            }
        }
        bool isValid()
        {
            if (txt_len_0(organ_ud_txt)) { txtError(organ_ud_txt); return true; } else { txtError(organ_ud_txt); }
            if (txt_len_0(god_vozb_txt)) { txtError(god_vozb_txt); return true; } else { txtError(god_vozb_txt); }
            if (txt_len_0(ud_num_txt)) { txtError(ud_num_txt); return true; } else { txtError(ud_num_txt); }
            if (txt_len_0(organ_vozb_txt)) { txtError(organ_vozb_txt); return true; } else { txtError(organ_vozb_txt); }
            if (statya_grid.Rows[0].Cells[1].Value == ""){statya_grid.BackgroundColor = Color.Red; return true; } else{statya_grid.BackgroundColor = Color.Gray;}

            return false;
        }
        private void guit_CheckedChanged(object sender, EventArgs e)
        {
            if (guit.Checked)
            {
                guit.Text = "Занесено в базу данных ГУИТ МВД КР";
                guit.ForeColor = Color.Blue;
            }
            else
            {
                guit.ForeColor = Color.Black;
                guit.Text = "Не занесено в базу данных ГУИТ МВД КР";
            }
        }
        private void groupBox1_Leave(object sender, EventArgs e)
        {
            if (txt_len_0(organ_ud_txt))   { txtError(organ_ud_txt);       } else { txtError(organ_ud_txt);   }
            if (txt_len_0(god_vozb_txt))   { txtError(god_vozb_txt);       } else { txtError(god_vozb_txt);   }
            if (txt_len_0(ud_num_txt))     { txtError(ud_num_txt);         } else { txtError(ud_num_txt);     }
            if (txt_len_0(organ_vozb_txt)) { txtError(organ_vozb_txt);     } else { txtError(organ_vozb_txt); }
        }
        private void fabula_gb_Leave(object sender, EventArgs e)
        {
            if (txt_len_0(fabula)) { txtError(fabula); } else { txtError(fabula); }
        }

        private void groupBox2_Leave(object sender, EventArgs e)
        {            

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
                ef = new ErrorForm();
                ef.textBox1.Text = ex.Message;
            }
            finally
            {
                con.Close();
            }
        }
        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (isValid())
            {

            }
        }

        private void stadiya_gb_Leave(object sender, EventArgs e)
        {
            if (upk_pnkt_txt.SelectedIndex == 3)
            {
                if (txt_len_0(rd_fio)){ txtError(rd_fio); } else { txtError(rd_fio);}
            }
        }
    }
}
