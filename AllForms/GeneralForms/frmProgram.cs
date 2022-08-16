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
    public partial class frmProgram : Form
    {
        public frmProgram()
        {
            InitializeComponent();
        }


        public void FillGrid(string searchvalue)
        {
            DataTable dt = new DataTable();
            string query = string.Empty;
            if (searchvalue.Trim().Length == 0)
            {
                query = "select ProgramID as [ID],ProgrameName as [Program],RegDate as [Registration Date],Description as [Description] from Programe_Table";
            }
            else
            {
                query = "select ProgramID as [ID],ProgrameName as [Program],RegDate as [Registration Date],Description as [Description] from Programe_Table where (ProgrameName +' '+ Description) like '%" + searchvalue + "%'";
            }

            dt = DatabaseCode.DatabaseAccess.SelectData(query);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    df_program_list.DataSource = dt;
                    df_program_list.Columns[0].Width = 100;
                    df_program_list.Columns[1].Width = 200;
                    df_program_list.Columns[2].Width = 160;
                    df_program_list.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    df_program_list.DataSource = null;
                }
            }
            else
            {
                df_program_list.DataSource = null;
            }
        }

        private void FormClean()
        {
            txt_program_name.Clear();
            txt_program_description.Clear();
            txt_regdate.Value = DateTime.Now;
       
        }

        private void EnableComponents()
        {
            btn_save_program.Enabled = false;
            btn_update_program.Enabled = true;
            txt_search_program.Enabled = false;
            btn_cancel_program.Enabled = true;
            df_program_list.Enabled = false;
        }

        private void DesibleComponents()
        {
            btn_save_program.Enabled = true;
            btn_update_program.Enabled = false;
            txt_search_program.Enabled = true;
            btn_cancel_program.Enabled = false;
            df_program_list.Enabled = true;
            FillGrid("");
            FormClean();
        }
        private void frmProgram_Load(object sender, EventArgs e)
        {
            DesibleComponents();
        }

        private void df_program_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cancel_program_Click(object sender, EventArgs e)
        {
            DesibleComponents();
        }

        private void btn_save_program_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txt_program_name.Text.Trim().Length==0)
            {
                ep.SetError(txt_program_name, "Please Enter The Program Name");
                txt_program_name.Focus();
                return;
            }

            DataTable dt = new DataTable();
            dt = DatabaseCode.DatabaseAccess.SelectData("SELECT * FROM Programe_Table WHERE ProgrameName = '" + txt_program_name.Text.Trim() + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txt_program_name, "Already Exists");
                    txt_program_name.Focus();
                    return;
                }
            }

            string insertquery = string.Format("INSERT INTO Programe_Table(ProgrameName,RegDate,Description) VALUES('{0}','{1}','{2}')", txt_program_name.Text.Trim(), txt_regdate.Value.ToString("yyy/MM/dd"), txt_program_description.Text.Trim());
            bool result = DatabaseCode.DatabaseAccess.InsertData(insertquery);
           if (result == true)
           {
               MessageBox.Show("Program Added Succefuly");
               FormClean();
               FillGrid(""); 
           }
           else
           {
               MessageBox.Show("Program Did Not Save");
           }
        }

        private void txt_search_program_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txt_search_program.Text.Trim());
        }

        private void btn_clear_program_Click(object sender, EventArgs e)
        {
            FormClean();
        }

        private void btn_update_program_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txt_program_name.Text.Trim().Length == 0)
            {
                ep.SetError(txt_program_name, "Please Enter The Program Name");
                txt_program_name.Focus();
                return;
            }

            DataTable dt = new DataTable();
            dt = DatabaseCode.DatabaseAccess.SelectData("SELECT * FROM Programe_Table WHERE Programe_Name = '" + txt_program_name.Text.Trim() + "' and ProgramID != '" + df_program_list.CurrentRow.Cells[0].Value + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txt_program_name, "Already Exists");
                    txt_program_name.Focus();
                    return;
                }
            }

            string updatequery = string.Format("UPDATE Programe_Table SET Programe_Name ='{0}',RegDate ='{1}',Description='{2}' WHERE ProgramID='{3}'", txt_program_name.Text.Trim(), txt_regdate.Value.ToString("yyy/MM/dd"), txt_program_description.Text.Trim(), df_program_list.CurrentRow.Cells[0].Value);
            bool result = DatabaseCode.DatabaseAccess.InsertData(updatequery);
            if (result == true)
            {
                MessageBox.Show("Program Updated Succefuly");
                DesibleComponents();
            }
            else
            {
                MessageBox.Show("Program Did Not Update");
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (df_program_list != null)
            {
                if (df_program_list.Rows.Count > 0)
                {
                    if (df_program_list.SelectedRows.Count == 1)
                    {
                        txt_program_name.Text = Convert.ToString(df_program_list.CurrentRow.Cells[1].Value);
                        txt_regdate.Value = Convert.ToDateTime(df_program_list.CurrentRow.Cells[2].Value);
                        txt_program_description.Text = Convert.ToString(df_program_list.CurrentRow.Cells[3].Value);
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

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
 }

