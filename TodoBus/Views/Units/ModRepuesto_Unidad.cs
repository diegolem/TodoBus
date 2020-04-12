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
        int? unit_id = 0;
        SpareUnitController spareUnitController = new SpareUnitController();
        public ModRepuesto_Unidad(int? id)
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

                dgvAvailableSpares.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAvailableSpares.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAvailableSpares.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAvailableSpares.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAvailableSpares.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvAvailableSpares.Columns[0].HeaderText = "Id";
                dgvAvailableSpares.Columns[0].Width = 30;
                dgvAvailableSpares.Columns[1].HeaderText = "Código";
                dgvAvailableSpares.Columns[1].Width = 75;
                dgvAvailableSpares.Columns[2].HeaderText = "Nombre";
                dgvAvailableSpares.Columns[3].HeaderText = "Marca";
                dgvAvailableSpares.Columns[1].Width = 75;
                dgvAvailableSpares.Columns[4].HeaderText = "Categoría";
                dgvAvailableSpares.Columns[4].Width = 200;
            }
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
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.FlatStyle = FlatStyle.Flat;
                btnDelete.Text = "Desasignar";
                btnDelete.UseColumnTextForButtonValue = true;
                btnDelete.HeaderText = "Acción";
                dgvAssignedSpares.Columns.Add(btnDelete);

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

        private int? getAvailableSpareId()
        {
            try
            {
                return int.Parse(dgvAvailableSpares.Rows[dgvAvailableSpares.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
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

        private void ModRepuesto_Unidad_Load(object sender, EventArgs e)
        {
            loadAssignedSpares();
            loadSpares();            
        }

        private void dgvAvailableSpares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int? spare_id = getAvailableSpareId();
            
            if (e.ColumnIndex == 5)
            {
                if(spare_id != null)
                {
                    bool save = spareUnitController.save(Convert.ToInt32(unit_id), Convert.ToInt32(spare_id));
                    if (save)
                    {
                        loadAssignedSpares();
                        loadSpares();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al asignar el repuesto");
                    }
                }
            }
        }

        private void dgvAssignedSpares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int? spare_id = getAssignedSpareId();
            if (e.ColumnIndex == 5)
            {
                if (spare_id != null)
                {
                    bool delete = spareUnitController.remove(Convert.ToInt32(unit_id), Convert.ToInt32(spare_id));
                    if (delete)
                    {
                        loadAssignedSpares();
                        loadSpares();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al desasignar el repuesto");
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
