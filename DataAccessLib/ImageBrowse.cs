using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLib
{
    public class ImageBrowse
    {
        public string GetImagePath()
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select an Image";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Images (*.jpg)|*.jpg|Images (*.png)|*.png";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                return fdlg.FileName;
            }
            return "";
        }
    }
}
