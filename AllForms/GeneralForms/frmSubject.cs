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
    public partial class frmSubject : Form
    {
        public frmSubject()
        {
            InitializeComponent();
        }

        public void FillGrid(string searchvalue)
        {
            DataTable dt = new DataTable();
            string query = string.Empty;
            if (searchvalue.Trim().Length == 0)
            {
                query = "select SubjectID as [ID],SubjectName as [Subject], Code from SubjectTable";
            }
            else
            {
                query = "select SubjectID as [ID],SubjectName as [Subject], Code from SubjectTable where (SubjectName +''+ Code) like '%" + searchvalue + "%'";
            }

            dt = DatabaseCode.DatabaseAccess.SelectData(query);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    df_subject_list.DataSource = dt;
                    df_subject_list.Columns[0].Width = 100;
                    df_subject_list.Columns[1].Width = 400;
                    df_subject_list.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    df_subject_list.DataSource = null;
                }
            }
            else
            {
                df_subject_list.DataSource = null;
            }
        }

        private void FormClean()
        {
            txt_subject_name.Clear();
            txt_subject_code.Clear();

        }

        private void EnableComponents()
        {
            btn_save_subject.Enabled = false;
            btn_update_subject.Enabled = true;
            txt_search_subject.Enabled = false;
            btn_cancel_subject.Enabled = true;
            df_subject_list.Enabled = false;
        }

        private void DesibleComponents()
        {
            btn_save_subject.Enabled = true;
            btn_update_subject.Enabled = false;
            txt_search_subject.Enabled = true;
            btn_cancel_subject.Enabled = false;
            df_subject_list.Enabled = true;
            FillGrid("");
            FormClean();
        }

        private void btn_save_semester_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txt_subject_name.Text.Trim().Length == 0)
            {
                ep.SetError(txt_subject_name, "Please Enter The Subject Name");
                txt_subject_name.Focus();
                return;
            }

            DataTable dt = new DataTable();
            dt = DatabaseCode.DatabaseAccess.SelectData("SELECT * FROM SubjectTable WHERE SubjectName = '" + txt_subject_name.Text.Trim() + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txt_subject_name, "Already Exists");
                    txt_subject_name.Focus();
                    return;
                }
            }

            string insertquery = string.Format("INSERT INTO SubjectTable (SubjectName,Code) VALUES ('{0}','{1}')", txt_subject_name.Text.Trim(), txt_subject_code.Text.Trim());
            bool result = DatabaseCode.DatabaseAccess.InsertData(insertquery);
            if (result == true)
            {
                MessageBox.Show("Subject Added Succefuly");
                FormClean();
                FillGrid("");
            }
            else
            {
                MessageBox.Show("Subject Did Not Save");
            }
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            DesibleComponents();
        }

        private void btn_clear_subject_Click(object sender, EventArgs e)
        {
            FormClean();
        }

        private void btn_cancel_subject_Click(object sender, EventArgs e)
        {
            DesibleComponents();
        }

        private void btn_update_subject_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txt_subject_name.Text.Trim().Length == 0)
            {
                ep.SetError(txt_subject_name, "Please Enter The Subject Name");
                txt_subject_name.Focus();
                return;
            }

            DataTable dt = new DataTable();
            dt = DatabaseCode.DatabaseAccess.SelectData("SELECT * FROM SubjectTable WHERE SubjectName = '" + txt_subject_name.Text.Trim() + "' and SubjectID != '" + df_subject_list.CurrentRow.Cells[0].Value + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txt_subject_name, "Already Exists");
                    txt_subject_name.Focus();
                    return;
                }
            }

            string updatequery = string.Format("UPDATE SubjectTable SET SubjectName ='{0}', Code = '{1}' WHERE SubjectID='{2}'", txt_subject_name.Text.Trim(), txt_subject_code.Text.Trim(), df_subject_list.CurrentRow.Cells[0].Value);
            bool result = DatabaseCode.DatabaseAccess.InsertData(updatequery);
            if (result == true)
            {
                MessageBox.Show("Subject Updated Succefuly");
                DesibleComponents();
            }
            else
            {
                MessageBox.Show("Subject Did Not Update");
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (df_subject_list != null)
            {
                if (df_subject_list.Rows.Count > 0)
                {
                    if (df_subject_list.SelectedRows.Count == 1)
                    {
                        txt_subject_name.Text = Convert.ToString(df_subject_list.CurrentRow.Cells[1].Value);
                        txt_subject_code.Text = Convert.ToString(df_subject_list.CurrentRow.Cells[2].Value);
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

        private void txt_search_subject_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txt_search_subject.Text.Trim());
        }
    }
}
