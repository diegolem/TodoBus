namespace TodoBus
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Options = new System.Windows.Forms.Panel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btn6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBrands = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClients = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSpare = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUnits = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblProyectName = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.header.Controls.Add(this.bunifuImageButton1);
            this.LogoTransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1132, 34);
            this.header.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.LogoTransition.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1092, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 28);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Options
            // 
            this.Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Options.Controls.Add(this.bunifuFlatButton3);
            this.Options.Controls.Add(this.bunifuFlatButton2);
            this.Options.Controls.Add(this.bunifuFlatButton1);
            this.Options.Controls.Add(this.logo);
            this.Options.Controls.Add(this.btn6);
            this.Options.Controls.Add(this.btnBrands);
            this.Options.Controls.Add(this.btnClients);
            this.Options.Controls.Add(this.btnSpare);
            this.Options.Controls.Add(this.btnUnits);
            this.Options.Controls.Add(this.btnHome);
            this.Options.Controls.Add(this.btnMenu);
            this.Options.Controls.Add(this.lblProyectName);
            this.LogoTransition.SetDecoration(this.Options, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Options, BunifuAnimatorNS.DecorationType.None);
            this.Options.Dock = System.Windows.Forms.DockStyle.Left;
            this.Options.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options.Location = new System.Drawing.Point(0, 34);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(200, 646);
            this.Options.TabIndex = 1;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "   Cerrar sesión";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 60D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(3, 537);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(198, 48);
            this.bunifuFlatButton3.TabIndex = 11;
            this.bunifuFlatButton3.Text = "   Cerrar sesión";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "   Configuración";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 60D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(3, 487);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(198, 48);
            this.bunifuFlatButton2.TabIndex = 10;
            this.bunifuFlatButton2.Text = "   Configuración";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "   Usuarios";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 60D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(1, 433);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(199, 48);
            this.bunifuFlatButton1.TabIndex = 9;
            this.bunifuFlatButton1.Text = "   Usuarios";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // logo
            // 
            this.PanelTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 32);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(44, 45);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // btn6
            // 
            this.btn6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn6.BorderRadius = 0;
            this.btn6.ButtonText = "   Tipos de repuesto";
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btn6, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btn6, BunifuAnimatorNS.DecorationType.None);
            this.btn6.DisabledColor = System.Drawing.Color.Gray;
            this.btn6.Iconcolor = System.Drawing.Color.Transparent;
            this.btn6.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn6.Iconimage")));
            this.btn6.Iconimage_right = null;
            this.btn6.Iconimage_right_Selected = null;
            this.btn6.Iconimage_Selected = null;
            this.btn6.IconMarginLeft = 0;
            this.btn6.IconMarginRight = 0;
            this.btn6.IconRightVisible = true;
            this.btn6.IconRightZoom = 0D;
            this.btn6.IconVisible = true;
            this.btn6.IconZoom = 60D;
            this.btn6.IsTab = false;
            this.btn6.Location = new System.Drawing.Point(1, 380);
            this.btn6.Name = "btn6";
            this.btn6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn6.OnHoverTextColor = System.Drawing.Color.White;
            this.btn6.selected = false;
            this.btn6.Size = new System.Drawing.Size(199, 48);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "   Tipos de repuesto";
            this.btn6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn6.Textcolor = System.Drawing.Color.White;
            this.btn6.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnBrands
            // 
            this.btnBrands.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBrands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBrands.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrands.BorderRadius = 0;
            this.btnBrands.ButtonText = "   Marcas";
            this.btnBrands.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnBrands, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btnBrands, BunifuAnimatorNS.DecorationType.None);
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
            this.btnBrands.Location = new System.Drawing.Point(1, 333);
            this.btnBrands.Name = "btnBrands";
            this.btnBrands.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBrands.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBrands.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrands.selected = false;
            this.btnBrands.Size = new System.Drawing.Size(200, 48);
            this.btnBrands.TabIndex = 6;
            this.btnBrands.Text = "   Marcas";
            this.btnBrands.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrands.Textcolor = System.Drawing.Color.White;
            this.btnBrands.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnClients
            // 
            this.btnClients.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClients.BorderRadius = 0;
            this.btnClients.ButtonText = "   Clientes";
            this.btnClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnClients, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btnClients, BunifuAnimatorNS.DecorationType.None);
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
            this.btnClients.Location = new System.Drawing.Point(1, 239);
            this.btnClients.Name = "btnClients";
            this.btnClients.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnClients.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnClients.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClients.selected = false;
            this.btnClients.Size = new System.Drawing.Size(199, 48);
            this.btnClients.TabIndex = 5;
            this.btnClients.Text = "   Clientes";
            this.btnClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.Textcolor = System.Drawing.Color.White;
            this.btnClients.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSpare
            // 
            this.btnSpare.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSpare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSpare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpare.BorderRadius = 0;
            this.btnSpare.ButtonText = "   Repuestos";
            this.btnSpare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnSpare, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btnSpare, BunifuAnimatorNS.DecorationType.None);
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
            this.btnSpare.Location = new System.Drawing.Point(1, 286);
            this.btnSpare.Name = "btnSpare";
            this.btnSpare.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSpare.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSpare.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSpare.selected = false;
            this.btnSpare.Size = new System.Drawing.Size(199, 48);
            this.btnSpare.TabIndex = 4;
            this.btnSpare.Text = "   Repuestos";
            this.btnSpare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpare.Textcolor = System.Drawing.Color.White;
            this.btnSpare.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnUnits
            // 
            this.btnUnits.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUnits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnits.BorderRadius = 0;
            this.btnUnits.ButtonText = "   Unidades";
            this.btnUnits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnUnits, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btnUnits, BunifuAnimatorNS.DecorationType.None);
            this.btnUnits.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnUnits.Location = new System.Drawing.Point(1, 192);
            this.btnUnits.Name = "btnUnits";
            this.btnUnits.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUnits.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUnits.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUnits.selected = false;
            this.btnUnits.Size = new System.Drawing.Size(199, 48);
            this.btnUnits.TabIndex = 3;
            this.btnUnits.Text = "   Unidades";
            this.btnUnits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnits.Textcolor = System.Drawing.Color.White;
            this.btnUnits.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "   Inicio";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 60D;
            this.btnHome.IsTab = false;
            this.btnHome.Location = new System.Drawing.Point(1, 145);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.selected = false;
            this.btnHome.Size = new System.Drawing.Size(200, 48);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "   Inicio";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.White;
            this.btnHome.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.LogoTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(154, 32);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // lblProyectName
            // 
            this.lblProyectName.AutoSize = true;
            this.PanelTransition.SetDecoration(this.lblProyectName, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.lblProyectName, BunifuAnimatorNS.DecorationType.None);
            this.lblProyectName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.lblProyectName.Location = new System.Drawing.Point(62, 41);
            this.lblProyectName.Name = "lblProyectName";
            this.lblProyectName.Size = new System.Drawing.Size(66, 20);
            this.lblProyectName.TabIndex = 0;
            this.lblProyectName.Text = "TodoBus";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.LogoTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(200, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 646);
            this.panel1.TabIndex = 2;
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 680);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.header);
            this.PanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Options;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label lblProyectName;
        private Bunifu.Framework.UI.BunifuFlatButton btn6;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrands;
        private Bunifu.Framework.UI.BunifuFlatButton btnClients;
        private Bunifu.Framework.UI.BunifuFlatButton btnSpare;
        private Bunifu.Framework.UI.BunifuFlatButton btnUnits;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
        private BunifuAnimatorNS.BunifuTransition PanelTransition;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}

