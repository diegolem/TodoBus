using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TodoBus.Views.Brands;
using TodoBus.Views.SpareCategory;
using TodoBus.Views.Units;
using TodoBus.Views.Users;
using TodoBus.Models;
using TodoBus.Controllers;

namespace TodoBus.Views.SpareCategoriesSubClasses
{
    public partial class SubCategories : Form
    {
        SubCategoryController subController = new SubCategoryController();
        CategoryController categoryController = new CategoryController();
        AlertController alerts = new AlertController();
        users user = new users();

        public SubCategories(users userS)
        {
            InitializeComponent();
            this.user = userS;
            btnSubCategory.Enabled = false;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estas seguro que deseas cerrar la aplicación", "TodoBus", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegSubCategoria_Click(object sender, EventArgs e)
        {
            if (categoryController.countCategories())
            {
                RegSubCategories frmR = new RegSubCategories();
                frmR.ShowDialog();
            }
            else
            {
                alerts.errorCountRelationships("una subcategoría", "una categoría");
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUserConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosUsuario frmConfig = new DatosUsuario(user);
            frmConfig.Show();
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmLogin = new Login();
            frmLogin.Show();
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

        private void btnSubClase_Click(object sender, EventArgs e)
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

        private void SubCategories_Load(object sender, EventArgs e)
        {
            //Llamo al metodo para llenar la tabla
            Refresh();
            formatTable();
        }

        private void formatTable()
        {
            if (dgvSubCategory.DataSource != null)
            {
                //Y ahora añadimos el boton modificar a la tabla
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.FlatStyle = FlatStyle.Flat;
                btnEdit.Text = "Modificar";
                btnEdit.UseColumnTextForButtonValue = true;
                btnEdit.HeaderText = "Modificar";
                dgvSubCategory.Columns.Add(btnEdit);
                //ahora el boton eliminar
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.FlatStyle = FlatStyle.Flat;
                btnDelete.Text = "Eliminar";
                btnDelete.UseColumnTextForButtonValue = true;
                btnDelete.HeaderText = "Eliminar";
                dgvSubCategory.Columns.Add(btnDelete);

                //Renombro las columnas del dgv como quiera
                dgvSubCategory.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSubCategory.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSubCategory.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSubCategory.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSubCategory.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSubCategory.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvSubCategory.Columns[0].HeaderText = "Id";
                dgvSubCategory.Columns[0].Width = 30;
                dgvSubCategory.Columns[1].HeaderText = "Código";
                dgvSubCategory.Columns[1].Width = 50;
                dgvSubCategory.Columns[2].HeaderText = "Nombre Subcategoría";
                dgvSubCategory.Columns[2].Width = 200;
                dgvSubCategory.Columns[3].HeaderText = "Categoría";
                dgvSubCategory.Columns[3].Width = 225;
            }
        }

        #region  helper
            private void Refresh()
            {
                if(dgvSubCategory.DataSource != null)
                {
                    //Si esto no estaba vacio limpio todas las columas del Grid
                    dgvSubCategory.Columns.Clear();
                }
                dgvSubCategory.DataSource = null;

                List<FakeSubCategories> subCategories = new List<FakeSubCategories>();
                subCategories = subController.getAllSubCategories();

                if(subCategories.Count() > 0)
                {
                    dgvSubCategory.DataSource = subCategories;
                }
                else
                {
                    dgvSubCategory.DataSource = null;
                }
            }

        private int? getId()
        {
            try
            {
                //Y le decimos que obtenga de mi dgv el valor de la celda 0(que es id) de la fila que se encuentre seleccionada
                return int.Parse(dgvSubCategory.Rows[dgvSubCategory.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void dgvSubCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Los index empiezan desde 0, asi que verificamos en que columna estan los botones modificar y eliminar, para obtener correctamente el id
            int? id = getId();

            if (e.ColumnIndex == 4)
            {
                if (id != null)
                {
                    ModSubCategories mod = new ModSubCategories(id);
                    mod.ShowDialog();
                }
            }
            else if (e.ColumnIndex == 5)
            {
                if (id != null)
                {
                    DialogResult result = MessageBox.Show("¿Estas seguro que deseas eliminar esta subcategoría?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (result == DialogResult.Yes)
                    {
                        if (subController.delete(id))
                        {
                            MessageBox.Show("La Subcategoria se ha eliminado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se puede eliminar esta subcategoría", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        Refresh();
                        formatTable();
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Refresh();
            formatTable();
        }

        private void btnAssociateSpare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repuesto_Unidades repunit = new Repuesto_Unidades(user);
            repunit.Show();
        }
    }
}
