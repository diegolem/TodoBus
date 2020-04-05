using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TodoBus.Controllers;
using TodoBus.Models;

namespace TodoBus.Views.SpareCategoriesSubClasses
{
    public partial class RegSubClase : Form
    {
        ValidationController valid = new ValidationController();
        SubClassController subclassController = new SubClassController();
        AlertController alerts = new AlertController();

        List<int> SubcategoryId = new List<int>();
        List<string> fillcmb = new List<string>();

        public RegSubClase()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadSubcateg()
        {
            SubcategoryId.Clear();
            fillcmb.Clear();

            subclassController.getSubClasses(ref SubcategoryId, ref fillcmb);
            cmbSC.DataSource = fillcmb;
        }

        private void btnRegSub_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                try
                {
                    //Mando a llamar el metodo de guardar del controller y paso los parametros
                    int save = subclassController.save(txtcode.Text, txtName.Text, SubcategoryId[cmbSC.SelectedIndex]);
                    if (save == 1)
                    {
                        //Limpio los controles
                        clearFields();
                        DialogResult result = MessageBox.Show("La subclase se ha ingresado exitosamente\n\n¿Quieres registrar otra subclase?", "TodoBus", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
                        alerts.errorInSaveChanges("una subclase");
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
            txtcode.Text = "";
            txtName.Text = "";
        }

        private bool validateFields()
        {
            Ep1.Clear();
            if (!(valid.isString(txtcode.Text)))
            {
                Ep1.SetError(txtcode, "El código no puede quedar vacío");
                return false;
            }
            if (!(valid.isString(txtName.Text)))
            {
                Ep1.SetError(txtName, "El Nombre no puede quedar vacío");
                return false;
            }
            return true;
        }

        private void body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegSubClase_Load(object sender, EventArgs e)
        {
            loadSubcateg();
        }
    }
}
