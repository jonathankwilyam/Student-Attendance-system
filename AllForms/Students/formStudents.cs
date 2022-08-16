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

namespace StdASystem.AllForms.Students
{
    public partial class formStudents : Form
    {
        public formStudents()
        {
            InitializeComponent();
            ComboHelper.session(cmb_session);
            ComboHelper.programe(cmb_program);
        }

        private void txt_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txt_search.Text.Trim());

        }

        private void formStudents_Load(object sender, EventArgs e)
        {
            ComboHelper.session(cmb_session);
            ComboHelper.programe(cmb_program);
            FillGrid("");
            EnableContents();
        }

        private void FillGrid(string searchvalue)
        {
            DataTable dt = new DataTable();
            string query = string.Empty;
            if (searchvalue.Trim().Length == 0)
            {
                query = string.Format("SELECT [StdID] as [ID],[RegID] as [Reg. ID],[FullName],[Programe_ID],[ProgrameName] as [Program],[Session_ID],[SessionName] as [Session] ,[Email],[PhoneNum] as [Telephone],[QR_code_num] as [QR Code],[Photo] FROM V_Students_list");
            }
            else
            {
                query = string.Format("select [StdID] as [ID],[RegID] as [Reg. ID],[FullName],[Programe_ID],[ProgrameName] as [Program],[Session_ID],[SessionName] as [Session] ,[Email],[PhoneNum] as [Telephone],[QR_code_num] as [QR Code],[Photo] FROM V_Students_list where (FullName +' '+ QR_code_num +''+ ProgrameName) like '%" + searchvalue + "%' ");
            }

            dt = DatabaseAccess.SelectData(query);
            if (dt.Rows.Count > 0)
            {
                df_timetable.DataSource = dt;
                df_timetable.Columns[3].Visible = false;
                df_timetable.Columns[5].Visible = false;

                df_timetable.Columns[0].Width = 100;
                df_timetable.Columns[1].Width = 100;
                df_timetable.Columns[2].Width = 230;
                df_timetable.Columns[4].Width = 100;
                df_timetable.Columns[6].Width = 180;
                df_timetable.Columns[7].Width = 150;
                df_timetable.Columns[8].Width = 100;
                df_timetable.Columns[9].Width = 100;
                df_timetable.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
            }
            else
            {
                df_timetable.DataSource = null;
            }

        }

        private void Resetform()
        {
            FormClear();
        }
        private void FormClear()
        {
            ep.Clear();
            txt_name.Clear();
            txt_email.Clear();
            txt_numerber.Clear();
            cmb_program.SelectedIndex = 0;
            cmb_session.SelectedIndex = 0;

        }

        private void DesibleContents()
        {
            btn_clear.Enabled = false;
            btn_save.Enabled = false;
            txt_search.Enabled = false;
            df_timetable.Enabled = false;
            btn_update.Enabled = true;
            btn_cancel.Enabled = true;
        }

        private void EnableContents()
        {
            btn_clear.Enabled = true;
            btn_save.Enabled = true;
            txt_search.Enabled = true;
            df_timetable.Enabled = true;
            btn_update.Enabled = false;
            btn_cancel.Enabled = false;
            Resetform();
        }

        private void formStudents_Activated(object sender, EventArgs e)
        {
            ComboHelper.session(cmb_session);
            ComboHelper.programe(cmb_program);
            FillGrid("");
        }

    
        private void btn_save_Click(object sender, EventArgs e)
        {
            string image64bitstring = string.Empty;
            if (pc_student != null)
            {
                image64bitstring = DatabaseAccess.ImageToBase64(pc_student.Image, System.Drawing.Imaging.ImageFormat.Png);
            }
            string checkquery = string.Format("select * from StudentTable  where [Programe_ID] = '{0}' and  [FullName] = '{1}'", cmb_program.SelectedValue, txt_name.Text.Trim());
            DataTable dt = DatabaseAccess.SelectData(checkquery);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txt_name, "This Students is Already Regersterd");
                    txt_name.Focus();
                    return;
                }
            }
                
            string insertquery = string.Format("insert into StudentTable([RegID],[FullName],[Programe_ID],[Session_ID],[Photo],[Email],[PhoneNum],[QR_code_num]) " +
                                               "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                                                txt_regid.Text.Trim(),txt_name.Text.Trim(),cmb_program.SelectedValue,cmb_session.SelectedValue,image64bitstring,txt_email.Text.Trim(),txt_numerber.Text.Trim(),txt_qrcode.Text.Trim());
            bool result = DatabaseCode.DatabaseAccess.InsertData(insertquery);
            string stdinsertid = DatabaseAccess.SelectData("select Max(StdID) from StudentTable;").Rows[0][0].ToString();
            string semesterid = string.Format("select Semester_ID, SemesterName from SubjectTimeTable INNER JOIN SemesterTable on Semester_ID = SemesterID"
                                                + "where Programe_ID = " +cmb_program.SelectedValue+ " and Session_ID = " +cmb_session.SelectedValue+ "group by Semester_ID, SemesterName");
            dt.Clear();
            dt = DatabaseAccess.SelectData(semesterid);

            foreach (DataRow semesterrow in dt.Rows)
            {
                if (semesterrow[1].ToString().Contains("1st") || semesterrow[1].ToString().Contains("First"))
                {
                    semesterid = string.Empty;
                    semesterid = semesterrow[0].ToString();
                    break;
                }
            }

            string semesterinsert = string.Format("insert into StudentSemesterRecordTable (Semester_ID,Std_ID, IsActive) values('{0}','{1}','1')", semesterid, stdinsertid);
            DatabaseAccess.InsertData(semesterinsert);

            if (result)
            {
                MessageBox.Show("Student Added Succefuly");
                FormClear();
                FillGrid("");
            }
            else
            {
                MessageBox.Show("Program Did Not Save");
            }
                     
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            upload_studentpic.Title = "Select a Student PassPort Photo Size";
            upload_studentpic.Filter = "Image File(*.bmp;*.jpg;*jpeg;*png)|*BMP;*JPG;*JPEG;*PNG";
            if (upload_studentpic.ShowDialog() == DialogResult.OK)
            {
                pc_student.ImageLocation = upload_studentpic.FileName;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            pc_student.Image = null;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            EnableContents();
        }

        private void bunifuCards3_Paint(object sender, PaintEventArgs e)
        {

        }

    
        private void btn_qrcode_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txt_regid.Text.Trim().Length == 0)
            {
                ep.SetError(txt_regid, "Please Insert the Student Registration Number");
                txt_regid.Focus();
                return;
            }

            txt_qrcode.Text = txt_regid.Text.Trim();
            Qr_Code_generator frm2 = new Qr_Code_generator(this);
            frm2.ShowDialog();

        }

        private void cmb_session_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
