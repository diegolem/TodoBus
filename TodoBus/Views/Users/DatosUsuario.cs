using System;
using System.Windows.Forms;
using TodoBus.Controllers;
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
        ValidationController valid = new ValidationController();
        AlertController alerts = new AlertController();
        UserController UserC = new UserController();

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
            TodoBus.Login frmLogin = new TodoBus.Login();
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
            DialogResult result = MessageBox.Show("Estas seguro que deseas cerrar la aplicación", "TodoBus", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void btnRegCliente_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                try
                {
                    int save = UserC.modifyUserData(txtName.Text, txtLastName.Text, txtMail.Text, txtPassword.Text, txtNewPassword.Text, user);
                    if (save == 1 || save == 2)
                    {
                        MessageBox.Show("Tus datos personales fueron actualizados exitosamente","TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNewPassword.Text = "";
                        txtPassword.Text = "";
                    }else if(save == 3)
                    {
                        MessageBox.Show("La contraseña actual no coincide con su registro, porfavor intentelo nuevamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNewPassword.Text = "";
                        txtPassword.Text = "";
                    }
                }
                catch
                {
                    alerts.errorInSaveChanges("");
                }
            }
        }

        private bool validateFields()
        {
            Ep1.Clear();
            if (!(valid.isString(txtName.Text)))
            {
                Ep1.SetError(txtName, "El Nombre no puede quedar vacío");
                return false;
            }
            if (!(valid.isString(txtLastName.Text)))
            {
                Ep1.SetError(txtLastName, "El Apellido no puede quedar vacío");
                return false;
            }
            if (!(valid.isString(txtMail.Text)))
            {
                Ep1.SetError(txtMail, "El Correo no puede quedar vacío");
                return false;
            }
            if (!(valid.isEmail(txtMail.Text)))
            {
                Ep1.SetError(txtMail, "Porfavor ingresa un correo válido");
                return false;
            }
            if (txtNewPassword.Text.Trim().Length > 0)
            {
                if (!(valid.isString(txtPassword.Text)))
                {
                    Ep1.SetError(txtPassword, "Debes confirmar la contraseña actual para cambiarla por una nueva");
                    return false;
                }
            }

            return true;
        }

        private void btnAssociateSpare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repuesto_Unidades repunit = new Repuesto_Unidades(user);
            repunit.Show();
        }
    }
}
