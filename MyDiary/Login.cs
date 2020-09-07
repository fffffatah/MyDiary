using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDiary
{
    public partial class Login : Form
    {
        int otp;
        public Login()
        {
            InitializeComponent();
        }

        private void SetSignupButtonStatus()
        {
            signupButton.Enabled = (signupFnameTextBox.Text != "" || signupFnameTextBox.Visible == false) && (signupLnameTextBox.Text != "" || signupLnameTextBox.Visible == false) && (signupPhoneTextBox.Text != "" || signupPhoneTextBox.Visible == false) && (signupPassTextBox.Text != "" || signupPassTextBox.Visible == false) && (signupCpassTextBox.Text != "" || signupCpassTextBox.Visible == false) && (agreementCheckbox.Checked || agreementCheckbox.Visible == false) && !(signupPhoneTextBox.Text.Length < 11);
            agreementCheckbox.Enabled = (signupFnameTextBox.Text != "" || signupFnameTextBox.Visible == false) && (signupLnameTextBox.Text != "" || signupLnameTextBox.Visible == false) && (signupPhoneTextBox.Text != "" || signupPhoneTextBox.Visible == false) && (signupPassTextBox.Text != "" || signupPassTextBox.Visible == false) && (signupCpassTextBox.Text != "" || signupCpassTextBox.Visible == false) && !(signupPhoneTextBox.Text.Length < 11);
        }

        private void SetSigninButtonStatus()
        {
            loginButton.Enabled = (loginPassTextBox.Text != "" || loginPassTextBox.Visible == false) && !(loginPhoneTextBox.Text.Length < 11);
        }

        private void SetSubmitButtonStatus()
        {
            submitButton.Enabled = !(otpTextBox.Text.Length < 6);
        }

        private int GenerateOtp()
        {
            return new Random().Next(0, 999999);
        }

        private void signupFnameTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSignupButtonStatus();
        }

        private void signupLnameTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSignupButtonStatus();
        }

        private void signupPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSignupButtonStatus();
        }

        private void signupPassTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSignupButtonStatus();
        }

        private void signupCpassTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSignupButtonStatus();
        }

        private void agreementCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            signupButton.Enabled = agreementCheckbox.Checked;
        }

        private void agreementLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/fffffatah");
        }

        private bool ComparePasswordBoxes()
        {
            return signupPassTextBox.Text.Equals(signupCpassTextBox.Text);
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            if (ComparePasswordBoxes())
            {
                signupGroupBox.Enabled = false;
                otpGroupBox.Visible = true;
                otp = GenerateOtp();
                new OtpSender().Send(otp, signupPhoneTextBox.Text);
            }
            else
            {
                MessageBox.Show("Password and Confirm Password must be same!", "Error");
            }
        }

        private void signupPhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void loginPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSigninButtonStatus();
        }

        private void loginPhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void loginPassTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSigninButtonStatus();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            //TO-DO
        }

        private void otpTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSubmitButtonStatus();
        }

        private void otpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            if (otpTextBox.Text.Equals(otp.ToString()))
            {
                //TO-DO
            }
            else
            {
                //TO-DO
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            otpGroupBox.Visible = false;
            signupGroupBox.Enabled = true;
        }
    }
}
