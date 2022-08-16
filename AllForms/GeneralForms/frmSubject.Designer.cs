namespace StdASystem.AllForms.GeneralForms
{
    partial class frmSubject
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
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.df_subject_list = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_search_subject = new Bunifu.Framework.BunifuCustomTextbox();
            this.txt_subject_name = new Bunifu.Framework.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cancel_subject = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_update_subject = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_clear_subject = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_save_subject = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_subject_code = new Bunifu.Framework.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.df_subject_list)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.df_subject_list;
            // 
            // df_subject_list
            // 
            this.df_subject_list.AllowUserToAddRows = false;
            this.df_subject_list.AllowUserToResizeColumns = false;
            this.df_subject_list.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.df_subject_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.df_subject_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.df_subject_list.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.df_subject_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.df_subject_list.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.df_subject_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2, 3, 3, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.df_subject_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.df_subject_list.ColumnHeadersHeight = 30;
            this.df_subject_list.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.df_subject_list.DefaultCellStyle = dataGridViewCellStyle6;
            this.df_subject_list.DoubleBuffered = true;
            this.df_subject_list.EnableHeadersVisualStyles = false;
            this.df_subject_list.GridColor = System.Drawing.Color.WhiteSmoke;
            this.df_subject_list.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.df_subject_list.HeaderForeColor = System.Drawing.Color.White;
            this.df_subject_list.Location = new System.Drawing.Point(569, 135);
            this.df_subject_list.Name = "df_subject_list";
            this.df_subject_list.ReadOnly = true;
            this.df_subject_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.df_subject_list.RowHeadersVisible = false;
            this.df_subject_list.RowHeadersWidth = 45;
            this.df_subject_list.RowTemplate.DividerHeight = 1;
            this.df_subject_list.RowTemplate.Height = 30;
            this.df_subject_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.df_subject_list.Size = new System.Drawing.Size(435, 370);
            this.df_subject_list.TabIndex = 26;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(566, 93);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(126, 16);
            this.bunifuCustomLabel7.TabIndex = 24;
            this.bunifuCustomLabel7.Text = "Search a Subject :";
            // 
            // txt_search_subject
            // 
            this.txt_search_subject.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_search_subject.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txt_search_subject.Location = new System.Drawing.Point(708, 92);
            this.txt_search_subject.Multiline = true;
            this.txt_search_subject.Name = "txt_search_subject";
            this.txt_search_subject.Size = new System.Drawing.Size(274, 27);
            this.txt_search_subject.TabIndex = 25;
            this.txt_search_subject.TextChanged += new System.EventHandler(this.txt_search_subject_TextChanged);
            // 
            // txt_subject_name
            // 
            this.txt_subject_name.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_subject_name.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subject_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txt_subject_name.Location = new System.Drawing.Point(134, 30);
            this.txt_subject_name.Multiline = true;
            this.txt_subject_name.Name = "txt_subject_name";
            this.txt_subject_name.Size = new System.Drawing.Size(322, 27);
            this.txt_subject_name.TabIndex = 6;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(13, 36);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(107, 16);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Subject Name :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(1, 4);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(163, 17);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Enter The Subject Details";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCards1.Controls.Add(this.txt_subject_code);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuCards1.Controls.Add(this.txt_subject_name);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(52, 83);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(480, 135);
            this.bunifuCards1.TabIndex = 22;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(10, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(236, 41);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Subject Form";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCards2.Controls.Add(this.btn_cancel_subject);
            this.bunifuCards2.Controls.Add(this.btn_update_subject);
            this.bunifuCards2.Controls.Add(this.btn_clear_subject);
            this.bunifuCards2.Controls.Add(this.btn_save_subject);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(118, 224);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(364, 129);
            this.bunifuCards2.TabIndex = 23;
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
            this.guna2ShadowPanel1.TabIndex = 21;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::StdASystem.Properties.Resources.edit_50px;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // btn_cancel_subject
            // 
            this.btn_cancel_subject.Active = false;
            this.btn_cancel_subject.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_cancel_subject.BackColor = System.Drawing.Color.Crimson;
            this.btn_cancel_subject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel_subject.BorderRadius = 6;
            this.btn_cancel_subject.ButtonText = "   Cancel";
            this.btn_cancel_subject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel_subject.DisabledColor = System.Drawing.Color.Gray;
            this.btn_cancel_subject.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cancel_subject.Iconimage = global::StdASystem.Properties.Resources.Close_50px;
            this.btn_cancel_subject.Iconimage_right = null;
            this.btn_cancel_subject.Iconimage_right_Selected = null;
            this.btn_cancel_subject.Iconimage_Selected = null;
            this.btn_cancel_subject.IconMarginLeft = 0;
            this.btn_cancel_subject.IconMarginRight = 0;
            this.btn_cancel_subject.IconRightVisible = true;
            this.btn_cancel_subject.IconRightZoom = 0D;
            this.btn_cancel_subject.IconVisible = true;
            this.btn_cancel_subject.IconZoom = 60D;
            this.btn_cancel_subject.IsTab = false;
            this.btn_cancel_subject.Location = new System.Drawing.Point(235, 73);
            this.btn_cancel_subject.Name = "btn_cancel_subject";
            this.btn_cancel_subject.Normalcolor = System.Drawing.Color.Crimson;
            this.btn_cancel_subject.OnHovercolor = System.Drawing.Color.Maroon;
            this.btn_cancel_subject.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cancel_subject.selected = false;
            this.btn_cancel_subject.Size = new System.Drawing.Size(115, 42);
            this.btn_cancel_subject.TabIndex = 4;
            this.btn_cancel_subject.Text = "   Cancel";
            this.btn_cancel_subject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel_subject.Textcolor = System.Drawing.Color.White;
            this.btn_cancel_subject.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_subject.Click += new System.EventHandler(this.btn_cancel_subject_Click);
            // 
            // btn_update_subject
            // 
            this.btn_update_subject.Active = false;
            this.btn_update_subject.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_update_subject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_update_subject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update_subject.BorderRadius = 6;
            this.btn_update_subject.ButtonText = "   Update";
            this.btn_update_subject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_subject.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update_subject.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_update_subject.Iconimage = global::StdASystem.Properties.Resources.refresh_50px;
            this.btn_update_subject.Iconimage_right = null;
            this.btn_update_subject.Iconimage_right_Selected = null;
            this.btn_update_subject.Iconimage_Selected = null;
            this.btn_update_subject.IconMarginLeft = 0;
            this.btn_update_subject.IconMarginRight = 0;
            this.btn_update_subject.IconRightVisible = true;
            this.btn_update_subject.IconRightZoom = 0D;
            this.btn_update_subject.IconVisible = true;
            this.btn_update_subject.IconZoom = 60D;
            this.btn_update_subject.IsTab = false;
            this.btn_update_subject.Location = new System.Drawing.Point(120, 73);
            this.btn_update_subject.Name = "btn_update_subject";
            this.btn_update_subject.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_update_subject.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_update_subject.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update_subject.selected = false;
            this.btn_update_subject.Size = new System.Drawing.Size(109, 42);
            this.btn_update_subject.TabIndex = 3;
            this.btn_update_subject.Text = "   Update";
            this.btn_update_subject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update_subject.Textcolor = System.Drawing.Color.White;
            this.btn_update_subject.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_subject.Click += new System.EventHandler(this.btn_update_subject_Click);
            // 
            // btn_clear_subject
            // 
            this.btn_clear_subject.Active = false;
            this.btn_clear_subject.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_clear_subject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_clear_subject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear_subject.BorderRadius = 6;
            this.btn_clear_subject.ButtonText = "   Clear";
            this.btn_clear_subject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear_subject.DisabledColor = System.Drawing.Color.Gray;
            this.btn_clear_subject.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_clear_subject.Iconimage = global::StdASystem.Properties.Resources.clear_symbol_50px;
            this.btn_clear_subject.Iconimage_right = null;
            this.btn_clear_subject.Iconimage_right_Selected = null;
            this.btn_clear_subject.Iconimage_Selected = null;
            this.btn_clear_subject.IconMarginLeft = 0;
            this.btn_clear_subject.IconMarginRight = 0;
            this.btn_clear_subject.IconRightVisible = true;
            this.btn_clear_subject.IconRightZoom = 0D;
            this.btn_clear_subject.IconVisible = true;
            this.btn_clear_subject.IconZoom = 60D;
            this.btn_clear_subject.IsTab = false;
            this.btn_clear_subject.Location = new System.Drawing.Point(17, 73);
            this.btn_clear_subject.Name = "btn_clear_subject";
            this.btn_clear_subject.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_clear_subject.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_clear_subject.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_clear_subject.selected = false;
            this.btn_clear_subject.Size = new System.Drawing.Size(97, 42);
            this.btn_clear_subject.TabIndex = 2;
            this.btn_clear_subject.Text = "   Clear";
            this.btn_clear_subject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear_subject.Textcolor = System.Drawing.Color.White;
            this.btn_clear_subject.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_subject.Click += new System.EventHandler(this.btn_clear_subject_Click);
            // 
            // btn_save_subject
            // 
            this.btn_save_subject.Active = false;
            this.btn_save_subject.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save_subject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save_subject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save_subject.BorderRadius = 6;
            this.btn_save_subject.ButtonText = "   Save";
            this.btn_save_subject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_subject.DisabledColor = System.Drawing.Color.Gray;
            this.btn_save_subject.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_save_subject.Iconimage = global::StdASystem.Properties.Resources.save_50px;
            this.btn_save_subject.Iconimage_right = null;
            this.btn_save_subject.Iconimage_right_Selected = null;
            this.btn_save_subject.Iconimage_Selected = null;
            this.btn_save_subject.IconMarginLeft = 0;
            this.btn_save_subject.IconMarginRight = 0;
            this.btn_save_subject.IconRightVisible = true;
            this.btn_save_subject.IconRightZoom = 0D;
            this.btn_save_subject.IconVisible = true;
            this.btn_save_subject.IconZoom = 60D;
            this.btn_save_subject.IsTab = false;
            this.btn_save_subject.Location = new System.Drawing.Point(120, 13);
            this.btn_save_subject.Name = "btn_save_subject";
            this.btn_save_subject.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save_subject.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_save_subject.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_save_subject.selected = false;
            this.btn_save_subject.Size = new System.Drawing.Size(109, 42);
            this.btn_save_subject.TabIndex = 1;
            this.btn_save_subject.Text = "   Save";
            this.btn_save_subject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_subject.Textcolor = System.Drawing.Color.White;
            this.btn_save_subject.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_subject.Click += new System.EventHandler(this.btn_save_semester_Click);
            // 
            // txt_subject_code
            // 
            this.txt_subject_code.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_subject_code.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subject_code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txt_subject_code.Location = new System.Drawing.Point(134, 74);
            this.txt_subject_code.Multiline = true;
            this.txt_subject_code.Name = "txt_subject_code";
            this.txt_subject_code.Size = new System.Drawing.Size(322, 27);
            this.txt_subject_code.TabIndex = 8;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(13, 80);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(103, 16);
            this.bunifuCustomLabel4.TabIndex = 7;
            this.bunifuCustomLabel4.Text = "Subject Code :";
            // 
            // frmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 511);
            this.Controls.Add(this.df_subject_list);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.txt_search_subject);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "frmSubject";
            this.Text = "frmSubject";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.df_subject_list)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ep;
        private Bunifu.Framework.UI.BunifuCustomDataGrid df_subject_list;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.BunifuCustomTextbox txt_search_subject;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.BunifuCustomTextbox txt_subject_name;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cancel_subject;
        private Bunifu.Framework.UI.BunifuFlatButton btn_update_subject;
        private Bunifu.Framework.UI.BunifuFlatButton btn_clear_subject;
        private Bunifu.Framework.UI.BunifuFlatButton btn_save_subject;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.BunifuCustomTextbox txt_subject_code;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
    }
}