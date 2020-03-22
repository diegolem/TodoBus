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

namespace TodoBus
{
    public partial class RegCliente : Form
    {
        ClientController clientController = new ClientController();
        ValidationController valid = new ValidationController();
        byte? tipoC;
        public RegCliente()
        {
            InitializeComponent();
        }
        private bool validarCampos()
        {
            //variable que verifica si algo ha sido validado
            bool validado = true;
            if (txtEmpresa.Visible== true)
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
            if(txtCorrAlternativo.Text.Trim().Length > 0)
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
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegCliente_Load(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Registrará un cliente ligado a una empresa?", "Empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult== DialogResult.Yes)
            {
                tipoC = 0;
            }
            else if (dialogResult==DialogResult.No)
            {
                tipoC = 1;
                bunifuCustomLabel2.Visible = false;
                txtEmpresa.Visible = false;
                bunifuCustomLabel3.Location = new Point(64, 146);
                txtContacto.Location = new Point(207, 146);
                bunifuCustomLabel7.Location = new Point(127, 198);
                txtCorreo.Location = new Point(207, 198);
                bunifuCustomLabel8.Location = new Point(64, 251);
                txtCorrAlternativo.Location = new Point(207, 251);
            }
        }

        private void btnRegCliente_Click(object sender, EventArgs e)
        {
            LimpiarError();
            if (validarCampos())
            {
                try
                {
                    //Mando a llamar el metodo de guardar del controller y paso los parametros
                    bool save = clientController.save(txtEmpresa.Text, txtContacto.Text, txtCorreo.Text, txtCorrAlternativo.Text, txtDireccion.Text, mtxtTelefono.Text, mtxtTelAlternativo.Text, int.Parse(nudUnidades.Text), tipoC);
                    if (save)
                    {
                        //Limpio los controles
                        clearFields();
                        MessageBox.Show("El cliente se ha ingresado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Ya existe un cliente con estas mismas caracteristicas", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearFields()
        {
            txtEmpresa.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            txtCorrAlternativo.Text = "";
            txtContacto.Text = "";
            mtxtTelefono.Text = "";
            mtxtTelAlternativo.Text = "";
            nudUnidades.Text = "";
        }

        private void LimpiarError()
        {
            errorProvider.Clear();
        }
    }
}
