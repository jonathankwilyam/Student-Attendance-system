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
    public partial class frmDailyReport : Form
    {
        public frmDailyReport()
        {
            InitializeComponent();
            ComboHelper.programe(cmb_program);
            ComboHelper.Semester(cmb_semester);
            ComboHelper.session(cmb_session);
            ComboHelper.subject(cmb_subject);
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

            DailyReport rpt = new DailyReport();
            rpt.SetParameterValue("@StartDate", DateTime.Now.ToString("yyyy/MM/dd"));
            rpt.SetParameterValue("@EndDate", DateTime.Now.ToString("yyyy/MM/dd"));
            rpt.SetParameterValue("@SessionID", cmb_session.SelectedValue);
            rpt.SetParameterValue("@ProgrameID", cmb_program.SelectedValue);
            rpt.SetParameterValue("@SemesterID", cmb_semester.SelectedValue);
            rpt.SetParameterValue("@stdid", null);
            rpt.SetParameterValue("@SubjectID", cmb_subject.SelectedValue);
            //rpt.SetParameterValue("psemestername", cmb_semester.SelectedText);
            //rpt.SetParameterValue("pprograme", cmb_program.SelectedText);
            //rpt.SetParameterValue("psession", cmb_session.SelectedText);
            crv.ReportSource = rpt;

        }

        private void frmDailyReport_Load(object sender, EventArgs e)
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
    }
}
