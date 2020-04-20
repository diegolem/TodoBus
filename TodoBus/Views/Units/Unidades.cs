using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TodoBus.Controllers;
using TodoBus.Models;
using TodoBus.Views.Brands;
using TodoBus.Views.SpareCategoriesSubClasses;
using TodoBus.Views.SpareCategory;
using TodoBus.Views.Users;

namespace TodoBus.Views.Units
{
    public partial class Unidades : Form
    {
        UnitController unitController = new UnitController();
        ClientController clientController = new ClientController();
        BrandController brandController = new BrandController();
        AlertController alerts = new AlertController();

        List<clients> lsClient = new List<clients>();

        users user = new users();
        public Unidades(users userS)
        {
            InitializeComponent();
            this.user = userS;
            btnUnits.Enabled = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (Options.Width == 50)
            {
                Options.Visible = false;Options.Width = 215;PanelTransition.ShowSync(Options);LogoTransition.ShowSync(logo);
            }
            else
            {
                LogoTransition.Hide(logo);Options.Visible = false;Options.Width = 50; PanelTransition.ShowSync(Options);
            }
        }

        private void btnNuevaUnidad_Click(object sender, EventArgs e)
        {
            if (clientController.countClients() && brandController.countBrands()) {
                RegistroUnidad RU = new RegistroUnidad();
                RU.ShowDialog();
            }
            else
            {
                alerts.errorCountRelationships("una unidad", "un cliente y/o una marca");
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmLogin = new Login();
            frmLogin.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes frmClientes = new Clientes(user);
            frmClientes.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubCategories frmSub = new SubCategories(user);
            frmSub.Show();
        }

        private void btnUserConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosUsuario frmConfig = new DatosUsuario(user);
            frmConfig.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estas seguro que deseas cerrar la aplicación", "TodoBus", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubClasses frmSub = new SubClasses(user);
            frmSub.Show();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marca frmM = new Marca(user);
            frmM.Show(); 
        }

        private void btnSpare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repuestos frmR = new Repuestos(user);
            frmR.Show();
        }

        private void btnSpareTypes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category ct = new Category(user);
            ct.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios frmU = new Usuarios(user);
            frmU.Show();
        }

        private void Unidades_Load(object sender, EventArgs e)
        {
            RefreshData();
            formatTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RefreshData();
            formatTable();
        }

        #region  helper
        private void RefreshData()
        {
            if (dgvUnidad.DataSource != null){dgvUnidad.Columns.Clear();}
            dgvUnidad.DataSource = null;

            List<FakeUnits> units = new List<FakeUnits>();
            units = unitController.getAllUnits();
            if (units.Count() > 0){ dgvUnidad.DataSource = units; }
            else { dgvUnidad.DataSource = null; }
        }

        private void formatTable()
        {
            if (dgvUnidad.DataSource != null)
            {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.FlatStyle = FlatStyle.Flat;
                btnEdit.Text = "Modificar";
                btnEdit.UseColumnTextForButtonValue = true;
                btnEdit.HeaderText = "Modificar";
                dgvUnidad.Columns.Add(btnEdit);
                
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.FlatStyle = FlatStyle.Flat;
                btnDelete.Text = "Eliminar";
                btnDelete.UseColumnTextForButtonValue = true;
                btnDelete.HeaderText = "Eliminar";
                dgvUnidad.Columns.Add(btnDelete);

                //Renombro las columnas del dgv como quiera
                dgvUnidad.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUnidad.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUnidad.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUnidad.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUnidad.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUnidad.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUnidad.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUnidad.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUnidad.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUnidad.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUnidad.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUnidad.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUnidad.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvUnidad.Columns[0].HeaderText = "Id";
                dgvUnidad.Columns[0].Width = 30;
                dgvUnidad.Columns[1].HeaderText = "Total de unidades";
                dgvUnidad.Columns[1].Width = 75;
                dgvUnidad.Columns[2].HeaderText = "Marca unidad";
                dgvUnidad.Columns[3].HeaderText = "Cliente";
                dgvUnidad.Columns[4].HeaderText = "Descripción";
                dgvUnidad.Columns[4].Width = 150;
                dgvUnidad.Columns[5].HeaderText = "Diseño pintura";
                dgvUnidad.Columns[6].HeaderText = "Año unidad";
                dgvUnidad.Columns[7].HeaderText = "Modelo unidad";
                dgvUnidad.Columns[8].HeaderText = "Número fabricación carrocería";
                dgvUnidad.Columns[9].HeaderText = "Número fabricación chasis";
                dgvUnidad.Columns[10].HeaderText = "Marca carrocería";
                dgvUnidad.Columns[11].HeaderText = "Marca chasis";
                dgvUnidad.Columns[12].HeaderText = "Marca motor";

            }
        }
        private int? getId()
        {
            try
            {
                return int.Parse(dgvUnidad.Rows[dgvUnidad.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void dgvUnidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int? id = getId();

            if (e.ColumnIndex == 13)
            {
                if (id != null)
                {
                    ModificarUnidad mo = new ModificarUnidad(id);
                    mo.ShowDialog();
                }
            }
            else if (e.ColumnIndex == 14)
            {
                if (id != null)
                {
                    DialogResult result = MessageBox.Show("¿Estas seguro que deseas eliminar esta unidad?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (result == DialogResult.Yes)
                    {
                        if (unitController.delete(id))
                        {
                            MessageBox.Show("La Unidad se ha eliminado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se puede eliminar esta unidad", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        RefreshData();
                        formatTable();
                    }
                }
            }
        }

        private void btnAssociateSpare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repuesto_Unidades repunit = new Repuesto_Unidades(user);
            repunit.Show();
        }
    }
}
