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
        AlertController alerts = new AlertController();

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
                    int save = brandController.save(txtName.Text, txtDescription.Text);
                    if (save == 1)
                    {
                        DialogResult result = MessageBox.Show("La marca se ha ingresado exitosamente\n\n¿Quieres registrar otra marca?", "TodoBus", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            clearFields();
                        }
                        else
                        {
                            this.Close();
                        }
                    }else if (save == 2)
                    {
                        alerts.errorInSaveChanges("una marca");
                    }
                    else
                    {
                        alerts.errorInSaveChanges("");
                    }
                }
                catch
                {
                    alerts.errorInSaveChanges("");
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
