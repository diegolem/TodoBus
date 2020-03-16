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
using TodoBus.Views.Brands;
using TodoBus.Views.SpareCategoriesSubClasses;
using TodoBus.Views.SpareCategory;
using TodoBus.Views.Users;

namespace TodoBus.Views.Units
{
    public partial class Unidades : Form
    {
        UnitController unitController = new UnitController();
        ClientController clientController = new ClientController();
        List<clients> lsClient = new List<clients>();
        public Unidades()
        {
            InitializeComponent();
            btnUnits.Enabled = false;
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {

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

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaUnidad_Click(object sender, EventArgs e)
        {
            
            RegistroUnidad RU = new RegistroUnidad();
            RU.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmLogin = new Login();
            frmLogin.Show();
        }

        private void btnUnits_Click_1(object sender, EventArgs e)
        {

        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes frmClientes = new Clientes();
            frmClientes.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubClasses frmSub = new SubClasses();
            frmSub.Show();
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

        private void btnAssociateSpare_Click(object sender, EventArgs e)
        {

        }

        private void Unidades_Load(object sender, EventArgs e)
        {
            Refresh();
            formatTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Refresh();
            formatTable();
        }

        #region  helper
        private void Refresh()
        {
            if (dgvUnidad.DataSource != null)
            {
                //Si esto no estaba vacio limpio todas las columas del Grid
                dgvUnidad.Columns.Clear();
            }
            dgvUnidad.DataSource = null;

            List<FakeUnits> units = new List<FakeUnits>();
            units = unitController.getAllUnits();
            if (units.Count() > 0)
            {
                dgvUnidad.DataSource = units;
            }
            else
            {
                dgvUnidad.DataSource = null;
            }
        }

        private void formatTable()
        {
            if (dgvUnidad.DataSource != null)
            {
                //Y ahora añadimos el boton modificar a la tabla
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.Name = "Editar";
                btnEdit.Text = "Modificar";
                btnEdit.UseColumnTextForButtonValue = true;
                btnEdit.HeaderText = "Modificar";
                dgvUnidad.Columns.Add(btnEdit);
                //ahora el boton eliminar
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "Eliminar";
                btnDelete.Text = "Eliminar";
                btnDelete.UseColumnTextForButtonValue = true;
                btnDelete.HeaderText = "Eliminar";
                dgvUnidad.Columns.Add(btnDelete);

                //Renombro las columnas del dgv como quiera
                dgvUnidad.Columns[0].HeaderText = "Id";
                dgvUnidad.Columns[1].HeaderText = "Medidas";
                dgvUnidad.Columns[2].HeaderText = "Total de unidades";
                dgvUnidad.Columns[3].HeaderText = "Marca";
                dgvUnidad.Columns[4].HeaderText = "Cliente";
            }
        }
        private int? getId()
        {
            //Metodo para obtener el id de la columna seleccionada
            try
            {
                //Y le decimos que obtenga de mi dgv el valor de la celda 0(que es id) de la fila que se encuentre seleccionada
                return int.Parse(dgvUnidad.Rows[dgvUnidad.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}
