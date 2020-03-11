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
using TodoBus.Views.SpareCategory;
using TodoBus.Views.Units;
using TodoBus.Views.Users;
using TodoBus.Models;

namespace TodoBus.Views.SpareCategoriesSubClasses
{
    public partial class SubCategories : Form
    {
        public SubCategories()
        {
            InitializeComponent();
            btnSubCategory.Enabled = false;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegSubCategoria_Click(object sender, EventArgs e)
        {
            RegSubCategories frmR = new RegSubCategories();
            frmR.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUserConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosUsuario frmConfig = new DatosUsuario();
            frmConfig.Show();
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

        private void SubCategories_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        #region  helper
            private void Refresh()
            {
                using (TodoBusEntities db = new TodoBusEntities())
                {
                    //Obtengo todos los registros de mi tabla en la variable lst
                    var lst = from d in db.spare_categories
                              select d;
                    //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                    //sea compatible con el DGV
                    dgvSubCategory.DataSource = lst.ToList();
                    //Eliminamos las columnas de relaciones, para evitar excepciones
                    dgvSubCategory.Columns.Remove("spare");
                    dgvSubCategory.Columns.Remove("spare_subcategories");
                    //Y ahora añadimos el boton modificar a la tabla
                    DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                    btnEdit.Name = "Editar";
                    btnEdit.Text = "Modificar";
                    btnEdit.UseColumnTextForButtonValue = true;
                    btnEdit.HeaderText = "Modificar";
                    dgvSubCategory.Columns.Add(btnEdit);
                    //ahora el boton eliminar
                    DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                    btnDelete.Name = "Eliminar";
                    btnDelete.Text = "Eliminar";
                    btnDelete.UseColumnTextForButtonValue = true;
                    btnDelete.HeaderText = "Eliminar";
                    dgvSubCategory.Columns.Add(btnDelete);

                    //Renombro las columnas del dgv como quiera
                    dgvSubCategory.Columns[0].HeaderText = "Id";
                    dgvSubCategory.Columns[1].HeaderText = "Código";
                    dgvSubCategory.Columns[2].HeaderText = "Nombre de Subcategoría";
                
                }
            }

        private int? getId()
        {
            //Metodo para obtener el id de la columna seleccionada
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

            if (e.ColumnIndex == 3)
            {
                
                if (id != null)
                {
                    MessageBox.Show("Presionaste modificar " + id);
                }
            }else if (e.ColumnIndex == 4)
            {
                if (id != null)
                {
                    MessageBox.Show("Presionaste eliminar " + id);
                }
            }
        }
    }
}
