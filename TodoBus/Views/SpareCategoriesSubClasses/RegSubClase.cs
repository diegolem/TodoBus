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

namespace TodoBus.Views.SpareCategoriesSubClasses
{
    public partial class RegSubClase : Form
    {
        ValidationController valid = new ValidationController();
        SubClassController subclassController = new SubClassController();

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

        private void RegSubClass_Load(object sender, EventArgs e)
        {
            loadSubcateg();
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
                    bool save = subclassController.save(txtcode.Text, txtName.Text, SubcategoryId[cmbSC.SelectedIndex]);
                    if (save)
                    {
                        //Limpio los controles
                        clearFields();
                        MessageBox.Show("La Subclase se ha ingresado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Ya existe una subclase con estas mismas caracteristicas", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
