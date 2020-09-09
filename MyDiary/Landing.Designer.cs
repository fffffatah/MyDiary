namespace MyDiary
{
    partial class Landing
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
            this.components = new System.ComponentModel.Container();
            this.eventsGroupBox = new System.Windows.Forms.GroupBox();
            this.eventDataGridView = new System.Windows.Forms.DataGridView();
            this.newEventGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.imageGroupBox = new System.Windows.Forms.GroupBox();
            this.clearPicButton = new System.Windows.Forms.Button();
            this.tpicPictureBox = new System.Windows.Forms.PictureBox();
            this.spicPictureBox = new System.Windows.Forms.PictureBox();
            this.fpicPictureBox = new System.Windows.Forms.PictureBox();
            this.eventGridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEventGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelEditButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.editTextTextBox = new System.Windows.Forms.TextBox();
            this.editTitleTextBox = new System.Windows.Forms.TextBox();
            this.editPicGroupBox = new System.Windows.Forms.GroupBox();
            this.editPicClearButton = new System.Windows.Forms.Button();
            this.etpicPictureBox = new System.Windows.Forms.PictureBox();
            this.espicPictureBox = new System.Windows.Forms.PictureBox();
            this.efpicPictureBox = new System.Windows.Forms.PictureBox();
            this.logOutButton = new System.Windows.Forms.Button();
            this.eventsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataGridView)).BeginInit();
            this.newEventGroupBox.SuspendLayout();
            this.imageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tpicPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spicPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpicPictureBox)).BeginInit();
            this.eventGridContextMenu.SuspendLayout();
            this.editEventGroupBox.SuspendLayout();
            this.editPicGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etpicPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espicPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.efpicPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // eventsGroupBox
            // 
            this.eventsGroupBox.Controls.Add(this.eventDataGridView);
            this.eventsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.eventsGroupBox.Name = "eventsGroupBox";
            this.eventsGroupBox.Size = new System.Drawing.Size(647, 610);
            this.eventsGroupBox.TabIndex = 0;
            this.eventsGroupBox.TabStop = false;
            this.eventsGroupBox.Text = "Events";
            // 
            // eventDataGridView
            // 
            this.eventDataGridView.AllowUserToAddRows = false;
            this.eventDataGridView.AllowUserToDeleteRows = false;
            this.eventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventDataGridView.Location = new System.Drawing.Point(6, 21);
            this.eventDataGridView.Name = "eventDataGridView";
            this.eventDataGridView.ReadOnly = true;
            this.eventDataGridView.RowHeadersWidth = 51;
            this.eventDataGridView.RowTemplate.Height = 24;
            this.eventDataGridView.Size = new System.Drawing.Size(635, 583);
            this.eventDataGridView.TabIndex = 0;
            // 
            // newEventGroupBox
            // 
            this.newEventGroupBox.Controls.Add(this.saveButton);
            this.newEventGroupBox.Controls.Add(this.editEventGroupBox);
            this.newEventGroupBox.Controls.Add(this.textTextBox);
            this.newEventGroupBox.Controls.Add(this.titleTextBox);
            this.newEventGroupBox.Controls.Add(this.imageGroupBox);
            this.newEventGroupBox.Location = new System.Drawing.Point(665, 12);
            this.newEventGroupBox.Name = "newEventGroupBox";
            this.newEventGroupBox.Size = new System.Drawing.Size(454, 548);
            this.newEventGroupBox.TabIndex = 1;
            this.newEventGroupBox.TabStop = false;
            this.newEventGroupBox.Text = "New Event";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(373, 508);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 35);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(7, 157);
            this.textTextBox.Multiline = true;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(441, 345);
            this.textTextBox.TabIndex = 2;
            this.textTextBox.Text = "Details of Your Event";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(7, 128);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(441, 22);
            this.titleTextBox.TabIndex = 1;
            this.titleTextBox.Text = "Title of Your Event";
            // 
            // imageGroupBox
            // 
            this.imageGroupBox.Controls.Add(this.clearPicButton);
            this.imageGroupBox.Controls.Add(this.tpicPictureBox);
            this.imageGroupBox.Controls.Add(this.spicPictureBox);
            this.imageGroupBox.Controls.Add(this.fpicPictureBox);
            this.imageGroupBox.Location = new System.Drawing.Point(7, 22);
            this.imageGroupBox.Name = "imageGroupBox";
            this.imageGroupBox.Size = new System.Drawing.Size(441, 100);
            this.imageGroupBox.TabIndex = 0;
            this.imageGroupBox.TabStop = false;
            this.imageGroupBox.Text = "Images";
            // 
            // clearPicButton
            // 
            this.clearPicButton.Location = new System.Drawing.Point(325, 38);
            this.clearPicButton.Name = "clearPicButton";
            this.clearPicButton.Size = new System.Drawing.Size(110, 39);
            this.clearPicButton.TabIndex = 3;
            this.clearPicButton.Text = "Clear";
            this.clearPicButton.UseVisualStyleBackColor = true;
            this.clearPicButton.Click += new System.EventHandler(this.clearPicButton_Click);
            // 
            // tpicPictureBox
            // 
            this.tpicPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpicPictureBox.Location = new System.Drawing.Point(218, 21);
            this.tpicPictureBox.Name = "tpicPictureBox";
            this.tpicPictureBox.Size = new System.Drawing.Size(100, 73);
            this.tpicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tpicPictureBox.TabIndex = 2;
            this.tpicPictureBox.TabStop = false;
            this.tpicPictureBox.Click += new System.EventHandler(this.tpicPictureBox_Click);
            // 
            // spicPictureBox
            // 
            this.spicPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spicPictureBox.Location = new System.Drawing.Point(112, 21);
            this.spicPictureBox.Name = "spicPictureBox";
            this.spicPictureBox.Size = new System.Drawing.Size(100, 73);
            this.spicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spicPictureBox.TabIndex = 1;
            this.spicPictureBox.TabStop = false;
            this.spicPictureBox.Click += new System.EventHandler(this.spicPictureBox_Click);
            // 
            // fpicPictureBox
            // 
            this.fpicPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fpicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpicPictureBox.Location = new System.Drawing.Point(6, 21);
            this.fpicPictureBox.Name = "fpicPictureBox";
            this.fpicPictureBox.Size = new System.Drawing.Size(100, 73);
            this.fpicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fpicPictureBox.TabIndex = 0;
            this.fpicPictureBox.TabStop = false;
            this.fpicPictureBox.Click += new System.EventHandler(this.fpicPictureBox_Click);
            // 
            // eventGridContextMenu
            // 
            this.eventGridContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.eventGridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editEventToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.eventGridContextMenu.Name = "eventGridContextMenu";
            this.eventGridContextMenu.Size = new System.Drawing.Size(145, 52);
            // 
            // editEventToolStripMenuItem
            // 
            this.editEventToolStripMenuItem.Name = "editEventToolStripMenuItem";
            this.editEventToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.editEventToolStripMenuItem.Text = "Edit Event";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // editEventGroupBox
            // 
            this.editEventGroupBox.Controls.Add(this.cancelEditButton);
            this.editEventGroupBox.Controls.Add(this.updateButton);
            this.editEventGroupBox.Controls.Add(this.editTextTextBox);
            this.editEventGroupBox.Controls.Add(this.editTitleTextBox);
            this.editEventGroupBox.Controls.Add(this.editPicGroupBox);
            this.editEventGroupBox.Location = new System.Drawing.Point(0, 0);
            this.editEventGroupBox.Name = "editEventGroupBox";
            this.editEventGroupBox.Size = new System.Drawing.Size(454, 548);
            this.editEventGroupBox.TabIndex = 4;
            this.editEventGroupBox.TabStop = false;
            this.editEventGroupBox.Text = "Edit Event";
            this.editEventGroupBox.Visible = false;
            // 
            // cancelEditButton
            // 
            this.cancelEditButton.Location = new System.Drawing.Point(292, 508);
            this.cancelEditButton.Name = "cancelEditButton";
            this.cancelEditButton.Size = new System.Drawing.Size(75, 35);
            this.cancelEditButton.TabIndex = 5;
            this.cancelEditButton.Text = "Cancel";
            this.cancelEditButton.UseVisualStyleBackColor = true;
            this.cancelEditButton.Click += new System.EventHandler(this.cancelEditButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(373, 508);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 35);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // editTextTextBox
            // 
            this.editTextTextBox.Location = new System.Drawing.Point(7, 157);
            this.editTextTextBox.Multiline = true;
            this.editTextTextBox.Name = "editTextTextBox";
            this.editTextTextBox.Size = new System.Drawing.Size(441, 345);
            this.editTextTextBox.TabIndex = 2;
            // 
            // editTitleTextBox
            // 
            this.editTitleTextBox.Location = new System.Drawing.Point(7, 128);
            this.editTitleTextBox.Name = "editTitleTextBox";
            this.editTitleTextBox.Size = new System.Drawing.Size(441, 22);
            this.editTitleTextBox.TabIndex = 1;
            // 
            // editPicGroupBox
            // 
            this.editPicGroupBox.Controls.Add(this.editPicClearButton);
            this.editPicGroupBox.Controls.Add(this.etpicPictureBox);
            this.editPicGroupBox.Controls.Add(this.espicPictureBox);
            this.editPicGroupBox.Controls.Add(this.efpicPictureBox);
            this.editPicGroupBox.Location = new System.Drawing.Point(7, 22);
            this.editPicGroupBox.Name = "editPicGroupBox";
            this.editPicGroupBox.Size = new System.Drawing.Size(441, 100);
            this.editPicGroupBox.TabIndex = 0;
            this.editPicGroupBox.TabStop = false;
            this.editPicGroupBox.Text = "Images";
            // 
            // editPicClearButton
            // 
            this.editPicClearButton.Location = new System.Drawing.Point(325, 38);
            this.editPicClearButton.Name = "editPicClearButton";
            this.editPicClearButton.Size = new System.Drawing.Size(110, 39);
            this.editPicClearButton.TabIndex = 3;
            this.editPicClearButton.Text = "Clear";
            this.editPicClearButton.UseVisualStyleBackColor = true;
            this.editPicClearButton.Click += new System.EventHandler(this.editPicClearButton_Click);
            // 
            // etpicPictureBox
            // 
            this.etpicPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.etpicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.etpicPictureBox.Location = new System.Drawing.Point(218, 21);
            this.etpicPictureBox.Name = "etpicPictureBox";
            this.etpicPictureBox.Size = new System.Drawing.Size(100, 73);
            this.etpicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.etpicPictureBox.TabIndex = 2;
            this.etpicPictureBox.TabStop = false;
            this.etpicPictureBox.Click += new System.EventHandler(this.etpicPictureBox_Click);
            // 
            // espicPictureBox
            // 
            this.espicPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.espicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.espicPictureBox.Location = new System.Drawing.Point(112, 21);
            this.espicPictureBox.Name = "espicPictureBox";
            this.espicPictureBox.Size = new System.Drawing.Size(100, 73);
            this.espicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.espicPictureBox.TabIndex = 1;
            this.espicPictureBox.TabStop = false;
            this.espicPictureBox.Click += new System.EventHandler(this.espicPictureBox_Click);
            // 
            // efpicPictureBox
            // 
            this.efpicPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.efpicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.efpicPictureBox.Location = new System.Drawing.Point(6, 21);
            this.efpicPictureBox.Name = "efpicPictureBox";
            this.efpicPictureBox.Size = new System.Drawing.Size(100, 73);
            this.efpicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.efpicPictureBox.TabIndex = 0;
            this.efpicPictureBox.TabStop = false;
            this.efpicPictureBox.Click += new System.EventHandler(this.efpicPictureBox_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.DeepPink;
            this.logOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(851, 576);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(105, 40);
            this.logOutButton.TabIndex = 5;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 634);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.newEventGroupBox);
            this.Controls.Add(this.eventsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Landing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyDiary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Landing_FormClosed);
            this.eventsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventDataGridView)).EndInit();
            this.newEventGroupBox.ResumeLayout(false);
            this.newEventGroupBox.PerformLayout();
            this.imageGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tpicPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spicPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpicPictureBox)).EndInit();
            this.eventGridContextMenu.ResumeLayout(false);
            this.editEventGroupBox.ResumeLayout(false);
            this.editEventGroupBox.PerformLayout();
            this.editPicGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.etpicPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espicPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.efpicPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox eventsGroupBox;
        private System.Windows.Forms.DataGridView eventDataGridView;
        private System.Windows.Forms.GroupBox newEventGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.GroupBox imageGroupBox;
        private System.Windows.Forms.Button clearPicButton;
        private System.Windows.Forms.PictureBox tpicPictureBox;
        private System.Windows.Forms.PictureBox spicPictureBox;
        private System.Windows.Forms.PictureBox fpicPictureBox;
        private System.Windows.Forms.ContextMenuStrip eventGridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.GroupBox editEventGroupBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox editTextTextBox;
        private System.Windows.Forms.TextBox editTitleTextBox;
        private System.Windows.Forms.GroupBox editPicGroupBox;
        private System.Windows.Forms.Button editPicClearButton;
        private System.Windows.Forms.PictureBox etpicPictureBox;
        private System.Windows.Forms.PictureBox espicPictureBox;
        private System.Windows.Forms.PictureBox efpicPictureBox;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button cancelEditButton;
    }
}