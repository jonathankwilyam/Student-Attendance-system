using StdASystem.AllCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StdASystem.AllReports
{
    public partial class frmCustomReport : Form
    {
        public frmCustomReport()
        {
            InitializeComponent();
            ComboHelper.programe(cmb_program);
            ComboHelper.Semester(cmb_semester);
            ComboHelper.session(cmb_session);
            ComboHelper.subject(cmb_subject);
        }

        public string stendid = null;
        private void frmCustomReport_Load(object sender, EventArgs e)
        {
            ComboHelper.programe(cmb_program);
            ComboHelper.Semester(cmb_semester);
            ComboHelper.session(cmb_session);
            ComboHelper.subject(cmb_subject);
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            ComboHelper.session(cmb_session);
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            ComboHelper.programe(cmb_program);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            ComboHelper.subject(cmb_subject);
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            ComboHelper.Semester(cmb_semester);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txt_searchstudent.Text.Trim().Length == 0)
            {
                ep.SetError(txt_searchstudent, "Please search Value!");
                txt_searchstudent.Focus();
                stendid = null;
                return;
            }
           //frmSearch frm = new frmSearch(this, txt_searchstudent.Text.Trim());
            //frm.ShowDialog();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
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
            stendid = txt_searchstudent.Text.Trim();
            if (string.IsNullOrWhiteSpace(stendid))
            {
                stendid = null;
            }

            if (string.IsNullOrEmpty(stendid))
            {
                stendid = null;
            }
            string subjectid = string.Empty;
            if (cmb_subject.SelectedIndex > 0)
            {
                subjectid = Convert.ToString(cmb_subject.SelectedValue);
            }
            else
            {
                subjectid = null;
            }
            if (!string.IsNullOrEmpty(stendid) && !string.IsNullOrWhiteSpace(stendid))
            {
                rpt_GetCustomAttendanceReport rpt = new rpt_GetCustomAttendanceReport();
                rpt.SetParameterValue("@StartDate", dpstartdate.Value.ToString("yyyy/MM/dd"));
                rpt.SetParameterValue("@EndDate", dptodate.Value.ToString("yyyy/MM/dd"));
                rpt.SetParameterValue("@SessionID", cmb_session.SelectedValue);
                rpt.SetParameterValue("@ProgrameID", cmb_program.SelectedValue);
                rpt.SetParameterValue("@SemesterID", cmb_semester.SelectedValue);
                rpt.SetParameterValue("@RegID", stendid);
                rpt.SetParameterValue("@SubjectID", subjectid);
                //rpt.SetParameterValue("psemestername", cmb_semester.SelectedText);
                //rpt.SetParameterValue("pprograme", cmb_program.SelectedText);
                //rpt.SetParameterValue("psession", cmb_session.SelectedText);
                crv.ReportSource = rpt;
            }
            else
            {
                
            }


        }
    }
}
