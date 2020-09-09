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
    public partial class Landing : Form
    {
        ImageBrowse ib;
        User user;
        public Landing(User user)
        {
            InitializeComponent();
            ib = new ImageBrowse();
            this.user = user;
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

        private void editPicClearButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            efpicPictureBox.Image = null;
            espicPictureBox.Image = null;
            etpicPictureBox.Image = null;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            //TO-DO
        }

        private void clearPicButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            fpicPictureBox.Image = null;
            spicPictureBox.Image = null;
            tpicPictureBox.Image = null;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            //TO-DO
        }

        private void cancelEditButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            editEventGroupBox.Visible = false;
            newEventGroupBox.Visible = true;
        }

        private void efpicPictureBox_Click(object sender, EventArgs e)
        {
            string imagePath = ib.GetImagePath();
            if (!(imagePath.Equals("")))
            {
                efpicPictureBox.Image = Image.FromFile(imagePath);
            }
        }

        private void espicPictureBox_Click(object sender, EventArgs e)
        {
            string imagePath = ib.GetImagePath();
            if (!(imagePath.Equals("")))
            {
                espicPictureBox.Image = Image.FromFile(imagePath);
            }
        }

        private void etpicPictureBox_Click(object sender, EventArgs e)
        {
            string imagePath = ib.GetImagePath();
            if (!(imagePath.Equals("")))
            {
                etpicPictureBox.Image = Image.FromFile(imagePath);
            }
        }

        private void fpicPictureBox_Click(object sender, EventArgs e)
        {
            string imagePath = ib.GetImagePath();
            if (!(imagePath.Equals("")))
            {
                fpicPictureBox.Image = Image.FromFile(imagePath);
            }
        }

        private void spicPictureBox_Click(object sender, EventArgs e)
        {
            string imagePath = ib.GetImagePath();
            if (!(imagePath.Equals("")))
            {
                spicPictureBox.Image = Image.FromFile(imagePath);
            }
        }

        private void tpicPictureBox_Click(object sender, EventArgs e)
        {
            string imagePath = ib.GetImagePath();
            if (!(imagePath.Equals("")))
            {
                tpicPictureBox.Image = Image.FromFile(imagePath);
            }
        }
    }
}
