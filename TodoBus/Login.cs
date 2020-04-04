using System;
using System.Windows.Forms;
using TodoBus.Views.Units;
using static TodoBus.Controllers.LoginController;
using TodoBus.Controllers;
using TodoBus.Models;

namespace TodoBus
{
    public partial class Login : Form
    {
        LoginController c = new LoginController();
        users user = new users();
        public Login()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ReContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ReestablecerContra contra = new ReestablecerContra();
            contra.Show();
        }

        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            bool verifi;
            string correo = txtEmail.Text;
            string pass = GetSHA256(txtPassword.Text.Trim());
            ErrorProvider r = new ErrorProvider();
            if (txtEmail.Text.Trim().Equals("") || txtPassword.Text.Trim().Equals(""))
            {
                r.SetError(txtEmail, "No se permiten campos vacios");
            }
            verifi= c.Verificar(pass, correo);
            if(verifi)
            {
                this.Hide();
                user = c.getUser(pass, correo);
                Unidades frmMenu = new Unidades(user);
                frmMenu.Show();
            }
            else
            {
                MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }
    }
}
