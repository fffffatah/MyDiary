using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLib
{
    public class ImageBrowse
    {
        private string GetRandomImageName(string phoneNumber)
        {
            StringBuilder builder = new StringBuilder();
            string date = new DateTime(2012, 12, 25, 10, 30, 50).ToString();
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                builder.Append(phoneNumber[i]);
                builder.Append(date[i]);
            }

            return builder.ToString();
        }

        public string GetImagePath(string phoneNumber)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select an Image";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Images (*.png)|*.png";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = fdlg.FileName;
                string destinationFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MyDiary\Images\" + GetRandomImageName(phoneNumber) + ".png";
                try
                {
                    File.Copy(sourceFile, destinationFile, true);
                }
                catch (IOException iox)
                {
                    Console.WriteLine(iox.StackTrace);
                }
                return destinationFile;
            }
            return "";
        }

    }
}
