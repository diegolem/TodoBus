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
    public partial class RegCategory : Form
    {
        BrandController categoryController = new BrandController();
        ValidationController valid = new ValidationController();

        public RegCategory()
        {
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

        private void btnRegCategory_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                try
                {
                    //Mando a llamar el metodo de guardar del controller y paso los parametros
                    bool save = categoryController.save(txtName.Text, txtCode.Text);
                    if (save)
                    {
                        //Limpio los controles
                        clearFields();
                        MessageBox.Show("La categoría se ha ingresado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void clearFields()
        {
            txtCode.Text = "";
            txtName.Text = "";
        }
    }
}
