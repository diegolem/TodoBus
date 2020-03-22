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

namespace TodoBus.Views.Brands
{
    public partial class ModMarca : Form
    {
        public int? id;
        ValidationController valid = new ValidationController();
        BrandController brandController = new BrandController();

        brands loadB = new brands();

        public ModMarca(int? id)
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

        private void btnRegSub_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                try
                {
                    bool edit = brandController.edit(txtName.Text, txtDescription.Text, loadB);
                    if (edit)
                    {
                        MessageBox.Show("La Marca se ha modificado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ModMarca_Load(object sender, EventArgs e)
        {
            loadB = brandController.getBrand(id);
            if(loadB != null)
            {
                txtName.Text = loadB.name;
                txtDescription.Text = loadB.description;
            }
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
