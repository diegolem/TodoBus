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

namespace TodoBus.Views.Brands
{
    public partial class RegistroMarca : Form
    {
        ValidationController valid = new ValidationController();
        BrandController brandController = new BrandController();

        public RegistroMarca()
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegSub_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                try
                {
                    //Mando a llamar el metodo de guardar del controller y paso los parametros
                    bool save = brandController.save(txtName.Text, txtDescription.Text);
                    if (save)
                    {
                        //Limpio los controles
                        clearFields();
                        MessageBox.Show("La Marca se ha ingresado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Ya existe una marca con estas mismas caracteristicas", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearFields()
        {
            txtName.Text = "";
            txtDescription.Text = "";
        }

        private bool validateFields()
        {
            Ep1.Clear();
            if (!(valid.isString(txtName.Text)))
            {
                Ep1.SetError(txtName, "El nombre no puede quedar vacío");
                return false;
            }
            if (!(valid.isString(txtDescription.Text)))
            {
                Ep1.SetError(txtDescription, "La descripción no puede quedar vacía");
                return false;
            }
            return true;
        }
    }
}
