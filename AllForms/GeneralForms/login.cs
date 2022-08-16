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
    public partial class login : Form
    {
        
        frmAttendanceSystem frm;
        public login(frmAttendanceSystem frmadd)
        {
            InitializeComponent();
            frm = frmadd;
            
        }

        private void txt_semester_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtusername.Text.Trim().Length == 0)
            {
                ep.SetError(txtusername, "Please enter the username");
                txtusername.Focus();
                return;
            }
            if (txtpassword.Text.Trim().Length == 0)
            {
                ep.SetError(txtpassword, "please entre the password");
                txtpassword.Focus();
                return;
            }

            string userquery = "select * from UserTable Where UserName = '"+txtusername.Text.Trim()+"' and Password = '"+txtpassword.Text.Trim()+ "'";
            DataTable dt = DatabaseCode.DatabaseAccess.SelectData(userquery);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    frm.label5.Visible = true;
                    frm.label6.Visible = false;
                    frm.menupanel.Enabled = true;
                    frm.panelparent.Enabled = true;
                    this.Close();
                }
                else
                {
                    lbl_iccorect.Visible = true;
                }
            }
            else
            {
                lbl_iccorect.Visible = true;
            }
        }
    }
}
