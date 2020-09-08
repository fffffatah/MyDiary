﻿using System;
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
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void Landing_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataAccessLib.OpenConnectionOnStart.Close();
            this.Dispose();
            Application.Exit();
            Environment.Exit(0);
        }
    }
}
