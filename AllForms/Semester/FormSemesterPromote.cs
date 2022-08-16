using StdASystem.AllCode;
using StdASystem.DatabaseCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StdASystem.AllForms.Semester
{
    public partial class FormSemesterPromote : Form
    {
        public FormSemesterPromote()
        {
            InitializeComponent();
            ComboHelper.session(cmb_session);
            ComboHelper.programe(cmb_program);
            ComboHelper.Semester(cmb_semester);
        }

        private void GetPromotedNotPromotedStudents()
        {
            if (cmb_session.SelectedIndex < 1 && cmb_program.SelectedIndex < 1)
            {
                return;
            }

            string query = string.Empty;
            if (rbpromoted.Checked == true)
            {
                query = string.Format("select * from V_GetPromotedOrNotPromotedStudent where Semester_ID IS NOT NULL AND Session_ID = '{0}' AND Programe_ID = '{1}' AND Semester_ID = '{2}' AND IsActive = 1", Convert.ToString(cmb_session.SelectedValue), Convert.ToString(cmb_program.SelectedValue), Convert.ToString(cmb_current_semester.SelectedValue));
            }
            else if (rbnotpromoted.Checked == true)
            {
                query = string.Format("select * from V_GetPromotedOrNotPromotedStudent where Semester_ID IS NULL AND Session_ID = '{0}' AND Programe_ID = '{1}'", Convert.ToString(cmb_session.SelectedValue), Convert.ToString(cmb_program.SelectedValue));
            }
            DataTable dt = DatabaseAccess.SelectData(query);
            dt = DatabaseAccess.SelectData(query);
            if (dt.Rows.Count > 0)
            {
                df_viewstudent.DataSource = dt;
                df_viewstudent.Columns[0].Visible = false;
                df_viewstudent.Columns[1].Visible = false;
                df_viewstudent.Columns[3].Visible = false;
                df_viewstudent.Columns[2].Width = 80;
                df_viewstudent.Columns[5].Visible = false;
                df_viewstudent.Columns[4].Visible = false;
                df_viewstudent.Columns[6].Width = 200;
                df_viewstudent.Columns[7].Width = 120;
                df_viewstudent.Columns[8].Visible = false;
                df_viewstudent.Columns[9].Visible = false;
                df_viewstudent.Columns[10].Visible = false;
                df_viewstudent.Columns[11].Visible = false;
                df_viewstudent.Columns[12].Visible = false;
                df_viewstudent.Columns[13].Width = 80;

                if (rbnotpromoted.Checked == true)
                {
                    df_viewstudent.Columns[5].Visible = false;
                    df_viewstudent.Columns[8].Visible = false;
                }
                if (rbpromoted.Checked == true)
                {
                    df_viewstudent.Columns[5].Visible = true;
                    df_viewstudent.Columns[8].Visible = true;
                }
            }
            else
            {
                df_viewstudent.DataSource = null;
            }

        }


        private void FormSemesterPromote_Load(object sender, EventArgs e)
        {
            ComboHelper.session(cmb_session);
            ComboHelper.programe(cmb_program);
        }

        private void btn_refresh_session_Click(object sender, EventArgs e)
        {
            ComboHelper.session(cmb_session);
        }

        private void btn_refresh_program_Click(object sender, EventArgs e)
        {
            ComboHelper.programe(cmb_program);
        }

        private void btn_refresh_cur_semester_Click(object sender, EventArgs e)
        {
            ComboHelper.GetSemesterByProgrameAndSession(cmb_current_semester, Convert.ToString(cmb_program.SelectedValue), Convert.ToString(cmb_session.SelectedValue));
            ComboHelper.GetSemesterByProgrameAndSession(cmb_semester, Convert.ToString(cmb_program.SelectedValue), Convert.ToString(cmb_session.SelectedValue));

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (df_viewstudent != null)
            {
                if (df_viewstudent.Rows.Count > 0)
                {
                    if (chckAll.Checked == true)
                    {
                        df_viewstudent.SelectAll();
                    }
                    else
                    {
                        df_viewstudent.ClearSelection();
                    }
                }
            }
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            cmb_semester.SelectedIndex = 0;
        }

        
        private void btnretrive_Click(object sender, EventArgs e)
        {
            GetPromotedNotPromotedStudents();
        }

        private void btn_refresh_sel_semester_Click(object sender, EventArgs e)
        {
            ComboHelper.Semester(cmb_semester);
        }

        private void btnpromote_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (cmb_session.SelectedIndex == 0)
            {
                ep.SetError(cmb_session, "Please Select Session!");
                cmb_session.Focus();
                return;
            }
            if (cmb_program.SelectedIndex == 0)
            {
                ep.SetError(cmb_program, "Please Select Program");
                cmb_program.Focus();
                return;
            }
            if (cmb_semester.SelectedIndex == 0)
            {
                ep.SetError(cmb_semester, "Select Promote Semester");
                cmb_semester.Focus();
                return;
            }

            if (rbpromoted.Checked == true)
            {
                if (cmb_current_semester.SelectedIndex == 0)
                {
                    ep.SetError(cmb_current_semester, "Please Select a current Semester");
                    cmb_current_semester.Focus();
                    return;
                }
                if (cmb_current_semester.SelectedIndex >= cmb_semester.SelectedIndex)
                {
                    ep.SetError(cmb_semester,"Promote Semester must be greater than Current semester");
                    cmb_semester.Focus();
                    return;
                }
            }
            if (rbnotpromoted.Checked == true)
            {
                if (cmb_semester.SelectedIndex == 0)
                {
                    ep.SetError(cmb_semester,"please select promote semester!");
                    cmb_semester.Focus();
                }

                cmb_current_semester.SelectedIndex = 0;
            }

            if (df_viewstudent != null)
            {
                if (df_viewstudent.Rows.Count >0)
                {
                    if (df_viewstudent.SelectedRows.Count > 0)
                    {
                        if (MessageBox.Show("Are tou sure you wanr to promote selected students!","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            foreach (DataGridViewRow record in df_viewstudent.SelectedRows)
                            {
                                string updatecurrentsemester = string.Format("update StudentSemesterRecordTable set IsActive = 0 where Std_ID ='{0}';", record.Cells[0].Value);
                                DatabaseAccess.InsertData(updatecurrentsemester);
                                string semesterinsert = string.Format("insert into StudentSemesterRecordTable(Semester_ID,Std_ID,IsActive) values ('{0}','{1}','1')", cmb_semester.SelectedValue, record.Cells[0].Value);
                                DatabaseAccess.InsertData(semesterinsert);
                            }
                            MessageBox.Show("Selected Students are promoted to " + cmb_semester.Text + "");
                            GetPromotedNotPromotedStudents();
                        }
                    }
                    else
                    {
                        if (rbnotpromoted.Checked == true)
                        {
                            MessageBox.Show("please select not promoted students record");
                        }
                        else
                        {
                            MessageBox.Show("please select promoted students record");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("List Empty");
                }
            }
            else
            {
                MessageBox.Show("no record found");
            }
        }

        private void cmb_session_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboHelper.GetSemesterByProgrameAndSession(cmb_current_semester, Convert.ToString(cmb_program.SelectedValue), Convert.ToString(cmb_session.SelectedValue));
            ComboHelper.GetSemesterByProgrameAndSession(cmb_semester, Convert.ToString(cmb_program.SelectedValue), Convert.ToString(cmb_session.SelectedValue));

        }

        private void cmb_program_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboHelper.GetSemesterByProgrameAndSession(cmb_current_semester, Convert.ToString(cmb_program.SelectedValue), Convert.ToString(cmb_session.SelectedValue));
            ComboHelper.GetSemesterByProgrameAndSession(cmb_semester, Convert.ToString(cmb_program.SelectedValue), Convert.ToString(cmb_session.SelectedValue));

        }

        private void rbpromoted_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
