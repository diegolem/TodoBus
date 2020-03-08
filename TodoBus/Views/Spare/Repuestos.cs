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
using TodoBus.Views.SpareCategoriesSubClasses;
using TodoBus.Views.SpareCategory;
using TodoBus.Views.Units;
using TodoBus.Views.Users;

namespace TodoBus
{
    public partial class Repuestos : Form
    {
        public Repuestos()
        {
            InitializeComponent();
            btnSpare.Enabled = false;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscador_OnTextChange(object sender, EventArgs e)
        {

        }

        private void btnRegCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegRepuest frmRegSpare = new RegRepuest();
            frmRegSpare.Show();
        }

        private void Options_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Repuestos_Load(object sender, EventArgs e)
        {

        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes frmClientes = new Clientes();
            frmClientes.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmLogin = new Login();
            frmLogin.Show();
        }

        private void btnSpare_Click(object sender, EventArgs e)
        {
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios frmUsuario = new Usuarios();
            frmUsuario.Show();
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

        private void btnUnits_Click(object sender, EventArgs e)
        {
            this.Hide();
            Unidades frmUnits = new Unidades();
            frmUnits.Show();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marca frmB = new Marca();
            frmB.Show();
        }

        private void btnSpareTypes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category ct = new Category();
            ct.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubClasses frmSub = new SubClasses();
            frmSub.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubCategories frmSub = new SubCategories();
            frmSub.Show();
        }

        private void btnUserConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosUsuario frmConfig = new DatosUsuario();
            frmConfig.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
