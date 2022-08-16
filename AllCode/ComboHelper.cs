using Guna.UI2.WinForms.Suite;
using StdASystem.DatabaseCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdASystem.AllCode
{
    class ComboHelper
    {
        public static void Semester(ComboBox cmb)
        {
            try
            {
                DataTable dtsemester = new DataTable();
                dtsemester.Columns.Add("SemesterID");
                dtsemester.Columns.Add("SemesterName");
                dtsemester.Rows.Add("0","Select Semester");

                DataTable dt = new DataTable();
                dt = DatabaseCode.DatabaseAccess.SelectData("select SemesterID, SemesterName from SemesterTable");

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow item in dt.Rows)
                        {
                            dtsemester.Rows.Add(item[0], item[1]);
                        }
                    }
                }
                cmb.DataSource = dtsemester;
                cmb.ValueMember = "SemesterID";
                cmb.DisplayMember = "SemesterName";
            }
            catch 
            {
                cmb.DataSource = null;
            }
        }

        public static void programe(ComboBox cmb)
        {
            try
            {
                DataTable dtprograme = new DataTable();
                dtprograme.Columns.Add("ProgramID");
                dtprograme.Columns.Add("ProgrameName");
                dtprograme.Rows.Add("0", "Select Program");

                DataTable dt = new DataTable();
                dt = DatabaseCode.DatabaseAccess.SelectData("select ProgramID, ProgrameName from Programe_Table");

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow item in dt.Rows)
                        {
                            dtprograme.Rows.Add(item[0], item[1]);
                        }
                    }
                }
                cmb.DataSource = dtprograme;
                cmb.ValueMember = "ProgramID";
                cmb.DisplayMember = "ProgrameName";
            }
            catch
            {
                cmb.DataSource = null;
            }
        }

        public static void session(ComboBox cmb)
        {
            try
            {
                DataTable dtsession = new DataTable();
                dtsession.Columns.Add("SessionID");
                dtsession.Columns.Add("SessionName");
                dtsession.Rows.Add("0", "Select Session");

                DataTable dt = new DataTable();
                dt = DatabaseCode.DatabaseAccess.SelectData("select SessionID, SessionName from SessionTable");

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow item in dt.Rows)
                        {
                            dtsession.Rows.Add(item[0], item[1]);
                        }
                    }
                }
                cmb.DataSource = dtsession;
                cmb.ValueMember = "SessionID";
                cmb.DisplayMember = "SessionName";
            }
            catch
            {
                cmb.DataSource = null;
            }
        }

        public static void subject(ComboBox cmb)
        {
            try
            {
                DataTable dtsubject = new DataTable();
                dtsubject.Columns.Add("SubjectID");
                dtsubject.Columns.Add("SubjectName");
                dtsubject.Rows.Add("0", "Select Subject");

                DataTable dt = new DataTable();
                dt = DatabaseCode.DatabaseAccess.SelectData("select SubjectID, SubjectName + ' ('+Code+')' as [Subject] from SubjectTable");

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow item in dt.Rows)
                        {
                            dtsubject.Rows.Add(item[0], item[1]);
                        }
                    }
                }
                cmb.DataSource = dtsubject;
                cmb.ValueMember = "SubjectID";
                cmb.DisplayMember = "SubjectName";
            }
            catch
            {
                cmb.DataSource = null;
            }
        }

        public static void timetable(ComboBox cmb)
        {
            try
            {
                DataTable dtsubject = new DataTable();
                dtsubject.Columns.Add("SubjectTimeTableID");
                dtsubject.Columns.Add("SubjectName");
                dtsubject.Rows.Add("0", "Select Course");

                DataTable dt = new DataTable();
                dt = DatabaseCode.DatabaseAccess.SelectData("select SubjectTimeTableID, SubjectName + ' ('+ProgrameName+')' as [Course] from V_TimeTableList");

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow item in dt.Rows)
                        {
                            dtsubject.Rows.Add(item[0], item[1]);
                        }
                    }
                }
                cmb.DataSource = dtsubject;
                cmb.ValueMember = "SubjectTimeTableID";
                cmb.DisplayMember = "SubjectName";
            }
            catch
            {
                cmb.DataSource = null;
            }
        }

        public static  void GetSemesterByProgrameAndSession(ComboBox cmb,string programeid,string sessionid)
        {
            try
            {
                DataTable dtAllsemester = new DataTable();
                dtAllsemester.Columns.Add("Semester_ID");
                dtAllsemester.Columns.Add("SemesterName");
                dtAllsemester.Rows.Add("0", "Select Semester");
                DataTable dt = new DataTable();
                string query = string.Format("select Semester_ID, SemesterName from SubjectTimeTable INNER JOIN SemesterTable on Semester_ID = SemesterID "
                                                + "where Programe_ID = "+ programeid +"and Session_ID = "+ sessionid + " group by Semester_ID, SemesterName");

                dt = DatabaseAccess.SelectData(query);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow item in dt.Rows)
                        {
                            dtAllsemester.Rows.Add(item[0], item[1]); 
                        }
                    }
                }

                cmb.DataSource = dtAllsemester;
                cmb.ValueMember = "Semester_ID";
                cmb.DisplayMember = "SemesterName";
            }
            catch
            {
                cmb.DataSource = null;
            }
        }
    }
}
