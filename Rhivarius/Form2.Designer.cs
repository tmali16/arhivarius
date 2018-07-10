namespace Rhivarius
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.f_max_btn = new System.Windows.Forms.PictureBox();
            this.f_close_btn = new System.Windows.Forms.PictureBox();
            this.statya_grid = new System.Windows.Forms.DataGridView();
            this.statya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statya_chast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statya_punkt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.organ_ud_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.god_vozb_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ud_num_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date_vozb_txt = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.organ_vozb_txt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_max_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statya_grid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.f_max_btn);
            this.panel1.Controls.Add(this.f_close_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 33);
            this.panel1.TabIndex = 0;
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // f_max_btn
            // 
            this.f_max_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.f_max_btn.BackColor = System.Drawing.Color.Transparent;
            this.f_max_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.f_max_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f_max_btn.Image = global::Rhivarius.Properties.Resources.maxsimize;
            this.f_max_btn.Location = new System.Drawing.Point(830, 2);
            this.f_max_btn.Margin = new System.Windows.Forms.Padding(4, 4, 7, 4);
            this.f_max_btn.Name = "f_max_btn";
            this.f_max_btn.Size = new System.Drawing.Size(28, 28);
            this.f_max_btn.TabIndex = 1;
            this.f_max_btn.TabStop = false;
            this.f_max_btn.Click += new System.EventHandler(this.f_max_btn_Click);
            // 
            // f_close_btn
            // 
            this.f_close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.f_close_btn.BackColor = System.Drawing.Color.Transparent;
            this.f_close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.f_close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f_close_btn.Image = global::Rhivarius.Properties.Resources.close;
            this.f_close_btn.Location = new System.Drawing.Point(876, 4);
            this.f_close_btn.Margin = new System.Windows.Forms.Padding(4, 4, 7, 4);
            this.f_close_btn.Name = "f_close_btn";
            this.f_close_btn.Size = new System.Drawing.Size(28, 28);
            this.f_close_btn.TabIndex = 0;
            this.f_close_btn.TabStop = false;
            this.f_close_btn.Click += new System.EventHandler(this.f_close_btn_Click);
            // 
            // statya_grid
            // 
            this.statya_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statya_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statya,
            this.statya_chast,
            this.statya_punkt});
            this.statya_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statya_grid.Location = new System.Drawing.Point(3, 19);
            this.statya_grid.Name = "statya_grid";
            this.statya_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.statya_grid.RowHeadersVisible = false;
            this.statya_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.statya_grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statya_grid.Size = new System.Drawing.Size(258, 139);
            this.statya_grid.TabIndex = 1;
            // 
            // statya
            // 
            this.statya.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statya.HeaderText = "Статья";
            this.statya.MaxInputLength = 10;
            this.statya.Name = "statya";
            this.statya.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // statya_chast
            // 
            this.statya_chast.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statya_chast.HeaderText = "Часть";
            this.statya_chast.MaxInputLength = 10;
            this.statya_chast.Name = "statya_chast";
            this.statya_chast.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // statya_punkt
            // 
            this.statya_punkt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statya_punkt.HeaderText = "Пункт";
            this.statya_punkt.MaxInputLength = 10;
            this.statya_punkt.Name = "statya_punkt";
            this.statya_punkt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.statya_grid);
            this.groupBox2.Location = new System.Drawing.Point(326, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 161);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Статья УД";
            // 
            // organ_ud_txt
            // 
            this.organ_ud_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.organ_ud_txt.Location = new System.Drawing.Point(8, 54);
            this.organ_ud_txt.Margin = new System.Windows.Forms.Padding(4);
            this.organ_ud_txt.MaxLength = 4;
            this.organ_ud_txt.Name = "organ_ud_txt";
            this.organ_ud_txt.Size = new System.Drawing.Size(47, 23);
            this.organ_ud_txt.TabIndex = 0;
            this.organ_ud_txt.TextChanged += new System.EventHandler(this.organ_ud_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Орган";
            // 
            // god_vozb_txt
            // 
            this.god_vozb_txt.Location = new System.Drawing.Point(80, 54);
            this.god_vozb_txt.Margin = new System.Windows.Forms.Padding(4);
            this.god_vozb_txt.Name = "god_vozb_txt";
            this.god_vozb_txt.Size = new System.Drawing.Size(69, 23);
            this.god_vozb_txt.TabIndex = 2;
            this.god_vozb_txt.TextChanged += new System.EventHandler(this.god_vozb_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Год возб.";
            // 
            // ud_num_txt
            // 
            this.ud_num_txt.Location = new System.Drawing.Point(178, 53);
            this.ud_num_txt.Margin = new System.Windows.Forms.Padding(4);
            this.ud_num_txt.Name = "ud_num_txt";
            this.ud_num_txt.Size = new System.Drawing.Size(74, 23);
            this.ud_num_txt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер УД";
            // 
            // date_vozb_txt
            // 
            this.date_vozb_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_vozb_txt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_vozb_txt.Location = new System.Drawing.Point(8, 115);
            this.date_vozb_txt.Name = "date_vozb_txt";
            this.date_vozb_txt.Size = new System.Drawing.Size(105, 26);
            this.date_vozb_txt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата возб.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "__";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "__";
            // 
            // organ_vozb_txt
            // 
            this.organ_vozb_txt.FormattingEnabled = true;
            this.organ_vozb_txt.Location = new System.Drawing.Point(128, 115);
            this.organ_vozb_txt.Name = "organ_vozb_txt";
            this.organ_vozb_txt.Size = new System.Drawing.Size(147, 24);
            this.organ_vozb_txt.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Орган возб. УД";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.organ_vozb_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.date_vozb_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ud_num_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.god_vozb_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.organ_ud_txt);
            this.groupBox1.Location = new System.Drawing.Point(16, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(290, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Уголовное дело";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            this.groupBox1.Leave += new System.EventHandler(this.groupBox1_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(620, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 161);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Стадия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Приостан.";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Пункт - 1 ст. 221",
            "Пункт - 2 ст. 221",
            "Пункт - 3 ст. 221",
            "Пункт - 4 ст. 221"});
            this.comboBox2.Location = new System.Drawing.Point(100, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(169, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 23);
            this.textBox2.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "ФИО розыскиваемого";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "№ Р/Д";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 108);
            this.panel2.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 487);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.f_max_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statya_grid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox f_close_btn;
        private System.Windows.Forms.PictureBox f_max_btn;
        private System.Windows.Forms.DataGridView statya_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn statya;
        private System.Windows.Forms.DataGridViewTextBoxColumn statya_chast;
        private System.Windows.Forms.DataGridViewTextBoxColumn statya_punkt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox organ_ud_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox god_vozb_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ud_num_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_vozb_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox organ_vozb_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
    }
}