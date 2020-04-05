using System;
using System.Drawing;
using System.Windows.Forms;
using TodoBus.Controllers;
using TodoBus.Models;

namespace TodoBus.Views.Clients
{
    public partial class ModClientes : Form
    {
        public int? id;
        ClientController clientController = new ClientController();
        ValidationController valid = new ValidationController();
        clients loadC = new clients();

        public ModClientes(int? id)
        {
            this.id = id;
            InitializeComponent();
        }
        private bool validarCampos()
        {
            //variable que verifica si algo ha sido validado
            bool validado = true;
            if (txtEmpresa.Visible == true)
            {
                if (txtEmpresa.Text == "") //vefica que no quede vacío el campo
                {
                    validado = false; //si está vacío validado es falso
                    errorProvider.SetError(txtEmpresa, "Ingresar nombre de Empresa");
                }
            }
            if (txtContacto.Text == "")
            {
                validado = false;
                errorProvider.SetError(txtContacto, "Ingrese nombre de Contacto");
            }
            if (txtCorreo.Text == "")
            {
                validado = false;
                errorProvider.SetError(txtCorreo, "Ingrese un correo eléctronico");
            }
            if (!(valid.isEmail(txtCorreo.Text)))
            {
                validado = false;
                errorProvider.SetError(txtCorreo, "Ingrese un correo válido");
            }
            if (txtCorrAlternativo.Text.Trim().Length > 0)
            {
                if (!(valid.isEmail(txtCorrAlternativo.Text)))
                {
                    validado = false;
                    errorProvider.SetError(txtCorrAlternativo, "Ingrese un correo válido");
                }
            }
            if (mtxtTelefono.Text == "")
            {
                validado = false;
                errorProvider.SetError(mtxtTelefono, "Ingrese un número de télefono");
            }
            return validado;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ModClientes_Load(object sender, EventArgs e)
        {
            loadC = clientController.getClient(id);
            if (loadC!= null && loadC.client_type != 0)
            {
                bunifuCustomLabel2.Visible = false;
                txtEmpresa.Visible = false;
                bunifuCustomLabel3.Location = new Point(14, 110);
                txtContacto.Location = new Point(157, 110);
                bunifuCustomLabel7.Location = new Point(77, 162);
                txtCorreo.Location = new Point(157, 162);
                bunifuCustomLabel8.Location = new Point(14, 215);
                txtCorrAlternativo.Location = new Point(157, 215);
                txtContacto.Text = loadC.contact_name;
                txtCorreo.Text = loadC.email;
                txtCorrAlternativo.Text = loadC.alternative_email;
                txtDireccion.Text = loadC.address;
                mtxtTelefono.Text = loadC.phone;
                mtxtTelAlternativo.Text = loadC.alternative_phone;
            }
            else if (loadC != null)
            {
                txtEmpresa.Text = loadC.client_name;
                txtContacto.Text = loadC.contact_name;
                txtCorreo.Text = loadC.email;
                txtCorrAlternativo.Text = loadC.alternative_email;
                txtDireccion.Text = loadC.address;
                mtxtTelefono.Text = loadC.phone;
                mtxtTelAlternativo.Text = loadC.alternative_phone;
            }
        }

        private void btnModCliente_Click(object sender, EventArgs e)
        {
            LimpiarError();
            if (validarCampos())
            {
                try
                {
                    string empresa = "";
                    if (loadC.client_type == 1)
                    {
                        empresa = txtContacto.Text;
                    }
                    else
                    {
                        empresa = txtEmpresa.Text;
                    }
                    bool edit = clientController.edit(empresa, txtContacto.Text, txtCorreo.Text, txtCorrAlternativo.Text, txtDireccion.Text, mtxtTelefono.Text, mtxtTelAlternativo.Text, 0, loadC);
                    if (edit)
                    {
                        MessageBox.Show("El cliente se ha modificado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarError()
        {
            errorProvider.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
