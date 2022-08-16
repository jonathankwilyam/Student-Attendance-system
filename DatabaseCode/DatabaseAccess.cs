using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace StdASystem.DatabaseCode
{
    public class DatabaseAccess
    {
        private static SqlConnection conn;

        private static SqlConnection ConnOpen()
        {
            if (conn == null)
            {
                conn = new SqlConnection(@"Data Source=KENT-PC\SQLEXPRESS;Initial Catalog=AttendanceDB;Integrated Security=True");
            }
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;
        }

        public static bool InsertData(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, ConnOpen());
                int noofrecord = cmd.ExecuteNonQuery();
                if(noofrecord > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdatetData(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, ConnOpen());
                int noofrecord = cmd.ExecuteNonQuery();
                if (noofrecord > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool DeletetData(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, ConnOpen());
                int noofrecord = cmd.ExecuteNonQuery();
                if (noofrecord > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static DataTable SelectData(string query)
        {
            DataTable dt = new DataTable();
            try
            {
               
                SqlDataAdapter da = new SqlDataAdapter(query, ConnOpen());
                da.Fill(dt);
                return dt;
            }
            catch 
            {
                
                return dt;
            }
        }

        public static string ImageToBase64(Image image,System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // convert image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // convert byte to base64 string
                string Base64String = Convert.ToBase64String(imageBytes);
                return Base64String;
             }
         }

        public static Image Base64ToImage(string base64String)
        {
            // convert base64 to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,imageBytes.Length);

            // convert byte[] to image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;

        }
    }
}
