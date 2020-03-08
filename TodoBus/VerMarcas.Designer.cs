namespace TodoBus
{
    partial class VerMarcas
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerMarcas));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.Options = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.body = new System.Windows.Forms.Panel();
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnModMarca = new System.Windows.Forms.Button();
            this.btnElMarca = new System.Windows.Forms.Button();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnSubClase = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSubCategory = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.header.SuspendLayout();
            this.Options.SuspendLayout();
            this.body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
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
            this.LogoTransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(936, 34);
            this.header.TabIndex = 0;
            // 
            // Options
            // 
            this.Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.Options.Controls.Add(this.btnSubClase);
            this.Options.Controls.Add(this.btnSubCategory);
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
            this.LogoTransition.SetDecoration(this.Options, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Options, BunifuAnimatorNS.DecorationType.None);
            this.Options.Dock = System.Windows.Forms.DockStyle.Left;
            this.Options.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options.Location = new System.Drawing.Point(0, 34);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(200, 673);
            this.Options.TabIndex = 1;
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
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.PanelTransition.DefaultAnimation = animation2;
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.body.Controls.Add(this.dgvMarcas);
            this.body.Controls.Add(this.btnElMarca);
            this.body.Controls.Add(this.btnModMarca);
            this.body.Controls.Add(this.label1);
            this.LogoTransition.SetDecoration(this.body, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.body, BunifuAnimatorNS.DecorationType.None);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body.Location = new System.Drawing.Point(200, 34);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(736, 673);
            this.body.TabIndex = 2;
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.LogoTransition.DefaultAnimation = animation1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.PanelTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(249, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marcas de Unidades";
            // 
            // btnModMarca
            // 
            this.PanelTransition.SetDecoration(this.btnModMarca, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnModMarca, BunifuAnimatorNS.DecorationType.None);
            this.btnModMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModMarca.Location = new System.Drawing.Point(537, 236);
            this.btnModMarca.Name = "btnModMarca";
            this.btnModMarca.Size = new System.Drawing.Size(134, 35);
            this.btnModMarca.TabIndex = 1;
            this.btnModMarca.Text = "Modificar Marca";
            this.btnModMarca.UseVisualStyleBackColor = true;
            // 
            // btnElMarca
            // 
            this.PanelTransition.SetDecoration(this.btnElMarca, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnElMarca, BunifuAnimatorNS.DecorationType.None);
            this.btnElMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElMarca.Location = new System.Drawing.Point(537, 317);
            this.btnElMarca.Name = "btnElMarca";
            this.btnElMarca.Size = new System.Drawing.Size(134, 35);
            this.btnElMarca.TabIndex = 2;
            this.btnElMarca.Text = "Eliminar Marca";
            this.btnElMarca.UseVisualStyleBackColor = true;
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogoTransition.SetDecoration(this.dgvMarcas, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.dgvMarcas, BunifuAnimatorNS.DecorationType.None);
            this.dgvMarcas.Location = new System.Drawing.Point(67, 176);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.Size = new System.Drawing.Size(442, 377);
            this.dgvMarcas.TabIndex = 3;
            // 
            // btnSubClase
            // 
            this.btnSubClase.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSubClase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnSubClase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubClase.BorderRadius = 0;
            this.btnSubClase.ButtonText = "   Subclases";
            this.btnSubClase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnSubClase, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btnSubClase, BunifuAnimatorNS.DecorationType.None);
            this.btnSubClase.DisabledColor = System.Drawing.Color.Gray;
            this.btnSubClase.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSubClase.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSubClase.Iconimage")));
            this.btnSubClase.Iconimage_right = null;
            this.btnSubClase.Iconimage_right_Selected = null;
            this.btnSubClase.Iconimage_Selected = null;
            this.btnSubClase.IconMarginLeft = 0;
            this.btnSubClase.IconMarginRight = 0;
            this.btnSubClase.IconRightVisible = true;
            this.btnSubClase.IconRightZoom = 0D;
            this.btnSubClase.IconVisible = true;
            this.btnSubClase.IconZoom = 60D;
            this.btnSubClase.IsTab = false;
            this.btnSubClase.Location = new System.Drawing.Point(1, 411);
            this.btnSubClase.Name = "btnSubClase";
            this.btnSubClase.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnSubClase.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSubClase.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSubClase.selected = false;
            this.btnSubClase.Size = new System.Drawing.Size(199, 48);
            this.btnSubClase.TabIndex = 8;
            this.btnSubClase.Text = "   Subclases";
            this.btnSubClase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubClase.Textcolor = System.Drawing.Color.White;
            this.btnSubClase.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubClase.Click += new System.EventHandler(this.btnSubClase_Click);
            // 
            // btnSubCategory
            // 
            this.btnSubCategory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSubCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnSubCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubCategory.BorderRadius = 0;
            this.btnSubCategory.ButtonText = "   Subcategorías";
            this.btnSubCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnSubCategory, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btnSubCategory, BunifuAnimatorNS.DecorationType.None);
            this.btnSubCategory.DisabledColor = System.Drawing.Color.Gray;
            this.btnSubCategory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSubCategory.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSubCategory.Iconimage")));
            this.btnSubCategory.Iconimage_right = null;
            this.btnSubCategory.Iconimage_right_Selected = null;
            this.btnSubCategory.Iconimage_Selected = null;
            this.btnSubCategory.IconMarginLeft = 0;
            this.btnSubCategory.IconMarginRight = 0;
            this.btnSubCategory.IconRightVisible = true;
            this.btnSubCategory.IconRightZoom = 0D;
            this.btnSubCategory.IconVisible = true;
            this.btnSubCategory.IconZoom = 60D;
            this.btnSubCategory.IsTab = false;
            this.btnSubCategory.Location = new System.Drawing.Point(1, 364);
            this.btnSubCategory.Name = "btnSubCategory";
            this.btnSubCategory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnSubCategory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSubCategory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSubCategory.selected = false;
            this.btnSubCategory.Size = new System.Drawing.Size(199, 48);
            this.btnSubCategory.TabIndex = 14;
            this.btnSubCategory.Text = "   Subcategorías";
            this.btnSubCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubCategory.Textcolor = System.Drawing.Color.White;
            this.btnSubCategory.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubCategory.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.BorderRadius = 0;
            this.btnLogOut.ButtonText = "   Cerrar Sesión";
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnLogOut, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btnLogOut, BunifuAnimatorNS.DecorationType.None);
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
            this.btnLogOut.Location = new System.Drawing.Point(1, 599);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnLogOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLogOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogOut.selected = false;
            this.btnLogOut.Size = new System.Drawing.Size(199, 48);
            this.btnLogOut.TabIndex = 13;
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
            this.LogoTransition.SetDecoration(this.btnAssociateSpare, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btnAssociateSpare, BunifuAnimatorNS.DecorationType.None);
            this.btnAssociateSpare.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnAssociateSpare.Location = new System.Drawing.Point(1, 552);
            this.btnAssociateSpare.Name = "btnAssociateSpare";
            this.btnAssociateSpare.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnAssociateSpare.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAssociateSpare.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAssociateSpare.selected = false;
            this.btnAssociateSpare.Size = new System.Drawing.Size(199, 48);
            this.btnAssociateSpare.TabIndex = 12;
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
            this.LogoTransition.SetDecoration(this.btnUserConfig, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btnUserConfig, BunifuAnimatorNS.DecorationType.None);
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
            this.btnUserConfig.Location = new System.Drawing.Point(1, 505);
            this.btnUserConfig.Name = "btnUserConfig";
            this.btnUserConfig.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnUserConfig.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUserConfig.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUserConfig.selected = false;
            this.btnUserConfig.Size = new System.Drawing.Size(199, 48);
            this.btnUserConfig.TabIndex = 10;
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
            this.LogoTransition.SetDecoration(this.btnUsers, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btnUsers, BunifuAnimatorNS.DecorationType.None);
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
            this.btnUsers.Location = new System.Drawing.Point(1, 458);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnUsers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUsers.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUsers.selected = false;
            this.btnUsers.Size = new System.Drawing.Size(199, 48);
            this.btnUsers.TabIndex = 9;
            this.btnUsers.Text = "   Usuarios";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Textcolor = System.Drawing.Color.White;
            this.btnUsers.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // logo
            // 
            this.PanelTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(137, 100);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 8;
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
            this.LogoTransition.SetDecoration(this.btnSpareTypes, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btnSpareTypes, BunifuAnimatorNS.DecorationType.None);
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
            this.btnSpareTypes.Location = new System.Drawing.Point(1, 317);
            this.btnSpareTypes.Name = "btnSpareTypes";
            this.btnSpareTypes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnSpareTypes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSpareTypes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSpareTypes.selected = false;
            this.btnSpareTypes.Size = new System.Drawing.Size(199, 48);
            this.btnSpareTypes.TabIndex = 7;
            this.btnSpareTypes.Text = "   Categorias";
            this.btnSpareTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpareTypes.Textcolor = System.Drawing.Color.White;
            this.btnSpareTypes.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnBrands
            // 
            this.btnBrands.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBrands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
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
            this.btnBrands.Location = new System.Drawing.Point(1, 270);
            this.btnBrands.Name = "btnBrands";
            this.btnBrands.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnBrands.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBrands.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrands.selected = false;
            this.btnBrands.Size = new System.Drawing.Size(199, 48);
            this.btnBrands.TabIndex = 6;
            this.btnBrands.Text = "   Marcas";
            this.btnBrands.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrands.Textcolor = System.Drawing.Color.White;
            this.btnBrands.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnClients
            // 
            this.btnClients.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
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
            this.btnClients.Location = new System.Drawing.Point(1, 176);
            this.btnClients.Name = "btnClients";
            this.btnClients.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnClients.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnClients.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClients.selected = false;
            this.btnClients.Size = new System.Drawing.Size(199, 48);
            this.btnClients.TabIndex = 5;
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
            this.btnSpare.Location = new System.Drawing.Point(1, 223);
            this.btnSpare.Name = "btnSpare";
            this.btnSpare.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
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
            this.btnUnits.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
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
            this.btnUnits.Location = new System.Drawing.Point(1, 129);
            this.btnUnits.Name = "btnUnits";
            this.btnUnits.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btnUnits.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUnits.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUnits.selected = false;
            this.btnUnits.Size = new System.Drawing.Size(199, 48);
            this.btnUnits.TabIndex = 3;
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
            this.LogoTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(155, 32);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.LogoTransition.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(854, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(37, 28);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click_1);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.LogoTransition.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(887, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 28);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Menu_VerMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 707);
            this.Controls.Add(this.body);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.header);
            this.PanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_VerMarcas";
            this.Text = "Menu";
            this.header.ResumeLayout(false);
            this.Options.ResumeLayout(false);
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Options;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSpareTypes;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrands;
        private Bunifu.Framework.UI.BunifuFlatButton btnClients;
        private Bunifu.Framework.UI.BunifuFlatButton btnSpare;
        private Bunifu.Framework.UI.BunifuFlatButton btnUnits;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
        private BunifuAnimatorNS.BunifuTransition PanelTransition;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel body;
        private Bunifu.Framework.UI.BunifuFlatButton btnUsers;
        private Bunifu.Framework.UI.BunifuFlatButton btnUserConfig;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogOut;
        private Bunifu.Framework.UI.BunifuFlatButton btnAssociateSpare;
        private Bunifu.Framework.UI.BunifuFlatButton btnSubClase;
        private Bunifu.Framework.UI.BunifuFlatButton btnSubCategory;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModMarca;
        private System.Windows.Forms.Button btnElMarca;
        private System.Windows.Forms.DataGridView dgvMarcas;
    }
}

