namespace TodoBus.Views.Units
{
    partial class RepuestosAsociados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepuestosAsociados));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.cmbAssignedSpares = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnAssignedSpares = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtAssignedSpares = new Bunifu.Framework.UI.BunifuTextbox();
            this.dgvAssignedSpares = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picSpareImage = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCategory = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblBrand = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnVolver = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblCode = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNotImage = new System.Windows.Forms.Label();
            this.txtDescription = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedSpares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpareImage)).BeginInit();
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
            this.header.Controls.Add(this.btnExit);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1026, 34);
            this.header.TabIndex = 6;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(918, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(37, 28);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(959, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbAssignedSpares
            // 
            this.cmbAssignedSpares.BackColor = System.Drawing.Color.Transparent;
            this.cmbAssignedSpares.BorderRadius = 3;
            this.cmbAssignedSpares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbAssignedSpares.DisabledColor = System.Drawing.Color.Gray;
            this.cmbAssignedSpares.ForeColor = System.Drawing.Color.White;
            this.cmbAssignedSpares.Items = new string[] {
        "Código",
        "Nombre",
        "Marca",
        "Categoría"};
            this.cmbAssignedSpares.Location = new System.Drawing.Point(305, 121);
            this.cmbAssignedSpares.Name = "cmbAssignedSpares";
            this.cmbAssignedSpares.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.cmbAssignedSpares.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.cmbAssignedSpares.selectedIndex = -1;
            this.cmbAssignedSpares.Size = new System.Drawing.Size(163, 35);
            this.cmbAssignedSpares.TabIndex = 51;
            // 
            // btnAssignedSpares
            // 
            this.btnAssignedSpares.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnAssignedSpares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnAssignedSpares.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAssignedSpares.BorderRadius = 5;
            this.btnAssignedSpares.ButtonText = "       Buscar";
            this.btnAssignedSpares.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignedSpares.DisabledColor = System.Drawing.Color.Gray;
            this.btnAssignedSpares.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignedSpares.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAssignedSpares.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAssignedSpares.Iconimage")));
            this.btnAssignedSpares.Iconimage_right = null;
            this.btnAssignedSpares.Iconimage_right_Selected = null;
            this.btnAssignedSpares.Iconimage_Selected = null;
            this.btnAssignedSpares.IconMarginLeft = 25;
            this.btnAssignedSpares.IconMarginRight = 0;
            this.btnAssignedSpares.IconRightVisible = false;
            this.btnAssignedSpares.IconRightZoom = 0D;
            this.btnAssignedSpares.IconVisible = false;
            this.btnAssignedSpares.IconZoom = 60D;
            this.btnAssignedSpares.IsTab = false;
            this.btnAssignedSpares.Location = new System.Drawing.Point(488, 121);
            this.btnAssignedSpares.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAssignedSpares.Name = "btnAssignedSpares";
            this.btnAssignedSpares.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnAssignedSpares.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnAssignedSpares.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnAssignedSpares.selected = false;
            this.btnAssignedSpares.Size = new System.Drawing.Size(89, 35);
            this.btnAssignedSpares.TabIndex = 50;
            this.btnAssignedSpares.Text = "       Buscar";
            this.btnAssignedSpares.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignedSpares.Textcolor = System.Drawing.Color.White;
            this.btnAssignedSpares.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtAssignedSpares
            // 
            this.txtAssignedSpares.BackColor = System.Drawing.Color.White;
            this.txtAssignedSpares.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAssignedSpares.BackgroundImage")));
            this.txtAssignedSpares.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtAssignedSpares.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAssignedSpares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtAssignedSpares.Icon = ((System.Drawing.Image)(resources.GetObject("txtAssignedSpares.Icon")));
            this.txtAssignedSpares.Location = new System.Drawing.Point(59, 121);
            this.txtAssignedSpares.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAssignedSpares.Name = "txtAssignedSpares";
            this.txtAssignedSpares.Size = new System.Drawing.Size(231, 35);
            this.txtAssignedSpares.TabIndex = 49;
            this.txtAssignedSpares.text = "";
            // 
            // dgvAssignedSpares
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAssignedSpares.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAssignedSpares.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.dgvAssignedSpares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssignedSpares.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignedSpares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAssignedSpares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedSpares.DoubleBuffered = true;
            this.dgvAssignedSpares.EnableHeadersVisualStyles = false;
            this.dgvAssignedSpares.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(197)))));
            this.dgvAssignedSpares.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.dgvAssignedSpares.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvAssignedSpares.Location = new System.Drawing.Point(32, 177);
            this.dgvAssignedSpares.Name = "dgvAssignedSpares";
            this.dgvAssignedSpares.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAssignedSpares.Size = new System.Drawing.Size(575, 440);
            this.dgvAssignedSpares.TabIndex = 48;
            this.dgvAssignedSpares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignedSpares_CellClick);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(171, 62);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(257, 37);
            this.bunifuCustomLabel3.TabIndex = 52;
            this.bunifuCustomLabel3.Text = "Repuestos asociados";
            // 
            // picSpareImage
            // 
            this.picSpareImage.Location = new System.Drawing.Point(660, 112);
            this.picSpareImage.Name = "picSpareImage";
            this.picSpareImage.Size = new System.Drawing.Size(336, 252);
            this.picSpareImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpareImage.TabIndex = 53;
            this.picSpareImage.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(671, 62);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(314, 37);
            this.bunifuCustomLabel1.TabIndex = 54;
            this.bunifuCustomLabel1.Text = "Información del Repuesto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(657, 379);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 15);
            this.lblNombre.TabIndex = 55;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCategory.Location = new System.Drawing.Point(657, 441);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(60, 15);
            this.lblCategory.TabIndex = 56;
            this.lblCategory.Text = "Categoría:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBrand.Location = new System.Drawing.Point(657, 476);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(41, 15);
            this.lblBrand.TabIndex = 58;
            this.lblBrand.Text = "Marca:";
            // 
            // btnVolver
            // 
            this.btnVolver.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.BorderRadius = 5;
            this.btnVolver.ButtonText = "              Cerrar";
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.DisabledColor = System.Drawing.Color.Gray;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVolver.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVolver.Iconimage")));
            this.btnVolver.Iconimage_right = null;
            this.btnVolver.Iconimage_right_Selected = null;
            this.btnVolver.Iconimage_Selected = null;
            this.btnVolver.IconMarginLeft = 25;
            this.btnVolver.IconMarginRight = 0;
            this.btnVolver.IconRightVisible = false;
            this.btnVolver.IconRightZoom = 0D;
            this.btnVolver.IconVisible = false;
            this.btnVolver.IconZoom = 60D;
            this.btnVolver.IsTab = false;
            this.btnVolver.Location = new System.Drawing.Point(868, 622);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnVolver.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnVolver.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnVolver.selected = false;
            this.btnVolver.Size = new System.Drawing.Size(128, 36);
            this.btnVolver.TabIndex = 74;
            this.btnVolver.Text = "              Cerrar";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Textcolor = System.Drawing.Color.White;
            this.btnVolver.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCode.Location = new System.Drawing.Point(657, 411);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(48, 15);
            this.lblCode.TabIndex = 75;
            this.lblCode.Text = "Código:";
            // 
            // lblNotImage
            // 
            this.lblNotImage.AutoSize = true;
            this.lblNotImage.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.lblNotImage.ForeColor = System.Drawing.Color.White;
            this.lblNotImage.Location = new System.Drawing.Point(707, 177);
            this.lblNotImage.Name = "lblNotImage";
            this.lblNotImage.Size = new System.Drawing.Size(237, 19);
            this.lblNotImage.TabIndex = 76;
            this.lblNotImage.Text = "El repuesto no tiene imagen insertada";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtDescription.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.txtDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.txtDescription.Location = new System.Drawing.Point(656, 509);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(325, 90);
            this.txtDescription.TabIndex = 77;
            this.txtDescription.Text = "Descripción:";
            // 
            // RepuestosAsociados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1026, 675);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblNotImage);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.picSpareImage);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.cmbAssignedSpares);
            this.Controls.Add(this.btnAssignedSpares);
            this.Controls.Add(this.txtAssignedSpares);
            this.Controls.Add(this.dgvAssignedSpares);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RepuestosAsociados";
            this.Text = "RepuestosAsociados";
            this.Load += new System.EventHandler(this.RepuestosAsociados_Load);
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedSpares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpareImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuDropdown cmbAssignedSpares;
        private Bunifu.Framework.UI.BunifuFlatButton btnAssignedSpares;
        private Bunifu.Framework.UI.BunifuTextbox txtAssignedSpares;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAssignedSpares;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox picSpareImage;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBrand;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCategory;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNombre;
        private Bunifu.Framework.UI.BunifuFlatButton btnVolver;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCode;
        private System.Windows.Forms.Label lblNotImage;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtDescription;
    }
}