using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoBus.Controllers;
using static TodoBus.Controllers.LoginController;

namespace TodoBus.Views.Login
{
    public partial class NuevaContraseña : Form
    {
        private string Email;
        LoginController lg = new LoginController();
        public NuevaContraseña(string mail)
        {
            InitializeComponent();
            this.Email = mail;
        }

        private void Checkbox1_OnChange(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = !Checkbox1.Checked;
        }

        private void NuevaContraseña_Load(object sender, EventArgs e)
        {

        }

        private void btnEnvNewContra_Click(object sender, EventArgs e)
        {
            if(txtContraseña.Text.Trim()!="")
            {
                string pass = GetSHA256(txtContraseña.Text.Trim());
                if(lg.nuevaContraseña(pass, Email))
                {
                    MessageBox.Show("Su contraseña se ha reestablecido correctamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    TodoBus.Login log = new TodoBus.Login();
                    log.Show();
                }
                else
                {
                    MessageBox.Show("Ah ocurrido un error", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("No se pueden dejar espacios vacíos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
