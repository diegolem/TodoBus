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

namespace TodoBus.Views.SpareCategory
{
    public partial class ModCategory : Form
    {
        public int? id;
        ValidationController valid = new ValidationController();
        CategoryController categoryController = new CategoryController();

        spare_categories loadCat = new spare_categories();

        public ModCategory(int? id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModCategory_Load(object sender, EventArgs e)
        {
            loadCat = categoryController.getCategory(id);
            if (loadCat != null)
            {
                txtCode.Text = loadCat.code;
                txtName.Text = loadCat.name;
            }
        }

        private void btnRegCategory_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                try
                {
                    bool edit = categoryController.edit(txtCode.Text, txtName.Text, loadCat);
                    if (edit)
                    {
                        MessageBox.Show("La categoría se ha modificado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Ya existe una categoría con estas mismas caracteristicas", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool validateFields()
        {
            errorP.Clear();
            if (!(valid.isString(txtCode.Text)))
            {
                errorP.SetError(txtCode, "El código no puede quedar vacío");
                return false;
            }
            if (!(valid.isString(txtName.Text)))
            {
                errorP.SetError(txtName, "El nombre no puede quedar vacío");
                return false;
            }
            return true;
        }
    }
}
