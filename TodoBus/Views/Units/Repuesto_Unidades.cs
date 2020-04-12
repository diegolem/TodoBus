using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoBus.Models;
using TodoBus.Views.Users;
using TodoBus.Views.SpareCategoriesSubClasses;
using TodoBus.Views.SpareCategory;
using TodoBus.Views.Brands;
using TodoBus.Controllers;

namespace TodoBus.Views.Units
{
    public partial class Repuesto_Unidades : Form
    {
        SpareUnitController spu = new SpareUnitController();
        UnitController unitController = new UnitController();

        users user = new users();
        public Repuesto_Unidades(users userS)
        {
            InitializeComponent();
            this.user = userS;
            btnAssociateSpare.Enabled = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmLogin = new Login();
            frmLogin.Show();
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            this.Hide();
            Unidades frmUnits = new Unidades(user);
            frmUnits.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes frmClientes = new Clientes(user);
            frmClientes.Show();
        }

        private void btnSpare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repuestos frmR = new Repuestos(user);
            frmR.Show();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marca frmM = new Marca(user);
            frmM.Show();
        }

        private void btnSpareTypes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category ct = new Category(user);
            ct.Show();
        }

        private void btnSpareSubCategories_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubCategories frmSub = new SubCategories(user);
            frmSub.Show();
        }

        private void btnSpareCategoriesSubClasses_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubClasses frmSub = new SubClasses(user);
            frmSub.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios frmU = new Usuarios(user);
            frmU.Show();
        }

        private void btnUserConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosUsuario frmConfig = new DatosUsuario(user);
            frmConfig.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (Options.Width == 50)
            {
                Options.Visible = false; Options.Width = 215; PanelTransition.ShowSync(Options); LogoTransition.ShowSync(logo);
            }
            else
            {
                LogoTransition.Hide(logo); Options.Visible = false; Options.Width = 50; PanelTransition.ShowSync(Options);
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estas seguro que deseas cerrar la aplicación", "TodoBus", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RefreshData()
        {
            if(dgvSpareUnit.DataSource != null)
            {
                dgvSpareUnit.Columns.Clear();
            }
            dgvSpareUnit.DataSource = null;

            List<FakeUnits> units = new List<FakeUnits>();
            units = unitController.getAllUnits();
            if (units.Count() > 0) { dgvSpareUnit.DataSource = units; }
            else { dgvSpareUnit.DataSource = null; }
        }

        private void formatTable()
        {
            if(dgvSpareUnit.DataSource != null)
            {
                DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
                btnVer.FlatStyle = FlatStyle.Flat;
                btnVer.Text = "Ver repuestos";
                btnVer.UseColumnTextForButtonValue = true;
                btnVer.HeaderText = "Repuestos asociados";
                dgvSpareUnit.Columns.Add(btnVer);

                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.FlatStyle = FlatStyle.Flat;
                btnEdit.Text = "Modificar";
                btnEdit.UseColumnTextForButtonValue = true;
                btnEdit.HeaderText = "Repuestos asociados";
                dgvSpareUnit.Columns.Add(btnEdit);

                //Renombro las columnas del dgv como quiera
                dgvSpareUnit.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSpareUnit.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSpareUnit.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSpareUnit.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSpareUnit.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSpareUnit.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSpareUnit.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvSpareUnit.Columns[0].HeaderText = "Id";
                dgvSpareUnit.Columns[0].Width = 30;
                dgvSpareUnit.Columns[1].HeaderText = "Medidas";
                dgvSpareUnit.Columns[1].Width = 150;
                dgvSpareUnit.Columns[2].HeaderText = "Total de unidades";
                dgvSpareUnit.Columns[2].Width = 75;
                dgvSpareUnit.Columns[3].HeaderText = "Marca";
                dgvSpareUnit.Columns[4].HeaderText = "Cliente";
                dgvSpareUnit.Columns[5].Width = 125;
                dgvSpareUnit.Columns[6].Width = 125;
            }
        }

        private int? getId()
        {
            try
            {
                return int.Parse(dgvSpareUnit.Rows[dgvSpareUnit.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void dgvSpareUnit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int? id = getId();

            if (e.ColumnIndex == 5)
            {
                if (id != null)
                {
                    //Aca el ver repuestos
                }
            }
            else if (e.ColumnIndex == 6)
            {
                if (id != null)
                {
                    ModRepuesto_Unidad mo = new ModRepuesto_Unidad(id);
                    mo.ShowDialog();
                }
            }
        }

        private void Repuesto_Unidades_Load(object sender, EventArgs e)
        {
            RefreshData();
            formatTable();
        }
    }
}
