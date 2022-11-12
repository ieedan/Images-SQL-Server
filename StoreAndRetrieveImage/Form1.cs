using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreAndRetrieveImage
{
    public partial class Form1 : Form
    {
        string connectionstring = "Connection string here"; // Replace this with your connection string
        public Form1()
        {
            InitializeComponent();
        }

        private void image_store_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog(); // Open dialog to pick image
            dialog.ShowDialog();

            if (dialog.FileName != null)
            {
                var filepath = dialog.FileName;
                image_store.ImageLocation = filepath; // If image was picked update screen image
            }
        }

        private void btn_store_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconnection = new SqlConnection(
                connectionstring))
            {
                sqlconnection.Open();

                // Converts image file into byte[]
                byte[] imgData = File.ReadAllBytes(image_store.ImageLocation);

                string insertXmlQuery = @"Insert Into [Images] (Description,Image) Values('This is an image',@Photo)";

                // Insert Image Value into Sql Table by SqlParameter
                SqlCommand insertCommand = new SqlCommand(insertXmlQuery, sqlconnection);
                SqlParameter sqlParam = insertCommand.Parameters.AddWithValue("@Photo", imgData);
                sqlParam.DbType = DbType.Binary;
                insertCommand.ExecuteNonQuery();
            }
        }

        private void btn_retrieve_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconnection = new SqlConnection(connectionstring))
            {
                sqlconnection.Open();

                string selectQuery = string.Format(@"Select [Image] From [Images] Where Id={0}",
                                     num_imgid.Value);

                //Read Image Value from Sql Table that was stored as Image Datatype
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlconnection);
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.Read())
                {
                    byte[] imgData = (byte[])reader[0];
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        System.Drawing.Image image = Image.FromStream(ms);
                        image_retrieve.Image = image;
                    }
                }
            }
        }
    }
}
