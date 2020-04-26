using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TodoBus.Views.Brands;
using TodoBus.Views.SpareCategoriesSubClasses;
using TodoBus.Views.Units;
using TodoBus.Views.Users;
using TodoBus.Models;
using TodoBus.Controllers;

namespace TodoBus.Views.SpareCategory
{
    public partial class Category : Form
    {
        CategoryController categoryController = new CategoryController();

        users user = new users();

        bool search = false;
        public Category(users userS)
        {
            InitializeComponent();
            this.user = userS;
            btnSpareTypes.Enabled = false;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            RegCategory frmR = new RegCategory();
            frmR.ShowDialog();
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            this.Hide();
            Unidades frmUnits = new Unidades(user);
            frmUnits.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes frmClientes = new Clientes(user);
            frmClientes.Show();
        }

        private void btnSpare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repuestos frmR = new Repuestos(user);
            frmR.Show();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marca frmM = new Marca(user);
            frmM.Show();
        }

        private void btnSpareTypes_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubCategories frmSub = new SubCategories(user);
            frmSub.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubClasses frmSub = new SubClasses(user);
            frmSub.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios frmU = new Usuarios(user);
            frmU.Show();
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
            Login log = new Login();
            log.Show();
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estas seguro que deseas cerrar la aplicación", "TodoBus", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Categories_Load(object sender, EventArgs e)
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
                txtBuscador.Size = new System.Drawing.Size(333, 35);
                txtBuscador.Location = new System.Drawing.Point(74, 90);
            }
            else
            {
                RefreshData();
                formatTable();
                btnResetSearch.Visible = false;
                txtBuscador.Size = new System.Drawing.Size(376, 35);
                txtBuscador.Location = new System.Drawing.Point(31, 90);
            }
        }

        private void RefreshData()
        {
            if(dgvCategoria.DataSource != null)
            {
                dgvCategoria.Columns.Clear();
            }
            dgvCategoria.DataSource = null;

            List<FakeCategories> categories = new List<FakeCategories>();
            categories = categoryController.getAllCategories();
            if (categories.Count() > 0)
            {
                dgvCategoria.DataSource = categories;
            }
            else
            {
                dgvCategoria.DataSource = null;
            }
        }
        private void formatTable()
        {
            if (dgvCategoria.DataSource != null)
            {
                //Y ahora añadimos el boton modificar a la tabla
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.FlatStyle = FlatStyle.Flat;
                btnEdit.Text = "Modificar";
                btnEdit.UseColumnTextForButtonValue = true;
                btnEdit.HeaderText = "Modificar";
                dgvCategoria.Columns.Add(btnEdit);
                //ahora el boton eliminar
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.FlatStyle = FlatStyle.Flat;
                btnDelete.Text = "Eliminar";
                btnDelete.UseColumnTextForButtonValue = true;
                btnDelete.HeaderText = "Eliminar";
                dgvCategoria.Columns.Add(btnDelete);
                //Renombro las columnas del dgv como quieradgvUnidad.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCategoria.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCategoria.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCategoria.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCategoria.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvCategoria.Columns[0].HeaderText = "Id";
                dgvCategoria.Columns[0].Width = 30;
                dgvCategoria.Columns[1].HeaderText = "Codigo";
                dgvCategoria.Columns[0].Width = 50;
                dgvCategoria.Columns[2].HeaderText = "Nombre de Categoria";
                dgvCategoria.Columns[2].Width = 255;
            }
        }
        #region  helper
        private void Refresh()
        {
            if (dgvCategoria.DataSource != null)
            {
                //Si esto no estaba vacio limpio todas las columas del Grid
                dgvCategoria.Columns.Clear();
            }
            dgvCategoria.DataSource = null;

            List<FakeCategories> Categories = new List<FakeCategories>();
            Categories = categoryController.getAllCategories();

            if (Categories.Count() > 0)
            {
                dgvCategoria.DataSource = Categories;
            }
            else
            {
                dgvCategoria.DataSource = null;
            }
        }

        private int? getId()
        {
            //Metodo para obtener el id de la columna seleccionada
            try
            {
                //Y le decimos que obtenga de mi dgv el valor de la celda 0(que es id) de la fila que se encuentre seleccionada
                return int.Parse(dgvCategoria.Rows[dgvCategoria.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RefreshData();
            formatTable();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int? id = getId();
            if (e.ColumnIndex == 3)
            {
                if (id != null)
                {
                    ModCategory mod = new ModCategory(id);
                    mod.ShowDialog();
                }
            }

            else if (e.ColumnIndex == 4)
            {
                if (id != null)
                {
                    DialogResult result = MessageBox.Show("¿Estas seguro que desea eliminar esta categoria?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (result == DialogResult.Yes)
                    {
                        if (categoryController.delete(id))
                        {
                            MessageBox.Show("La categoría se ha eliminado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se puede eliminar esta categoría", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    categoryController.buscar(ref dgvCategoria, txtBuscador.text, cmbOptions.selectedValue);
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
            txtBuscador.text = "";
        }
    }
}
