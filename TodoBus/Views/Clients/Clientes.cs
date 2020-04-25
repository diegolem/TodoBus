using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TodoBus.Views.Clients;
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
        UserController userController = new UserController();
        AlertController alerts = new AlertController();

        bool search = false;

        users user = new users();
        public Clientes(users userS)
        {
            InitializeComponent();
            this.user = userS;
            btnClients.Enabled = false;
        }
        #region Menu, Salir y Minimizar
        private void btnRegCliente_Click(object sender, EventArgs e)
        {
            if (userController.countUsers())
            {
                RegCliente reg = new RegCliente(user);
                reg.ShowDialog();
            }
            else
            {
                alerts.errorCountRelationships("una unidad", "un usuario");
            }
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
            SubCategories frmSub = new SubCategories(user);
            frmSub.Show();
        }

        private void btnUserConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosUsuario frmConfig = new DatosUsuario(user);
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
            Unidades frmUnits = new Unidades(user);
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
            DialogResult result = MessageBox.Show("Estas seguro que deseas cerrar la aplicación", "TodoBus", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            SubClasses frmSub = new SubClasses(user);
            frmSub.Show();
            this.Hide();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marca frmM = new Marca(user);
            frmM.Show();
        }

        private void btnSpare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repuestos frmR = new Repuestos(user);
            frmR.Show();
        }

        private void btnSpareTypes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category ct = new Category(user);
            ct.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios frmU = new Usuarios(user);
            frmU.Show();
        }
        #endregion
        private void Clientes_Load(object sender, EventArgs e)
        {
            isSearching();
            RefreshData();
            formatTable();
            cmbOptions.selectedIndex = 0;
        }

        private void isSearching()
        {
            if (search)
            {
                btnResetSearch.Visible = true;
                txtBuscador.Size = new System.Drawing.Size(317, 35);
                txtBuscador.Location = new System.Drawing.Point(289, 121);
            }
            else
            {
                RefreshData();
                formatTable();
                btnResetSearch.Visible = false;
                txtBuscador.Size = new System.Drawing.Size(359, 35);
                txtBuscador.Location = new System.Drawing.Point(247, 121);
            }
        }

        private void formatTable()
        {
            if (dgvClientes.DataSource != null)
            {
                //Y ahora añadimos el boton modificar a la tabla
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.FlatStyle = FlatStyle.Flat;
                btnEdit.Text = "Modificar";
                btnEdit.UseColumnTextForButtonValue = true;
                btnEdit.HeaderText = "Modificar";
                dgvClientes.Columns.Add(btnEdit);
                //ahora el boton eliminar
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.FlatStyle = FlatStyle.Flat;
                btnDelete.Text = "Eliminar";
                btnDelete.UseColumnTextForButtonValue = true;
                btnDelete.HeaderText = "Eliminar";
                dgvClientes.Columns.Add(btnDelete);

                //Renombro las columnas del dgv como quiera
                dgvClientes.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvClientes.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvClientes.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvClientes.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvClientes.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvClientes.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvClientes.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvClientes.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvClientes.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvClientes.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvClientes.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvClientes.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvClientes.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvClientes.Columns[0].HeaderText = "Id";
                dgvClientes.Columns[0].Width = 30;
                dgvClientes.Columns[1].HeaderText = "Nombre Empresa";
                dgvClientes.Columns[2].HeaderText = "Nombre Contacto";
                dgvClientes.Columns[2].Width = 185;
                dgvClientes.Columns[3].HeaderText = "Teléfono";
                dgvClientes.Columns[3].Width = 85;
                dgvClientes.Columns[4].HeaderText = "Teléfono Alternativo";
                dgvClientes.Columns[5].HeaderText = "Dirección";
                dgvClientes.Columns[6].HeaderText = "Correo";
                dgvClientes.Columns[6].Width = 85;
                dgvClientes.Columns[7].HeaderText = "Correo Alternativo";
                dgvClientes.Columns[8].HeaderText = "Unidades Totales";
                dgvClientes.Columns[8].Width = 75;
                dgvClientes.Columns[9].HeaderText = "Tipo de usuario";
                dgvClientes.Columns[10].HeaderText = "Registrado por";
            }
        }
        private void RefreshData()
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
            RefreshData();
            formatTable();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int? id = getId();
            if (e.ColumnIndex == 11)
            {
                if (id != null)
                {
                    ModClientes mod = new ModClientes(id);
                    mod.ShowDialog();
                }
            }

            else if (e.ColumnIndex == 12)
            {
                if (id != null)
                {
                    DialogResult result = MessageBox.Show("¿Estas seguro que desea eliminar este cliente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (result == DialogResult.Yes)
                    {
                        if (clientController.delete(id))
                        {
                            MessageBox.Show("El cliente se ha eliminado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se puede eliminar este cliente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        RefreshData();
                        formatTable();
                    }
                }
            }
        }

        private void btnAssociateSpare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repuesto_Unidades repunit = new Repuesto_Unidades(user);
            repunit.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscador.text.Length > 0)
            {
                if (cmbOptions.selectedIndex > 0)
                {
                    clientController.buscar(ref dgvClientes, txtBuscador.text, cmbOptions.selectedValue);
                    formatTable();
            }
                else
                {
                    MessageBox.Show("Seleccione un parametro de búsqueda válido", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingrese una cadena de búsqueda", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBuscador_OnTextChange(object sender, EventArgs e)
        {
            if (txtBuscador.text.Trim().Length > 0)
            {
                search = true;
                isSearching();
            }
            else
            {
                search = false;
                isSearching();
            }
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            search = false;
            isSearching();
        }
    }
}
