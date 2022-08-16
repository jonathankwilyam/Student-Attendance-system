using StdASystem.AllForms.GeneralForms;
using StdASystem.AllForms.Semester;
using StdASystem.AllForms.Students;
using StdASystem.AllForms.TimeTable;
using StdASystem.AllReports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StdASystem.AllForms
{
    public partial class frmAttendanceSystem : Form
    {
        frmSession SessionForm;
        frmProgram ProgramForm;
        frmSemester SemesterForm;
        frmSubject SubjectForm;
        frmTimeTable TimetableForm;
        formStudents StudentsForm;
        frmAttendance AttendanceForm;
        FormSemesterPromote SemesterPromoteForm;
        frmMonthlyReport MonthlyReportForm;
        frmDailyReport DailyReportForm;
        frmCustomReport CustomReportForm;
        Dashboardmain DashboardForm;

        public frmAttendanceSystem()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (SessionForm == null)
            {
                SessionForm = new frmSession();
            }
            SessionForm.TopLevel = false;
            panelparent.Controls.Add(SessionForm);
            SessionForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            SessionForm.Show();
            SessionForm.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (ProgramForm == null)
            {
                ProgramForm = new frmProgram();
            }
            ProgramForm.TopLevel = false;
            panelparent.Controls.Add(ProgramForm);
            ProgramForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ProgramForm.Show();
            ProgramForm.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (SemesterForm == null)
            {
                SemesterForm = new frmSemester();
            }
            SemesterForm.TopLevel = false;
            panelparent.Controls.Add(SemesterForm);
            SemesterForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            SemesterForm.Show();
            SemesterForm.BringToFront();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (SubjectForm == null)
            {
                SubjectForm = new frmSubject();
            }
            SubjectForm.TopLevel = false;
            panelparent.Controls.Add(SubjectForm);
            SubjectForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            SubjectForm.Show();
            SubjectForm.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (TimetableForm == null)
            {
                TimetableForm = new frmTimeTable();
            }
            TimetableForm.TopLevel = false;
            panelparent.Controls.Add(TimetableForm);
            TimetableForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            TimetableForm.Show();
            TimetableForm.BringToFront();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (StudentsForm == null)
            {
                StudentsForm = new formStudents();
            }
            StudentsForm.TopLevel = false;
            panelparent.Controls.Add(StudentsForm);
            StudentsForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            StudentsForm.Show();
            StudentsForm.BringToFront();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if (AttendanceForm == null)
            {
                AttendanceForm = new frmAttendance();
            }
            AttendanceForm.TopLevel = false;
            panelparent.Controls.Add(AttendanceForm);
            AttendanceForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            AttendanceForm.Show();
            AttendanceForm.BringToFront();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            if (SemesterPromoteForm == null)
            {
                SemesterPromoteForm = new FormSemesterPromote();
            }
            SemesterPromoteForm.TopLevel = false;
            panelparent.Controls.Add(SemesterPromoteForm);
            SemesterPromoteForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            SemesterPromoteForm.Show();
            SemesterPromoteForm.BringToFront();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            if (MonthlyReportForm == null)
            {
                MonthlyReportForm = new frmMonthlyReport();
            }
            MonthlyReportForm.TopLevel = false;
            panelparent.Controls.Add(MonthlyReportForm);
            MonthlyReportForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MonthlyReportForm.Show();
            MonthlyReportForm.BringToFront();
        }

        private void frmAttendanceSystem_Load(object sender, EventArgs e)
        {
            if (DashboardForm == null)
            {
                DashboardForm = new Dashboardmain();
            }
            DashboardForm.TopLevel = false;
            panelparent.Controls.Add(DashboardForm);
            DashboardForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            DashboardForm.Show();
            DashboardForm.BringToFront();
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            if (DailyReportForm == null)
            {
                DailyReportForm = new frmDailyReport();
            }
            DailyReportForm.TopLevel = false;
            panelparent.Controls.Add(DailyReportForm);
            DailyReportForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            DailyReportForm.Show();
            DailyReportForm.BringToFront();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            
                if (CustomReportForm == null)
            {
                CustomReportForm = new frmCustomReport();
            }
            CustomReportForm.TopLevel = false;
            panelparent.Controls.Add(CustomReportForm);
            CustomReportForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            CustomReportForm.Show();
            CustomReportForm.BringToFront();
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            if (DashboardForm == null)
            {
                DashboardForm = new Dashboardmain();
            }
            DashboardForm.TopLevel = false;
            panelparent.Controls.Add(DashboardForm);
            DashboardForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            DashboardForm.Show();
            DashboardForm.BringToFront();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            login frm = new login(this);
            frm.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
 