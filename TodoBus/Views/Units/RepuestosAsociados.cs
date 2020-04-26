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

        bool search = false;
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
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RepuestosAsociados_Load(object sender, EventArgs e)
        {
            isSearching();
            lblNotImage.Visible = false;
            loadAssignedSpares();
            cmbAssignedSpares.selectedIndex = 0;
        }

        private void isSearching()
        {
            if (search)
            {
                btnResetSearch.Visible = true;
                txtBuscador.Size = new System.Drawing.Size(231, 35);
                txtBuscador.Location = new System.Drawing.Point(59, 121);
            }
            else
            {
                loadAssignedSpares();
                btnResetSearch.Visible = false;
                txtBuscador.Size = new System.Drawing.Size(188, 35);
                txtBuscador.Location = new System.Drawing.Point(102, 121);
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

        private void formatTable()
        {
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

        private void btnAssignedSpares_Click(object sender, EventArgs e)
        {
            if (txtBuscador.text.Length > 0)
            {
                if (cmbAssignedSpares.selectedIndex > 0)
                {
                    spareUnitController.buscar(int.Parse(unit_id.ToString()),ref dgvAssignedSpares, txtBuscador.text, cmbAssignedSpares.selectedValue);
                    formatTable();
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

        private void txtAssignedSpares_OnTextChange(object sender, EventArgs e)
        {
            if (txtBuscador.text.Trim().Length > 0)
            {
                search = true;
                isSearching();
            }
            else
            {
                search = false;
                isSearching();
            }
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            search = false;
            isSearching();
            txtBuscador.text = "";
        }
    }
}
