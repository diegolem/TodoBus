﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoBus.Views.Spare
{
    public partial class Imagen : Form
    {
        public Imagen(string url)
        {
            InitializeComponent();
            Image.Load(url);
            Image.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
