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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Threading;

namespace StdASystem.AllForms.Students
{
    public partial class frmAttendance : Form
    {
        public frmAttendance()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterinfocollection;
        VideoCaptureDevice capturedevice;

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {
            txt_attendance.Visible = false;
            filterinfocollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterifo in filterinfocollection)
                cboDevice.Items.Add(filterifo.Name);
                cboDevice.SelectedIndex = 0;
            
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (capturedevice.IsRunning)
                capturedevice.Stop();
            pb_scanner.Image = null;
            txt_attendance.Visible = false;
            scannedvalue.Clear();
            timer1.Stop();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            capturedevice = new VideoCaptureDevice(filterinfocollection[cboDevice.SelectedIndex].MonikerString);
            capturedevice.NewFrame += CaptureDevice_NewFrame;
            capturedevice.Start();
            scannedvalue.Clear();
            timer1.Start();
            
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pb_scanner.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pb_scanner.Image != null)
            {
                BarcodeReader barcodereader = new BarcodeReader();
                Result result = barcodereader.Decode((Bitmap)pb_scanner.Image);

                if (result != null)
                {
                    scannedvalue.Text = result.ToString();
                    timer1.Stop();

                    if (capturedevice.IsRunning)
                        capturedevice.Stop();
                }
            }
        }

        private void frmAttendance_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (capturedevice.IsRunning)
                capturedevice.Stop();
            
        }

        private void scannedvalue_TextChanged(object sender, EventArgs e)
        {
            txt_attendance.Visible = false;
            Thread.Sleep(1000);

            if (scannedvalue.Text.Trim().Length == 0)
            {
                scannedvalue.Focus();
                scannedvalue.Clear();
                return;
            }

            string insertquery = string.Format("insert into AttendanceDataLog(QrCodeNo,DateTimeReco,DateOnlyRecord,TimeOnlyRecord) values('{0}','{1}','{2}','{3}')",
                                                    scannedvalue.Text.Trim(), DateTime.Now, DateTime.Now.ToString("yyyy/MM/dd"), DateTime.Now.ToString("hh:mm:ss"));
            bool result = DatabaseCode.DatabaseAccess.InsertData(insertquery);

            if (result)
            {
                txt_attendance.Text = "Successfully Saved";
                txt_attendance.Visible = true;
                Console.Beep(1900, 200);
                timer2.Start();


            }
            else
            {
                txt_attendance.Text = "unexpected Error";
                txt_attendance.Visible = true;
            }
        }

        private void df_timetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCards3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            capturedevice = new VideoCaptureDevice(filterinfocollection[cboDevice.SelectedIndex].MonikerString);
            capturedevice.NewFrame += CaptureDevice_NewFrame;
            capturedevice.Start();
            scannedvalue.Clear();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
