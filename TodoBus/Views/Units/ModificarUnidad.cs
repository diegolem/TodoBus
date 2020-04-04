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

namespace TodoBus.Views.Units
{
    public partial class ModificarUnidad : Form
    {
        public int? id;
        ValidationController valid = new ValidationController();
        UnitController units = new UnitController();

        int oldTotal = 0;

        units loadU = new units();

        List<int> clientsId = new List<int>();
        List<string> fillClients = new List<string>();

        List<int> brandsId = new List<int>();
        List<string> fillBrands = new List<string>();

        public ModificarUnidad(int? id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegUnit_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                try
                {
                    bool edit = units.edit(brandsId[cmbBrand.SelectedIndex], clientsId[cmbpOwner.SelectedIndex], txtUnitDescription.Text, int.Parse(txtTotal.Text), loadU, oldTotal);
                    if (edit)
                    {
                        MessageBox.Show("La Unidad se ha modificado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("La unidad no se pudo modificar", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void ModificarUnidad_Load(object sender, EventArgs e)
        {
            loadU = units.getUnit(id);
            if (loadU != null)
            {
                loadClients();
                loadBrands();

                txtTotal.Text = loadU.total.ToString();
                oldTotal = loadU.total;
                txtUnitDescription.Text = loadU.measure_description;

                cmbBrand.SelectedItem = units.getBrand(loadU.brand_id).name;
                cmbpOwner.SelectedItem = units.getClient(loadU.client_id).client_name;
            }
        }
    }
}
