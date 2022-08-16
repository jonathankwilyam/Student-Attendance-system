namespace StdASystem.AllForms.GeneralForms
{
    partial class frmSemester
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.txt_semester_name = new Bunifu.Framework.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_cancel_semester = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_update_semester = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_clear_semester = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_save_semester = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_search_semester = new Bunifu.Framework.BunifuCustomTextbox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.df_semester_list = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2ShadowPanel1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.df_semester_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
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
            this.guna2ShadowPanel1.TabIndex = 13;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(10, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(264, 41);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Semester Form";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCards1.Controls.Add(this.txt_semester_name);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(52, 77);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(480, 85);
            this.bunifuCards1.TabIndex = 14;
            // 
            // txt_semester_name
            // 
            this.txt_semester_name.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_semester_name.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_semester_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txt_semester_name.Location = new System.Drawing.Point(134, 30);
            this.txt_semester_name.Multiline = true;
            this.txt_semester_name.Name = "txt_semester_name";
            this.txt_semester_name.Size = new System.Drawing.Size(322, 27);
            this.txt_semester_name.TabIndex = 6;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(13, 36);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(117, 16);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Semester Name :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(1, 4);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(168, 17);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Enter The Semeter Details";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCards2.Controls.Add(this.btn_cancel_semester);
            this.bunifuCards2.Controls.Add(this.btn_update_semester);
            this.bunifuCards2.Controls.Add(this.btn_clear_semester);
            this.bunifuCards2.Controls.Add(this.btn_save_semester);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(102, 168);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(364, 129);
            this.bunifuCards2.TabIndex = 15;
            // 
            // btn_cancel_semester
            // 
            this.btn_cancel_semester.Active = false;
            this.btn_cancel_semester.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_cancel_semester.BackColor = System.Drawing.Color.Crimson;
            this.btn_cancel_semester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel_semester.BorderRadius = 6;
            this.btn_cancel_semester.ButtonText = "   Cancel";
            this.btn_cancel_semester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel_semester.DisabledColor = System.Drawing.Color.Gray;
            this.btn_cancel_semester.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cancel_semester.Iconimage = global::StdASystem.Properties.Resources.Close_50px;
            this.btn_cancel_semester.Iconimage_right = null;
            this.btn_cancel_semester.Iconimage_right_Selected = null;
            this.btn_cancel_semester.Iconimage_Selected = null;
            this.btn_cancel_semester.IconMarginLeft = 0;
            this.btn_cancel_semester.IconMarginRight = 0;
            this.btn_cancel_semester.IconRightVisible = true;
            this.btn_cancel_semester.IconRightZoom = 0D;
            this.btn_cancel_semester.IconVisible = true;
            this.btn_cancel_semester.IconZoom = 60D;
            this.btn_cancel_semester.IsTab = false;
            this.btn_cancel_semester.Location = new System.Drawing.Point(235, 73);
            this.btn_cancel_semester.Name = "btn_cancel_semester";
            this.btn_cancel_semester.Normalcolor = System.Drawing.Color.Crimson;
            this.btn_cancel_semester.OnHovercolor = System.Drawing.Color.Maroon;
            this.btn_cancel_semester.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cancel_semester.selected = false;
            this.btn_cancel_semester.Size = new System.Drawing.Size(115, 42);
            this.btn_cancel_semester.TabIndex = 4;
            this.btn_cancel_semester.Text = "   Cancel";
            this.btn_cancel_semester.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel_semester.Textcolor = System.Drawing.Color.White;
            this.btn_cancel_semester.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_semester.Click += new System.EventHandler(this.btn_cancel_semester_Click);
            // 
            // btn_update_semester
            // 
            this.btn_update_semester.Active = false;
            this.btn_update_semester.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_update_semester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_update_semester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update_semester.BorderRadius = 6;
            this.btn_update_semester.ButtonText = "   Update";
            this.btn_update_semester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_semester.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update_semester.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_update_semester.Iconimage = global::StdASystem.Properties.Resources.refresh_50px;
            this.btn_update_semester.Iconimage_right = null;
            this.btn_update_semester.Iconimage_right_Selected = null;
            this.btn_update_semester.Iconimage_Selected = null;
            this.btn_update_semester.IconMarginLeft = 0;
            this.btn_update_semester.IconMarginRight = 0;
            this.btn_update_semester.IconRightVisible = true;
            this.btn_update_semester.IconRightZoom = 0D;
            this.btn_update_semester.IconVisible = true;
            this.btn_update_semester.IconZoom = 60D;
            this.btn_update_semester.IsTab = false;
            this.btn_update_semester.Location = new System.Drawing.Point(120, 73);
            this.btn_update_semester.Name = "btn_update_semester";
            this.btn_update_semester.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_update_semester.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_update_semester.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update_semester.selected = false;
            this.btn_update_semester.Size = new System.Drawing.Size(109, 42);
            this.btn_update_semester.TabIndex = 3;
            this.btn_update_semester.Text = "   Update";
            this.btn_update_semester.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update_semester.Textcolor = System.Drawing.Color.White;
            this.btn_update_semester.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_semester.Click += new System.EventHandler(this.btn_update_semester_Click);
            // 
            // btn_clear_semester
            // 
            this.btn_clear_semester.Active = false;
            this.btn_clear_semester.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_clear_semester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_clear_semester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear_semester.BorderRadius = 6;
            this.btn_clear_semester.ButtonText = "   Clear";
            this.btn_clear_semester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear_semester.DisabledColor = System.Drawing.Color.Gray;
            this.btn_clear_semester.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_clear_semester.Iconimage = global::StdASystem.Properties.Resources.clear_symbol_50px;
            this.btn_clear_semester.Iconimage_right = null;
            this.btn_clear_semester.Iconimage_right_Selected = null;
            this.btn_clear_semester.Iconimage_Selected = null;
            this.btn_clear_semester.IconMarginLeft = 0;
            this.btn_clear_semester.IconMarginRight = 0;
            this.btn_clear_semester.IconRightVisible = true;
            this.btn_clear_semester.IconRightZoom = 0D;
            this.btn_clear_semester.IconVisible = true;
            this.btn_clear_semester.IconZoom = 60D;
            this.btn_clear_semester.IsTab = false;
            this.btn_clear_semester.Location = new System.Drawing.Point(17, 73);
            this.btn_clear_semester.Name = "btn_clear_semester";
            this.btn_clear_semester.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_clear_semester.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_clear_semester.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_clear_semester.selected = false;
            this.btn_clear_semester.Size = new System.Drawing.Size(97, 42);
            this.btn_clear_semester.TabIndex = 2;
            this.btn_clear_semester.Text = "   Clear";
            this.btn_clear_semester.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear_semester.Textcolor = System.Drawing.Color.White;
            this.btn_clear_semester.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_semester.Click += new System.EventHandler(this.btn_clear_semester_Click);
            // 
            // btn_save_semester
            // 
            this.btn_save_semester.Active = false;
            this.btn_save_semester.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save_semester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save_semester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save_semester.BorderRadius = 6;
            this.btn_save_semester.ButtonText = "   Save";
            this.btn_save_semester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_semester.DisabledColor = System.Drawing.Color.Gray;
            this.btn_save_semester.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_save_semester.Iconimage = global::StdASystem.Properties.Resources.save_50px;
            this.btn_save_semester.Iconimage_right = null;
            this.btn_save_semester.Iconimage_right_Selected = null;
            this.btn_save_semester.Iconimage_Selected = null;
            this.btn_save_semester.IconMarginLeft = 0;
            this.btn_save_semester.IconMarginRight = 0;
            this.btn_save_semester.IconRightVisible = true;
            this.btn_save_semester.IconRightZoom = 0D;
            this.btn_save_semester.IconVisible = true;
            this.btn_save_semester.IconZoom = 60D;
            this.btn_save_semester.IsTab = false;
            this.btn_save_semester.Location = new System.Drawing.Point(120, 13);
            this.btn_save_semester.Name = "btn_save_semester";
            this.btn_save_semester.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save_semester.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_save_semester.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_save_semester.selected = false;
            this.btn_save_semester.Size = new System.Drawing.Size(109, 42);
            this.btn_save_semester.TabIndex = 1;
            this.btn_save_semester.Text = "   Save";
            this.btn_save_semester.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_semester.Textcolor = System.Drawing.Color.White;
            this.btn_save_semester.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_semester.Click += new System.EventHandler(this.btn_save_semester_Click);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(566, 87);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(136, 16);
            this.bunifuCustomLabel7.TabIndex = 17;
            this.bunifuCustomLabel7.Text = "Search a Semester :";
            // 
            // txt_search_semester
            // 
            this.txt_search_semester.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_search_semester.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_semester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txt_search_semester.Location = new System.Drawing.Point(708, 86);
            this.txt_search_semester.Multiline = true;
            this.txt_search_semester.Name = "txt_search_semester";
            this.txt_search_semester.Size = new System.Drawing.Size(274, 27);
            this.txt_search_semester.TabIndex = 18;
            this.txt_search_semester.TextChanged += new System.EventHandler(this.txt_search_semester_TextChanged);
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
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.df_semester_list;
            // 
            // df_semester_list
            // 
            this.df_semester_list.AllowUserToAddRows = false;
            this.df_semester_list.AllowUserToResizeColumns = false;
            this.df_semester_list.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.df_semester_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.df_semester_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.df_semester_list.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.df_semester_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.df_semester_list.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.df_semester_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2, 3, 3, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.df_semester_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.df_semester_list.ColumnHeadersHeight = 30;
            this.df_semester_list.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.df_semester_list.DefaultCellStyle = dataGridViewCellStyle6;
            this.df_semester_list.DoubleBuffered = true;
            this.df_semester_list.EnableHeadersVisualStyles = false;
            this.df_semester_list.GridColor = System.Drawing.Color.WhiteSmoke;
            this.df_semester_list.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.df_semester_list.HeaderForeColor = System.Drawing.Color.White;
            this.df_semester_list.Location = new System.Drawing.Point(569, 129);
            this.df_semester_list.Name = "df_semester_list";
            this.df_semester_list.ReadOnly = true;
            this.df_semester_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.df_semester_list.RowHeadersVisible = false;
            this.df_semester_list.RowHeadersWidth = 45;
            this.df_semester_list.RowTemplate.DividerHeight = 1;
            this.df_semester_list.RowTemplate.Height = 30;
            this.df_semester_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.df_semester_list.Size = new System.Drawing.Size(435, 370);
            this.df_semester_list.TabIndex = 20;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // frmSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 511);
            this.Controls.Add(this.df_semester_list);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.txt_search_semester);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "frmSemester";
            this.Text = "frmSemester";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSemester_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.df_semester_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.BunifuCustomTextbox txt_semester_name;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cancel_semester;
        private Bunifu.Framework.UI.BunifuFlatButton btn_update_semester;
        private Bunifu.Framework.UI.BunifuFlatButton btn_clear_semester;
        private Bunifu.Framework.UI.BunifuFlatButton btn_save_semester;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.BunifuCustomTextbox txt_search_semester;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid df_semester_list;
        private System.Windows.Forms.ErrorProvider ep;
    }
}