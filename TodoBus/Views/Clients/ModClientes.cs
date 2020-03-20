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
using TodoBus.Models;

namespace TodoBus.Views.Clients
{
    public partial class ModClientes : Form
    {
        public int? id;
        ClientController clientController = new ClientController();
        clients loadC = new clients();
        public ModClientes(int? id)
        {
            this.id = id;
            InitializeComponent();
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
            if (loadC != null)
            {
                txtEmpresa.Text = loadC.client_name;
                txtContacto.Text = loadC.contact_name;
                txtCorreo.Text = loadC.email;
                txtCorrAlternativo.Text = loadC.alternative_email;
                txtDireccion.Text = loadC.address;
                mtxtTelefono.Text = loadC.phone;
                mtxtTelAlternativo.Text = loadC.alternative_phone;
                nudUnidades.Value = loadC.units_total;
            }
        }

        private void btnModCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //Mando a llamar el metodo de guardar del controller y paso los parametros
                bool edit = clientController.edit(txtEmpresa.Text, txtContacto.Text, txtCorreo.Text, txtCorrAlternativo.Text, txtDireccion.Text, mtxtTelefono.Text, mtxtTelAlternativo.Text, int.Parse(nudUnidades.Text), loadC);
                if (edit)
                {
                    MessageBox.Show("El cliente se ha modificado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
