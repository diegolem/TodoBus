using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoBus.Views.Brands;
using TodoBus.Views.SpareCategory;
using TodoBus.Views.Units;
using TodoBus.Views.Users;

namespace TodoBus.Views.SpareCategoriesSubClasses
{
    public partial class SubCategories : Form
    {
        public SubCategories()
        {
            InitializeComponent();
            btnSubCategory.Enabled = false;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegSubCategoria_Click(object sender, EventArgs e)
        {
            RegSubCategories frmR = new RegSubCategories();
            frmR.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUserConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosUsuario frmConfig = new DatosUsuario();
            frmConfig.Show();
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            this.Hide();
            Unidades frmUnits = new Unidades();
            frmUnits.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes frmClientes = new Clientes();
            frmClientes.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmLogin = new Login();
            frmLogin.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (Options.Width == 50)
            {
                Options.Visible = false;
                Options.Width = 215;
                PanelTransition.ShowSync(Options);
                LogoTransition.ShowSync(logo);
            }
            else
            {
                LogoTransition.Hide(logo);
                Options.Visible = false;
                Options.Width = 50;
                PanelTransition.ShowSync(Options);
            }
        }

        private void btnSubClase_Click(object sender, EventArgs e)
        {
            SubClasses frmSub = new SubClasses();
            frmSub.Show();
            this.Hide();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marca frmM = new Marca();
            frmM.Show();
        }

        private void btnSpare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repuestos frmR = new Repuestos();
            frmR.Show();
        }

        private void btnSpareTypes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category ct = new Category();
            ct.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios frmU = new Usuarios();
            frmU.Show();
        }
    }
}
