namespace MyDiary
{
    partial class ViewEvent
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
            this.viewTextTextBox = new System.Windows.Forms.TextBox();
            this.dateCreatedLabel = new System.Windows.Forms.Label();
            this.dateModifiedLabel = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.viewTitleTextBox = new System.Windows.Forms.TextBox();
            this.viewPicPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewPicPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // viewTextTextBox
            // 
            this.viewTextTextBox.Location = new System.Drawing.Point(12, 248);
            this.viewTextTextBox.Multiline = true;
            this.viewTextTextBox.Name = "viewTextTextBox";
            this.viewTextTextBox.ReadOnly = true;
            this.viewTextTextBox.Size = new System.Drawing.Size(830, 387);
            this.viewTextTextBox.TabIndex = 0;
            // 
            // dateCreatedLabel
            // 
            this.dateCreatedLabel.AutoSize = true;
            this.dateCreatedLabel.Location = new System.Drawing.Point(616, 21);
            this.dateCreatedLabel.Name = "dateCreatedLabel";
            this.dateCreatedLabel.Size = new System.Drawing.Size(100, 17);
            this.dateCreatedLabel.TabIndex = 1;
            this.dateCreatedLabel.Text = "Date Created: ";
            // 
            // dateModifiedLabel
            // 
            this.dateModifiedLabel.AutoSize = true;
            this.dateModifiedLabel.Location = new System.Drawing.Point(613, 59);
            this.dateModifiedLabel.Name = "dateModifiedLabel";
            this.dateModifiedLabel.Size = new System.Drawing.Size(103, 17);
            this.dateModifiedLabel.TabIndex = 2;
            this.dateModifiedLabel.Text = "Date Modified: ";
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(656, 97);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(60, 17);
            this.priorityLabel.TabIndex = 3;
            this.priorityLabel.Text = "Priority: ";
            // 
            // viewTitleTextBox
            // 
            this.viewTitleTextBox.Location = new System.Drawing.Point(13, 186);
            this.viewTitleTextBox.Multiline = true;
            this.viewTitleTextBox.Name = "viewTitleTextBox";
            this.viewTitleTextBox.ReadOnly = true;
            this.viewTitleTextBox.Size = new System.Drawing.Size(829, 56);
            this.viewTitleTextBox.TabIndex = 4;
            // 
            // viewPicPictureBox
            // 
            this.viewPicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewPicPictureBox.Location = new System.Drawing.Point(12, 13);
            this.viewPicPictureBox.Name = "viewPicPictureBox";
            this.viewPicPictureBox.Size = new System.Drawing.Size(220, 167);
            this.viewPicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewPicPictureBox.TabIndex = 5;
            this.viewPicPictureBox.TabStop = false;
            // 
            // ViewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 647);
            this.Controls.Add(this.viewPicPictureBox);
            this.Controls.Add(this.viewTitleTextBox);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.dateModifiedLabel);
            this.Controls.Add(this.dateCreatedLabel);
            this.Controls.Add(this.viewTextTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewEvent";
            this.Text = "ViewEvent";
            ((System.ComponentModel.ISupportInitialize)(this.viewPicPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox viewTextTextBox;
        private System.Windows.Forms.Label dateCreatedLabel;
        private System.Windows.Forms.Label dateModifiedLabel;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.TextBox viewTitleTextBox;
        private System.Windows.Forms.PictureBox viewPicPictureBox;
    }
}