using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StdASystem.AllForms.GeneralForms
{
    public partial class frmSemester : Form
    {
        public frmSemester()
        {
            InitializeComponent();
        }

        public void FillGrid(string searchvalue)
        {
            DataTable dt = new DataTable();
            string query = string.Empty;
            if (searchvalue.Trim().Length == 0)
            {
                query = "select SemesterID as [ID],SemesterName as [Semester] from SemesterTable";
            }
            else
            {
                query = "select SemesterID as [ID],SemesterName as [Semester] from SemesterTable where SemesterName  like '%" + searchvalue + "%'";
            }

            dt = DatabaseCode.DatabaseAccess.SelectData(query);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    df_semester_list.DataSource = dt;
                    df_semester_list.Columns[0].Width = 100;
                    df_semester_list.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    df_semester_list.DataSource = null;
                }
            }
            else
            {
                df_semester_list.DataSource = null;
            }
        }

        private void FormClean()
        {
            txt_semester_name.Clear();
          
        }

        private void EnableComponents()
        {
            btn_save_semester.Enabled = false;
            btn_update_semester.Enabled = true;
            txt_search_semester.Enabled = false;
            btn_cancel_semester.Enabled = true;
            df_semester_list.Enabled = false;
        }

        private void DesibleComponents()
        {
            btn_save_semester.Enabled = true;
            btn_update_semester.Enabled = false;
            txt_search_semester.Enabled = true;
            btn_cancel_semester.Enabled = false;
            df_semester_list.Enabled = true;
            FillGrid("");
            FormClean();
        }
        private void frmSemester_Load(object sender, EventArgs e)
        {
            DesibleComponents();
        }

        private void btn_save_semester_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txt_semester_name.Text.Trim().Length == 0)
            {
                ep.SetError(txt_semester_name, "Please Enter The Semester Name");
                txt_semester_name.Focus();
                return;
            }

            DataTable dt = new DataTable();
            dt = DatabaseCode.DatabaseAccess.SelectData("SELECT * FROM SemesterTable WHERE SemesterName = '" + txt_semester_name.Text.Trim() + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txt_semester_name, "Already Exists");
                    txt_semester_name.Focus();
                    return;
                }
            }

            string insertquery = string.Format("INSERT INTO SemesterTable(SemesterName) VALUES('{0}')", txt_semester_name.Text.Trim());
            bool result = DatabaseCode.DatabaseAccess.InsertData(insertquery);
            if (result == true)
            {
                MessageBox.Show("Semester Added Succefuly");
                FormClean();
                FillGrid("");
            }
            else
            {
                MessageBox.Show("Semester Did Not Save");
            }
        }

        private void txt_search_semester_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txt_search_semester.Text.Trim());
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (df_semester_list != null)
            {
                if (df_semester_list.Rows.Count > 0)
                {
                    if (df_semester_list.SelectedRows.Count == 1)
                    {
                        txt_semester_name.Text = Convert.ToString(df_semester_list.CurrentRow.Cells[1].Value);
                        EnableComponents();
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

        private void btn_clear_semester_Click(object sender, EventArgs e)
        {
            FormClean();
        }

        private void btn_cancel_semester_Click(object sender, EventArgs e)
        {
            DesibleComponents();
        }

        private void btn_update_semester_Click(object sender, EventArgs e)
        {

            ep.Clear();
            if (txt_semester_name.Text.Trim().Length == 0)
            {
                ep.SetError(txt_semester_name, "Please Enter The Semester Name");
                txt_semester_name.Focus();
                return;
            }

            DataTable dt = new DataTable();
            dt = DatabaseCode.DatabaseAccess.SelectData("SELECT * FROM SemesterTable WHERE SemesterName = '" + txt_semester_name.Text.Trim() + "' and SemesterID != '" + df_semester_list.CurrentRow.Cells[0].Value + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txt_semester_name, "Already Exists");
                    txt_semester_name.Focus();
                    return;
                }
            }

            string updatequery = string.Format("UPDATE SemesterTable SET SemesterName ='{0}' WHERE SemesterID='{1}'", txt_semester_name.Text.Trim(), df_semester_list.CurrentRow.Cells[0].Value);
            bool result = DatabaseCode.DatabaseAccess.InsertData(updatequery);
            if (result == true)
            {
                MessageBox.Show("Semester Updated Succefuly");
                DesibleComponents();
            }
            else
            {
                MessageBox.Show("Semester Did Not Update");
            }
        }
    }
}
