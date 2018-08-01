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
using Rhivarius.helper;

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
        dbHelper dbH;


        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
        }

        private void f_close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {

        }

      

        private void organ_ud_txt_TextChanged(object sender, EventArgs e)
        {
            if (organ_ud_txt.Text.Length ==2 || organ_ud_txt.Text.Length == 3)
            {
                god_vozb_txt.Focus();
            }
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
            return t.Text.Length == 0 ? false : true;
        }

        private void god_vozb_txt_TextChanged(object sender, EventArgs e)
        {
            if (god_vozb_txt.Text.Length == 2)
            {
                if (Convert.ToInt32(god_vozb_txt.Text) >=40  && Convert.ToInt32(god_vozb_txt.Text) <= 99)
                {
                    date_vozb_txt.Value = Convert.ToDateTime("01.01.19" + god_vozb_txt.Text);
                }
                else
                {
                    date_vozb_txt.Value = Convert.ToDateTime("01.01.20" + god_vozb_txt.Text);
                }
                
            }
            if (god_vozb_txt.Text.Length == 2 )
            {
                ud_num_txt.Focus();
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
            int i = 0;
            if (txt_len_0(organ_ud_txt)) { txtError(organ_ud_txt); i = i + 1; } else { txtError(organ_ud_txt); }
            if (txt_len_0(god_vozb_txt)) { txtError(god_vozb_txt); i = i + 1; } else { txtError(god_vozb_txt); }
            if (txt_len_0(ud_num_txt)) { txtError(ud_num_txt); i = i + 1; } else { txtError(ud_num_txt); }
            if (txt_len_0(organ_vozb_txt)) { txtError(organ_vozb_txt); i = i + 1; } else { txtError(organ_vozb_txt); }
            if (statya_grid.Rows[0].Cells[0].Value != null){statya_grid.BackgroundColor = Color.Gray; i = i + 1; } else{statya_grid.BackgroundColor = Color.Red;}
            if (txt_len_0(fabula)) { txtError(fabula); i = i + 1; } else { txtError(fabula); }
            if (upk_pnkt_txt.SelectedIndex != 3){ txtError(rd_nomer); txtError(rd_fio); i = i + 1; } else { txtError(rd_nomer); txtError(rd_fio); }
            if (txt_len_0(sledovatel)) { txtError(sledovatel); i = i + 1; } else { txtError(sledovatel); }
            if (txt_len_0(terpila)) { txtError(terpila); i = i + 1; } else { txtError(terpila); }
            //if (gde_c_box.SelectedIndex == 0) { txtError(peredacha_cbox); txtError(peredach_Fio); i = i + 1; } else { txtError(peredacha_cbox); txtError(peredach_Fio); }
            if (i >= 9)
            {
                return true;
            }
            else
            {
                //MessageBox.Show(i.ToString());
                return false;
            }
            
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
            if (date_vozb_txt.Text.Substring(0, 6) == "01.01."){ var res = MessageBox.Show("Дата возбуждения установлено верно?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No) { date_vozb_txt.Focus(); }
            }
        }
        private void fabula_gb_Leave(object sender, EventArgs e)
        {
            if (txt_len_0(fabula)) { txtError(fabula); } else { txtError(fabula); }
        }

        private void groupBox2_Leave(object sender, EventArgs e)
        {
            
        }
        void statya_ins()
        {
            dbH = new dbHelper();
            int last_id = dbH.Last_id();
            if ((statya_grid.Rows[0].Cells[0].Value).ToString().Length > 1 || last_id != 0)
            {
                string begin = "INSERT INTO statya (statya,statya_chast,chast_punkt,ud_id) VALUES ";
                string loops = "";
                string all = "";
                for (int i = 0; i < statya_grid.Rows.Count-1; i++)
                {
                    string st = statya_grid.Rows[i].Cells[0].Value != null ? statya_grid.Rows[i].Cells[0].Value.ToString().Trim() : "";
                    string chast = statya_grid.Rows[i].Cells[1].Value != null ? statya_grid.Rows[i].Cells[1].Value.ToString().Trim() : "";
                    string punkt = statya_grid.Rows[i].Cells[2].Value != null ? statya_grid.Rows[i].Cells[2].Value.ToString().Trim() : "";
                    loops = loops + "('" + st + "','" + chast + "', '" + punkt + "', '"+ last_id.ToString() + "'), ";
                }

                all = (begin += loops.Substring(0, (loops.Length-2)));
                try
                {
                    dbH.InsertQuery(all);
                }
                catch (SQLiteException e)
                {
                    ef = new ErrorForm();
                    ef.textBox1.Text = e.Message;
                    ef.ShowDialog();
                }
            }
            
        }
        void peredacha_insert()
        {
            dbH = new dbHelper();
            string query = "INSERT INTO peredacha (fio, prichina, dates, updates, ud_id) VALUES ";
            switch (gde_c_box.SelectedIndex)
            {
                case 0:
                    query += "('В Архиве','', '" + DateTime.Now.ToString()+ "', '" + DateTime.Now.ToString() + "','" + dbH.Last_id()+"')";
                    break;
                case 1:
                    query += "('"+peredach_Fio.Text+"','"+peredacha_cbox.Items[peredacha_cbox.SelectedIndex].ToString()+"', '" + DateTime.Now.ToString() + "', '" + DateTime.Now.ToString() + "','" + dbH.Last_id() + "')";
                    break;
                
            }
            dbH.InsertQuery(query);
        }
        Boolean insert(string organ, string god_ud, string nomer_ud, string rd_nomer, string statya_uk, string punkt_stadiya, DateTime date_vozb_organ, bool guit, string fabula, string terpila, string sledovatel, string primechanie)
        {
            
            con = new SQLiteConnection();
            cmd = new SQLiteCommand();
            con.Close();
            da = new SQLiteDataAdapter();
            con.ConnectionString = "datasource=" + dbNmae + "; Version=3";
            string arhiv_ud = "INSERT INTO arhiv_ud (organ, god_ud, nomer_ud, date_vozb_ud, punkt_stadiya, rd_nomer, rd_fio,guit, fabula,"
                        + " poterpevshiy, sledovatel, primechanie, create_dt, update_dt ) VALUES(" +
                            "@organ," + "@god_ud," + "@nomer_ud," + "@date_vozb_ud," + "@punkt_stadiya," + "@rd_nomer," + "@rd_fio," + "@guit," + "@fabula," + "@poterpevshiy," + "@sledovatel," + "@primechanie, @create_dt, @update_dt)";
            cmd.CommandText = arhiv_ud;
            cmd.Parameters.Add(new SQLiteParameter("@organ", organ));
            cmd.Parameters.Add(new SQLiteParameter("@god_ud", god_ud));
            cmd.Parameters.Add(new SQLiteParameter("@nomer_ud", nomer_ud));
            cmd.Parameters.Add(new SQLiteParameter("@date_vozb_ud", date_vozb_organ));
            cmd.Parameters.Add(new SQLiteParameter("@punkt_stadiya", punkt_stadiya));
            cmd.Parameters.Add(new SQLiteParameter("@rd_nomer", rd_nomer));
            cmd.Parameters.Add(new SQLiteParameter("@rd_fio", rd_fio));
            cmd.Parameters.Add(new SQLiteParameter("@guit", guit));
            cmd.Parameters.Add(new SQLiteParameter("@fabula", fabula));
            cmd.Parameters.Add(new SQLiteParameter("@poterpevshiy", terpila));
            cmd.Parameters.Add(new SQLiteParameter("@sledovatel", sledovatel));
            cmd.Parameters.Add(new SQLiteParameter("@primechanie", primechanie));
            cmd.Parameters.Add(new SQLiteParameter("@create_dt", DateTime.Now));
            cmd.Parameters.Add(new SQLiteParameter("@update_dt", DateTime.Now));
            cmd.Connection = con;
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery()> 0)
                {
                    con.Close();
                    con.Dispose();
                    statya_ins();
                    peredacha_insert();
                }
                
                return true;
            }
            catch (SQLiteException ex)
            {
                ef = new ErrorForm();
                ef.textBox1.Text = ex.Message;
                return false;
            }
        }
        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                if (insert(organ_ud_txt.Text, god_vozb_txt.Text, ud_num_txt.Text, (rd_nomer.Text.Length == 0 ? "" : rd_nomer.Text), (rd_fio.Text.Length == 0 ? "" : rd_fio.Text), upk_pnkt_txt.Text, date_vozb_txt.Value, (guit.Checked == true ? true : false), fabula.Text, terpila.Text, sledovatel.Text, primichanie_txt.Text))
                {
                    MessageBox.Show("Сохранено");
                }
                    
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }

        private void stadiya_gb_Leave(object sender, EventArgs e)
        {
            if (upk_pnkt_txt.SelectedIndex == 3)
            {
                if (txt_len_0(rd_fio)){ txtError(rd_fio); } else { txtError(rd_fio);}
            }
        }

        private void gde_c_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gde_c_box.SelectedIndex == 0)
            {
                predecha_box.Height = 55;
                peredacha_cbox.Visible = false;
                peredach_Fio.Visible = false;
            }
            else
            {
                predecha_box.Height = 194;
                peredacha_cbox.Visible = true;
                peredach_Fio.Visible = true;
            }
        }

        private void predecha_box_Leave(object sender, EventArgs e)
        {
            if (gde_c_box.SelectedIndex != 0)
            {            
                if (txt_len_0(peredacha_cbox)) { txtError(peredacha_cbox); } else { txtError(peredacha_cbox); }
                if (txt_len_0(peredach_Fio)) { txtError(peredach_Fio); } else { txtError(peredach_Fio); }
            }
            else
            {
                if (txt_len_0(gde_c_box)) { txtError(gde_c_box); } else { txtError(gde_c_box); }
            }
        }

        private void ud_num_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
