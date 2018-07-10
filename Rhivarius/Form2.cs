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
namespace Rhivarius
{
    public partial class Form2 : Form
    {
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

        private void groupBox1_Leave(object sender, EventArgs e)
        {
            if (txt_len_0(organ_ud_txt)) { txtError(organ_ud_txt); }     else { txtError(organ_ud_txt); }
            if (txt_len_0(god_vozb_txt)) { txtError(god_vozb_txt); }     else { txtError(god_vozb_txt); }
            if (txt_len_0(ud_num_txt)) { txtError(ud_num_txt); }         else { txtError(ud_num_txt); }
            if (txt_len_0(organ_vozb_txt)) { txtError(organ_vozb_txt); } else { txtError(organ_vozb_txt); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
