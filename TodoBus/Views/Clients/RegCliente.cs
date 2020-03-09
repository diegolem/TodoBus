using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoBus
{
    public partial class RegCliente : Form
    {
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
    }
}
