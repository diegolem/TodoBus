using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoBus.Views.Brands;
using TodoBus.Views.SpareCategoriesSubClasses;
using TodoBus.Views.SpareCategory;
using TodoBus.Views.Units;
using TodoBus.Views.Users;
using TodoBus.Models;
using TodoBus.Controllers;

namespace TodoBus
{
    public partial class Clientes : Form
    {
        ClientController clientController = new ClientController();
        public Clientes()
        {
            InitializeComponent();
            btnClients.Enabled = false;
        }

        private void btnRegCliente_Click(object sender, EventArgs e)
        {
            RegCliente reg = new RegCliente();
            reg.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClients_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubCategories frmSub = new SubCategories();
            frmSub.Show();
        }

        private void btnUserConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosUsuario frmConfig = new DatosUsuario();
            frmConfig.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmLogin = new Login();
            frmLogin.Show();
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            this.Hide();
            Unidades frmUnits = new Unidades();
            frmUnits.Show();
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            SubClasses frmSub = new SubClasses();
            frmSub.Show();
            this.Hide();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marca frmM = new Marca();
            frmM.Show();
        }

        private void btnSpare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repuestos frmR = new Repuestos();
            frmR.Show();
        }

        private void btnSpareTypes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category ct = new Category();
            ct.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios frmU = new Usuarios();
            frmU.Show();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Refresh();
            formatTable();
        }

        private void formatTable()
        {
            if (dgvClientes.DataSource != null)
            {
                //Y ahora añadimos el boton modificar a la tabla
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.Name = "Editar";
                btnEdit.Text = "Modificar";
                btnEdit.UseColumnTextForButtonValue = true;
                btnEdit.HeaderText = "Modificar";
                dgvClientes.Columns.Add(btnEdit);
                //ahora el boton eliminar
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "Eliminar";
                btnDelete.Text = "Eliminar";
                btnDelete.UseColumnTextForButtonValue = true;
                btnDelete.HeaderText = "Eliminar";
                dgvClientes.Columns.Add(btnDelete);

                //Renombro las columnas del dgv como quiera
                dgvClientes.Columns[0].HeaderText = "Id";
                dgvClientes.Columns[1].HeaderText = "Nombre Empresa";
                dgvClientes.Columns[2].HeaderText = "Nombre Contacto";
                dgvClientes.Columns[2].Width = 185;
                dgvClientes.Columns[3].HeaderText = "Teléfono";
                dgvClientes.Columns[4].HeaderText = "Teléfono Alternativo";
                dgvClientes.Columns[4].Width = 185;
                dgvClientes.Columns[5].HeaderText = "Dirección";
                dgvClientes.Columns[6].HeaderText = "Correo";
                dgvClientes.Columns[7].HeaderText = "Correo Alternativo";
                dgvClientes.Columns[7].Width = 185;
                dgvClientes.Columns[8].HeaderText = "Unidades Totales";
                dgvClientes.Columns[8].Width = 185;
                dgvClientes.Columns[9].HeaderText = "Tipo de usuario";
                dgvClientes.Columns[10].HeaderText = "Registrado por";
            }
        }
        private void Refresh()
        {
            if (dgvClientes.DataSource != null)
            {
                //Si esto no estaba vacio limpio todas las columas del Grid
                dgvClientes.Columns.Clear();
            }
            dgvClientes.DataSource = null;

            List<FakeClients> clients= new List<FakeClients>();
            clients = clientController.getAllClients();

            if (clients.Count() > 0)
            {
                dgvClientes.DataSource = clients;
            }
            else
            {
                dgvClientes.DataSource = null;
            }
        }
        private int? getId()
        {
            //Metodo para obtener el id de la columna seleccionada
            try
            {
                //Y le decimos que obtenga de mi dgv el valor de la celda 0(que es id) de la fila que se encuentre seleccionada
                return int.Parse(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Refresh();
            formatTable();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int? id = getId();
            if (e.ColumnIndex == 11)
            {
                if (id != null)
                {

                }
            }
        }
    }
}
