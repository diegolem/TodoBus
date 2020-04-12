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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgvAssignedSpares = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgvAvailableSpares = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnAssignedSpares = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtAssignedSpares = new Bunifu.Framework.UI.BunifuTextbox();
            this.cmbAssignedSpares = new Bunifu.Framework.UI.BunifuDropdown();
            this.cmbAvailableSpares = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnAvailableSpares = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtAvailableSpares = new Bunifu.Framework.UI.BunifuTextbox();
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
            this.header.Size = new System.Drawing.Size(1206, 34);
            this.header.TabIndex = 5;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1114, 3);
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
            this.btnExit.Location = new System.Drawing.Point(1155, 3);
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
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAssignedSpares.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvAssignedSpares.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.dgvAssignedSpares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssignedSpares.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignedSpares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvAssignedSpares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedSpares.DoubleBuffered = true;
            this.dgvAssignedSpares.EnableHeadersVisualStyles = false;
            this.dgvAssignedSpares.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(197)))));
            this.dgvAssignedSpares.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.dgvAssignedSpares.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvAssignedSpares.Location = new System.Drawing.Point(617, 183);
            this.dgvAssignedSpares.Name = "dgvAssignedSpares";
            this.dgvAssignedSpares.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAssignedSpares.Size = new System.Drawing.Size(575, 440);
            this.dgvAssignedSpares.TabIndex = 35;
            this.dgvAssignedSpares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignedSpares_CellClick);
            // 
            // dgvAvailableSpares
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAvailableSpares.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvAvailableSpares.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.dgvAvailableSpares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAvailableSpares.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvailableSpares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvAvailableSpares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableSpares.DoubleBuffered = true;
            this.dgvAvailableSpares.EnableHeadersVisualStyles = false;
            this.dgvAvailableSpares.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(197)))));
            this.dgvAvailableSpares.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.dgvAvailableSpares.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvAvailableSpares.Location = new System.Drawing.Point(17, 183);
            this.dgvAvailableSpares.Name = "dgvAvailableSpares";
            this.dgvAvailableSpares.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAvailableSpares.Size = new System.Drawing.Size(575, 440);
            this.dgvAvailableSpares.TabIndex = 36;
            this.dgvAvailableSpares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvailableSpares_CellClick);
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
            this.btnBack.Location = new System.Drawing.Point(541, 644);
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
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(151, 60);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(273, 37);
            this.bunifuCustomLabel2.TabIndex = 40;
            this.bunifuCustomLabel2.Text = "Repuestos disponibles";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(770, 60);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(257, 37);
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
            this.btnAssignedSpares.Location = new System.Drawing.Point(1073, 127);
            this.btnAssignedSpares.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAssignedSpares.Name = "btnAssignedSpares";
            this.btnAssignedSpares.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnAssignedSpares.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnAssignedSpares.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnAssignedSpares.selected = false;
            this.btnAssignedSpares.Size = new System.Drawing.Size(89, 35);
            this.btnAssignedSpares.TabIndex = 46;
            this.btnAssignedSpares.Text = "       Buscar";
            this.btnAssignedSpares.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignedSpares.Textcolor = System.Drawing.Color.White;
            this.btnAssignedSpares.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtAssignedSpares
            // 
            this.txtAssignedSpares.BackColor = System.Drawing.Color.White;
            this.txtAssignedSpares.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtAssignedSpares.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAssignedSpares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtAssignedSpares.Icon = ((System.Drawing.Image)(resources.GetObject("txtAssignedSpares.Icon")));
            this.txtAssignedSpares.Location = new System.Drawing.Point(644, 127);
            this.txtAssignedSpares.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAssignedSpares.Name = "txtAssignedSpares";
            this.txtAssignedSpares.Size = new System.Drawing.Size(231, 35);
            this.txtAssignedSpares.TabIndex = 45;
            this.txtAssignedSpares.text = "";
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
            this.cmbAssignedSpares.Location = new System.Drawing.Point(890, 127);
            this.cmbAssignedSpares.Name = "cmbAssignedSpares";
            this.cmbAssignedSpares.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.cmbAssignedSpares.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.cmbAssignedSpares.selectedIndex = -1;
            this.cmbAssignedSpares.Size = new System.Drawing.Size(163, 35);
            this.cmbAssignedSpares.TabIndex = 47;
            // 
            // cmbAvailableSpares
            // 
            this.cmbAvailableSpares.BackColor = System.Drawing.Color.Transparent;
            this.cmbAvailableSpares.BorderRadius = 3;
            this.cmbAvailableSpares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbAvailableSpares.DisabledColor = System.Drawing.Color.Gray;
            this.cmbAvailableSpares.ForeColor = System.Drawing.Color.White;
            this.cmbAvailableSpares.Items = new string[] {
        "Código",
        "Nombre",
        "Marca",
        "Categoría"};
            this.cmbAvailableSpares.Location = new System.Drawing.Point(294, 127);
            this.cmbAvailableSpares.Name = "cmbAvailableSpares";
            this.cmbAvailableSpares.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.cmbAvailableSpares.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.cmbAvailableSpares.selectedIndex = -1;
            this.cmbAvailableSpares.Size = new System.Drawing.Size(163, 35);
            this.cmbAvailableSpares.TabIndex = 50;
            // 
            // btnAvailableSpares
            // 
            this.btnAvailableSpares.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnAvailableSpares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnAvailableSpares.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAvailableSpares.BorderRadius = 5;
            this.btnAvailableSpares.ButtonText = "       Buscar";
            this.btnAvailableSpares.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvailableSpares.DisabledColor = System.Drawing.Color.Gray;
            this.btnAvailableSpares.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailableSpares.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAvailableSpares.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAvailableSpares.Iconimage")));
            this.btnAvailableSpares.Iconimage_right = null;
            this.btnAvailableSpares.Iconimage_right_Selected = null;
            this.btnAvailableSpares.Iconimage_Selected = null;
            this.btnAvailableSpares.IconMarginLeft = 25;
            this.btnAvailableSpares.IconMarginRight = 0;
            this.btnAvailableSpares.IconRightVisible = false;
            this.btnAvailableSpares.IconRightZoom = 0D;
            this.btnAvailableSpares.IconVisible = false;
            this.btnAvailableSpares.IconZoom = 60D;
            this.btnAvailableSpares.IsTab = false;
            this.btnAvailableSpares.Location = new System.Drawing.Point(477, 127);
            this.btnAvailableSpares.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAvailableSpares.Name = "btnAvailableSpares";
            this.btnAvailableSpares.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnAvailableSpares.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnAvailableSpares.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnAvailableSpares.selected = false;
            this.btnAvailableSpares.Size = new System.Drawing.Size(89, 35);
            this.btnAvailableSpares.TabIndex = 49;
            this.btnAvailableSpares.Text = "       Buscar";
            this.btnAvailableSpares.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvailableSpares.Textcolor = System.Drawing.Color.White;
            this.btnAvailableSpares.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtAvailableSpares
            // 
            this.txtAvailableSpares.BackColor = System.Drawing.Color.White;
            this.txtAvailableSpares.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtAvailableSpares.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAvailableSpares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtAvailableSpares.Icon = ((System.Drawing.Image)(resources.GetObject("txtAvailableSpares.Icon")));
            this.txtAvailableSpares.Location = new System.Drawing.Point(48, 127);
            this.txtAvailableSpares.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAvailableSpares.Name = "txtAvailableSpares";
            this.txtAvailableSpares.Size = new System.Drawing.Size(231, 35);
            this.txtAvailableSpares.TabIndex = 48;
            this.txtAvailableSpares.text = "";
            // 
            // ModRepuesto_Unidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1206, 700);
            this.Controls.Add(this.cmbAvailableSpares);
            this.Controls.Add(this.btnAvailableSpares);
            this.Controls.Add(this.txtAvailableSpares);
            this.Controls.Add(this.cmbAssignedSpares);
            this.Controls.Add(this.btnAssignedSpares);
            this.Controls.Add(this.txtAssignedSpares);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
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
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAssignedSpares;
        private Bunifu.Framework.UI.BunifuTextbox txtAssignedSpares;
        private Bunifu.Framework.UI.BunifuDropdown cmbAssignedSpares;
        private Bunifu.Framework.UI.BunifuDropdown cmbAvailableSpares;
        private Bunifu.Framework.UI.BunifuFlatButton btnAvailableSpares;
        private Bunifu.Framework.UI.BunifuTextbox txtAvailableSpares;
    }
}