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
        public RegCliente()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Clientes C = new Clientes();
            C.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegCliente_Load(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Registrará un cliente ligado a una empresa?", "Empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult== DialogResult.Yes)
            {

            }
            else if (dialogResult==DialogResult.No)
            {
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
            try
            {
                //Mando a llamar el metodo de guardar del controller y paso los parametros
                bool save = clientController.save(txtEmpresa.Text, txtContacto.Text, txtCorreo.Text, txtCorrAlternativo.Text, txtDireccion.Text, mtxtTelefono.Text, mtxtTelAlternativo.Text,int.Parse(udUnidades.Text));
                if (save)
                {
                    //Limpio los controles
                    clearFields();
                    MessageBox.Show("El cliente se ha ingresado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void clearFields()
        {
            txtEmpresa.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            txtCorrAlternativo.Text = "";
            txtContacto.Text = "";
            mtxtTelefono.Text = "";
            mtxtTelAlternativo.Text = "";
            udUnidades.Text = "";
        }
    }
}
