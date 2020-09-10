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
    public partial class Login : Form
    {
        int otp;
        string dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MyDiary\Images";
        public Login()
        {
            InitializeComponent();
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
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
            UserDataAccess userDataAccess = new UserDataAccess();
            User user = new User();
            user = userDataAccess.GetUser(loginPhoneTextBox.Text, loginPassTextBox.Text);
            if(user.FirstName.Length > 0)
            {
                this.Hide();
                var Landing = new Landing(user);
                Landing.Closed += (s, args) => this.Close();
                Landing.Show();
            }
            else
            {
                MessageBox.Show("Account Not Found!\nPlease Re-Check Phone Number or Password", "Error");
            }
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
                otpGroupBox.Visible = false;
                signupGroupBox.Enabled = true;
                User user = new User();
                user.FirstName = signupFnameTextBox.Text;
                user.LastName = signupLnameTextBox.Text;
                user.Password = signupPassTextBox.Text;
                user.PhoneNumber = signupPhoneTextBox.Text;
                UserDataAccess userDataAccess = new UserDataAccess();
                if (userDataAccess.DoesPhoneNumberExists(signupPhoneTextBox.Text))
                {
                    MessageBox.Show("An Account Associated with this Phone Number Already Exists!\nTry Logging In","Error");
                }
                else
                {
                    if (userDataAccess.CreateUser(user))
                    {
                        MessageBox.Show("Account Creation Successful!\nPlease Log In.","Successful");
                    }
                    else
                    {
                        MessageBox.Show("Account Creation Failed!\nPlease Check Your Internet Connection!", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Account Creation Failed!\nPlease Input Valid OTP!", "Error");
            }
            signupGroupBox.Enabled = true;
            otpGroupBox.Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            otpGroupBox.Visible = false;
            signupGroupBox.Enabled = true;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
