using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TodoBus.Controllers;
using TodoBus.Models;

namespace TodoBus.Views.Units
{
    public partial class RepuestosAsociados : Form
    {
        int? unit_id = 0;
        SpareUnitController spareUnitController = new SpareUnitController();
        public RepuestosAsociados(int? id)
        {
            InitializeComponent();
            this.unit_id = id;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RepuestosAsociados_Load(object sender, EventArgs e)
        {
            lblNotImage.Visible = false;
            loadAssignedSpares();
        }

        private void loadAssignedSpares()
        {
            if (dgvAssignedSpares != null)
            {
                dgvAssignedSpares.Columns.Clear();
            }
            dgvAssignedSpares.DataSource = null;

            List<FakeSpareUnit> assignedSpares = new List<FakeSpareUnit>();
            assignedSpares = spareUnitController.getAllAsignedSpares(Convert.ToInt32(this.unit_id));
            if (assignedSpares.Count() > 0)
            {
                dgvAssignedSpares.DataSource = assignedSpares;
            }
            else
            {
                dgvAssignedSpares.DataSource = null;
            }

            //Formato de la tabla
            if (dgvAssignedSpares.DataSource != null)
            {
                DataGridViewButtonColumn btnRead = new DataGridViewButtonColumn();
                btnRead.FlatStyle = FlatStyle.Flat;
                btnRead.Text = "Ver Información";
                btnRead.UseColumnTextForButtonValue = true;
                btnRead.HeaderText = "Acción";
                dgvAssignedSpares.Columns.Add(btnRead);

                dgvAssignedSpares.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAssignedSpares.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAssignedSpares.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAssignedSpares.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAssignedSpares.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvAssignedSpares.Columns[0].HeaderText = "Id";
                dgvAssignedSpares.Columns[0].Width = 30;
                dgvAssignedSpares.Columns[1].HeaderText = "Código";
                dgvAssignedSpares.Columns[1].Width = 75;
                dgvAssignedSpares.Columns[2].HeaderText = "Nombre";
                dgvAssignedSpares.Columns[3].HeaderText = "Marca";
                dgvAssignedSpares.Columns[4].HeaderText = "Categoría";
                dgvAssignedSpares.Columns[4].Width = 200;
            }
        }

        private int? getAssignedSpareId()
        {
            try
            {
                return int.Parse(dgvAssignedSpares.Rows[dgvAssignedSpares.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void dgvAssignedSpares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int? spare_id = getAssignedSpareId();
            if (e.ColumnIndex == 5)
            {
                if (spare_id != null)
                {
                    int id = Int32.Parse(spare_id.ToString());
                    spareUnitController.spareInformation(id,ref lblNotImage, ref lblNombre,ref lblBrand,ref lblCategory,ref lblCode,ref txtDescription,ref picSpareImage);
                }
            }
        }
    }
}
