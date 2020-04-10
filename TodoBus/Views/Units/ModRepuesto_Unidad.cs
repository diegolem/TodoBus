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
    public partial class ModRepuesto_Unidad : Form
    {
        int? id = 0;
        SpareUnitController spareUnitController = new SpareUnitController();
        public ModRepuesto_Unidad(int? id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadSpares()
        {
            if (dgvAvailableSpares != null)
            {
                dgvAvailableSpares.Columns.Clear();
            }
            dgvAvailableSpares.DataSource = null;

            List<FakeSpareUnit> availableSpares = new List<FakeSpareUnit>();
            availableSpares = spareUnitController.getAllSpares();
            if(availableSpares.Count() > 0)
            {
                dgvAvailableSpares.DataSource = availableSpares;
            }
            else
            {
                dgvAvailableSpares.DataSource = null;
            }

            //Formato de la tabla
            if (dgvAvailableSpares.DataSource != null)
            {
                DataGridViewButtonColumn btnAdd = new DataGridViewButtonColumn();
                btnAdd.FlatStyle = FlatStyle.Flat;
                btnAdd.Text = "+ Asignar";
                btnAdd.UseColumnTextForButtonValue = true;
                btnAdd.HeaderText = "Asignar Repuesto";
                dgvAvailableSpares.Columns.Add(btnAdd);

                dgvAvailableSpares.Columns[0].HeaderText = "Id";
                dgvAvailableSpares.Columns[1].HeaderText = "Código";
                dgvAvailableSpares.Columns[2].HeaderText = "Nombre";
                dgvAvailableSpares.Columns[3].HeaderText = "Marca";
                dgvAvailableSpares.Columns[4].HeaderText = "Categoría";
                dgvAvailableSpares.Columns[4].Width = 200;
            }
        }

        private void loadAssignedSpares()
        {

        }

        private void ModRepuesto_Unidad_Load(object sender, EventArgs e)
        {
            loadSpares();
            loadAssignedSpares();
        }
    }
}
