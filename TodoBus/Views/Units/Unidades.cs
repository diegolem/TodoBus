﻿using System;
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
        List<clients> lsClient = new List<clients>();
        public Unidades()
        {
            InitializeComponent();
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
            RegistroUnidad RU = new RegistroUnidad();
            RU.ShowDialog();
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
            Clientes frmClientes = new Clientes();
            frmClientes.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubCategories frmSub = new SubCategories();
            frmSub.Show();
        }

        private void btnUserConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosUsuario frmConfig = new DatosUsuario();
            frmConfig.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubClasses frmSub = new SubClasses();
            frmSub.Show();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marca frmM = new Marca();
            frmM.Show(); 
        }

        private void btnSpare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repuestos frmR = new Repuestos();
            frmR.Show();
        }

        private void btnSpareTypes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category ct = new Category();
            ct.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios frmU = new Usuarios();
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

                dgvUnidad.Columns[0].HeaderText = "Id";
                dgvUnidad.Columns[0].Width = 30;
                dgvUnidad.Columns[1].HeaderText = "Medidas";
                dgvUnidad.Columns[1].Width = 150;
                dgvUnidad.Columns[2].HeaderText = "Total de unidades";
                dgvUnidad.Columns[2].Width = 75;
                dgvUnidad.Columns[3].HeaderText = "Marca";
                dgvUnidad.Columns[4].HeaderText = "Cliente";
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

            if (e.ColumnIndex == 5)
            {
                if (id != null)
                {
                    ModificarUnidad mo = new ModificarUnidad(id);
                    mo.ShowDialog();
                }
            }
            else if (e.ColumnIndex == 6)
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
                            MessageBox.Show("Ocurrio un error al eliminar la unidad", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        RefreshData();
                        formatTable();
                    }
                }
            }
        }
    }
}
