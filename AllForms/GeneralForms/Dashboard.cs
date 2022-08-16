using StdASystem.Dashboard.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StdASystem.AllForms.GeneralForms
{
    public partial class Dashboardmain : Form

    {
        private Dashboard1 model;

        public Dashboardmain()
        {
            InitializeComponent();
            model = new Dashboard1();
            LoadData();
        }

        //Private methods
        public void LoadData()
        {

            //connect database
            string str = @"Data Source=KENT-PC\SQLEXPRESS;Initial Catalog=AttendanceDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;
            // create commande
            string query1 = "select count(StdID) from StudentTable";
            string query2 = "select count(SubjectID) from SubjectTable";
            string query3 = "select count(ProgramID) from Programe_Table";
            string query4 = "select count(SemesterID) from SemesterTable";
            try
            {
                con.Open();
                cmd = new SqlCommand(query1, con);

                //read from db
                Int32 rows_count1 = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();

                cmd = new SqlCommand(query2, con);
                Int32 rows_count2 = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();

                cmd = new SqlCommand(query3, con);
                Int32 rows_count3 = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();

                cmd = new SqlCommand(query4, con);
                Int32 rows_count4 = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();

                con.Close();
                //display data on page 
                lblstudent.Text = rows_count1.ToString();
                lblsubject.Text = rows_count2.ToString();
                lblcourse.Text = rows_count3.ToString();
                lblsemester.Text = rows_count4.ToString();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
                //lblstudent.Text = model.NumStudents.ToString();
                //lblsubject.Text = model.Numsubject.ToString();
                //lblcourse.Text = model.Numcourse.ToString();
                //lblsemester.Text = model.Numsemester.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToLongTimeString();
            labeldate.Text = DateTime.Now.ToLongDateString();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadData();
            timer1.Start();
           
        }

        private void labeldate_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbllogin_Click(object sender, EventArgs e)
        {
            

        }
    }
}
