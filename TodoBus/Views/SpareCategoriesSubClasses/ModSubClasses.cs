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
    public partial class ModSubClasses : Form
    {
        public int? id;
        ValidationController valid = new ValidationController();
        SubClassController subclassController = new SubClassController();

        spare_subclasses loadSCl = new spare_subclasses();

        List<int> subcategoryid = new List<int>();
        List<string> fillcmb = new List<string>();

        public ModSubClasses(int? id)
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

        private void ModSubclass_Load(object sender, EventArgs e)
        {
            loadSCl = subclassController.getSubclass(id);
            if (loadSCl != null)
            {
                loadSubcateg();

                txtcode.Text = loadSCl.code;
                txtName.Text = loadSCl.name;
                spare_subcategories sc = subclassController.getSubCategory(loadSCl.subcategory_id);
                cmbSC.SelectedItem = sc.name;

            }
        }
        private void loadSubcateg()
        {
            subcategoryid.Clear();
            fillcmb.Clear();

            subclassController.getSubClasses(ref subcategoryid, ref fillcmb);
            cmbSC.DataSource = fillcmb;
        }

        private void btnRegSub_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                try
                {
                    bool edit = subclassController.edit(txtcode.Text, txtName.Text, subcategoryid[cmbSC.SelectedIndex], loadSCl);
                    if (edit)
                    {
                        MessageBox.Show("La Subclase se ha modificado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
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
                Ep1.SetError(txtName, "El Nombre no puede quedar vacía");
                return false;
            }
            return true;
        }

    }
}
  
