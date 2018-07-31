namespace Rhivarius
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.add_btn = new System.Windows.Forms.Button();
            this.grid_view = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.u_cont = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.user_fio_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user_username_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.create_date_label = new System.Windows.Forms.Label();
            this.user_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.user_update = new System.Windows.Forms.LinkLabel();
            this.user_lbl_pass2 = new System.Windows.Forms.Label();
            this.user_pass2 = new System.Windows.Forms.TextBox();
            this.user_pass_chng_pnl = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.user_save_btn = new System.Windows.Forms.Button();
            this.user_isAdmin = new System.Windows.Forms.CheckBox();
            this.user_isActive = new System.Windows.Forms.CheckBox();
            this.user_lbl_id = new System.Windows.Forms.Label();
            this.user_username_error = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.user_pass_chng_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 386);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 386);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.grid_view);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.panel2.Controls.Add(this.add_btn);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 47);
            this.panel2.TabIndex = 1;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(13, 7);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(100, 30);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click_1);
            // 
            // grid_view
            // 
            this.grid_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_view.BackgroundColor = System.Drawing.Color.White;
            this.grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.grid_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_view.GridColor = System.Drawing.Color.Silver;
            this.grid_view.Location = new System.Drawing.Point(3, 48);
            this.grid_view.Margin = new System.Windows.Forms.Padding(0);
            this.grid_view.Name = "grid_view";
            this.grid_view.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_view.Size = new System.Drawing.Size(783, 309);
            this.grid_view.TabIndex = 0;
            this.grid_view.Paint += new System.Windows.Forms.PaintEventHandler(this.grid_view_Paint);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.tabPage2.Controls.Add(this.user_update);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(789, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel3.Controls.Add(this.u_cont);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 360);
            this.panel3.TabIndex = 0;
            // 
            // u_cont
            // 
            this.u_cont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.u_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.u_cont.Location = new System.Drawing.Point(0, 83);
            this.u_cont.Name = "u_cont";
            this.u_cont.Size = new System.Drawing.Size(160, 277);
            this.u_cont.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(109, 22);
            this.menuExit.Text = "Выйти";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.panel4.Controls.Add(this.user_username_error);
            this.panel4.Controls.Add(this.user_lbl_id);
            this.panel4.Controls.Add(this.user_isActive);
            this.panel4.Controls.Add(this.user_isAdmin);
            this.panel4.Controls.Add(this.user_save_btn);
            this.panel4.Controls.Add(this.user_pass_chng_pnl);
            this.panel4.Controls.Add(this.user_pass);
            this.panel4.Controls.Add(this.create_date_label);
            this.panel4.Controls.Add(this.user_username_txt);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.user_fio_txt);
            this.panel4.Location = new System.Drawing.Point(163, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(626, 313);
            this.panel4.TabIndex = 1;
            // 
            // user_fio_txt
            // 
            this.user_fio_txt.Enabled = false;
            this.user_fio_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_fio_txt.Location = new System.Drawing.Point(38, 30);
            this.user_fio_txt.Name = "user_fio_txt";
            this.user_fio_txt.Size = new System.Drawing.Size(472, 23);
            this.user_fio_txt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия Имя Отчество";
            // 
            // user_username_txt
            // 
            this.user_username_txt.Enabled = false;
            this.user_username_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_username_txt.Location = new System.Drawing.Point(38, 88);
            this.user_username_txt.MaxLength = 16;
            this.user_username_txt.Name = "user_username_txt";
            this.user_username_txt.Size = new System.Drawing.Size(185, 23);
            this.user_username_txt.TabIndex = 2;
            this.user_username_txt.TextChanged += new System.EventHandler(this.user_username_txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Имя пользователя";
            // 
            // create_date_label
            // 
            this.create_date_label.AutoSize = true;
            this.create_date_label.ForeColor = System.Drawing.Color.White;
            this.create_date_label.Location = new System.Drawing.Point(361, 72);
            this.create_date_label.Name = "create_date_label";
            this.create_date_label.Size = new System.Drawing.Size(35, 13);
            this.create_date_label.TabIndex = 3;
            this.create_date_label.Text = "label5";
            // 
            // user_pass
            // 
            this.user_pass.Enabled = false;
            this.user_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_pass.Location = new System.Drawing.Point(38, 154);
            this.user_pass.MaxLength = 100;
            this.user_pass.Name = "user_pass";
            this.user_pass.PasswordChar = '*';
            this.user_pass.Size = new System.Drawing.Size(185, 23);
            this.user_pass.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Пароль";
            // 
            // user_update
            // 
            this.user_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.user_update.AutoSize = true;
            this.user_update.BackColor = System.Drawing.Color.Transparent;
            this.user_update.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.user_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_update.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.user_update.LinkArea = new System.Windows.Forms.LinkArea(0, 15);
            this.user_update.LinkColor = System.Drawing.Color.Black;
            this.user_update.Location = new System.Drawing.Point(522, 13);
            this.user_update.Name = "user_update";
            this.user_update.Size = new System.Drawing.Size(81, 24);
            this.user_update.TabIndex = 5;
            this.user_update.TabStop = true;
            this.user_update.Text = "Изменить";
            this.user_update.UseCompatibleTextRendering = true;
            this.user_update.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.user_update_LinkClicked);
            // 
            // user_lbl_pass2
            // 
            this.user_lbl_pass2.AutoSize = true;
            this.user_lbl_pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_lbl_pass2.ForeColor = System.Drawing.Color.White;
            this.user_lbl_pass2.Location = new System.Drawing.Point(7, 56);
            this.user_lbl_pass2.Name = "user_lbl_pass2";
            this.user_lbl_pass2.Size = new System.Drawing.Size(129, 17);
            this.user_lbl_pass2.TabIndex = 1;
            this.user_lbl_pass2.Text = "Повторить пароль";
            // 
            // user_pass2
            // 
            this.user_pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_pass2.Location = new System.Drawing.Point(7, 76);
            this.user_pass2.MaxLength = 16;
            this.user_pass2.Name = "user_pass2";
            this.user_pass2.PasswordChar = '*';
            this.user_pass2.Size = new System.Drawing.Size(185, 23);
            this.user_pass2.TabIndex = 4;
            this.user_pass2.WordWrap = false;
            // 
            // user_pass_chng_pnl
            // 
            this.user_pass_chng_pnl.Controls.Add(this.label5);
            this.user_pass_chng_pnl.Controls.Add(this.user_lbl_pass2);
            this.user_pass_chng_pnl.Controls.Add(this.textBox1);
            this.user_pass_chng_pnl.Controls.Add(this.user_pass2);
            this.user_pass_chng_pnl.Location = new System.Drawing.Point(30, 183);
            this.user_pass_chng_pnl.Name = "user_pass_chng_pnl";
            this.user_pass_chng_pnl.Size = new System.Drawing.Size(203, 106);
            this.user_pass_chng_pnl.TabIndex = 5;
            this.user_pass_chng_pnl.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(7, 26);
            this.textBox1.MaxLength = 16;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(185, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Новый пароль";
            // 
            // user_save_btn
            // 
            this.user_save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_save_btn.Location = new System.Drawing.Point(364, 259);
            this.user_save_btn.Name = "user_save_btn";
            this.user_save_btn.Size = new System.Drawing.Size(92, 23);
            this.user_save_btn.TabIndex = 6;
            this.user_save_btn.Text = "Сохранить";
            this.user_save_btn.UseVisualStyleBackColor = true;
            this.user_save_btn.Click += new System.EventHandler(this.user_save_btn_Click);
            // 
            // user_isAdmin
            // 
            this.user_isAdmin.AutoSize = true;
            this.user_isAdmin.ForeColor = System.Drawing.Color.White;
            this.user_isAdmin.Location = new System.Drawing.Point(364, 184);
            this.user_isAdmin.Name = "user_isAdmin";
            this.user_isAdmin.Size = new System.Drawing.Size(105, 17);
            this.user_isAdmin.TabIndex = 7;
            this.user_isAdmin.Text = "Администратор";
            this.user_isAdmin.UseVisualStyleBackColor = true;
            // 
            // user_isActive
            // 
            this.user_isActive.AutoSize = true;
            this.user_isActive.ForeColor = System.Drawing.Color.White;
            this.user_isActive.Location = new System.Drawing.Point(364, 213);
            this.user_isActive.Name = "user_isActive";
            this.user_isActive.Size = new System.Drawing.Size(76, 17);
            this.user_isActive.TabIndex = 7;
            this.user_isActive.Text = "Активный";
            this.user_isActive.UseVisualStyleBackColor = true;
            // 
            // user_lbl_id
            // 
            this.user_lbl_id.AutoSize = true;
            this.user_lbl_id.Location = new System.Drawing.Point(361, 233);
            this.user_lbl_id.Name = "user_lbl_id";
            this.user_lbl_id.Size = new System.Drawing.Size(35, 13);
            this.user_lbl_id.TabIndex = 8;
            this.user_lbl_id.Text = "label6";
            this.user_lbl_id.Visible = false;
            // 
            // user_username_error
            // 
            this.user_username_error.AutoSize = true;
            this.user_username_error.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_username_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(210)));
            this.user_username_error.ForeColor = System.Drawing.Color.Red;
            this.user_username_error.Location = new System.Drawing.Point(37, 114);
            this.user_username_error.Name = "user_username_error";
            this.user_username_error.Size = new System.Drawing.Size(35, 13);
            this.user_username_error.TabIndex = 9;
            this.user_username_error.Text = "label6";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "УД";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 82.08121F;
            this.Column3.HeaderText = "Дата возбуждения";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.FillWeight = 167.5127F;
            this.Column4.HeaderText = "ГУИТ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 42;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 82.08121F;
            this.Column5.HeaderText = "Ст. приостановления";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 82.08121F;
            this.Column6.HeaderText = "Следователь";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 82.08121F;
            this.Column7.HeaderText = "Заявитель";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 82.08121F;
            this.Column8.HeaderText = "Примечание";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_view)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.user_pass_chng_pnl.ResumeLayout(false);
            this.user_pass_chng_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grid_view;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Panel u_cont;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label create_date_label;
        private System.Windows.Forms.TextBox user_username_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_fio_txt;
        private System.Windows.Forms.TextBox user_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel user_update;
        private System.Windows.Forms.TextBox user_pass2;
        private System.Windows.Forms.Label user_lbl_pass2;
        private System.Windows.Forms.Panel user_pass_chng_pnl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button user_save_btn;
        private System.Windows.Forms.CheckBox user_isActive;
        private System.Windows.Forms.CheckBox user_isAdmin;
        private System.Windows.Forms.Label user_lbl_id;
        private System.Windows.Forms.Label user_username_error;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}

