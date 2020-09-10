using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLib;

namespace MyDiary
{
    public partial class Landing : Form
    {
        User user;
        int currentMouseOverRow;
        string contentId;

        public Landing(User user)
        {
            InitializeComponent();
            this.user = user;
            newEventPriorityComboBox.SelectedIndex = 1;
            editPriorityComboBox.SelectedIndex = 1;
            eventDataGridView.DataSource = new ContentDataAccess().GetContents(user.PhoneNumber);
        }

        private void Landing_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            this.Hide();
            var Login = new Login();
            Login.Closed += (s, args) => this.Close();
            Login.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            Content content = new Content();
            content.Id = contentId;
            content.Title = editTitleTextBox.Text;
            content.Text = editTextTextBox.Text;
            content.DateModified = DateTime.Now.ToString("dd-MM-yyyy");
            content.Priority = editPriorityComboBox.Text;
            if (new ContentDataAccess().UpdateEvent(content))
            {
                MessageBox.Show("Event Updated Successfully!", "Success");
                eventDataGridView.DataSource = new ContentDataAccess().GetContents(user.PhoneNumber);
            }
            else
            {
                MessageBox.Show("Couldn't Update Event!", "Failed");
            }
        }

        private void clearPicButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            fpicPictureBox.Image = MyDiary.Properties.Resources.add;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            Content content = new Content();
            Images images = new Images();
            content.Title = titleTextBox.Text;
            content.Text = textTextBox.Text;
            content.Priority = newEventPriorityComboBox.Text;
            images.FirstImageLocation = fpicPictureBox.ImageLocation;
            if((new ContentDataAccess().AddEvent(content, user)) && (new ImageDataAccess().AddImages(images, new ContentDataAccess().GetContents(user.PhoneNumber)[new ContentDataAccess().GetContents(user.PhoneNumber).Count - 1])))
            {
                MessageBox.Show("Event Added Successfully!", "Success");
                eventDataGridView.DataSource = new ContentDataAccess().GetContents(user.PhoneNumber);
            }
            else
            {
                MessageBox.Show("Couldn't Add Event!", "Failed");
            }
        }

        private void cancelEditButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            editEventGroupBox.Visible = false;
            newEventGroupBox.Visible = true;
        }

        private void fpicPictureBox_Click(object sender, EventArgs e)
        {
            string imagePath = new ImageBrowse().GetImagePath(user.PhoneNumber);
            if (!(imagePath.Equals("")))
            {
                fpicPictureBox.ImageLocation = imagePath;
            }
        }

        private void editEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newEventGroupBox.Visible = false;
            editEventGroupBox.Visible = true;
            contentId = eventDataGridView.Rows[currentMouseOverRow].Cells[0].Value.ToString();
            editTitleTextBox.Text = eventDataGridView.Rows[currentMouseOverRow].Cells[1].Value.ToString();
            editTextTextBox.Text= eventDataGridView.Rows[currentMouseOverRow].Cells[2].Value.ToString();
            efpicPictureBox.ImageLocation = new ImageDataAccess().GetImagePath(contentId);
        }

        private void viewEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Content content = new Content();
            Images images = new Images();
            content.Id = eventDataGridView.Rows[currentMouseOverRow].Cells[0].Value.ToString();
            content.Title = eventDataGridView.Rows[currentMouseOverRow].Cells[1].Value.ToString();
            content.Text = eventDataGridView.Rows[currentMouseOverRow].Cells[2].Value.ToString();
            content.DateCreated = eventDataGridView.Rows[currentMouseOverRow].Cells[3].Value.ToString();
            content.DateModified = eventDataGridView.Rows[currentMouseOverRow].Cells[4].Value.ToString();
            content.Priority = eventDataGridView.Rows[currentMouseOverRow].Cells[5].Value.ToString();
            images.FirstImageLocation = new ImageDataAccess().GetImagePath(content.Id);
            new ViewEvent(content, images).Show();
        }

        private void deleteEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contentId = eventDataGridView.Rows[currentMouseOverRow].Cells[0].Value.ToString();
            if (new ContentDataAccess().DeleteEvent(contentId))
            {
                MessageBox.Show("Event Deleted Successfully!", "Success");
                eventDataGridView.DataSource = new ContentDataAccess().GetContents(user.PhoneNumber);
            }
            else
            {
                MessageBox.Show("Couldn't Delete Event!", "Failed");
            }
        }

        private void eventDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                gridContextMenuStrip.Show(MousePosition.X, MousePosition.Y);
                currentMouseOverRow = eventDataGridView.HitTest(e.X, e.Y).RowIndex;
            }
        }
    }
}
