﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TodoBus.Views.SpareCategoriesSubClasses;
using TodoBus.Views.SpareCategory;
using TodoBus.Views.Units;
using TodoBus.Views.Users;
using TodoBus.Views;
using TodoBus.Controllers;
using TodoBus.Models;

namespace TodoBus.Views.Brands
{
    public partial class Marca : Form
    {
        BrandController brandController = new BrandController();
        users user = new users();

        bool search = false;
        public Marca(users userS)
        {
            InitializeComponent();
            this.user = userS;
            btnBrands.Enabled = false;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estas seguro que deseas cerrar la aplicación", "TodoBus", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNuevaUnidad_Click(object sender, EventArgs e)
        {
            RegistroMarca frmM = new RegistroMarca();
            frmM.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (Options.Width == 50)
            {
                Options.Visible = false;
                Options.Width = 215;
                PanelTransition.ShowSync(Options);
                LogoTransition.ShowSync(logo);
            }
            else
            {
                LogoTransition.Hide(logo);
                Options.Visible = false;
                Options.Width = 50;
                PanelTransition.ShowSync(Options);
            }
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubCategories frmSub = new SubCategories(user);
            frmSub.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubClasses frmSub = new SubClasses(user);
            frmSub.Show();
        }

        private void btnUserConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosUsuario frmConfig = new DatosUsuario(user);
            frmConfig.Show();
        }

        private void btnSpare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repuestos frmR = new Repuestos(user);
            frmR.Show();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios frmU = new Usuarios(user);
            frmU.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            TodoBus.Login log = new TodoBus.Login();
            log.Show();
        }

        private void btnSpareTypes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category ct = new Category(user);
            ct.Show();
        }

        private void formatTable()
        {
            if (dgvMarca.DataSource != null)
            {
                //Y ahora añadimos el boton modificar a la tabla
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.Name = "Editar";
                btnEdit.Text = "Modificar";
                btnEdit.UseColumnTextForButtonValue = true;
                btnEdit.HeaderText = "Modificar";
                btnEdit.FlatStyle = FlatStyle.Flat;
                dgvMarca.Columns.Add(btnEdit);
                //ahora el boton eliminar
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.FlatStyle = FlatStyle.Flat;
                btnDelete.Name = "Eliminar";
                btnDelete.Text = "Eliminar";
                btnDelete.UseColumnTextForButtonValue = true;
                btnDelete.HeaderText = "Eliminar";
                dgvMarca.Columns.Add(btnDelete);

                //Renombro las columnas del dgv como quiera
                dgvMarca.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvMarca.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvMarca.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvMarca.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvMarca.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvMarca.Columns[0].HeaderText = "Id";
                dgvMarca.Columns[0].Width = 30;
                dgvMarca.Columns[1].HeaderText = "Nombre";
                dgvMarca.Columns[2].HeaderText = "Descripción";
                dgvMarca.Columns[2].Width = 275;
            }
        }
        private void RefreshTable()
        {
            if (dgvMarca.DataSource != null)
            {
                //Si esto no estaba vacio limpio todas las columas del Grid
                dgvMarca.Columns.Clear();
            }
            dgvMarca.DataSource = null;

            List<FakeBrands> brnd = new List<FakeBrands>();
            brnd = brandController.getAllBrands();

            if (brnd.Count() > 0)
            {
                dgvMarca.DataSource = brnd;
            }
            else
            {
                dgvMarca.DataSource = null;
            }
        }
        private int? getId()
        {
            
            try
            {
                return int.Parse(dgvMarca.Rows[dgvMarca.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RefreshTable();
            formatTable();
        }

        private void Marca_Load(object sender, EventArgs e)
        {
            isSearching();
            RefreshTable();
            formatTable();
            cmbOptions.selectedIndex = 0;
        }

        private void isSearching()
        {
            if (search)
            {
                btnResetSearch.Visible = true;
                txtBuscador.Size = new System.Drawing.Size(317, 35);
                txtBuscador.Location = new System.Drawing.Point(89, 87);
            }
            else
            {
                RefreshTable();
                formatTable();
                btnResetSearch.Visible = false;
                txtBuscador.Size = new System.Drawing.Size(359, 35);
                txtBuscador.Location = new System.Drawing.Point(46, 87);
            }
        }

        private void dgvMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int? id = getId();

            if (e.ColumnIndex == 3)
            {
                if (id != null)
                {
                    ModMarca mod = new ModMarca(id);
                    mod.ShowDialog();
                }
            }
            else if (e.ColumnIndex == 4)
            {
                if (id != null)
                {
                    DialogResult result = MessageBox.Show("¿Estas seguro que deseas eliminar esta marca?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (result == DialogResult.Yes)
                    {
                        if (brandController.delete(id))
                        {
                            MessageBox.Show("La Marca se ha eliminado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se puede eliminar esta marca", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        RefreshTable();
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

        private void txtBuscador_OnTextChange(object sender, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscador.text.Length > 0)
            {
                if (cmbOptions.selectedIndex > 0)
                {
                    brandController.buscar(ref dgvMarca, txtBuscador.text, cmbOptions.selectedValue);
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
    }
}
