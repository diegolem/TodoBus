using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TodoBus.Controllers;
using TodoBus.Models;

namespace TodoBus.Views.Units
{
    public partial class ModRepuesto_Unidad : Form
    {
        int? unit_id = 0;
        SpareUnitController spareUnitController = new SpareUnitController();

        bool search = false;
        bool search2 = false;
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
            isSearchingAvailable();
            isSearchingAssigned();
            cmbAvailableSpares.selectedIndex = 0;
            cmbAssignedSpares.selectedIndex = 0;
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

        private void formatTable(bool dgv)
        {
            
            if (dgv)
            {
                //AvailableSpares
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
            else
            {
                //AssignedSpares
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
        }

        private void btnAvailableSpares_Click(object sender, EventArgs e)
        {
            if(dgvAvailableSpares.DataSource != null)
            {
                if (txtAvailableSpares.text.Length > 0)
                {
                    if (cmbAvailableSpares.selectedIndex > 0)
                    {
                        spareUnitController.buscarDisponibles(ref dgvAvailableSpares, txtAvailableSpares.text, cmbAvailableSpares.selectedValue);
                        formatTable(true);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un parametro de búsqueda válido", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una cadena de búsqueda", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No hay elementos para buscar", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void isSearchingAvailable()
        {
            if (search)
            {
                btnResetSearch.Visible = true;
                txtAvailableSpares.Size = new System.Drawing.Size(188, 35);
                txtAvailableSpares.Location = new System.Drawing.Point(91, 127);
            }
            else
            {
                loadSpares();
                btnResetSearch.Visible = false;
                txtAvailableSpares.Size = new System.Drawing.Size(231, 35);
                txtAvailableSpares.Location = new System.Drawing.Point(48, 127);
            }
        }

        private void txtAvailableSpares_OnTextChange(object sender, EventArgs e)
        {
            if (txtAvailableSpares.text.Trim().Length > 0)
            {
                search = true;
                isSearchingAvailable();
            }
            else
            {
                search = false;
                isSearchingAvailable();
            }
        }

        private void btnAssignedSpares_Click(object sender, EventArgs e)
        {
            if (dgvAssignedSpares.DataSource != null)
            {
                if (txtAssignedSpares.text.Length > 0)
                {
                    if (cmbAssignedSpares.selectedIndex > 0)
                    {
                        spareUnitController.buscar(int.Parse(unit_id.ToString()), ref dgvAssignedSpares, txtAssignedSpares.text, cmbAssignedSpares.selectedValue);
                        formatTable(false);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un parametro de búsqueda válido", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una cadena de búsqueda", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No hay elementos para buscar", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void isSearchingAssigned()
        {
            if (search2)
            {
                btnAssignedReset.Visible = true;
                txtAssignedSpares.Size = new System.Drawing.Size(188, 35);
                txtAssignedSpares.Location = new System.Drawing.Point(687, 127);
            }
            else
            {
                loadAssignedSpares();
                btnAssignedReset.Visible = false;
                txtAssignedSpares.Size = new System.Drawing.Size(231, 35);
                txtAssignedSpares.Location = new System.Drawing.Point(644, 127);
            }
        }

        private void txtAssignedSpares_OnTextChange(object sender, EventArgs e)
        {
            if (txtAssignedSpares.text.Trim().Length > 0)
            {
                search2 = true;
                isSearchingAssigned();
            }
            else
            {
                search2 = false;
                isSearchingAssigned();
            }
        }

        private void btnAssignedReset_Click(object sender, EventArgs e)
        {
            search2 = false;
            isSearchingAssigned();
            txtAssignedSpares.text = "";
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            search = false;
            isSearchingAvailable();
            txtAvailableSpares.text = "";
        }
    }
}
