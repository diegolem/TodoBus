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
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.Options = new System.Windows.Forms.Panel();
            this.Body = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            this.Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
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
            this.header.Size = new System.Drawing.Size(800, 34);
            this.header.TabIndex = 0;
            // 
            // Options
            // 
            this.Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Options.Controls.Add(this.logo);
            this.Options.Controls.Add(this.btn6);
            this.Options.Controls.Add(this.btn5);
            this.Options.Controls.Add(this.btn3);
            this.Options.Controls.Add(this.btn4);
            this.Options.Controls.Add(this.btn2);
            this.Options.Controls.Add(this.btn1);
            this.Options.Controls.Add(this.btnMenu);
            this.Options.Controls.Add(this.label1);
            this.LogoTransition.SetDecoration(this.Options, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Options, BunifuAnimatorNS.DecorationType.None);
            this.Options.Dock = System.Windows.Forms.DockStyle.Left;
            this.Options.Location = new System.Drawing.Point(0, 34);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(200, 416);
            this.Options.TabIndex = 1;
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.LogoTransition.SetDecoration(this.Body, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Body, BunifuAnimatorNS.DecorationType.None);
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(200, 34);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(600, 416);
            this.Body.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.LogoTransition.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(751, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 28);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.PanelTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(62, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TodoBus";
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.LogoTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(152, 32);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(44, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // btn1
            // 
            this.btn1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.BorderRadius = 0;
            this.btn1.ButtonText = "Option 1";
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btn1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btn1, BunifuAnimatorNS.DecorationType.None);
            this.btn1.DisabledColor = System.Drawing.Color.Gray;
            this.btn1.Iconcolor = System.Drawing.Color.Transparent;
            this.btn1.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn1.Iconimage")));
            this.btn1.Iconimage_right = null;
            this.btn1.Iconimage_right_Selected = null;
            this.btn1.Iconimage_Selected = null;
            this.btn1.IconMarginLeft = 0;
            this.btn1.IconMarginRight = 0;
            this.btn1.IconRightVisible = true;
            this.btn1.IconRightZoom = 0D;
            this.btn1.IconVisible = true;
            this.btn1.IconZoom = 90D;
            this.btn1.IsTab = false;
            this.btn1.Location = new System.Drawing.Point(0, 96);
            this.btn1.Name = "btn1";
            this.btn1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn1.OnHoverTextColor = System.Drawing.Color.White;
            this.btn1.selected = false;
            this.btn1.Size = new System.Drawing.Size(200, 48);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Option 1";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1.Textcolor = System.Drawing.Color.White;
            this.btn1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn2
            // 
            this.btn2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.BorderRadius = 0;
            this.btn2.ButtonText = "Option 2";
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btn2, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btn2, BunifuAnimatorNS.DecorationType.None);
            this.btn2.DisabledColor = System.Drawing.Color.Gray;
            this.btn2.Iconcolor = System.Drawing.Color.Transparent;
            this.btn2.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn2.Iconimage")));
            this.btn2.Iconimage_right = null;
            this.btn2.Iconimage_right_Selected = null;
            this.btn2.Iconimage_Selected = null;
            this.btn2.IconMarginLeft = 0;
            this.btn2.IconMarginRight = 0;
            this.btn2.IconRightVisible = true;
            this.btn2.IconRightZoom = 0D;
            this.btn2.IconVisible = true;
            this.btn2.IconZoom = 90D;
            this.btn2.IsTab = false;
            this.btn2.Location = new System.Drawing.Point(0, 143);
            this.btn2.Name = "btn2";
            this.btn2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn2.OnHoverTextColor = System.Drawing.Color.White;
            this.btn2.selected = false;
            this.btn2.Size = new System.Drawing.Size(200, 48);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Option 2";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2.Textcolor = System.Drawing.Color.White;
            this.btn2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn4
            // 
            this.btn4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn4.BorderRadius = 0;
            this.btn4.ButtonText = "Option 4";
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btn4, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btn4, BunifuAnimatorNS.DecorationType.None);
            this.btn4.DisabledColor = System.Drawing.Color.Gray;
            this.btn4.Iconcolor = System.Drawing.Color.Transparent;
            this.btn4.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn4.Iconimage")));
            this.btn4.Iconimage_right = null;
            this.btn4.Iconimage_right_Selected = null;
            this.btn4.Iconimage_Selected = null;
            this.btn4.IconMarginLeft = 0;
            this.btn4.IconMarginRight = 0;
            this.btn4.IconRightVisible = true;
            this.btn4.IconRightZoom = 0D;
            this.btn4.IconVisible = true;
            this.btn4.IconZoom = 90D;
            this.btn4.IsTab = false;
            this.btn4.Location = new System.Drawing.Point(0, 237);
            this.btn4.Name = "btn4";
            this.btn4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn4.OnHoverTextColor = System.Drawing.Color.White;
            this.btn4.selected = false;
            this.btn4.Size = new System.Drawing.Size(200, 48);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "Option 4";
            this.btn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn4.Textcolor = System.Drawing.Color.White;
            this.btn4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn3
            // 
            this.btn3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3.BorderRadius = 0;
            this.btn3.ButtonText = "Option 3";
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btn3, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btn3, BunifuAnimatorNS.DecorationType.None);
            this.btn3.DisabledColor = System.Drawing.Color.Gray;
            this.btn3.Iconcolor = System.Drawing.Color.Transparent;
            this.btn3.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn3.Iconimage")));
            this.btn3.Iconimage_right = null;
            this.btn3.Iconimage_right_Selected = null;
            this.btn3.Iconimage_Selected = null;
            this.btn3.IconMarginLeft = 0;
            this.btn3.IconMarginRight = 0;
            this.btn3.IconRightVisible = true;
            this.btn3.IconRightZoom = 0D;
            this.btn3.IconVisible = true;
            this.btn3.IconZoom = 90D;
            this.btn3.IsTab = false;
            this.btn3.Location = new System.Drawing.Point(0, 190);
            this.btn3.Name = "btn3";
            this.btn3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn3.OnHoverTextColor = System.Drawing.Color.White;
            this.btn3.selected = false;
            this.btn3.Size = new System.Drawing.Size(200, 48);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "Option 3";
            this.btn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3.Textcolor = System.Drawing.Color.White;
            this.btn3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn5
            // 
            this.btn5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn5.BorderRadius = 0;
            this.btn5.ButtonText = "Option 5";
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btn5, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btn5, BunifuAnimatorNS.DecorationType.None);
            this.btn5.DisabledColor = System.Drawing.Color.Gray;
            this.btn5.Iconcolor = System.Drawing.Color.Transparent;
            this.btn5.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn5.Iconimage")));
            this.btn5.Iconimage_right = null;
            this.btn5.Iconimage_right_Selected = null;
            this.btn5.Iconimage_Selected = null;
            this.btn5.IconMarginLeft = 0;
            this.btn5.IconMarginRight = 0;
            this.btn5.IconRightVisible = true;
            this.btn5.IconRightZoom = 0D;
            this.btn5.IconVisible = true;
            this.btn5.IconZoom = 90D;
            this.btn5.IsTab = false;
            this.btn5.Location = new System.Drawing.Point(0, 284);
            this.btn5.Name = "btn5";
            this.btn5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn5.OnHoverTextColor = System.Drawing.Color.White;
            this.btn5.selected = false;
            this.btn5.Size = new System.Drawing.Size(200, 48);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "Option 5";
            this.btn5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn5.Textcolor = System.Drawing.Color.White;
            this.btn5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn6
            // 
            this.btn6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn6.BorderRadius = 0;
            this.btn6.ButtonText = "Option 6";
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
            this.btn6.IconZoom = 90D;
            this.btn6.IsTab = false;
            this.btn6.Location = new System.Drawing.Point(0, 331);
            this.btn6.Name = "btn6";
            this.btn6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn6.OnHoverTextColor = System.Drawing.Color.White;
            this.btn6.selected = false;
            this.btn6.Size = new System.Drawing.Size(200, 48);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "Option 6";
            this.btn6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn6.Textcolor = System.Drawing.Color.White;
            this.btn6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PanelTransition
            // 
            this.PanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.PanelTransition.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 1;
            animation6.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 2F;
            animation6.TransparencyCoeff = 0F;
            this.PanelTransition.DefaultAnimation = animation6;
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoTransition.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(30);
            animation5.RotateCoeff = 0.5F;
            animation5.RotateLimit = 0.2F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.LogoTransition.DefaultAnimation = animation5;
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.header);
            this.PanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.header.ResumeLayout(false);
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Options;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel Body;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn6;
        private Bunifu.Framework.UI.BunifuFlatButton btn5;
        private Bunifu.Framework.UI.BunifuFlatButton btn3;
        private Bunifu.Framework.UI.BunifuFlatButton btn4;
        private Bunifu.Framework.UI.BunifuFlatButton btn2;
        private Bunifu.Framework.UI.BunifuFlatButton btn1;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
        private BunifuAnimatorNS.BunifuTransition PanelTransition;
        private System.Windows.Forms.PictureBox logo;
    }
}

