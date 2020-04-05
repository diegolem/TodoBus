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

namespace TodoBus.Views.Units
{
    public partial class RegistroUnidad : Form
    {
        ValidationController valid = new ValidationController();
        UnitController units = new UnitController();
        AlertController alerts = new AlertController();

        List<int> clientsId = new List<int>();
        List<string> fillClients = new List<string>();

        List<int> brandsId = new List<int>();
        List<string> fillBrands = new List<string>();

        public RegistroUnidad()
        {
            InitializeComponent();
        }

        private void body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loadClients()
        {
            clientsId.Clear();
            fillClients.Clear();

            units.getClients(ref clientsId, ref fillClients);
            cmbpOwner.DataSource = fillClients;
        }

        private void loadBrands()
        {
            brandsId.Clear();
            fillBrands.Clear();

            units.getBrands(ref brandsId, ref fillBrands);
            cmbBrand.DataSource = fillBrands;
        }

        private void btnRegUnit_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                try
                {
                    bool save = units.save(brandsId[cmbBrand.SelectedIndex], clientsId[cmbpOwner.SelectedIndex], txtUnitDescription.Text, int.Parse(txtTotal.Text));
                    if (save)
                    {
                        DialogResult result = MessageBox.Show("La unidad se ha ingresado exitosamente\n\n¿Quieres registrar otra unidad?", "TodoBus", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            clearFields();
                        }
                        else
                        {
                            this.Close();
                        }
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
            txtUnitDescription.Text = "";
            txtTotal.Text = "";
        }

        private bool validateFields()
        {
            Ep1.Clear();
            if (!(valid.isString(txtUnitDescription.Text)))
            {
                Ep1.SetError(txtUnitDescription, "La descripción no puede quedar vacía");
                return false;
            }
            if (!(valid.isPositiveNumber(txtTotal.Text)))
            {
                Ep1.SetError(txtTotal, "Porfavor ingrese un número válido");
                return false;
            }
            return true;
        }

        private void RegistroUnidad_Load(object sender, EventArgs e)
        {
            loadClients();
            loadBrands();
        }
    }
}
