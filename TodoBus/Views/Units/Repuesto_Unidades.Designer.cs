namespace TodoBus.Views.Units
{
    partial class Repuesto_Unidades
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repuesto_Unidades));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.Options = new System.Windows.Forms.Panel();
            this.btnSpareCategoriesSubClasses = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSpareSubCategories = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAssociateSpare = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUserConfig = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUsers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnSpareTypes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBrands = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClients = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSpare = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUnits = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvSpareUnit = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpareUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Controls.Add(this.btnExit);
            this.PanelTransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(940, 34);
            this.header.TabIndex = 5;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.PanelTransition.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(858, 3);
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
            this.PanelTransition.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(891, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Options
            // 
            this.Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.Options.Controls.Add(this.btnSpareCategoriesSubClasses);
            this.Options.Controls.Add(this.btnSpareSubCategories);
            this.Options.Controls.Add(this.btnLogOut);
            this.Options.Controls.Add(this.btnAssociateSpare);
            this.Options.Controls.Add(this.btnUserConfig);
            this.Options.Controls.Add(this.btnUsers);
            this.Options.Controls.Add(this.logo);
            this.Options.Controls.Add(this.btnSpareTypes);
            this.Options.Controls.Add(this.btnBrands);
            this.Options.Controls.Add(this.btnClients);
            this.Options.Controls.Add(this.btnSpare);
            this.Options.Controls.Add(this.btnUnits);
            this.Options.Controls.Add(this.btnMenu);
            this.PanelTransition.SetDecoration(this.Options, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.Options, BunifuAnimatorNS.DecorationType.None);
            this.Options.Location = new System.Drawing.Point(0, 34);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(200, 673);
            this.Options.TabIndex = 6;
            // 
            // btnSpareCategoriesSubClasses
            // 
            this.btnSpareCategoriesSubClasses.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSpareCategoriesSubClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnSpareCategoriesSubClasses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpareCategoriesSubClasses.BorderRadius = 0;
            this.btnSpareCategoriesSubClasses.ButtonText = "   Subclases";
            this.btnSpareCategoriesSubClasses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnSpareCategoriesSubClasses, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnSpareCategoriesSubClasses, BunifuAnimatorNS.DecorationType.None);
            this.btnSpareCategoriesSubClasses.DisabledColor = System.Drawing.Color.Gray;
            this.btnSpareCategoriesSubClasses.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSpareCategoriesSubClasses.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSpareCategoriesSubClasses.Iconimage")));
            this.btnSpareCategoriesSubClasses.Iconimage_right = null;
            this.btnSpareCategoriesSubClasses.Iconimage_right_Selected = null;
            this.btnSpareCategoriesSubClasses.Iconimage_Selected = null;
            this.btnSpareCategoriesSubClasses.IconMarginLeft = 0;
            this.btnSpareCategoriesSubClasses.IconMarginRight = 0;
            this.btnSpareCategoriesSubClasses.IconRightVisible = true;
            this.btnSpareCategoriesSubClasses.IconRightZoom = 0D;
            this.btnSpareCategoriesSubClasses.IconVisible = true;
            this.btnSpareCategoriesSubClasses.IconZoom = 60D;
            this.btnSpareCategoriesSubClasses.IsTab = false;
            this.btnSpareCategoriesSubClasses.Location = new System.Drawing.Point(1, 421);
            this.btnSpareCategoriesSubClasses.Name = "btnSpareCategoriesSubClasses";
            this.btnSpareCategoriesSubClasses.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnSpareCategoriesSubClasses.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSpareCategoriesSubClasses.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSpareCategoriesSubClasses.selected = false;
            this.btnSpareCategoriesSubClasses.Size = new System.Drawing.Size(199, 48);
            this.btnSpareCategoriesSubClasses.TabIndex = 34;
            this.btnSpareCategoriesSubClasses.Text = "   Subclases";
            this.btnSpareCategoriesSubClasses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpareCategoriesSubClasses.Textcolor = System.Drawing.Color.White;
            this.btnSpareCategoriesSubClasses.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpareCategoriesSubClasses.Click += new System.EventHandler(this.btnSpareCategoriesSubClasses_Click);
            // 
            // btnSpareSubCategories
            // 
            this.btnSpareSubCategories.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSpareSubCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnSpareSubCategories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpareSubCategories.BorderRadius = 0;
            this.btnSpareSubCategories.ButtonText = "   Subcategorías";
            this.btnSpareSubCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnSpareSubCategories, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnSpareSubCategories, BunifuAnimatorNS.DecorationType.None);
            this.btnSpareSubCategories.DisabledColor = System.Drawing.Color.Gray;
            this.btnSpareSubCategories.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSpareSubCategories.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSpareSubCategories.Iconimage")));
            this.btnSpareSubCategories.Iconimage_right = null;
            this.btnSpareSubCategories.Iconimage_right_Selected = null;
            this.btnSpareSubCategories.Iconimage_Selected = null;
            this.btnSpareSubCategories.IconMarginLeft = 0;
            this.btnSpareSubCategories.IconMarginRight = 0;
            this.btnSpareSubCategories.IconRightVisible = true;
            this.btnSpareSubCategories.IconRightZoom = 0D;
            this.btnSpareSubCategories.IconVisible = true;
            this.btnSpareSubCategories.IconZoom = 60D;
            this.btnSpareSubCategories.IsTab = false;
            this.btnSpareSubCategories.Location = new System.Drawing.Point(1, 374);
            this.btnSpareSubCategories.Name = "btnSpareSubCategories";
            this.btnSpareSubCategories.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnSpareSubCategories.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSpareSubCategories.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSpareSubCategories.selected = false;
            this.btnSpareSubCategories.Size = new System.Drawing.Size(199, 48);
            this.btnSpareSubCategories.TabIndex = 40;
            this.btnSpareSubCategories.Text = "   Subcategorías";
            this.btnSpareSubCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpareSubCategories.Textcolor = System.Drawing.Color.White;
            this.btnSpareSubCategories.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpareSubCategories.Click += new System.EventHandler(this.btnSpareSubCategories_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.BorderRadius = 0;
            this.btnLogOut.ButtonText = "   Cerrar Sesión";
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnLogOut, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnLogOut, BunifuAnimatorNS.DecorationType.None);
            this.btnLogOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Iconimage")));
            this.btnLogOut.Iconimage_right = null;
            this.btnLogOut.Iconimage_right_Selected = null;
            this.btnLogOut.Iconimage_Selected = null;
            this.btnLogOut.IconMarginLeft = 0;
            this.btnLogOut.IconMarginRight = 0;
            this.btnLogOut.IconRightVisible = true;
            this.btnLogOut.IconRightZoom = 0D;
            this.btnLogOut.IconVisible = true;
            this.btnLogOut.IconZoom = 60D;
            this.btnLogOut.IsTab = false;
            this.btnLogOut.Location = new System.Drawing.Point(1, 609);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnLogOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLogOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogOut.selected = false;
            this.btnLogOut.Size = new System.Drawing.Size(199, 48);
            this.btnLogOut.TabIndex = 39;
            this.btnLogOut.Text = "   Cerrar Sesión";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Textcolor = System.Drawing.Color.White;
            this.btnLogOut.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAssociateSpare
            // 
            this.btnAssociateSpare.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAssociateSpare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnAssociateSpare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAssociateSpare.BorderRadius = 0;
            this.btnAssociateSpare.ButtonText = "   Asociar Repuesto";
            this.btnAssociateSpare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnAssociateSpare, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnAssociateSpare, BunifuAnimatorNS.DecorationType.None);
            this.btnAssociateSpare.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.btnAssociateSpare.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAssociateSpare.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAssociateSpare.Iconimage")));
            this.btnAssociateSpare.Iconimage_right = null;
            this.btnAssociateSpare.Iconimage_right_Selected = null;
            this.btnAssociateSpare.Iconimage_Selected = null;
            this.btnAssociateSpare.IconMarginLeft = 0;
            this.btnAssociateSpare.IconMarginRight = 0;
            this.btnAssociateSpare.IconRightVisible = true;
            this.btnAssociateSpare.IconRightZoom = 0D;
            this.btnAssociateSpare.IconVisible = true;
            this.btnAssociateSpare.IconZoom = 60D;
            this.btnAssociateSpare.IsTab = false;
            this.btnAssociateSpare.Location = new System.Drawing.Point(1, 562);
            this.btnAssociateSpare.Name = "btnAssociateSpare";
            this.btnAssociateSpare.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnAssociateSpare.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAssociateSpare.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAssociateSpare.selected = false;
            this.btnAssociateSpare.Size = new System.Drawing.Size(199, 48);
            this.btnAssociateSpare.TabIndex = 38;
            this.btnAssociateSpare.Text = "   Asociar Repuesto";
            this.btnAssociateSpare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssociateSpare.Textcolor = System.Drawing.Color.White;
            this.btnAssociateSpare.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnUserConfig
            // 
            this.btnUserConfig.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUserConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnUserConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserConfig.BorderRadius = 0;
            this.btnUserConfig.ButtonText = "   Configuración";
            this.btnUserConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnUserConfig, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnUserConfig, BunifuAnimatorNS.DecorationType.None);
            this.btnUserConfig.DisabledColor = System.Drawing.Color.Gray;
            this.btnUserConfig.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUserConfig.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUserConfig.Iconimage")));
            this.btnUserConfig.Iconimage_right = null;
            this.btnUserConfig.Iconimage_right_Selected = null;
            this.btnUserConfig.Iconimage_Selected = null;
            this.btnUserConfig.IconMarginLeft = 0;
            this.btnUserConfig.IconMarginRight = 0;
            this.btnUserConfig.IconRightVisible = true;
            this.btnUserConfig.IconRightZoom = 0D;
            this.btnUserConfig.IconVisible = true;
            this.btnUserConfig.IconZoom = 60D;
            this.btnUserConfig.IsTab = false;
            this.btnUserConfig.Location = new System.Drawing.Point(1, 515);
            this.btnUserConfig.Name = "btnUserConfig";
            this.btnUserConfig.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnUserConfig.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUserConfig.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUserConfig.selected = false;
            this.btnUserConfig.Size = new System.Drawing.Size(199, 48);
            this.btnUserConfig.TabIndex = 37;
            this.btnUserConfig.Text = "   Configuración";
            this.btnUserConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserConfig.Textcolor = System.Drawing.Color.White;
            this.btnUserConfig.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserConfig.Click += new System.EventHandler(this.btnUserConfig_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsers.BorderRadius = 0;
            this.btnUsers.ButtonText = "   Usuarios";
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnUsers, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnUsers, BunifuAnimatorNS.DecorationType.None);
            this.btnUsers.DisabledColor = System.Drawing.Color.Gray;
            this.btnUsers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUsers.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUsers.Iconimage")));
            this.btnUsers.Iconimage_right = null;
            this.btnUsers.Iconimage_right_Selected = null;
            this.btnUsers.Iconimage_Selected = null;
            this.btnUsers.IconMarginLeft = 0;
            this.btnUsers.IconMarginRight = 0;
            this.btnUsers.IconRightVisible = true;
            this.btnUsers.IconRightZoom = 0D;
            this.btnUsers.IconVisible = true;
            this.btnUsers.IconZoom = 60D;
            this.btnUsers.IsTab = false;
            this.btnUsers.Location = new System.Drawing.Point(1, 468);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnUsers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUsers.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUsers.selected = false;
            this.btnUsers.Size = new System.Drawing.Size(199, 48);
            this.btnUsers.TabIndex = 36;
            this.btnUsers.Text = "   Usuarios";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Textcolor = System.Drawing.Color.White;
            this.btnUsers.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // logo
            // 
            this.LogoTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 16);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(137, 100);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 35;
            this.logo.TabStop = false;
            // 
            // btnSpareTypes
            // 
            this.btnSpareTypes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSpareTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnSpareTypes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpareTypes.BorderRadius = 0;
            this.btnSpareTypes.ButtonText = "   Categorias";
            this.btnSpareTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnSpareTypes, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnSpareTypes, BunifuAnimatorNS.DecorationType.None);
            this.btnSpareTypes.DisabledColor = System.Drawing.Color.Gray;
            this.btnSpareTypes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSpareTypes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSpareTypes.Iconimage")));
            this.btnSpareTypes.Iconimage_right = null;
            this.btnSpareTypes.Iconimage_right_Selected = null;
            this.btnSpareTypes.Iconimage_Selected = null;
            this.btnSpareTypes.IconMarginLeft = 0;
            this.btnSpareTypes.IconMarginRight = 0;
            this.btnSpareTypes.IconRightVisible = true;
            this.btnSpareTypes.IconRightZoom = 0D;
            this.btnSpareTypes.IconVisible = true;
            this.btnSpareTypes.IconZoom = 60D;
            this.btnSpareTypes.IsTab = false;
            this.btnSpareTypes.Location = new System.Drawing.Point(1, 327);
            this.btnSpareTypes.Name = "btnSpareTypes";
            this.btnSpareTypes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnSpareTypes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSpareTypes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSpareTypes.selected = false;
            this.btnSpareTypes.Size = new System.Drawing.Size(199, 48);
            this.btnSpareTypes.TabIndex = 33;
            this.btnSpareTypes.Text = "   Categorias";
            this.btnSpareTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpareTypes.Textcolor = System.Drawing.Color.White;
            this.btnSpareTypes.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpareTypes.Click += new System.EventHandler(this.btnSpareTypes_Click);
            // 
            // btnBrands
            // 
            this.btnBrands.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBrands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnBrands.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrands.BorderRadius = 0;
            this.btnBrands.ButtonText = "   Marcas";
            this.btnBrands.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnBrands, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnBrands, BunifuAnimatorNS.DecorationType.None);
            this.btnBrands.DisabledColor = System.Drawing.Color.Gray;
            this.btnBrands.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBrands.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBrands.Iconimage")));
            this.btnBrands.Iconimage_right = null;
            this.btnBrands.Iconimage_right_Selected = null;
            this.btnBrands.Iconimage_Selected = null;
            this.btnBrands.IconMarginLeft = 0;
            this.btnBrands.IconMarginRight = 0;
            this.btnBrands.IconRightVisible = true;
            this.btnBrands.IconRightZoom = 0D;
            this.btnBrands.IconVisible = true;
            this.btnBrands.IconZoom = 60D;
            this.btnBrands.IsTab = false;
            this.btnBrands.Location = new System.Drawing.Point(1, 280);
            this.btnBrands.Name = "btnBrands";
            this.btnBrands.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnBrands.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBrands.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrands.selected = false;
            this.btnBrands.Size = new System.Drawing.Size(199, 48);
            this.btnBrands.TabIndex = 32;
            this.btnBrands.Text = "   Marcas";
            this.btnBrands.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrands.Textcolor = System.Drawing.Color.White;
            this.btnBrands.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrands.Click += new System.EventHandler(this.btnBrands_Click);
            // 
            // btnClients
            // 
            this.btnClients.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClients.BorderRadius = 0;
            this.btnClients.ButtonText = "   Clientes";
            this.btnClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnClients, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnClients, BunifuAnimatorNS.DecorationType.None);
            this.btnClients.DisabledColor = System.Drawing.Color.Gray;
            this.btnClients.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClients.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClients.Iconimage")));
            this.btnClients.Iconimage_right = null;
            this.btnClients.Iconimage_right_Selected = null;
            this.btnClients.Iconimage_Selected = null;
            this.btnClients.IconMarginLeft = 0;
            this.btnClients.IconMarginRight = 0;
            this.btnClients.IconRightVisible = true;
            this.btnClients.IconRightZoom = 0D;
            this.btnClients.IconVisible = true;
            this.btnClients.IconZoom = 60D;
            this.btnClients.IsTab = false;
            this.btnClients.Location = new System.Drawing.Point(1, 186);
            this.btnClients.Name = "btnClients";
            this.btnClients.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnClients.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnClients.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClients.selected = false;
            this.btnClients.Size = new System.Drawing.Size(199, 48);
            this.btnClients.TabIndex = 31;
            this.btnClients.Text = "   Clientes";
            this.btnClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.Textcolor = System.Drawing.Color.White;
            this.btnClients.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnSpare
            // 
            this.btnSpare.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSpare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnSpare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpare.BorderRadius = 0;
            this.btnSpare.ButtonText = "   Repuestos";
            this.btnSpare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnSpare, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnSpare, BunifuAnimatorNS.DecorationType.None);
            this.btnSpare.DisabledColor = System.Drawing.Color.Gray;
            this.btnSpare.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSpare.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSpare.Iconimage")));
            this.btnSpare.Iconimage_right = null;
            this.btnSpare.Iconimage_right_Selected = null;
            this.btnSpare.Iconimage_Selected = null;
            this.btnSpare.IconMarginLeft = 0;
            this.btnSpare.IconMarginRight = 0;
            this.btnSpare.IconRightVisible = true;
            this.btnSpare.IconRightZoom = 0D;
            this.btnSpare.IconVisible = true;
            this.btnSpare.IconZoom = 60D;
            this.btnSpare.IsTab = false;
            this.btnSpare.Location = new System.Drawing.Point(1, 233);
            this.btnSpare.Name = "btnSpare";
            this.btnSpare.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnSpare.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSpare.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSpare.selected = false;
            this.btnSpare.Size = new System.Drawing.Size(199, 48);
            this.btnSpare.TabIndex = 30;
            this.btnSpare.Text = "   Repuestos";
            this.btnSpare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpare.Textcolor = System.Drawing.Color.White;
            this.btnSpare.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpare.Click += new System.EventHandler(this.btnSpare_Click);
            // 
            // btnUnits
            // 
            this.btnUnits.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnUnits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnits.BorderRadius = 0;
            this.btnUnits.ButtonText = "   Unidades";
            this.btnUnits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnUnits, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnUnits, BunifuAnimatorNS.DecorationType.None);
            this.btnUnits.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.btnUnits.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUnits.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUnits.Iconimage")));
            this.btnUnits.Iconimage_right = null;
            this.btnUnits.Iconimage_right_Selected = null;
            this.btnUnits.Iconimage_Selected = null;
            this.btnUnits.IconMarginLeft = 0;
            this.btnUnits.IconMarginRight = 0;
            this.btnUnits.IconRightVisible = true;
            this.btnUnits.IconRightZoom = 0D;
            this.btnUnits.IconVisible = true;
            this.btnUnits.IconZoom = 60D;
            this.btnUnits.IsTab = false;
            this.btnUnits.Location = new System.Drawing.Point(1, 139);
            this.btnUnits.Name = "btnUnits";
            this.btnUnits.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnUnits.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUnits.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUnits.selected = false;
            this.btnUnits.Size = new System.Drawing.Size(199, 48);
            this.btnUnits.TabIndex = 29;
            this.btnUnits.Text = "   Unidades";
            this.btnUnits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnits.Textcolor = System.Drawing.Color.White;
            this.btnUnits.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnits.Click += new System.EventHandler(this.btnUnits_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.PanelTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(155, 42);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 28;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.LogoTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(435, 50);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(279, 30);
            this.bunifuCustomLabel1.TabIndex = 39;
            this.bunifuCustomLabel1.Text = "Asociar Respuesto a Unidad";
            // 
            // dgvSpareUnit
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSpareUnit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSpareUnit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.dgvSpareUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSpareUnit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSpareUnit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSpareUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogoTransition.SetDecoration(this.dgvSpareUnit, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.dgvSpareUnit, BunifuAnimatorNS.DecorationType.None);
            this.dgvSpareUnit.DoubleBuffered = true;
            this.dgvSpareUnit.EnableHeadersVisualStyles = false;
            this.dgvSpareUnit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(197)))));
            this.dgvSpareUnit.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.dgvSpareUnit.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvSpareUnit.Location = new System.Drawing.Point(246, 147);
            this.dgvSpareUnit.Name = "dgvSpareUnit";
            this.dgvSpareUnit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSpareUnit.Size = new System.Drawing.Size(649, 518);
            this.dgvSpareUnit.TabIndex = 42;
            this.dgvSpareUnit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpareUnit_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.ButtonText = "    Actualizar Registros";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnUpdate, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnUpdate, BunifuAnimatorNS.DecorationType.None);
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Iconimage")));
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 25;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = false;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = false;
            this.btnUpdate.IconZoom = 60D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(495, 107);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(151, 33);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "    Actualizar Registros";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoTransition.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0.5F;
            animation3.RotateLimit = 0.2F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.LogoTransition.DefaultAnimation = animation3;
            // 
            // PanelTransition
            // 
            this.PanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.PanelTransition.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 1;
            animation4.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 2F;
            animation4.TransparencyCoeff = 0F;
            this.PanelTransition.DefaultAnimation = animation4;
            // 
            // Repuesto_Unidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(940, 692);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvSpareUnit);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.header);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Repuesto_Unidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repuesto_Unidades";
            this.Load += new System.EventHandler(this.Repuesto_Unidades_Load);
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.Options.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpareUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private System.Windows.Forms.Panel Options;
        private Bunifu.Framework.UI.BunifuFlatButton btnSpareCategoriesSubClasses;
        private Bunifu.Framework.UI.BunifuFlatButton btnSpareSubCategories;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogOut;
        private Bunifu.Framework.UI.BunifuFlatButton btnAssociateSpare;
        private Bunifu.Framework.UI.BunifuFlatButton btnUserConfig;
        private Bunifu.Framework.UI.BunifuFlatButton btnUsers;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuFlatButton btnSpareTypes;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrands;
        private Bunifu.Framework.UI.BunifuFlatButton btnClients;
        private Bunifu.Framework.UI.BunifuFlatButton btnSpare;
        private Bunifu.Framework.UI.BunifuFlatButton btnUnits;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvSpareUnit;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
        private BunifuAnimatorNS.BunifuTransition PanelTransition;
    }
}