﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoBus.Views.SpareCategoriesSubClasses
{
    public partial class RegSubClase : Form
    {
        public RegSubClase()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SubClasses frmC = new SubClasses();
            frmC.Show();
            this.Hide();
        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
