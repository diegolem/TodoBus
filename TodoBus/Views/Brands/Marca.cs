using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoBus.Views.SpareCategoriesSubClasses;
using TodoBus.Views.SpareCategory;
using TodoBus.Views.Units;
using TodoBus.Views.Users;
using TodoBus.Controllers;
using TodoBus.Models;

namespace TodoBus.Views.Brands
{
    public partial class Marca : Form
    {
        BrandController brandController = new BrandController();
        public Marca()
        {
            InitializeComponent();
            btnBrands.Enabled = false;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNuevaUnidad_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroMarca frmM = new RegistroMarca();
            frmM.Show();
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

        private void btnUnits_Click(object sender, EventArgs e)
        {
            this.Hide();
            Unidades frmUnits = new Unidades();
            frmUnits.Show();
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

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubClasses frmSub = new SubClasses();
            frmSub.Show();
        }

        private void btnUserConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosUsuario frmConfig = new DatosUsuario();
            frmConfig.Show();
        }

        private void btnSpare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repuestos frmR = new Repuestos();
            frmR.Show();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios frmU = new Usuarios();
            frmU.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void btnSpareTypes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category ct = new Category();
            ct.Show();
        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            //Llamo al metodo para llenar la tabla
            Refresh();
            formatTable();
        }

        private void formatTable()
        {
            if (dgvMarca.DataSource != null)
            {
                //Eliminamos las columnas de relaciones, para evitar excepciones
                dgvMarca.Columns.Remove("spare");
                dgvMarca.Columns.Remove("units");
                //Y ahora añadimos el boton modificar a la tabla
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.Name = "Editar";
                btnEdit.Text = "Modificar";
                btnEdit.UseColumnTextForButtonValue = true;
                btnEdit.HeaderText = "Modificar";
                dgvMarca.Columns.Add(btnEdit);
                //ahora el boton eliminar
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "Eliminar";
                btnDelete.Text = "Eliminar";
                btnDelete.UseColumnTextForButtonValue = true;
                btnDelete.HeaderText = "Eliminar";
                dgvMarca.Columns.Add(btnDelete);

                //Renombro las columnas del dgv como quiera
                dgvMarca.Columns[0].HeaderText = "Id";
                dgvMarca.Columns[1].HeaderText = "Nombre";
                dgvMarca.Columns[2].HeaderText = "Descripción";
                dgvMarca.Columns[2].Width = 185;

            }
        }
        private void Refresh()
        {
            if (dgvMarca.DataSource != null)
            {
                //Si esto no estaba vacio limpio todas las columas del Grid
                dgvMarca.Columns.Clear();
            }
            dgvMarca.DataSource = null;

            List<brands> brnd = new List<brands>();
            brnd = brandController.getAllBrands();

            if (brnd.Count() > 0)
            {
                dgvMarca.DataSource = brnd;
            }
            else
            {
                dgvMarca.DataSource = null;
            }
        }
        private int? getId()
        {
            //Metodo para obtener el id de la columna seleccionada
            try
            {
                //Y le decimos que obtenga de mi dgv el valor de la celda 0(que es id) de la fila que se encuentre seleccionada
                return int.Parse(dgvMarca.Rows[dgvMarca.CurrentRow.Index].Cells[0].Value.ToString());
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
    }
}
