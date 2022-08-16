namespace StdASystem.AllReports
{
    partial class frmCustomReport
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmb_semester = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmb_session = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmb_program = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmb_subject = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dpstartdate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dptodate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txt_searchstudent = new Bunifu.Framework.BunifuCustomTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnsearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.guna2GroupBox1.BorderRadius = 5;
            this.guna2GroupBox1.Controls.Add(this.btnsearch);
            this.guna2GroupBox1.Controls.Add(this.bunifuCustomLabel6);
            this.guna2GroupBox1.Controls.Add(this.txt_searchstudent);
            this.guna2GroupBox1.Controls.Add(this.dptodate);
            this.guna2GroupBox1.Controls.Add(this.dpstartdate);
            this.guna2GroupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.guna2GroupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.guna2GroupBox1.Controls.Add(this.bunifuFlatButton8);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton2);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton3);
            this.guna2GroupBox1.Controls.Add(this.cmb_semester);
            this.guna2GroupBox1.Controls.Add(this.bunifuCustomLabel8);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton4);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton1);
            this.guna2GroupBox1.Controls.Add(this.cmb_session);
            this.guna2GroupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.guna2GroupBox1.Controls.Add(this.cmb_program);
            this.guna2GroupBox1.Controls.Add(this.bunifuCustomLabel4);
            this.guna2GroupBox1.Controls.Add(this.cmb_subject);
            this.guna2GroupBox1.Controls.Add(this.bunifuCustomLabel5);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 4);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(1056, 221);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Report Parameter";
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
            this.cmb_semester.Location = new System.Drawing.Point(492, 176);
            this.cmb_semester.Name = "cmb_semester";
            this.cmb_semester.ShadowDecoration.Parent = this.cmb_semester;
            this.cmb_semester.Size = new System.Drawing.Size(295, 36);
            this.cmb_semester.TabIndex = 39;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(371, 183);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(117, 16);
            this.bunifuCustomLabel8.TabIndex = 38;
            this.bunifuCustomLabel8.Text = "Select Semester :";
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
            this.cmb_session.Location = new System.Drawing.Point(492, 43);
            this.cmb_session.Name = "cmb_session";
            this.cmb_session.ShadowDecoration.Parent = this.cmb_session;
            this.cmb_session.Size = new System.Drawing.Size(208, 36);
            this.cmb_session.TabIndex = 33;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(372, 50);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(106, 16);
            this.bunifuCustomLabel3.TabIndex = 32;
            this.bunifuCustomLabel3.Text = "Select Session :";
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
            this.cmb_program.Location = new System.Drawing.Point(492, 89);
            this.cmb_program.Name = "cmb_program";
            this.cmb_program.ShadowDecoration.Parent = this.cmb_program;
            this.cmb_program.Size = new System.Drawing.Size(208, 36);
            this.cmb_program.TabIndex = 35;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(371, 96);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(114, 16);
            this.bunifuCustomLabel4.TabIndex = 34;
            this.bunifuCustomLabel4.Text = "Select Program :";
            // 
            // cmb_subject
            // 
            this.cmb_subject.BackColor = System.Drawing.Color.Transparent;
            this.cmb_subject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_subject.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_subject.FocusedState.Parent = this.cmb_subject;
            this.cmb_subject.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_subject.FormattingEnabled = true;
            this.cmb_subject.HoverState.Parent = this.cmb_subject;
            this.cmb_subject.ItemHeight = 30;
            this.cmb_subject.ItemsAppearance.Parent = this.cmb_subject;
            this.cmb_subject.Location = new System.Drawing.Point(492, 132);
            this.cmb_subject.Name = "cmb_subject";
            this.cmb_subject.ShadowDecoration.Parent = this.cmb_subject;
            this.cmb_subject.Size = new System.Drawing.Size(295, 36);
            this.cmb_subject.TabIndex = 37;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(371, 141);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(107, 16);
            this.bunifuCustomLabel5.TabIndex = 36;
            this.bunifuCustomLabel5.Text = "Select Subject :";
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Active = false;
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 7;
            this.bunifuFlatButton8.ButtonText = "   Generate Report";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = global::StdASystem.Properties.Resources.accounting_50px;
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 60D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(863, 147);
            this.bunifuFlatButton8.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(189, 64);
            this.bunifuFlatButton8.TabIndex = 44;
            this.bunifuFlatButton8.Tag = "";
            this.bunifuFlatButton8.Text = "   Generate Report";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton8.Click += new System.EventHandler(this.bunifuFlatButton8_Click);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = global::StdASystem.Properties.Resources.synchronize_50px1;
            this.guna2ImageButton2.Location = new System.Drawing.Point(787, 183);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Size = new System.Drawing.Size(26, 23);
            this.guna2ImageButton2.TabIndex = 40;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.CheckedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton3.HoverState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Image = global::StdASystem.Properties.Resources.synchronize_50px1;
            this.guna2ImageButton3.Location = new System.Drawing.Point(706, 96);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Size = new System.Drawing.Size(27, 23);
            this.guna2ImageButton3.TabIndex = 42;
            this.guna2ImageButton3.Click += new System.EventHandler(this.guna2ImageButton3_Click);
            // 
            // guna2ImageButton4
            // 
            this.guna2ImageButton4.CheckedState.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton4.HoverState.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.Image = global::StdASystem.Properties.Resources.synchronize_50px1;
            this.guna2ImageButton4.Location = new System.Drawing.Point(706, 50);
            this.guna2ImageButton4.Name = "guna2ImageButton4";
            this.guna2ImageButton4.PressedState.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.Size = new System.Drawing.Size(26, 23);
            this.guna2ImageButton4.TabIndex = 43;
            this.guna2ImageButton4.Click += new System.EventHandler(this.guna2ImageButton4_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::StdASystem.Properties.Resources.synchronize_50px1;
            this.guna2ImageButton1.Location = new System.Drawing.Point(787, 139);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(26, 23);
            this.guna2ImageButton1.TabIndex = 41;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(16, 57);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(81, 16);
            this.bunifuCustomLabel1.TabIndex = 47;
            this.bunifuCustomLabel1.Text = "From Date :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(16, 101);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(64, 16);
            this.bunifuCustomLabel2.TabIndex = 48;
            this.bunifuCustomLabel2.Text = "To Date :";
            // 
            // dpstartdate
            // 
            this.dpstartdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.dpstartdate.BorderRadius = 0;
            this.dpstartdate.ForeColor = System.Drawing.Color.White;
            this.dpstartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpstartdate.FormatCustom = null;
            this.dpstartdate.Location = new System.Drawing.Point(103, 48);
            this.dpstartdate.Name = "dpstartdate";
            this.dpstartdate.Size = new System.Drawing.Size(245, 36);
            this.dpstartdate.TabIndex = 49;
            this.dpstartdate.Value = new System.DateTime(2022, 2, 25, 10, 7, 51, 634);
            // 
            // dptodate
            // 
            this.dptodate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.dptodate.BorderRadius = 0;
            this.dptodate.ForeColor = System.Drawing.Color.White;
            this.dptodate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptodate.FormatCustom = null;
            this.dptodate.Location = new System.Drawing.Point(103, 94);
            this.dptodate.Name = "dptodate";
            this.dptodate.Size = new System.Drawing.Size(245, 36);
            this.dptodate.TabIndex = 50;
            this.dptodate.Value = new System.DateTime(2022, 2, 25, 10, 7, 51, 634);
            // 
            // txt_searchstudent
            // 
            this.txt_searchstudent.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_searchstudent.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchstudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txt_searchstudent.Location = new System.Drawing.Point(787, 71);
            this.txt_searchstudent.Multiline = true;
            this.txt_searchstudent.Name = "txt_searchstudent";
            this.txt_searchstudent.Size = new System.Drawing.Size(236, 27);
            this.txt_searchstudent.TabIndex = 51;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(784, 48);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(109, 16);
            this.bunifuCustomLabel6.TabIndex = 52;
            this.bunifuCustomLabel6.Text = "Enter Student ID";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Aqua;
            this.btnsearch.CheckedState.Parent = this.btnsearch;
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.HoverState.Parent = this.btnsearch;
            this.btnsearch.Image = global::StdASystem.Properties.Resources.synchronize_50px1;
            this.btnsearch.Location = new System.Drawing.Point(1023, 71);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.PressedState.Parent = this.btnsearch;
            this.btnsearch.Size = new System.Drawing.Size(26, 27);
            this.btnsearch.TabIndex = 53;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.crv);
            this.groupBox1.Location = new System.Drawing.Point(12, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 323);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // crv
            // 
            this.crv.ActiveViewIndex = -1;
            this.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv.Location = new System.Drawing.Point(3, 16);
            this.crv.Name = "crv";
            this.crv.ShowCloseButton = false;
            this.crv.ShowGroupTreeButton = false;
            this.crv.ShowLogo = false;
            this.crv.ShowParameterPanelButton = false;
            this.crv.Size = new System.Drawing.Size(1050, 304);
            this.crv.TabIndex = 1;
            this.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCustomReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "frmCustomReport";
            this.Text = "frmCustomReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomReport_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_semester;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_session;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_program;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_subject;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDatepicker dptodate;
        private Bunifu.Framework.UI.BunifuDatepicker dpstartdate;
        private Guna.UI2.WinForms.Guna2ImageButton btnsearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.BunifuCustomTextbox txt_searchstudent;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.GroupBox groupBox1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
    }
}