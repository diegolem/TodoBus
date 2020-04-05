using System;
using System.Windows.Forms;
using TodoBus.Controllers;
using TodoBus.Models;

namespace TodoBus.Views.SpareCategory
{
    public partial class RegCategory : Form
    {
        CategoryController categoryController = new CategoryController();
        ValidationController valid = new ValidationController();
        AlertController alerts = new AlertController();

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

        private void body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegCategory_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                try
                {
                    int save = categoryController.save(txtCode.Text, txtName.Text);
                    if (save == 1)
                    {
                        //Limpio los controles
                        clearFields();
                        DialogResult result = MessageBox.Show("La categoría se ha ingresado exitosamente\n\n¿Quieres registrar otra categoría?", "TodoBus", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            clearFields();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else if (save == 2)
                    {
                        alerts.errorInSaveChanges("una categoría");
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

        private void clearFields()
        {
            txtCode.Text = "";
            txtName.Text = "";
        }
    }
}
