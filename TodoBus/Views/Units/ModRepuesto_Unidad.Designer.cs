namespace TodoBus.Views.Units
{
    partial class ModRepuesto_Unidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModRepuesto_Unidad));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgvAssignedSpares = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgvAvailableSpares = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedSpares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableSpares)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Controls.Add(this.btnExit);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(983, 34);
            this.header.TabIndex = 5;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(910, 3);
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
            this.btnExit.Location = new System.Drawing.Point(943, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvAssignedSpares
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAssignedSpares.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAssignedSpares.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.dgvAssignedSpares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssignedSpares.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignedSpares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAssignedSpares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedSpares.DoubleBuffered = true;
            this.dgvAssignedSpares.EnableHeadersVisualStyles = false;
            this.dgvAssignedSpares.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(197)))));
            this.dgvAssignedSpares.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.dgvAssignedSpares.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvAssignedSpares.Location = new System.Drawing.Point(509, 124);
            this.dgvAssignedSpares.Name = "dgvAssignedSpares";
            this.dgvAssignedSpares.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAssignedSpares.Size = new System.Drawing.Size(458, 446);
            this.dgvAssignedSpares.TabIndex = 35;
            // 
            // dgvAvailableSpares
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAvailableSpares.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAvailableSpares.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.dgvAvailableSpares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAvailableSpares.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvailableSpares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAvailableSpares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableSpares.DoubleBuffered = true;
            this.dgvAvailableSpares.EnableHeadersVisualStyles = false;
            this.dgvAvailableSpares.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(197)))));
            this.dgvAvailableSpares.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.dgvAvailableSpares.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvAvailableSpares.Location = new System.Drawing.Point(17, 124);
            this.dgvAvailableSpares.Name = "dgvAvailableSpares";
            this.dgvAvailableSpares.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAvailableSpares.Size = new System.Drawing.Size(458, 446);
            this.dgvAvailableSpares.TabIndex = 36;
            // 
            // btnBack
            // 
            this.btnBack.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.BorderRadius = 5;
            this.btnBack.ButtonText = "Cerrar";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBack.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBack.Iconimage")));
            this.btnBack.Iconimage_right = null;
            this.btnBack.Iconimage_right_Selected = null;
            this.btnBack.Iconimage_Selected = null;
            this.btnBack.IconMarginLeft = 25;
            this.btnBack.IconMarginRight = 0;
            this.btnBack.IconRightVisible = false;
            this.btnBack.IconRightZoom = 0D;
            this.btnBack.IconVisible = false;
            this.btnBack.IconZoom = 60D;
            this.btnBack.IsTab = false;
            this.btnBack.Location = new System.Drawing.Point(12, 601);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnBack.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(128, 36);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Cerrar";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.Textcolor = System.Drawing.Color.White;
            this.btnBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(393, 47);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(208, 30);
            this.bunifuCustomLabel1.TabIndex = 39;
            this.bunifuCustomLabel1.Text = "Modificar Repuestos";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(148, 95);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(159, 20);
            this.bunifuCustomLabel2.TabIndex = 40;
            this.bunifuCustomLabel2.Text = "Repuestos disponibles";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(674, 95);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(148, 20);
            this.bunifuCustomLabel3.TabIndex = 41;
            this.bunifuCustomLabel3.Text = "Repuestos asociados";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // ModRepuesto_Unidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(983, 650);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvAvailableSpares);
            this.Controls.Add(this.dgvAssignedSpares);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModRepuesto_Unidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModRepuesto_Unidad";
            this.Load += new System.EventHandler(this.ModRepuesto_Unidad_Load);
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedSpares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableSpares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAssignedSpares;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAvailableSpares;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}