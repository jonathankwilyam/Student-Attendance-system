using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace StdASystem.AllForms.Students
{
    public partial class Qr_Code_generator : Form
    {
        formStudents frmstudent;
        public Qr_Code_generator(formStudents fs)
        {
            InitializeComponent();
            this.frmstudent = fs;

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_regid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        public static void SaveImageCapture(System.Drawing.Image image)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.FileName = "Image";
            s.DefaultExt = ".Jpg";
            s.Filter = "Image (.jpg)|*.jpg"; 

            s.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);      
            s.RestoreDirectory = true;
           
            if (s.ShowDialog() == DialogResult.OK)
            {
                string filename = s.FileName;
                using (System.IO.FileStream fstream = new System.IO.FileStream(filename, System.IO.FileMode.Create))
                {
                    image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fstream.Close();
                }
            }
        }

        private void Qr_Code_generator_Load(object sender, EventArgs e)
        {
            txt_regid2.Text = frmstudent.txt_regid.Text;

            var qrcodeWriter = new BarcodeWriter();
            EncodingOptions encodingoption = new EncodingOptions() { Width = 300, Height = 300, Margin = 0, PureBarcode = false };
            encodingoption.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);

            qrcodeWriter.Renderer = new BitmapRenderer();
            qrcodeWriter.Options = encodingoption;
            qrcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = qrcodeWriter.Write(txt_regid2.Text);
            Bitmap logo = new Bitmap($"{Application.StartupPath}/logo1.png");
            Graphics g = Graphics.FromImage(bitmap); 
            pictureBox1.Image = bitmap;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveImageCapture(pictureBox1.Image);
        }
    }
}
