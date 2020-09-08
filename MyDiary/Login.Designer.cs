namespace MyDiary
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.signupGroupBox = new System.Windows.Forms.GroupBox();
            this.signupCpassTextBox = new System.Windows.Forms.TextBox();
            this.signupPassTextBox = new System.Windows.Forms.TextBox();
            this.signupPhoneTextBox = new System.Windows.Forms.TextBox();
            this.signupFnameTextBox = new System.Windows.Forms.TextBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.agreementLinkLabel = new System.Windows.Forms.LinkLabel();
            this.agreementCheckbox = new System.Windows.Forms.CheckBox();
            this.cpassLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPhoneTextBox = new System.Windows.Forms.TextBox();
            this.loginPassTextBox = new System.Windows.Forms.TextBox();
            this.loginPassLabel = new System.Windows.Forms.Label();
            this.loginPhoneLabel = new System.Windows.Forms.Label();
            this.signupLnameTextBox = new System.Windows.Forms.TextBox();
            this.otpGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.otpTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signupGroupBox.SuspendLayout();
            this.loginGroupBox.SuspendLayout();
            this.otpGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // signupGroupBox
            // 
            this.signupGroupBox.Controls.Add(this.signupCpassTextBox);
            this.signupGroupBox.Controls.Add(this.signupPassTextBox);
            this.signupGroupBox.Controls.Add(this.signupPhoneTextBox);
            this.signupGroupBox.Controls.Add(this.signupFnameTextBox);
            this.signupGroupBox.Controls.Add(this.signupButton);
            this.signupGroupBox.Controls.Add(this.agreementLinkLabel);
            this.signupGroupBox.Controls.Add(this.agreementCheckbox);
            this.signupGroupBox.Controls.Add(this.cpassLabel);
            this.signupGroupBox.Controls.Add(this.passLabel);
            this.signupGroupBox.Controls.Add(this.phoneLabel);
            this.signupGroupBox.Controls.Add(this.lnameLabel);
            this.signupGroupBox.Controls.Add(this.fnameLabel);
            this.signupGroupBox.Location = new System.Drawing.Point(44, 27);
            this.signupGroupBox.Name = "signupGroupBox";
            this.signupGroupBox.Size = new System.Drawing.Size(433, 362);
            this.signupGroupBox.TabIndex = 0;
            this.signupGroupBox.TabStop = false;
            this.signupGroupBox.Text = "Signup";
            // 
            // signupCpassTextBox
            // 
            this.signupCpassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupCpassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupCpassTextBox.Location = new System.Drawing.Point(160, 226);
            this.signupCpassTextBox.Name = "signupCpassTextBox";
            this.signupCpassTextBox.PasswordChar = '*';
            this.signupCpassTextBox.Size = new System.Drawing.Size(235, 23);
            this.signupCpassTextBox.TabIndex = 17;
            this.signupCpassTextBox.TextChanged += new System.EventHandler(this.signupCpassTextBox_TextChanged);
            // 
            // signupPassTextBox
            // 
            this.signupPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupPassTextBox.Location = new System.Drawing.Point(160, 177);
            this.signupPassTextBox.Name = "signupPassTextBox";
            this.signupPassTextBox.PasswordChar = '*';
            this.signupPassTextBox.Size = new System.Drawing.Size(235, 23);
            this.signupPassTextBox.TabIndex = 16;
            this.signupPassTextBox.TextChanged += new System.EventHandler(this.signupPassTextBox_TextChanged);
            // 
            // signupPhoneTextBox
            // 
            this.signupPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupPhoneTextBox.Location = new System.Drawing.Point(160, 129);
            this.signupPhoneTextBox.MaxLength = 11;
            this.signupPhoneTextBox.Name = "signupPhoneTextBox";
            this.signupPhoneTextBox.Size = new System.Drawing.Size(235, 23);
            this.signupPhoneTextBox.TabIndex = 15;
            this.signupPhoneTextBox.TextChanged += new System.EventHandler(this.signupPhoneTextBox_TextChanged);
            this.signupPhoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.signupPhoneTextBox_KeyPress);
            // 
            // signupFnameTextBox
            // 
            this.signupFnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupFnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupFnameTextBox.Location = new System.Drawing.Point(160, 34);
            this.signupFnameTextBox.Name = "signupFnameTextBox";
            this.signupFnameTextBox.Size = new System.Drawing.Size(235, 23);
            this.signupFnameTextBox.TabIndex = 14;
            this.signupFnameTextBox.TextChanged += new System.EventHandler(this.signupFnameTextBox_TextChanged);
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.SpringGreen;
            this.signupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupButton.Enabled = false;
            this.signupButton.FlatAppearance.BorderSize = 0;
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.ForeColor = System.Drawing.Color.White;
            this.signupButton.Location = new System.Drawing.Point(139, 306);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(131, 41);
            this.signupButton.TabIndex = 13;
            this.signupButton.Text = "Sign Up";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // agreementLinkLabel
            // 
            this.agreementLinkLabel.AutoSize = true;
            this.agreementLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.agreementLinkLabel.LinkColor = System.Drawing.Color.Magenta;
            this.agreementLinkLabel.Location = new System.Drawing.Point(109, 272);
            this.agreementLinkLabel.Name = "agreementLinkLabel";
            this.agreementLinkLabel.Size = new System.Drawing.Size(234, 17);
            this.agreementLinkLabel.TabIndex = 12;
            this.agreementLinkLabel.TabStop = true;
            this.agreementLinkLabel.Text = "I agree to the Terms and Conditions";
            this.agreementLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.agreementLinkLabel_LinkClicked);
            // 
            // agreementCheckbox
            // 
            this.agreementCheckbox.AutoSize = true;
            this.agreementCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.agreementCheckbox.Enabled = false;
            this.agreementCheckbox.Location = new System.Drawing.Point(85, 272);
            this.agreementCheckbox.Name = "agreementCheckbox";
            this.agreementCheckbox.Size = new System.Drawing.Size(18, 17);
            this.agreementCheckbox.TabIndex = 11;
            this.agreementCheckbox.UseVisualStyleBackColor = false;
            this.agreementCheckbox.CheckedChanged += new System.EventHandler(this.agreementCheckbox_CheckedChanged);
            // 
            // cpassLabel
            // 
            this.cpassLabel.AutoSize = true;
            this.cpassLabel.Location = new System.Drawing.Point(23, 228);
            this.cpassLabel.Name = "cpassLabel";
            this.cpassLabel.Size = new System.Drawing.Size(121, 17);
            this.cpassLabel.TabIndex = 4;
            this.cpassLabel.Text = "Confirm Password";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(75, 179);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(69, 17);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Password";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(41, 131);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(103, 17);
            this.phoneLabel.TabIndex = 2;
            this.phoneLabel.Text = "Phone Number";
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Location = new System.Drawing.Point(68, 84);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(76, 17);
            this.lnameLabel.TabIndex = 1;
            this.lnameLabel.Text = "Last Name";
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Location = new System.Drawing.Point(68, 36);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(76, 17);
            this.fnameLabel.TabIndex = 0;
            this.fnameLabel.Text = "First Name";
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.loginButton);
            this.loginGroupBox.Controls.Add(this.loginPhoneTextBox);
            this.loginGroupBox.Controls.Add(this.loginPassTextBox);
            this.loginGroupBox.Controls.Add(this.loginPassLabel);
            this.loginGroupBox.Controls.Add(this.loginPhoneLabel);
            this.loginGroupBox.Location = new System.Drawing.Point(660, 27);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(425, 362);
            this.loginGroupBox.TabIndex = 1;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "Login";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Enabled = false;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(167, 306);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(114, 41);
            this.loginButton.TabIndex = 19;
            this.loginButton.Text = "Sign In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPhoneTextBox
            // 
            this.loginPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPhoneTextBox.Location = new System.Drawing.Point(156, 34);
            this.loginPhoneTextBox.MaxLength = 11;
            this.loginPhoneTextBox.Name = "loginPhoneTextBox";
            this.loginPhoneTextBox.Size = new System.Drawing.Size(235, 23);
            this.loginPhoneTextBox.TabIndex = 18;
            this.loginPhoneTextBox.TextChanged += new System.EventHandler(this.loginPhoneTextBox_TextChanged);
            this.loginPhoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginPhoneTextBox_KeyPress);
            // 
            // loginPassTextBox
            // 
            this.loginPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPassTextBox.Location = new System.Drawing.Point(156, 82);
            this.loginPassTextBox.Name = "loginPassTextBox";
            this.loginPassTextBox.PasswordChar = '*';
            this.loginPassTextBox.Size = new System.Drawing.Size(235, 23);
            this.loginPassTextBox.TabIndex = 5;
            this.loginPassTextBox.TextChanged += new System.EventHandler(this.loginPassTextBox_TextChanged);
            // 
            // loginPassLabel
            // 
            this.loginPassLabel.AutoSize = true;
            this.loginPassLabel.Location = new System.Drawing.Point(66, 84);
            this.loginPassLabel.Name = "loginPassLabel";
            this.loginPassLabel.Size = new System.Drawing.Size(69, 17);
            this.loginPassLabel.TabIndex = 4;
            this.loginPassLabel.Text = "Password";
            // 
            // loginPhoneLabel
            // 
            this.loginPhoneLabel.AutoSize = true;
            this.loginPhoneLabel.Location = new System.Drawing.Point(32, 36);
            this.loginPhoneLabel.Name = "loginPhoneLabel";
            this.loginPhoneLabel.Size = new System.Drawing.Size(103, 17);
            this.loginPhoneLabel.TabIndex = 3;
            this.loginPhoneLabel.Text = "Phone Number";
            // 
            // signupLnameTextBox
            // 
            this.signupLnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupLnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupLnameTextBox.Location = new System.Drawing.Point(204, 109);
            this.signupLnameTextBox.Name = "signupLnameTextBox";
            this.signupLnameTextBox.Size = new System.Drawing.Size(235, 23);
            this.signupLnameTextBox.TabIndex = 15;
            this.signupLnameTextBox.TextChanged += new System.EventHandler(this.signupLnameTextBox_TextChanged);
            // 
            // otpGroupBox
            // 
            this.otpGroupBox.Controls.Add(this.cancelButton);
            this.otpGroupBox.Controls.Add(this.submitButton);
            this.otpGroupBox.Controls.Add(this.otpTextBox);
            this.otpGroupBox.Controls.Add(this.label1);
            this.otpGroupBox.Location = new System.Drawing.Point(44, 443);
            this.otpGroupBox.Name = "otpGroupBox";
            this.otpGroupBox.Size = new System.Drawing.Size(433, 122);
            this.otpGroupBox.TabIndex = 16;
            this.otpGroupBox.TabStop = false;
            this.otpGroupBox.Text = "Verification";
            this.otpGroupBox.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DeepPink;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(320, 62);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 32);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.SpringGreen;
            this.submitButton.Enabled = false;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(216, 62);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 32);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // otpTextBox
            // 
            this.otpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otpTextBox.Location = new System.Drawing.Point(71, 65);
            this.otpTextBox.MaxLength = 6;
            this.otpTextBox.Name = "otpTextBox";
            this.otpTextBox.Size = new System.Drawing.Size(124, 26);
            this.otpTextBox.TabIndex = 1;
            this.otpTextBox.TextChanged += new System.EventHandler(this.otpTextBox_TextChanged);
            this.otpTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.otpTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter the OTP Sent to Your Phone Number";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 634);
            this.Controls.Add(this.otpGroupBox);
            this.Controls.Add(this.signupLnameTextBox);
            this.Controls.Add(this.loginGroupBox);
            this.Controls.Add(this.signupGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyDiary - Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.signupGroupBox.ResumeLayout(false);
            this.signupGroupBox.PerformLayout();
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.otpGroupBox.ResumeLayout(false);
            this.otpGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox signupGroupBox;
        private System.Windows.Forms.TextBox signupCpassTextBox;
        private System.Windows.Forms.TextBox signupPassTextBox;
        private System.Windows.Forms.TextBox signupPhoneTextBox;
        private System.Windows.Forms.TextBox signupFnameTextBox;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.LinkLabel agreementLinkLabel;
        private System.Windows.Forms.CheckBox agreementCheckbox;
        private System.Windows.Forms.Label cpassLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.TextBox signupLnameTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginPhoneTextBox;
        private System.Windows.Forms.TextBox loginPassTextBox;
        private System.Windows.Forms.Label loginPassLabel;
        private System.Windows.Forms.Label loginPhoneLabel;
        private System.Windows.Forms.GroupBox otpGroupBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox otpTextBox;
        private System.Windows.Forms.Label label1;
    }
}

