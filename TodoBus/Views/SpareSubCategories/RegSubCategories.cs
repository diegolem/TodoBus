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
    public partial class RegSubCategories : Form
    {
        SubCategoryController catec = new SubCategoryController();

        List<int> categoriesId = new List<int>();
        List<string> fillcmb = new List<string>();

        public RegSubCategories()
        {
            InitializeComponent();
        }

        private void body_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnRegSub_Click(object sender, EventArgs e)
        {
            try
            {
                //Mando a llamar el metodo de guardar del controller y paso los parametros
                bool save = catec.save(txtName.Text, txtCode.Text, categoriesId[cmbCategory.SelectedIndex]);
                if (save)
                {
                    //Limpio los controles
                    clearFields();
                    MessageBox.Show("La Subcategoria se ha ingresado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ya existe una subcategoria con estas mismas caracteristicas", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearFields()
        {
            txtCode.Text = "";
            txtName.Text = "";
        }

        private void RegSubCategories_Load(object sender, EventArgs e)
        {
            //Llamo al metodo justo cuando el form se cargue
            loadCategories();
        }

        #region  helper
        private void loadCategories()
        {
            categoriesId.Clear();
            fillcmb.Clear();
            //Paso por referencia las listas de aca para que se llenen en el controlador y separar vistas de procesos de la BDD
            catec.getSubCategories(ref categoriesId, ref fillcmb);
            //Lleno el comboBox
            cmbCategory.DataSource = fillcmb;
        }
        #endregion
    }
}
