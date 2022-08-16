namespace StdASystem.AllForms.GeneralForms
{
    partial class frmProgram
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.df_program_list = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_regdate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txt_program_description = new Bunifu.Framework.BunifuCustomTextbox();
            this.txt_program_name = new Bunifu.Framework.BunifuCustomTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_search_program = new Bunifu.Framework.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_cancel_program = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_update_program = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_clear_program = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_save_program = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtmax = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.df_program_list)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::StdASystem.Properties.Resources.edit_50px;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // df_program_list
            // 
            this.df_program_list.AllowUserToAddRows = false;
            this.df_program_list.AllowUserToResizeColumns = false;
            this.df_program_list.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.df_program_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.df_program_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.df_program_list.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.df_program_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.df_program_list.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.df_program_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 3, 3, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.df_program_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.df_program_list.ColumnHeadersHeight = 30;
            this.df_program_list.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.df_program_list.DefaultCellStyle = dataGridViewCellStyle3;
            this.df_program_list.DoubleBuffered = true;
            this.df_program_list.EnableHeadersVisualStyles = false;
            this.df_program_list.GridColor = System.Drawing.Color.WhiteSmoke;
            this.df_program_list.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.df_program_list.HeaderForeColor = System.Drawing.Color.White;
            this.df_program_list.Location = new System.Drawing.Point(41, 363);
            this.df_program_list.Name = "df_program_list";
            this.df_program_list.ReadOnly = true;
            this.df_program_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.df_program_list.RowHeadersVisible = false;
            this.df_program_list.RowHeadersWidth = 45;
            this.df_program_list.RowTemplate.DividerHeight = 1;
            this.df_program_list.RowTemplate.Height = 30;
            this.df_program_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.df_program_list.Size = new System.Drawing.Size(963, 143);
            this.df_program_list.TabIndex = 17;
            this.df_program_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.df_program_list_CellContentClick);
            // 
            // txt_regdate
            // 
            this.txt_regdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txt_regdate.BorderRadius = 0;
            this.txt_regdate.ForeColor = System.Drawing.Color.White;
            this.txt_regdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_regdate.FormatCustom = null;
            this.txt_regdate.Location = new System.Drawing.Point(134, 70);
            this.txt_regdate.Name = "txt_regdate";
            this.txt_regdate.Size = new System.Drawing.Size(322, 24);
            this.txt_regdate.TabIndex = 9;
            this.txt_regdate.Value = new System.DateTime(2022, 2, 25, 10, 7, 51, 634);
            // 
            // txt_program_description
            // 
            this.txt_program_description.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_program_description.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_program_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txt_program_description.Location = new System.Drawing.Point(135, 103);
            this.txt_program_description.Multiline = true;
            this.txt_program_description.Name = "txt_program_description";
            this.txt_program_description.Size = new System.Drawing.Size(322, 104);
            this.txt_program_description.TabIndex = 7;
            // 
            // txt_program_name
            // 
            this.txt_program_name.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_program_name.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_program_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txt_program_name.Location = new System.Drawing.Point(134, 30);
            this.txt_program_name.Multiline = true;
            this.txt_program_name.Name = "txt_program_name";
            this.txt_program_name.Size = new System.Drawing.Size(322, 27);
            this.txt_program_name.TabIndex = 6;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(13, 105);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(89, 16);
            this.bunifuCustomLabel6.TabIndex = 5;
            this.bunifuCustomLabel6.Text = "Description :";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(13, 74);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(75, 16);
            this.bunifuCustomLabel4.TabIndex = 3;
            this.bunifuCustomLabel4.Text = "Reg Date :";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(13, 36);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(114, 16);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Program Name :";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(45, 321);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(133, 16);
            this.bunifuCustomLabel7.TabIndex = 15;
            this.bunifuCustomLabel7.Text = "Search a Program :";
            // 
            // txt_search_program
            // 
            this.txt_search_program.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_search_program.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_program.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txt_search_program.Location = new System.Drawing.Point(182, 316);
            this.txt_search_program.Multiline = true;
            this.txt_search_program.Name = "txt_search_program";
            this.txt_search_program.Size = new System.Drawing.Size(274, 27);
            this.txt_search_program.TabIndex = 16;
            this.txt_search_program.TextChanged += new System.EventHandler(this.txt_search_program_TextChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(1, 4);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(172, 17);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Enter The Program Details";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCards2.Controls.Add(this.btn_cancel_program);
            this.bunifuCards2.Controls.Add(this.btn_update_program);
            this.bunifuCards2.Controls.Add(this.btn_clear_program);
            this.bunifuCards2.Controls.Add(this.btn_save_program);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(571, 77);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(330, 201);
            this.bunifuCards2.TabIndex = 14;
            // 
            // btn_cancel_program
            // 
            this.btn_cancel_program.Active = false;
            this.btn_cancel_program.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_cancel_program.BackColor = System.Drawing.Color.Crimson;
            this.btn_cancel_program.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel_program.BorderRadius = 6;
            this.btn_cancel_program.ButtonText = "   Cancel";
            this.btn_cancel_program.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel_program.DisabledColor = System.Drawing.Color.Gray;
            this.btn_cancel_program.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cancel_program.Iconimage = global::StdASystem.Properties.Resources.Close_50px;
            this.btn_cancel_program.Iconimage_right = null;
            this.btn_cancel_program.Iconimage_right_Selected = null;
            this.btn_cancel_program.Iconimage_Selected = null;
            this.btn_cancel_program.IconMarginLeft = 0;
            this.btn_cancel_program.IconMarginRight = 0;
            this.btn_cancel_program.IconRightVisible = true;
            this.btn_cancel_program.IconRightZoom = 0D;
            this.btn_cancel_program.IconVisible = true;
            this.btn_cancel_program.IconZoom = 60D;
            this.btn_cancel_program.IsTab = false;
            this.btn_cancel_program.Location = new System.Drawing.Point(167, 137);
            this.btn_cancel_program.Name = "btn_cancel_program";
            this.btn_cancel_program.Normalcolor = System.Drawing.Color.Crimson;
            this.btn_cancel_program.OnHovercolor = System.Drawing.Color.Maroon;
            this.btn_cancel_program.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cancel_program.selected = false;
            this.btn_cancel_program.Size = new System.Drawing.Size(129, 42);
            this.btn_cancel_program.TabIndex = 4;
            this.btn_cancel_program.Text = "   Cancel";
            this.btn_cancel_program.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel_program.Textcolor = System.Drawing.Color.White;
            this.btn_cancel_program.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_program.Click += new System.EventHandler(this.btn_cancel_program_Click);
            // 
            // btn_update_program
            // 
            this.btn_update_program.Active = false;
            this.btn_update_program.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_update_program.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_update_program.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update_program.BorderRadius = 6;
            this.btn_update_program.ButtonText = "   Update";
            this.btn_update_program.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_program.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update_program.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_update_program.Iconimage = global::StdASystem.Properties.Resources.refresh_50px;
            this.btn_update_program.Iconimage_right = null;
            this.btn_update_program.Iconimage_right_Selected = null;
            this.btn_update_program.Iconimage_Selected = null;
            this.btn_update_program.IconMarginLeft = 0;
            this.btn_update_program.IconMarginRight = 0;
            this.btn_update_program.IconRightVisible = true;
            this.btn_update_program.IconRightZoom = 0D;
            this.btn_update_program.IconVisible = true;
            this.btn_update_program.IconZoom = 60D;
            this.btn_update_program.IsTab = false;
            this.btn_update_program.Location = new System.Drawing.Point(23, 137);
            this.btn_update_program.Name = "btn_update_program";
            this.btn_update_program.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_update_program.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_update_program.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update_program.selected = false;
            this.btn_update_program.Size = new System.Drawing.Size(123, 42);
            this.btn_update_program.TabIndex = 3;
            this.btn_update_program.Text = "   Update";
            this.btn_update_program.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update_program.Textcolor = System.Drawing.Color.White;
            this.btn_update_program.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_program.Click += new System.EventHandler(this.btn_update_program_Click);
            // 
            // btn_clear_program
            // 
            this.btn_clear_program.Active = false;
            this.btn_clear_program.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_clear_program.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_clear_program.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear_program.BorderRadius = 6;
            this.btn_clear_program.ButtonText = "   Clear";
            this.btn_clear_program.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear_program.DisabledColor = System.Drawing.Color.Gray;
            this.btn_clear_program.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_clear_program.Iconimage = global::StdASystem.Properties.Resources.clear_symbol_50px;
            this.btn_clear_program.Iconimage_right = null;
            this.btn_clear_program.Iconimage_right_Selected = null;
            this.btn_clear_program.Iconimage_Selected = null;
            this.btn_clear_program.IconMarginLeft = 0;
            this.btn_clear_program.IconMarginRight = 0;
            this.btn_clear_program.IconRightVisible = true;
            this.btn_clear_program.IconRightZoom = 0D;
            this.btn_clear_program.IconVisible = true;
            this.btn_clear_program.IconZoom = 60D;
            this.btn_clear_program.IsTab = false;
            this.btn_clear_program.Location = new System.Drawing.Point(23, 82);
            this.btn_clear_program.Name = "btn_clear_program";
            this.btn_clear_program.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_clear_program.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_clear_program.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_clear_program.selected = false;
            this.btn_clear_program.Size = new System.Drawing.Size(123, 42);
            this.btn_clear_program.TabIndex = 2;
            this.btn_clear_program.Text = "   Clear";
            this.btn_clear_program.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear_program.Textcolor = System.Drawing.Color.White;
            this.btn_clear_program.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_program.Click += new System.EventHandler(this.btn_clear_program_Click);
            // 
            // btn_save_program
            // 
            this.btn_save_program.Active = false;
            this.btn_save_program.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save_program.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save_program.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save_program.BorderRadius = 6;
            this.btn_save_program.ButtonText = "   Save";
            this.btn_save_program.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_program.DisabledColor = System.Drawing.Color.Gray;
            this.btn_save_program.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_save_program.Iconimage = global::StdASystem.Properties.Resources.save_50px;
            this.btn_save_program.Iconimage_right = null;
            this.btn_save_program.Iconimage_right_Selected = null;
            this.btn_save_program.Iconimage_Selected = null;
            this.btn_save_program.IconMarginLeft = 0;
            this.btn_save_program.IconMarginRight = 0;
            this.btn_save_program.IconRightVisible = true;
            this.btn_save_program.IconRightZoom = 0D;
            this.btn_save_program.IconVisible = true;
            this.btn_save_program.IconZoom = 60D;
            this.btn_save_program.IsTab = false;
            this.btn_save_program.Location = new System.Drawing.Point(23, 27);
            this.btn_save_program.Name = "btn_save_program";
            this.btn_save_program.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save_program.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_save_program.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_save_program.selected = false;
            this.btn_save_program.Size = new System.Drawing.Size(123, 42);
            this.btn_save_program.TabIndex = 1;
            this.btn_save_program.Text = "   Save";
            this.btn_save_program.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_program.Textcolor = System.Drawing.Color.White;
            this.btn_save_program.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_program.Click += new System.EventHandler(this.btn_save_program_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCards1.Controls.Add(this.txt_regdate);
            this.bunifuCards1.Controls.Add(this.txt_program_description);
            this.bunifuCards1.Controls.Add(this.txt_program_name);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(41, 77);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(480, 222);
            this.bunifuCards1.TabIndex = 13;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1016, 71);
            this.guna2ShadowPanel1.TabIndex = 12;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(10, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(254, 41);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Program Form";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.df_program_list;
            // 
            // txtmax
            // 
            this.txtmax.AutoSize = true;
            this.txtmax.BackColor = System.Drawing.Color.Transparent;
            this.txtmax.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txtmax.Location = new System.Drawing.Point(568, 316);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(89, 16);
            this.txtmax.TabIndex = 10;
            this.txtmax.Text = "Description :";
            // 
            // frmProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 511);
            this.Controls.Add(this.txtmax);
            this.Controls.Add(this.df_program_list);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.txt_search_program);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProgram";
            this.Text = "frmProgram";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.df_program_list)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ep;
        private Bunifu.Framework.UI.BunifuCustomDataGrid df_program_list;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.BunifuCustomTextbox txt_search_program;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cancel_program;
        private Bunifu.Framework.UI.BunifuFlatButton btn_update_program;
        private Bunifu.Framework.UI.BunifuFlatButton btn_clear_program;
        private Bunifu.Framework.UI.BunifuFlatButton btn_save_program;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuDatepicker txt_regdate;
        private Bunifu.Framework.BunifuCustomTextbox txt_program_description;
        private Bunifu.Framework.BunifuCustomTextbox txt_program_name;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel txtmax;
    }
}