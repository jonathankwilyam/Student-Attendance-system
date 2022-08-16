using StdASystem.AllCode;
using StdASystem.DatabaseCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StdASystem.AllForms.TimeTable
{
    public partial class frmTimeTable : Form
    {
        public frmTimeTable()
        {
            InitializeComponent();
            ComboHelper.programe(cmb_program);
            ComboHelper.Semester(cmb_semester);
            ComboHelper.session(cmb_session);
            ComboHelper.subject(cmb_subject);
            cmb_day.SelectedIndex = 0;
        }

        private void frmTimeTable_Load(object sender, EventArgs e)
        {
            lbl_isactive.Visible = false;
            chbox_isactive.Visible = false;
            ComboHelper.programe(cmb_program);
            ComboHelper.Semester(cmb_semester);
            ComboHelper.session(cmb_session);
            ComboHelper.subject(cmb_subject);
            FillGrid("");
        }

        private void frmTimeTable_Activated(object sender, EventArgs e)
        {
            ComboHelper.programe(cmb_program);
            ComboHelper.Semester(cmb_semester);
            ComboHelper.session(cmb_session);
            ComboHelper.subject(cmb_subject);
            FillGrid("");
        }

        private void FillGrid(string searchvalue)
        {
            DataTable dt = new DataTable();
            string query = string.Empty;
            if (searchvalue.Trim().Length == 0 )
            {
                query = string.Format("select SubjectTimeTableID as [ID],Session_ID,SessionName as [Session],Programe_ID,ProgrameName as [Program],Semester_ID,SemesterName as [Semester],Subject_ID,SubjectName as [Subject],FromTime,ToTime,[Day],[Year],RegDate,[Description],IsActive from V_TimeTableList ");
            }
            else
            {
                query = string.Format("select SubjectTimeTableID as [ID],Session_ID,SessionName as [Session],Programe_ID,ProgrameName as [Program],Semester_ID,SemesterName as [Semester],Subject_ID,SubjectName as [Subject],FromTime,ToTime,[Day],[Year],RegDate,[Description],IsActive from V_TimeTableList where (SubjectName +' '+ SemesterName +''+ ProgrameName) like '%" + searchvalue + "%' ");
            }

            dt = DatabaseAccess.SelectData(query);
            if (dt.Rows.Count > 0)
            {
                df_timetable.DataSource = dt;
                df_timetable.Columns[1].Visible = false;
                df_timetable.Columns[3].Visible = false;
                df_timetable.Columns[5].Visible = false;
                df_timetable.Columns[7].Visible = false;
                df_timetable.Columns[0].Width = 100;
                df_timetable.Columns[2].Width = 100;
                df_timetable.Columns[4].Width = 100;
                df_timetable.Columns[6].Width = 180;
                df_timetable.Columns[8].Width = 250;
                df_timetable.Columns[9].Width = 100;
                df_timetable.Columns[10].Width = 100;
                df_timetable.Columns[11].Width = 100;
                df_timetable.Columns[12].Width = 100;
                df_timetable.Columns[13].Width = 100;
                df_timetable.Columns[14].Width = 100;
                df_timetable.Columns[15].Width = 100;
            }
            else
            {
                df_timetable.DataSource = null;
            }

        }

        private void Resetform()
        {
            FormClear();
            dtp_fromtime.Value = DateTime.Now;
            dtp_totime.Value = DateTime.Now;
            dtp_year.Value = DateTime.Now;
            cmb_day.SelectedIndex = 0;
            lbl_isactive.Visible = false;
            chbox_isactive.Visible = false;

        }
        private void FormClear()
        {
            ep.Clear();
            txt_description.Clear();
            cmb_program.SelectedIndex = 0;
            cmb_semester.SelectedIndex = 0;
            cmb_session.SelectedIndex = 0;

        }

        private void DesibleContents()
        {
            btn_clear.Enabled = false;
            btn_save.Enabled = false;
            txt_search.Enabled = false;
            df_timetable.Enabled = false;
            lbl_isactive.Visible = true;
            chbox_isactive.Visible = true;
            btn_update.Enabled = true;
            btn_cancel.Enabled = true;
        }

        private void EnableContents()
        {
            btn_clear.Enabled = true;
            btn_save.Enabled = true;
            txt_search.Enabled = true;
            df_timetable.Enabled = true;
            lbl_isactive.Visible = false;
            chbox_isactive.Visible = false;
            btn_update.Enabled = false;
            btn_cancel.Enabled = false;
            Resetform();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (cmb_program.SelectedIndex == 0)
            {
                ep.SetError(cmb_program, "Please Select a Program");
                cmb_program.Focus();
                return;
            }

            if (cmb_semester.SelectedIndex == 0)
            {
                ep.SetError(cmb_semester, "Please Select a Semester");
                cmb_semester.Focus();
                return;
            }

            if (cmb_session.SelectedIndex == 0)
            {
                ep.SetError(cmb_session, "Please Select a Session");
                cmb_session.Focus();
                return;
            }

            if (cmb_subject.SelectedIndex == 0)
            {
                ep.SetError(cmb_subject, "Please Select a Subject");
                cmb_subject.Focus();
                return;
            }

            if (cmb_day.SelectedIndex == 0)
            {
                ep.SetError(cmb_day, "Please Select a Day");
                cmb_day.Focus();
                return;
            }

            if (cmb_day.SelectedIndex == 0)
            {
                ep.SetError(cmb_day, "Please Select a Day");
                cmb_day.Focus();
                return;
            }

            var fromMints = dtp_fromtime.Value.Minute;
            var toMints = dtp_totime.Value.Minute;
            var deffMinuts = toMints - fromMints;

            var fromHours = dtp_fromtime.Value.Hour;
            var toHours = dtp_totime.Value.Hour;
            var deffHours = toHours - fromHours;

            if (deffHours == 0 && deffMinuts <30)
            {
                ep.SetError(dtp_fromtime, "please Set Class Start Time and To Time Note: Class Min Time is 30 Minutes and Max time is 3hrs  ");
                dtp_fromtime.Focus();
                return;
            }

            if (deffHours > 3 && deffMinuts > 0)
            {
                ep.SetError(dtp_fromtime, "please Set Class Start Time and To Time Note: Class Min Time is 30 Minutes and Max time is 3hrs  ");
                dtp_fromtime.Focus();
                return;
            }

            if (deffMinuts > 0)
            {
                if (deffHours >= 3 || deffHours < 0)
                {
                    ep.SetError(dtp_fromtime, "please Set Class Start Time and To Time Note: Class Min Time is 30 Minutes and Max time is 3hrs  ");
                    dtp_fromtime.Focus();
                    return;
                }
                if (deffHours > 3 || deffHours < 0)
                {
                    ep.SetError(dtp_fromtime, "please Set Class Start Time and To Time Note: Class Min Time is 30 Minutes and Max time is 3hrs  ");
                    dtp_fromtime.Focus();
                    return;
                }
            }

            var selectyear = dtp_year.Value.Year;
            var currentyear = DateTime.Now.Year;
            if (selectyear < currentyear)
            {
                ep.SetError(dtp_year, "can't be set time table for previous Year. Otherwise contact to high authority");
                dtp_year.Focus();
                return;
            }

            DataTable dt = new DataTable();
            dt = DatabaseCode.DatabaseAccess.SelectData(string.Format("select * from SubjectTimeTable where Programe_ID = '{0}' and Semester_ID = '{1}' and Subject_ID = '{2}' and Session_ID = '{3}' and IsActive ='1'", cmb_program.SelectedValue, cmb_semester.SelectedValue, cmb_subject.SelectedValue, cmb_session.SelectedValue));

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(cmb_semester, "Subject is Already Add in This Semester, Please Contact the Administrator");
                    cmb_semester.Focus();
                    return;
                }
            }

            string insertquery = string.Format("insert into SubjectTimeTable(Programe_ID,Semester_ID,Subject_ID,Session_ID,FromTime,ToTime,[Day],[Year],RegDate,[Description],IsActive) " +
                                               " values('{0}','{1}','{2}','{3}',convert(varchar(5),'{4}',108),convert(varchar(5),'{5}',108),'{6}','{7}','{8}','{9}','{10}')", 
                                                cmb_program.SelectedValue, cmb_semester.SelectedValue, cmb_subject.SelectedValue, cmb_session.SelectedValue, dtp_fromtime.Value.TimeOfDay,
                                                dtp_totime.Value.TimeOfDay, cmb_day.Text, dtp_year.Value.Year, DateTime.Now.ToString("yyyy/MM/dd"), txt_description.Text.Trim(), 1);
            
            bool result = DatabaseCode.DatabaseAccess.InsertData(insertquery)  ;
            if (result == true)
            {
                MessageBox.Show("Successfully Saved");
                FormClear();
                FillGrid("");
            }
            else
            {
                MessageBox.Show("Unexpected Error occured, Please Contact the IT team");
            }

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txt_search.Text.Trim());
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (df_timetable != null)
            {
                if (df_timetable.Rows.Count > 0)
                {
                    if (df_timetable.SelectedRows.Count == 1)
                    {
                        cmb_session.SelectedValue = Convert.ToInt32(df_timetable.CurrentRow.Cells[1].Value);
                        cmb_program.SelectedValue = Convert.ToInt32(df_timetable.CurrentRow.Cells[3].Value);
                        cmb_semester.SelectedValue = Convert.ToInt32(df_timetable.CurrentRow.Cells[5].Value);
                        cmb_subject.SelectedValue = Convert.ToInt32(df_timetable.CurrentRow.Cells[7].Value);
                        dtp_fromtime.Value = DateTime.ParseExact(Convert.ToString(df_timetable.CurrentRow.Cells[9].Value), "HH:mm:ss",CultureInfo.InvariantCulture);
                        dtp_totime.Value = DateTime.ParseExact(Convert.ToString(df_timetable.CurrentRow.Cells[10].Value), "HH:mm:ss", CultureInfo.InvariantCulture);
                        cmb_day.Text = Convert.ToString(df_timetable.CurrentRow.Cells[11].Value);
                        dtp_year.Value = DateTime.ParseExact(Convert.ToString(df_timetable.CurrentRow.Cells[12].Value), "yyyy", CultureInfo.InvariantCulture);
                        chbox_isactive.Checked = Convert.ToBoolean(df_timetable.CurrentRow.Cells[15].Value);
                        txt_description.Text = Convert.ToString(df_timetable.CurrentRow.Cells[14].Value);
                        DesibleContents();
                    }
                    else
                    {
                        MessageBox.Show("Select One Record!");
                        
                    }
                }
                else
                {
                    MessageBox.Show("List is Empty!");
                }
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (cmb_program.SelectedIndex == 0)
            {
                ep.SetError(cmb_program, "Please Select a Program");
                cmb_program.Focus();
                return;
            }

            if (cmb_semester.SelectedIndex == 0)
            {
                ep.SetError(cmb_semester, "Please Select a Semester");
                cmb_semester.Focus();
                return;
            }

            if (cmb_session.SelectedIndex == 0)
            {
                ep.SetError(cmb_session, "Please Select a Session");
                cmb_session.Focus();
                return;
            }

            if (cmb_subject.SelectedIndex == 0)
            {
                ep.SetError(cmb_subject, "Please Select a Subject");
                cmb_subject.Focus();
                return;
            }

            if (cmb_day.SelectedIndex == 0)
            {
                ep.SetError(cmb_day, "Please Select a Day");
                cmb_day.Focus();
                return;
            }

            if (cmb_day.SelectedIndex == 0)
            {
                ep.SetError(cmb_day, "Please Select a Day");
                cmb_day.Focus();
                return;
            }

            var fromMints = dtp_fromtime.Value.Minute;
            var toMints = dtp_totime.Value.Minute;
            var deffMinuts = toMints - fromMints;

            var fromHours = dtp_fromtime.Value.Hour;
            var toHours = dtp_totime.Value.Hour;
            var deffHours = toHours - fromHours;

            if (deffHours == 0 && deffMinuts < 30)
            {
                ep.SetError(dtp_fromtime, "please Set Class Start Time and To Time Note: Class Min Time is 30 Minutes and Max time is 3hrs  ");
                dtp_fromtime.Focus();
                return;
            }

            if (deffHours > 3 && deffMinuts > 0)
            {
                ep.SetError(dtp_fromtime, "please Set Class Start Time and To Time Note: Class Min Time is 30 Minutes and Max time is 3hrs  ");
                dtp_fromtime.Focus();
                return;
            }

            if (deffMinuts > 0)
            {
                if (deffHours >= 3 || deffHours < 0)
                {
                    ep.SetError(dtp_fromtime, "please Set Class Start Time and To Time Note: Class Min Time is 30 Minutes and Max time is 3hrs  ");
                    dtp_fromtime.Focus();
                    return;
                }
                if (deffHours > 3 || deffHours < 0)
                {
                    ep.SetError(dtp_fromtime, "please Set Class Start Time and To Time Note: Class Min Time is 30 Minutes and Max time is 3hrs  ");
                    dtp_fromtime.Focus();
                    return;
                }
            }

            var selectyear = dtp_year.Value.Year;
            var currentyear = DateTime.Now.Year;
            if (selectyear < currentyear)
            {
                ep.SetError(dtp_year, "can't be set time table for previous Year. Otherwise contact to high authority");
                dtp_year.Focus();
                return;
            }


            string updatequery = string.Format("update SubjectTimeTable set ProgrameID = '{0}',SemesterID = '{1}',SubjectID = {2},SessionID = '{3}',FromTime = convert(varchar(5),'{4}',108) ,ToTime = convert(varchar(5),'{5}',108) ,[Day] = '{6}' ,[Year] = '{7}',[Description] = '{8}',IsActive = '{9}') " +
                                               " where SubjectTimeTableID = '{10}",
                                                cmb_program.SelectedValue, cmb_semester.SelectedValue, cmb_subject.SelectedValue, cmb_session.SelectedValue, dtp_fromtime.Value.TimeOfDay,
                                                dtp_totime.Value.TimeOfDay, cmb_day.Text, dtp_year.Value.Year, txt_description.Text.Trim(), chbox_isactive, Convert.ToString(df_timetable.CurrentRow.Cells[0].Value).Trim());

            bool result = DatabaseCode.DatabaseAccess.InsertData(updatequery);
            if (result == true)
            {
                MessageBox.Show("Successfully Saved");
                EnableContents();
                FillGrid("");
            }
            else
            {
                MessageBox.Show("Unexpected Error occured, Please Contact the IT team");
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            EnableContents();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            ComboHelper.programe(cmb_program);
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            ComboHelper.Semester(cmb_semester);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            ComboHelper.session(cmb_session);
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            ComboHelper.subject(cmb_subject);
        }

        private void cmb_subject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_session_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_program_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
