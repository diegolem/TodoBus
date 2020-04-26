namespace TodoBus.Views.Login
{
    partial class NuevaContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaContraseña));
            this.logoLetras = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Checkbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtContraseña = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnEnvNewContra = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.logoLetras)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // logoLetras
            // 
            this.logoLetras.Image = global::TodoBus.Properties.Resources.logopng;
            this.logoLetras.Location = new System.Drawing.Point(0, 35);
            this.logoLetras.Name = "logoLetras";
            this.logoLetras.Size = new System.Drawing.Size(635, 105);
            this.logoLetras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoLetras.TabIndex = 19;
            this.logoLetras.TabStop = false;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Controls.Add(this.bunifuImageButton1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(637, 32);
            this.header.TabIndex = 18;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(564, 1);
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
            this.bunifuImageButton1.Location = new System.Drawing.Point(597, 1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 28);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 181);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(118, 17);
            this.bunifuCustomLabel1.TabIndex = 31;
            this.bunifuCustomLabel1.Text = "Nueva Contraseña:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(478, 178);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(138, 20);
            this.bunifuCustomLabel5.TabIndex = 63;
            this.bunifuCustomLabel5.Text = "Mostrar Contraseña";
            // 
            // Checkbox1
            // 
            this.Checkbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox1.Checked = false;
            this.Checkbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Checkbox1.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.Checkbox1.ForeColor = System.Drawing.Color.White;
            this.Checkbox1.Location = new System.Drawing.Point(452, 175);
            this.Checkbox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Checkbox1.Name = "Checkbox1";
            this.Checkbox1.Size = new System.Drawing.Size(20, 20);
            this.Checkbox1.TabIndex = 62;
            this.Checkbox1.OnChange += new System.EventHandler(this.Checkbox1_OnChange);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.txtContraseña.Location = new System.Drawing.Point(136, 171);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(309, 27);
            this.txtContraseña.TabIndex = 64;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // btnEnvNewContra
            // 
            this.btnEnvNewContra.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnEnvNewContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnEnvNewContra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnvNewContra.BorderRadius = 5;
            this.btnEnvNewContra.ButtonText = "Confirmar";
            this.btnEnvNewContra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnvNewContra.DisabledColor = System.Drawing.Color.Gray;
            this.btnEnvNewContra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvNewContra.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEnvNewContra.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEnvNewContra.Iconimage")));
            this.btnEnvNewContra.Iconimage_right = null;
            this.btnEnvNewContra.Iconimage_right_Selected = null;
            this.btnEnvNewContra.Iconimage_Selected = null;
            this.btnEnvNewContra.IconMarginLeft = 25;
            this.btnEnvNewContra.IconMarginRight = 0;
            this.btnEnvNewContra.IconRightVisible = false;
            this.btnEnvNewContra.IconRightZoom = 0D;
            this.btnEnvNewContra.IconVisible = false;
            this.btnEnvNewContra.IconZoom = 60D;
            this.btnEnvNewContra.IsTab = false;
            this.btnEnvNewContra.Location = new System.Drawing.Point(245, 245);
            this.btnEnvNewContra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnvNewContra.Name = "btnEnvNewContra";
            this.btnEnvNewContra.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnEnvNewContra.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnEnvNewContra.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnEnvNewContra.selected = false;
            this.btnEnvNewContra.Size = new System.Drawing.Size(101, 33);
            this.btnEnvNewContra.TabIndex = 65;
            this.btnEnvNewContra.Text = "Confirmar";
            this.btnEnvNewContra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnvNewContra.Textcolor = System.Drawing.Color.White;
            this.btnEnvNewContra.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvNewContra.Click += new System.EventHandler(this.btnEnvNewContra_Click);
            // 
            // NuevaContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(637, 342);
            this.Controls.Add(this.btnEnvNewContra);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.Checkbox1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.logoLetras);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevaContraseña";
            this.Text = "NuevaContraseña";
            this.Load += new System.EventHandler(this.NuevaContraseña_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoLetras)).EndInit();
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoLetras;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCheckbox Checkbox1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtContraseña;
        private Bunifu.Framework.UI.BunifuFlatButton btnEnvNewContra;
    }
}