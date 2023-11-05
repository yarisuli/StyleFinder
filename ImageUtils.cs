using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace App_Ropa___Intento_1
{
    static class ImageUtils
    {
#pragma warning disable CS0618 // 'ConfigurationSettings.AppSettings' está obsoleto: 'This method is obsolete, it has been replaced by System.Configuration!System.Configuration.ConfigurationManager.AppSettings'
        private static readonly int maxUploadImageSize = Int16.Parse(System.Configuration.ConfigurationSettings.AppSettings["maxUploadImageSize"]);
#pragma warning restore CS0618 // 'ConfigurationSettings.AppSettings' está obsoleto: 'This method is obsolete, it has been replaced by System.Configuration!System.Configuration.ConfigurationManager.AppSettings'
        public static string SelectImageBase64()
        {
            string base64Image = string.Empty;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.PNG; *.JPG; *.GIF*; *.BMP; *.JPEG;)| *.PNG; *.JPG; *.GIF; *.BMP; *.JPEG;"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time

            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                //Get the path of specified file
                var filePath = dialog.FileName;

                byte[] bytes = File.ReadAllBytes(filePath);
                base64Image = Convert.ToBase64String(bytes);
            }
            return base64Image;
        }

        public static void ShowBase64ImageInPictureBox(string base64Image, PictureBox imageContainer)
        {
            if (!string.IsNullOrWhiteSpace(base64Image))
            {
                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(base64Image)))
                {
                    imageContainer.Image = Image.FromStream(ms);
                }
            }
        }

        public static bool VerifyFileSize(byte[] bytes)
        {
            float size =bytes.Length / 1024f / 1024f; //first convertto kb then to mb
                return size <= maxUploadImageSize;

        }

        public static Image Base64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
    }
}