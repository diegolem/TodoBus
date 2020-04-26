using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBus.Views.Login;
using System.Windows.Forms;
using TodoBus.Controllers;

namespace TodoBus
{
    public partial class ReestablecerContra : Form
    {
        LoginController lg = new LoginController();
        ValidationController v = new ValidationController();
        public ReestablecerContra()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmlogin = new Login();
            frmlogin.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEnvNewContra_Click(object sender, EventArgs e)
        {
            System.Uri Url = new System.Uri("http://www.google.com/");
            System.Net.WebRequest WebRequest;
            WebRequest = System.Net.WebRequest.Create(Url);
            System.Net.WebResponse objResp;
            try
            {
                
                objResp = WebRequest.GetResponse();              
                objResp.Close();
                WebRequest = null;
                if (txtEmail.Text.Trim() != "")
                {
                    if (v.isEmail(txtEmail.Text))
                    {
                        var result = lg.recoverPassword(txtEmail.Text);
                        MessageBox.Show(result, "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        CodigoRecuperacion frmRecu = new CodigoRecuperacion(txtEmail.Text);
                        frmRecu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una dirección de correo valida", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se permiten dejar espacios vacíos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
               MessageBox.Show("Error al intentar conectarse a internet ");
                WebRequest = null;
            }
            
            
        }
    }
}
