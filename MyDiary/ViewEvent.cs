using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLib;

namespace MyDiary
{
    public partial class ViewEvent : Form
    {
        public ViewEvent(Content content, Images images)
        {
            InitializeComponent();
            ShowEvent(content, images);
        }

        public void ShowEvent(Content content, Images images)
        {
            viewPicPictureBox.ImageLocation = images.FirstImageLocation;
            viewTitleTextBox.Text = content.Title;
            viewTextTextBox.Text = content.Text;
            dateCreatedLabel.Text += content.DateCreated;
            dateModifiedLabel.Text += content.DateModified;
            priorityLabel.Text += content.Priority;
        }
    }
}
