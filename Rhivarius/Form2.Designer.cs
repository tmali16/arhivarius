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
            this.stadiya_gb = new System.Windows.Forms.GroupBox();
            this.rd_panel = new System.Windows.Forms.Panel();
            this.rd_fio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rd_nomer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.upk_pnkt_txt = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guit = new System.Windows.Forms.CheckBox();
            this.fabula = new System.Windows.Forms.TextBox();
            this.sledovatel = new System.Windows.Forms.TextBox();
            this.terpila = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.guit_gb = new System.Windows.Forms.GroupBox();
            this.fio_pnl = new System.Windows.Forms.Panel();
            this.fabula_gb = new System.Windows.Forms.GroupBox();
            this.bottom_pnl = new System.Windows.Forms.Panel();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.predecha_box = new System.Windows.Forms.GroupBox();
            this.gde_c_box = new System.Windows.Forms.ComboBox();
            this.peredacha_cbox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.peredach_Fio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statya_grid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.stadiya_gb.SuspendLayout();
            this.rd_panel.SuspendLayout();
            this.guit_gb.SuspendLayout();
            this.fio_pnl.SuspendLayout();
            this.fabula_gb.SuspendLayout();
            this.bottom_pnl.SuspendLayout();
            this.predecha_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // statya_grid
            // 
            this.statya_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statya_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statya,
            this.statya_chast,
            this.statya_punkt});
            this.statya_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statya_grid.Location = new System.Drawing.Point(3, 26);
            this.statya_grid.Name = "statya_grid";
            this.statya_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.statya_grid.RowHeadersVisible = false;
            this.statya_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.statya_grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statya_grid.Size = new System.Drawing.Size(258, 132);
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
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.statya_grid);
            this.groupBox2.Location = new System.Drawing.Point(325, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(264, 161);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Статья УД";
            this.groupBox2.Leave += new System.EventHandler(this.groupBox2_Leave);
            // 
            // organ_ud_txt
            // 
            this.organ_ud_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.organ_ud_txt.Location = new System.Drawing.Point(8, 54);
            this.organ_ud_txt.Margin = new System.Windows.Forms.Padding(4);
            this.organ_ud_txt.MaxLength = 3;
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
            this.god_vozb_txt.MaxLength = 2;
            this.god_vozb_txt.Name = "god_vozb_txt";
            this.god_vozb_txt.Size = new System.Drawing.Size(64, 23);
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
            this.ud_num_txt.MaxLength = 5;
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
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.groupBox1.Location = new System.Drawing.Point(15, 64);
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
            // stadiya_gb
            // 
            this.stadiya_gb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stadiya_gb.Controls.Add(this.rd_panel);
            this.stadiya_gb.Controls.Add(this.upk_pnkt_txt);
            this.stadiya_gb.Controls.Add(this.label8);
            this.stadiya_gb.Location = new System.Drawing.Point(612, 64);
            this.stadiya_gb.Name = "stadiya_gb";
            this.stadiya_gb.Size = new System.Drawing.Size(282, 160);
            this.stadiya_gb.TabIndex = 3;
            this.stadiya_gb.TabStop = false;
            this.stadiya_gb.Text = "Стадия";
            this.stadiya_gb.Leave += new System.EventHandler(this.stadiya_gb_Leave);
            // 
            // rd_panel
            // 
            this.rd_panel.Controls.Add(this.rd_fio);
            this.rd_panel.Controls.Add(this.label10);
            this.rd_panel.Controls.Add(this.rd_nomer);
            this.rd_panel.Controls.Add(this.label9);
            this.rd_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rd_panel.Location = new System.Drawing.Point(3, 49);
            this.rd_panel.Name = "rd_panel";
            this.rd_panel.Size = new System.Drawing.Size(276, 108);
            this.rd_panel.TabIndex = 7;
            // 
            // rd_fio
            // 
            this.rd_fio.Location = new System.Drawing.Point(3, 77);
            this.rd_fio.Name = "rd_fio";
            this.rd_fio.Size = new System.Drawing.Size(263, 23);
            this.rd_fio.TabIndex = 4;
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
            // rd_nomer
            // 
            this.rd_nomer.Location = new System.Drawing.Point(3, 25);
            this.rd_nomer.Name = "rd_nomer";
            this.rd_nomer.Size = new System.Drawing.Size(263, 23);
            this.rd_nomer.TabIndex = 3;
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
            // upk_pnkt_txt
            // 
            this.upk_pnkt_txt.FormattingEnabled = true;
            this.upk_pnkt_txt.Items.AddRange(new object[] {
            "Пункт - 1 ст. 221",
            "Пункт - 2 ст. 221",
            "Пункт - 3 ст. 221",
            "Пункт - 4 ст. 221"});
            this.upk_pnkt_txt.Location = new System.Drawing.Point(100, 20);
            this.upk_pnkt_txt.Name = "upk_pnkt_txt";
            this.upk_pnkt_txt.Size = new System.Drawing.Size(169, 24);
            this.upk_pnkt_txt.TabIndex = 2;
            this.upk_pnkt_txt.SelectedIndexChanged += new System.EventHandler(this.upk_pnkt_txt_SelectedIndexChanged);
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
            // guit
            // 
            this.guit.AutoSize = true;
            this.guit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guit.Location = new System.Drawing.Point(10, 27);
            this.guit.Name = "guit";
            this.guit.Size = new System.Drawing.Size(267, 19);
            this.guit.TabIndex = 4;
            this.guit.Text = "Не занесено в базу данных ГУИТ МВД КР";
            this.guit.UseVisualStyleBackColor = true;
            this.guit.CheckedChanged += new System.EventHandler(this.guit_CheckedChanged);
            // 
            // fabula
            // 
            this.fabula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fabula.Location = new System.Drawing.Point(3, 19);
            this.fabula.Multiline = true;
            this.fabula.Name = "fabula";
            this.fabula.Size = new System.Drawing.Size(258, 175);
            this.fabula.TabIndex = 0;
            // 
            // sledovatel
            // 
            this.sledovatel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sledovatel.Location = new System.Drawing.Point(22, 33);
            this.sledovatel.Name = "sledovatel";
            this.sledovatel.Size = new System.Drawing.Size(246, 23);
            this.sledovatel.TabIndex = 7;
            // 
            // terpila
            // 
            this.terpila.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.terpila.Location = new System.Drawing.Point(22, 87);
            this.terpila.Name = "terpila";
            this.terpila.Size = new System.Drawing.Size(246, 23);
            this.terpila.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Следователь (ФИО)";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Заявитель (ФИО)";
            // 
            // guit_gb
            // 
            this.guit_gb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guit_gb.Controls.Add(this.guit);
            this.guit_gb.Location = new System.Drawing.Point(12, 372);
            this.guit_gb.Name = "guit_gb";
            this.guit_gb.Size = new System.Drawing.Size(293, 67);
            this.guit_gb.TabIndex = 5;
            this.guit_gb.TabStop = false;
            this.guit_gb.Text = "База данных";
            // 
            // fio_pnl
            // 
            this.fio_pnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fio_pnl.Controls.Add(this.sledovatel);
            this.fio_pnl.Controls.Add(this.terpila);
            this.fio_pnl.Controls.Add(this.label12);
            this.fio_pnl.Controls.Add(this.label13);
            this.fio_pnl.Location = new System.Drawing.Point(12, 245);
            this.fio_pnl.Name = "fio_pnl";
            this.fio_pnl.Size = new System.Drawing.Size(293, 121);
            this.fio_pnl.TabIndex = 8;
            // 
            // fabula_gb
            // 
            this.fabula_gb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fabula_gb.Controls.Add(this.fabula);
            this.fabula_gb.Location = new System.Drawing.Point(325, 245);
            this.fabula_gb.Name = "fabula_gb";
            this.fabula_gb.Size = new System.Drawing.Size(264, 197);
            this.fabula_gb.TabIndex = 9;
            this.fabula_gb.TabStop = false;
            this.fabula_gb.Text = "Фабула";
            this.fabula_gb.Leave += new System.EventHandler(this.fabula_gb_Leave);
            // 
            // bottom_pnl
            // 
            this.bottom_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.bottom_pnl.Controls.Add(this.cancel_btn);
            this.bottom_pnl.Controls.Add(this.Save_btn);
            this.bottom_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_pnl.Location = new System.Drawing.Point(0, 449);
            this.bottom_pnl.Name = "bottom_pnl";
            this.bottom_pnl.Size = new System.Drawing.Size(915, 50);
            this.bottom_pnl.TabIndex = 10;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Location = new System.Drawing.Point(791, 9);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(100, 30);
            this.cancel_btn.TabIndex = 0;
            this.cancel_btn.Text = "Отмена";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // Save_btn
            // 
            this.Save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_btn.Location = new System.Drawing.Point(652, 9);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(109, 30);
            this.Save_btn.TabIndex = 0;
            this.Save_btn.Text = "Сохранить";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // predecha_box
            // 
            this.predecha_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.predecha_box.Controls.Add(this.label14);
            this.predecha_box.Controls.Add(this.peredach_Fio);
            this.predecha_box.Controls.Add(this.label11);
            this.predecha_box.Controls.Add(this.peredacha_cbox);
            this.predecha_box.Controls.Add(this.gde_c_box);
            this.predecha_box.Location = new System.Drawing.Point(612, 245);
            this.predecha_box.Name = "predecha_box";
            this.predecha_box.Size = new System.Drawing.Size(282, 194);
            this.predecha_box.TabIndex = 11;
            this.predecha_box.TabStop = false;
            this.predecha_box.Text = "groupBox3";
            this.predecha_box.Leave += new System.EventHandler(this.predecha_box_Leave);
            // 
            // gde_c_box
            // 
            this.gde_c_box.FormattingEnabled = true;
            this.gde_c_box.Items.AddRange(new object[] {
            "в Архиве",
            "Передано"});
            this.gde_c_box.Location = new System.Drawing.Point(6, 22);
            this.gde_c_box.Name = "gde_c_box";
            this.gde_c_box.Size = new System.Drawing.Size(270, 24);
            this.gde_c_box.TabIndex = 0;
            this.gde_c_box.SelectedIndexChanged += new System.EventHandler(this.gde_c_box_SelectedIndexChanged);
            // 
            // peredacha_cbox
            // 
            this.peredacha_cbox.FormattingEnabled = true;
            this.peredacha_cbox.Items.AddRange(new object[] {
            "Запрос"});
            this.peredacha_cbox.Location = new System.Drawing.Point(6, 86);
            this.peredacha_cbox.Name = "peredacha_cbox";
            this.peredacha_cbox.Size = new System.Drawing.Size(270, 24);
            this.peredacha_cbox.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Основание передачи";
            // 
            // peredach_Fio
            // 
            this.peredach_Fio.Location = new System.Drawing.Point(6, 150);
            this.peredach_Fio.Name = "peredach_Fio";
            this.peredach_Fio.Size = new System.Drawing.Size(270, 23);
            this.peredach_Fio.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "Кому передано";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 499);
            this.Controls.Add(this.predecha_box);
            this.Controls.Add(this.bottom_pnl);
            this.Controls.Add(this.fabula_gb);
            this.Controls.Add(this.fio_pnl);
            this.Controls.Add(this.guit_gb);
            this.Controls.Add(this.stadiya_gb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.statya_grid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.stadiya_gb.ResumeLayout(false);
            this.stadiya_gb.PerformLayout();
            this.rd_panel.ResumeLayout(false);
            this.rd_panel.PerformLayout();
            this.guit_gb.ResumeLayout(false);
            this.guit_gb.PerformLayout();
            this.fio_pnl.ResumeLayout(false);
            this.fio_pnl.PerformLayout();
            this.fabula_gb.ResumeLayout(false);
            this.fabula_gb.PerformLayout();
            this.bottom_pnl.ResumeLayout(false);
            this.predecha_box.ResumeLayout(false);
            this.predecha_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.GroupBox stadiya_gb;
        private System.Windows.Forms.Panel rd_panel;
        private System.Windows.Forms.TextBox rd_fio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rd_nomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox upk_pnkt_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox guit;
        private System.Windows.Forms.TextBox fabula;
        private System.Windows.Forms.TextBox sledovatel;
        private System.Windows.Forms.TextBox terpila;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox guit_gb;
        private System.Windows.Forms.Panel fio_pnl;
        private System.Windows.Forms.GroupBox fabula_gb;
        private System.Windows.Forms.Panel bottom_pnl;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.GroupBox predecha_box;
        private System.Windows.Forms.ComboBox gde_c_box;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox peredach_Fio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox peredacha_cbox;
    }
}