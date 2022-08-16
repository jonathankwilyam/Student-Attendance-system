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
    public partial class frmSession : Form
    {
        public frmSession()
        {
            InitializeComponent();
        }

        public void FillGrid(string searchvalue)
        {
            DataTable dt = new DataTable();
            string query =string.Empty ;
            if (searchvalue.Trim().Length ==0 )
            {
                query = "select SessionID as [ID],SessionName as [Session],StartDate as [Start Date],EndDate as [End Date],Description from SessionTable";
            }
            else
            {
                query = "select SessionID as [ID],SessionName as [Session],StartDate as [Start Date],EndDate as [End Date],Description from SessionTable where (SessionName +' '+ Description) like '%" + searchvalue + "%'";
            }

            dt = DatabaseCode.DatabaseAccess.SelectData(query);
           if (dt != null)
            {
                if (dt.Rows.Count > 0 )
                {
                    df_session_list.DataSource = dt;
                    df_session_list.Columns[0].Width = 100;
                    df_session_list.Columns[1].Width = 200;
                    df_session_list.Columns[2].Width = 120;
                    df_session_list.Columns[3].Width = 120;
                    df_session_list.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    df_session_list.DataSource = null;
                }
            }
           else
           {
               df_session_list.DataSource = null;
           }
        }

        private void FormClean()
        {
            txt_session_name.Clear();
            txt_session_description.Clear();
            txt_session_startdate.Value = DateTime.Now;
            txt_session_enddate.Value = DateTime.Now;
        }

        private void EnableComponents()
        {
            btn_save_session.Enabled = false;
            btn_update_session.Enabled = true;
            txt_search_session.Enabled = false;
            btn_cancel_session.Enabled = true;
            df_session_list.Enabled = false;
        }

        private void DesibleComponents()
        {
            btn_save_session.Enabled = true;
            btn_update_session.Enabled = false;
            txt_search_session.Enabled = true;
            btn_cancel_session.Enabled = false;
            df_session_list.Enabled = true;
            FillGrid("");
            FormClean();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txt_session_name.Text.Trim().Length==0)
            {
                ep.SetError(txt_session_name, "Please Enter The Session Name");
                txt_session_name.Focus();
                return;
            }

            DataTable dt = new DataTable();
            dt = DatabaseCode.DatabaseAccess.SelectData("SELECT * FROM SessionTable WHERE SessionName  = '" + txt_session_name.Text.Trim() + "' and SessionID != '" + df_session_list.CurrentRow.Cells[0].Value + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txt_session_name, "Already Exists");
                    txt_session_name.Focus();
                    return;
                }
            }

            string insertquery = string.Format("INSERT INTO SessionTable(SessionName,StartDate,EndDate,[Description]) VALUES('{0}','{1}','{2}','{3}')", txt_session_name.Text.Trim(), txt_session_startdate.Value.ToString("yyy/MM/dd"), txt_session_enddate.Value.ToString("yyy/MM/dd"), txt_session_description.Text.Trim());
            bool result = DatabaseCode.DatabaseAccess.InsertData(insertquery);
           if (result == true)
           {
               MessageBox.Show("Session Added Succefuly");
               FormClean();
               FillGrid(""); 
           }
           else
           {
               MessageBox.Show("Session Did Not Save");
           }
        }

        private void frmSession_Load(object sender, EventArgs e)
        {
            DesibleComponents();
        }

        private void txt_search_session_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txt_search_session.Text.Trim());
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            FormClean();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (df_session_list != null)
            {
                if (df_session_list.Rows.Count > 0)
                {
                    if (df_session_list.SelectedRows.Count == 1)
                    {
                        txt_session_name.Text = Convert.ToString(df_session_list.CurrentRow.Cells[1].Value);
                        txt_session_startdate.Value = Convert.ToDateTime(df_session_list.CurrentRow.Cells[2].Value);
                        txt_session_enddate.Value = Convert.ToDateTime(df_session_list.CurrentRow.Cells[3].Value);
                        txt_session_description.Text = Convert.ToString(df_session_list.CurrentRow.Cells[4].Value);
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

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txt_session_name.Text.Trim().Length == 0)
            {
                ep.SetError(txt_session_name, "Please Enter The Session Name");
                txt_session_name.Focus();
                return;
            }

            DataTable dt = new DataTable();
            dt = DatabaseCode.DatabaseAccess.SelectData("SELECT * FROM SessionTable WHERE SessionName = '" + txt_session_name.Text.Trim() + "' and SessionID != '"+ df_session_list.CurrentRow.Cells[0].Value+"'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txt_session_name, "Already Exists");
                    txt_session_name.Focus();
                    return;
                }
            }

            string insertquery = string.Format("UPDATE SessionTable SET SessionName ='{0}',StartDate ='{1}',EndDate='{2}',Description='{3}' WHERE SessionID = '{4}'", txt_session_name.Text.Trim(), txt_session_startdate.Value.ToString("yyy/MM/dd"), txt_session_enddate.Value.ToString("yyy/MM/dd"), txt_session_description.Text.Trim(), df_session_list.CurrentRow.Cells[0].Value);
            bool result = DatabaseCode.DatabaseAccess.InsertData(insertquery);
            if (result == true)
            {
                MessageBox.Show("Session Updated Succefuly");
                DesibleComponents();
            }
            else
            {
                MessageBox.Show("Session Did Not Update");
            }
        }

        private void btn_cancel_session_Click(object sender, EventArgs e)
        {
            DesibleComponents();
        }

        private void df_session_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
