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

namespace TodoBus.Views.SpareCategoriesSubClasses
{
    public partial class ModSubCategories : Form
    {
        public int? id;
        SubCategoryController subController = new SubCategoryController();
        spare_subcategories loadSC = new spare_subcategories();

        List<int> categoriesId = new List<int>();
        List<string> fillcmb = new List<string>();

        public ModSubCategories(int? id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ModSubCategories_Load(object sender, EventArgs e)
        {
            loadSC = subController.getSubCategory(id);
            if (loadSC != null)
            {
                loadCategories();
                
                txtName.Text = loadSC.name;
                txtCode.Text = loadSC.code;
                spare_categories sc = subController.getCategory(loadSC.category_id);
                cmbCategory.SelectedItem = sc.name;
            }
        }

        #region  helper
        private void loadCategories()
        {
            categoriesId.Clear();
            fillcmb.Clear();
            //Paso por referencia las listas de aca para que se llenen en el controlador y separar vistas de procesos de la BDD
            subController.getSubCategories(ref categoriesId, ref fillcmb);
            
            //Lleno el comboBox
            cmbCategory.DataSource = fillcmb;
        }
        #endregion

        private void btnRegSub_Click(object sender, EventArgs e)
        {
            try
            {
                //Mando a llamar el metodo de guardar del controller y paso los parametros
                bool edit = subController.edit(txtName.Text, txtCode.Text, categoriesId[cmbCategory.SelectedIndex], loadSC);
                if (edit)
                {
                    MessageBox.Show("La Subcategoria se ha modificado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
