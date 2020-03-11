﻿namespace TodoBus.Views.Brands
{
    partial class RegistroMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroMarca));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.body = new System.Windows.Forms.Panel();
            this.txtName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtUnitDescription = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtDescription = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnReturn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRegSub = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.header.SuspendLayout();
            this.body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Controls.Add(this.bunifuImageButton1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(388, 32);
            this.header.TabIndex = 46;
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.body.Controls.Add(this.txtUnitDescription);
            this.body.Controls.Add(this.txtDescription);
            this.body.Controls.Add(this.btnReturn);
            this.body.Controls.Add(this.btnRegSub);
            this.body.Controls.Add(this.txtName);
            this.body.Controls.Add(this.bunifuCustomLabel2);
            this.body.Controls.Add(this.bunifuCustomLabel1);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(0, 32);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(388, 406);
            this.body.TabIndex = 47;
            this.body.Paint += new System.Windows.Forms.PaintEventHandler(this.body_Paint);
            // 
            // txtName
            // 
            this.txtName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtName.Location = new System.Drawing.Point(136, 90);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 20);
            this.txtName.TabIndex = 66;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(41, 90);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(60, 17);
            this.bunifuCustomLabel2.TabIndex = 64;
            this.bunifuCustomLabel2.Text = "Nombre:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(118, 24);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(163, 30);
            this.bunifuCustomLabel1.TabIndex = 63;
            this.bunifuCustomLabel1.Text = "Registrar Marca";
            // 
            // txtUnitDescription
            // 
            this.txtUnitDescription.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtUnitDescription.Location = new System.Drawing.Point(136, 138);
            this.txtUnitDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnitDescription.Multiline = true;
            this.txtUnitDescription.Name = "txtUnitDescription";
            this.txtUnitDescription.Size = new System.Drawing.Size(202, 103);
            this.txtUnitDescription.TabIndex = 71;
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(41, 138);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(79, 17);
            this.txtDescription.TabIndex = 70;
            this.txtDescription.Text = "Descripción:";
            // 
            // btnReturn
            // 
            this.btnReturn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.BorderRadius = 5;
            this.btnReturn.ButtonText = "              Volver";
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.DisabledColor = System.Drawing.Color.Gray;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReturn.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReturn.Iconimage")));
            this.btnReturn.Iconimage_right = null;
            this.btnReturn.Iconimage_right_Selected = null;
            this.btnReturn.Iconimage_Selected = null;
            this.btnReturn.IconMarginLeft = 25;
            this.btnReturn.IconMarginRight = 0;
            this.btnReturn.IconRightVisible = false;
            this.btnReturn.IconRightZoom = 0D;
            this.btnReturn.IconVisible = false;
            this.btnReturn.IconZoom = 60D;
            this.btnReturn.IsTab = false;
            this.btnReturn.Location = new System.Drawing.Point(12, 334);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnReturn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnReturn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnReturn.selected = false;
            this.btnReturn.Size = new System.Drawing.Size(128, 36);
            this.btnReturn.TabIndex = 69;
            this.btnReturn.Text = "              Volver";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Textcolor = System.Drawing.Color.White;
            this.btnReturn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRegSub
            // 
            this.btnRegSub.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnRegSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnRegSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegSub.BorderRadius = 5;
            this.btnRegSub.ButtonText = "    Registrar";
            this.btnRegSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegSub.DisabledColor = System.Drawing.Color.Gray;
            this.btnRegSub.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegSub.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegSub.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRegSub.Iconimage")));
            this.btnRegSub.Iconimage_right = null;
            this.btnRegSub.Iconimage_right_Selected = null;
            this.btnRegSub.Iconimage_Selected = null;
            this.btnRegSub.IconMarginLeft = 25;
            this.btnRegSub.IconMarginRight = 0;
            this.btnRegSub.IconRightVisible = false;
            this.btnRegSub.IconRightZoom = 0D;
            this.btnRegSub.IconVisible = false;
            this.btnRegSub.IconZoom = 60D;
            this.btnRegSub.IsTab = false;
            this.btnRegSub.Location = new System.Drawing.Point(136, 262);
            this.btnRegSub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegSub.Name = "btnRegSub";
            this.btnRegSub.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnRegSub.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnRegSub.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnRegSub.selected = false;
            this.btnRegSub.Size = new System.Drawing.Size(85, 36);
            this.btnRegSub.TabIndex = 68;
            this.btnRegSub.Text = "    Registrar";
            this.btnRegSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegSub.Textcolor = System.Drawing.Color.White;
            this.btnRegSub.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(301, 2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(37, 28);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(343, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 28);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // RegistroMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 438);
            this.Controls.Add(this.body);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroMarca";
            this.Text = "RegistroMarca";
            this.header.ResumeLayout(false);
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel body;
        private Bunifu.Framework.UI.BunifuFlatButton btnReturn;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegSub;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtUnitDescription;
        private Bunifu.Framework.UI.BunifuCustomLabel txtDescription;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}