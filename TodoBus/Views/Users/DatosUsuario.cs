using System;
using System.Windows.Forms;
using TodoBus.Models;
using TodoBus.Views.Brands;
using TodoBus.Views.SpareCategoriesSubClasses;
using TodoBus.Views.SpareCategory;
using TodoBus.Views.Units;

namespace TodoBus.Views.Users
{
    public partial class DatosUsuario : Form
    {
        users user = new users();
        public DatosUsuario(users userS)
        {
            InitializeComponent();
            this.user = userS;
            btnUserConfig.Enabled = false;
            loadInformation();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubCategories frmSub = new SubCategories(user);
            frmSub.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmLogin = new Login();
            frmLogin.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes frmClientes = new Clientes(user);
            frmClientes.Show();
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            this.Hide();
            Unidades frmUnits = new Unidades(user);
            frmUnits.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            SubClasses frmSub = new SubClasses(user);
            frmSub.Show();
            this.Hide();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marca frmM = new Marca(user);
            frmM.Show();
        }

        private void btnSpare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repuestos frmR = new Repuestos(user);
            frmR.Show();
        }

        private void btnSpareTypes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category ct = new Category(user);
            ct.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios frmU = new Usuarios(user);
            frmU.Show();
        }

        private void loadInformation()
        {
            txtName.Text = user.name;
            txtLastName.Text = user.last_name;
            txtMail.Text = user.email;
            Age.Text = user.age.ToString();
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
    }
}
