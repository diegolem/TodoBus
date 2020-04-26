using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBus.Views.Login;
using TodoBus.Controllers;
using System.Windows.Forms;

namespace TodoBus.Views.Login
{
    public partial class CodigoRecuperacion : Form
    {
        LoginController log = new LoginController();
        ValidationController v = new ValidationController();
        private string Email;
        public CodigoRecuperacion(string email)
        {
            InitializeComponent();
            this.Email = email;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TodoBus.Login log = new TodoBus.Login();
            log.Show();
        }

        private void btnEnvNewContra_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnvNewContra_Click_1(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() != "")
            {
                if (v.isInteger(txtCodigo.Text))
                {
                    bool bandera = log.VerifiCodi(Email, int.Parse(txtCodigo.Text));
                    if (bandera)
                    {
                        this.Hide();
                        NuevaContraseña log = new NuevaContraseña(Email);
                        log.Show();
                    }

                }

            }
        }

        private void txtCodigo_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
