namespace StdASystem.AllForms.Semester
{
    partial class FormSemesterPromote
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_refresh_cur_semester = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cmb_current_semester = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_refresh_session = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_refresh_program = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cmb_program = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmb_session = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards5 = new Bunifu.Framework.UI.BunifuCards();
            this.btnretrive = new Guna.UI2.WinForms.Guna2Button();
            this.rbnotpromoted = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbpromoted = new Guna.UI2.WinForms.Guna2RadioButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_refresh_sel_semester = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cmb_semester = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnpromote = new Guna.UI2.WinForms.Guna2Button();
            this.btclear = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.df_viewstudent = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.chckAll = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2ShadowPanel1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards5.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.df_viewstudent)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
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
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1115, 71);
            this.guna2ShadowPanel1.TabIndex = 15;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(10, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(308, 41);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Students Promote";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCards1.Controls.Add(this.btn_refresh_cur_semester);
            this.bunifuCards1.Controls.Add(this.cmb_current_semester);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards1.Controls.Add(this.btn_refresh_session);
            this.bunifuCards1.Controls.Add(this.btn_refresh_program);
            this.bunifuCards1.Controls.Add(this.cmb_program);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuCards1.Controls.Add(this.cmb_session);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(11, 47);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(446, 174);
            this.bunifuCards1.TabIndex = 16;
            // 
            // btn_refresh_cur_semester
            // 
            this.btn_refresh_cur_semester.CheckedState.Parent = this.btn_refresh_cur_semester;
            this.btn_refresh_cur_semester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh_cur_semester.HoverState.Parent = this.btn_refresh_cur_semester;
            this.btn_refresh_cur_semester.Image = global::StdASystem.Properties.Resources.synchronize_50px1;
            this.btn_refresh_cur_semester.Location = new System.Drawing.Point(405, 128);
            this.btn_refresh_cur_semester.Name = "btn_refresh_cur_semester";
            this.btn_refresh_cur_semester.PressedState.Parent = this.btn_refresh_cur_semester;
            this.btn_refresh_cur_semester.Size = new System.Drawing.Size(26, 23);
            this.btn_refresh_cur_semester.TabIndex = 16;
            this.btn_refresh_cur_semester.Click += new System.EventHandler(this.btn_refresh_cur_semester_Click);
            // 
            // cmb_current_semester
            // 
            this.cmb_current_semester.BackColor = System.Drawing.Color.Transparent;
            this.cmb_current_semester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_current_semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_current_semester.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_current_semester.FocusedState.Parent = this.cmb_current_semester;
            this.cmb_current_semester.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_current_semester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_current_semester.FormattingEnabled = true;
            this.cmb_current_semester.HoverState.Parent = this.cmb_current_semester;
            this.cmb_current_semester.ItemHeight = 30;
            this.cmb_current_semester.ItemsAppearance.Parent = this.cmb_current_semester;
            this.cmb_current_semester.Location = new System.Drawing.Point(188, 122);
            this.cmb_current_semester.Name = "cmb_current_semester";
            this.cmb_current_semester.ShadowDecoration.Parent = this.cmb_current_semester;
            this.cmb_current_semester.Size = new System.Drawing.Size(211, 36);
            this.cmb_current_semester.TabIndex = 15;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(13, 129);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(169, 16);
            this.bunifuCustomLabel2.TabIndex = 14;
            this.bunifuCustomLabel2.Text = "Select Current Semester :";
            // 
            // btn_refresh_session
            // 
            this.btn_refresh_session.CheckedState.Parent = this.btn_refresh_session;
            this.btn_refresh_session.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh_session.HoverState.Parent = this.btn_refresh_session;
            this.btn_refresh_session.Image = global::StdASystem.Properties.Resources.synchronize_50px1;
            this.btn_refresh_session.Location = new System.Drawing.Point(405, 22);
            this.btn_refresh_session.Name = "btn_refresh_session";
            this.btn_refresh_session.PressedState.Parent = this.btn_refresh_session;
            this.btn_refresh_session.Size = new System.Drawing.Size(26, 23);
            this.btn_refresh_session.TabIndex = 13;
            this.btn_refresh_session.Click += new System.EventHandler(this.btn_refresh_session_Click);
            // 
            // btn_refresh_program
            // 
            this.btn_refresh_program.CheckedState.Parent = this.btn_refresh_program;
            this.btn_refresh_program.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh_program.HoverState.Parent = this.btn_refresh_program;
            this.btn_refresh_program.Image = global::StdASystem.Properties.Resources.synchronize_50px1;
            this.btn_refresh_program.Location = new System.Drawing.Point(405, 64);
            this.btn_refresh_program.Name = "btn_refresh_program";
            this.btn_refresh_program.PressedState.Parent = this.btn_refresh_program;
            this.btn_refresh_program.Size = new System.Drawing.Size(26, 23);
            this.btn_refresh_program.TabIndex = 12;
            this.btn_refresh_program.Click += new System.EventHandler(this.btn_refresh_program_Click);
            // 
            // cmb_program
            // 
            this.cmb_program.BackColor = System.Drawing.Color.Transparent;
            this.cmb_program.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_program.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_program.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_program.FocusedState.Parent = this.cmb_program;
            this.cmb_program.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_program.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_program.FormattingEnabled = true;
            this.cmb_program.HoverState.Parent = this.cmb_program;
            this.cmb_program.ItemHeight = 30;
            this.cmb_program.ItemsAppearance.Parent = this.cmb_program;
            this.cmb_program.Location = new System.Drawing.Point(133, 57);
            this.cmb_program.Name = "cmb_program";
            this.cmb_program.ShadowDecoration.Parent = this.cmb_program;
            this.cmb_program.Size = new System.Drawing.Size(266, 36);
            this.cmb_program.TabIndex = 10;
            this.cmb_program.SelectedIndexChanged += new System.EventHandler(this.cmb_program_SelectedIndexChanged);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(13, 64);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(114, 16);
            this.bunifuCustomLabel4.TabIndex = 9;
            this.bunifuCustomLabel4.Text = "Select Program :";
            // 
            // cmb_session
            // 
            this.cmb_session.BackColor = System.Drawing.Color.Transparent;
            this.cmb_session.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_session.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_session.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_session.FocusedState.Parent = this.cmb_session;
            this.cmb_session.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_session.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_session.FormattingEnabled = true;
            this.cmb_session.HoverState.Parent = this.cmb_session;
            this.cmb_session.ItemHeight = 30;
            this.cmb_session.ItemsAppearance.Parent = this.cmb_session;
            this.cmb_session.Location = new System.Drawing.Point(133, 15);
            this.cmb_session.Name = "cmb_session";
            this.cmb_session.ShadowDecoration.Parent = this.cmb_session;
            this.cmb_session.Size = new System.Drawing.Size(266, 36);
            this.cmb_session.TabIndex = 8;
            this.cmb_session.SelectedIndexChanged += new System.EventHandler(this.cmb_session_SelectedIndexChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(13, 22);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(106, 16);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Select Session :";
            // 
            // bunifuCards5
            // 
            this.bunifuCards5.BackColor = System.Drawing.Color.White;
            this.bunifuCards5.BorderRadius = 5;
            this.bunifuCards5.BottomSahddow = true;
            this.bunifuCards5.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCards5.Controls.Add(this.btnretrive);
            this.bunifuCards5.Controls.Add(this.rbnotpromoted);
            this.bunifuCards5.Controls.Add(this.rbpromoted);
            this.bunifuCards5.LeftSahddow = false;
            this.bunifuCards5.Location = new System.Drawing.Point(467, 121);
            this.bunifuCards5.Name = "bunifuCards5";
            this.bunifuCards5.RightSahddow = true;
            this.bunifuCards5.ShadowDepth = 20;
            this.bunifuCards5.Size = new System.Drawing.Size(216, 95);
            this.bunifuCards5.TabIndex = 24;
            // 
            // btnretrive
            // 
            this.btnretrive.BorderRadius = 5;
            this.btnretrive.CheckedState.Parent = this.btnretrive;
            this.btnretrive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnretrive.CustomImages.Parent = this.btnretrive;
            this.btnretrive.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnretrive.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretrive.ForeColor = System.Drawing.Color.White;
            this.btnretrive.HoverState.Parent = this.btnretrive;
            this.btnretrive.Location = new System.Drawing.Point(23, 49);
            this.btnretrive.Name = "btnretrive";
            this.btnretrive.ShadowDecoration.Parent = this.btnretrive;
            this.btnretrive.Size = new System.Drawing.Size(166, 34);
            this.btnretrive.TabIndex = 26;
            this.btnretrive.Text = "Retrive";
            this.btnretrive.Click += new System.EventHandler(this.btnretrive_Click);
            // 
            // rbnotpromoted
            // 
            this.rbnotpromoted.AutoSize = true;
            this.rbnotpromoted.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbnotpromoted.CheckedState.BorderThickness = 0;
            this.rbnotpromoted.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbnotpromoted.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbnotpromoted.CheckedState.InnerOffset = -4;
            this.rbnotpromoted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.rbnotpromoted.Location = new System.Drawing.Point(111, 11);
            this.rbnotpromoted.Name = "rbnotpromoted";
            this.rbnotpromoted.Size = new System.Drawing.Size(101, 19);
            this.rbnotpromoted.TabIndex = 2;
            this.rbnotpromoted.TabStop = true;
            this.rbnotpromoted.Text = "Not Promoted";
            this.rbnotpromoted.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbnotpromoted.UncheckedState.BorderThickness = 2;
            this.rbnotpromoted.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbnotpromoted.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbnotpromoted.UseVisualStyleBackColor = true;
            // 
            // rbpromoted
            // 
            this.rbpromoted.AutoSize = true;
            this.rbpromoted.Checked = true;
            this.rbpromoted.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbpromoted.CheckedState.BorderThickness = 0;
            this.rbpromoted.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbpromoted.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbpromoted.CheckedState.InnerOffset = -4;
            this.rbpromoted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.rbpromoted.Location = new System.Drawing.Point(17, 11);
            this.rbpromoted.Name = "rbpromoted";
            this.rbpromoted.Size = new System.Drawing.Size(78, 19);
            this.rbpromoted.TabIndex = 1;
            this.rbpromoted.TabStop = true;
            this.rbpromoted.Text = "Promoted";
            this.rbpromoted.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbpromoted.UncheckedState.BorderThickness = 2;
            this.rbpromoted.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbpromoted.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbpromoted.UseVisualStyleBackColor = true;
            this.rbpromoted.CheckedChanged += new System.EventHandler(this.rbpromoted_CheckedChanged);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(463, 98);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(73, 20);
            this.bunifuCustomLabel5.TabIndex = 27;
            this.bunifuCustomLabel5.Text = "Filter By :";
            // 
            // btn_refresh_sel_semester
            // 
            this.btn_refresh_sel_semester.CheckedState.Parent = this.btn_refresh_sel_semester;
            this.btn_refresh_sel_semester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh_sel_semester.HoverState.Parent = this.btn_refresh_sel_semester;
            this.btn_refresh_sel_semester.Image = global::StdASystem.Properties.Resources.synchronize_50px1;
            this.btn_refresh_sel_semester.Location = new System.Drawing.Point(324, 62);
            this.btn_refresh_sel_semester.Name = "btn_refresh_sel_semester";
            this.btn_refresh_sel_semester.PressedState.Parent = this.btn_refresh_sel_semester;
            this.btn_refresh_sel_semester.Size = new System.Drawing.Size(26, 23);
            this.btn_refresh_sel_semester.TabIndex = 18;
            this.btn_refresh_sel_semester.Click += new System.EventHandler(this.btn_refresh_sel_semester_Click);
            // 
            // cmb_semester
            // 
            this.cmb_semester.BackColor = System.Drawing.Color.Transparent;
            this.cmb_semester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_semester.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_semester.FocusedState.Parent = this.cmb_semester;
            this.cmb_semester.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_semester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_semester.FormattingEnabled = true;
            this.cmb_semester.HoverState.Parent = this.cmb_semester;
            this.cmb_semester.ItemHeight = 30;
            this.cmb_semester.ItemsAppearance.Parent = this.cmb_semester;
            this.cmb_semester.Location = new System.Drawing.Point(132, 56);
            this.cmb_semester.Name = "cmb_semester";
            this.cmb_semester.ShadowDecoration.Parent = this.cmb_semester;
            this.cmb_semester.Size = new System.Drawing.Size(186, 36);
            this.cmb_semester.TabIndex = 17;
            // 
            // btnpromote
            // 
            this.btnpromote.BorderRadius = 5;
            this.btnpromote.CheckedState.Parent = this.btnpromote;
            this.btnpromote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpromote.CustomImages.Parent = this.btnpromote;
            this.btnpromote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnpromote.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpromote.ForeColor = System.Drawing.Color.White;
            this.btnpromote.HoverState.Parent = this.btnpromote;
            this.btnpromote.Location = new System.Drawing.Point(995, 199);
            this.btnpromote.Name = "btnpromote";
            this.btnpromote.ShadowDecoration.Parent = this.btnpromote;
            this.btnpromote.Size = new System.Drawing.Size(106, 34);
            this.btnpromote.TabIndex = 27;
            this.btnpromote.Text = "Promote";
            this.btnpromote.Click += new System.EventHandler(this.btnpromote_Click);
            // 
            // btclear
            // 
            this.btclear.BorderRadius = 5;
            this.btclear.CheckedState.Parent = this.btclear;
            this.btclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btclear.CustomImages.Parent = this.btclear;
            this.btclear.FillColor = System.Drawing.Color.Crimson;
            this.btclear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btclear.ForeColor = System.Drawing.Color.White;
            this.btclear.HoverState.Parent = this.btclear;
            this.btclear.Location = new System.Drawing.Point(897, 199);
            this.btclear.Name = "btclear";
            this.btclear.ShadowDecoration.Parent = this.btclear;
            this.btclear.Size = new System.Drawing.Size(92, 34);
            this.btclear.TabIndex = 28;
            this.btclear.Text = "Clear";
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(3, 62);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(117, 16);
            this.bunifuCustomLabel6.TabIndex = 19;
            this.bunifuCustomLabel6.Text = "Select Semester :";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.btn_refresh_sel_semester);
            this.guna2GroupBox1.Controls.Add(this.bunifuCustomLabel6);
            this.guna2GroupBox1.Controls.Add(this.cmb_semester);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(734, 78);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(367, 108);
            this.guna2GroupBox1.TabIndex = 29;
            this.guna2GroupBox1.Text = "Select Promote Semester";
            // 
            // df_viewstudent
            // 
            this.df_viewstudent.AllowUserToAddRows = false;
            this.df_viewstudent.AllowUserToResizeColumns = false;
            this.df_viewstudent.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.df_viewstudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.df_viewstudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.df_viewstudent.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.df_viewstudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.df_viewstudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.df_viewstudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 3, 3, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.df_viewstudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.df_viewstudent.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.df_viewstudent.DefaultCellStyle = dataGridViewCellStyle3;
            this.df_viewstudent.DoubleBuffered = true;
            this.df_viewstudent.EnableHeadersVisualStyles = false;
            this.df_viewstudent.GridColor = System.Drawing.Color.WhiteSmoke;
            this.df_viewstudent.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.df_viewstudent.HeaderForeColor = System.Drawing.Color.White;
            this.df_viewstudent.Location = new System.Drawing.Point(11, 262);
            this.df_viewstudent.Name = "df_viewstudent";
            this.df_viewstudent.ReadOnly = true;
            this.df_viewstudent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.df_viewstudent.RowHeadersVisible = false;
            this.df_viewstudent.RowHeadersWidth = 45;
            this.df_viewstudent.RowTemplate.DividerHeight = 1;
            this.df_viewstudent.RowTemplate.Height = 30;
            this.df_viewstudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.df_viewstudent.Size = new System.Drawing.Size(672, 224);
            this.df_viewstudent.TabIndex = 30;
            // 
            // chckAll
            // 
            this.chckAll.AutoSize = true;
            this.chckAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chckAll.CheckedState.BorderRadius = 2;
            this.chckAll.CheckedState.BorderThickness = 0;
            this.chckAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chckAll.Location = new System.Drawing.Point(11, 237);
            this.chckAll.Name = "chckAll";
            this.chckAll.Size = new System.Drawing.Size(74, 19);
            this.chckAll.TabIndex = 31;
            this.chckAll.Text = "Select All";
            this.chckAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chckAll.UncheckedState.BorderRadius = 2;
            this.chckAll.UncheckedState.BorderThickness = 0;
            this.chckAll.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chckAll.UseVisualStyleBackColor = true;
            this.chckAll.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GroupBox2.Controls.Add(this.chckAll);
            this.guna2GroupBox2.Controls.Add(this.df_viewstudent);
            this.guna2GroupBox2.Controls.Add(this.bunifuCustomLabel5);
            this.guna2GroupBox2.Controls.Add(this.bunifuCards5);
            this.guna2GroupBox2.Controls.Add(this.bunifuCards1);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(6, 78);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(695, 499);
            this.guna2GroupBox2.TabIndex = 32;
            this.guna2GroupBox2.Text = "Select Students By Semester ";
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // FormSemesterPromote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1115, 590);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btclear);
            this.Controls.Add(this.btnpromote);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "FormSemesterPromote";
            this.Text = "FormSemesterPromote";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSemesterPromote_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards5.ResumeLayout(false);
            this.bunifuCards5.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.df_viewstudent)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_refresh_session;
        private Guna.UI2.WinForms.Guna2ImageButton btn_refresh_program;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_program;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_session;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Guna.UI2.WinForms.Guna2ImageButton btn_refresh_cur_semester;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_current_semester;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards5;
        private Guna.UI2.WinForms.Guna2RadioButton rbnotpromoted;
        private Guna.UI2.WinForms.Guna2RadioButton rbpromoted;
        private Guna.UI2.WinForms.Guna2Button btnretrive;
        private Guna.UI2.WinForms.Guna2ImageButton btn_refresh_sel_semester;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_semester;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Guna.UI2.WinForms.Guna2Button btnpromote;
        private Guna.UI2.WinForms.Guna2Button btclear;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid df_viewstudent;
        private Guna.UI2.WinForms.Guna2CheckBox chckAll;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.ErrorProvider ep;
    }
}