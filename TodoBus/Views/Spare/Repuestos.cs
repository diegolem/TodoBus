﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TodoBus.Views.Brands;
using TodoBus.Views.SpareCategoriesSubClasses;
using TodoBus.Views.SpareCategory;
using TodoBus.Views.Units;
using TodoBus.Views.Spare;
using TodoBus.Views.Users;
using TodoBus.Models;
using TodoBus.Controllers;
using System.IO;

namespace TodoBus
{
    public partial class Repuestos : Form
    {
        SpareController control = new SpareController();
        BrandController brandController = new BrandController();
        CategoryController categoryController = new CategoryController();
        AlertController alerts = new AlertController();

        users user = new users();

        bool search = false;
        public Repuestos(users userS)
        {
            InitializeComponent();
            this.user = userS;
            btnSpare.Enabled = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (txtBuscador.text.Length > 0)
            {
                if (cmbOptions.selectedIndex > 0)
                {
                    control.Busqueda(dgvRepuestos, txtBuscador.text, cmbOptions.selectedValue);
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

        private void btnRegCliente_Click(object sender, EventArgs e)
        {
            if (brandController.countBrands() && categoryController.countCategories())
            {
                RegRepuest frmRegSpare = new RegRepuest();
                frmRegSpare.ShowDialog();
            }
            else{
                alerts.errorCountRelationships("un repuesto", "una marca y/o una categoría");
            }
        }

        #region Helper
        private void Refresh()
        {
            if (dgvRepuestos.DataSource != null)
            {
                
                dgvRepuestos.Columns.Clear();
            }
            dgvRepuestos.DataSource = null;

            List<FakeSpare> spares = new List<FakeSpare>();
            spares = control.getAllSpare();

            if (spares.Count() > 0)
            {
                dgvRepuestos.DataSource = spares;
            }
            else
            {
                dgvRepuestos.DataSource = null;
            }
        }
        private int? getId()
        {
            
            try
            {
                
                return int.Parse(dgvRepuestos.Rows[dgvRepuestos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion
        private void Repuestos_Load(object sender, EventArgs e)
        {
            isSearching();
            Refresh();
            formatTable();
            cmbOptions.Clear();
            cmbOptions.AddItem("Buscar por");
            cmbOptions.AddItem("Código");
            cmbOptions.AddItem("Nombre");
            cmbOptions.AddItem("Marca");
            cmbOptions.AddItem("Categoría");

            cmbOptions.selectedIndex = 0;
        }

        private void isSearching()
        {
            if (search)
            {
                btnResetSearch.Visible = true;
                txtBuscador.Size = new System.Drawing.Size(317, 35);
                txtBuscador.Location = new System.Drawing.Point(288, 114);
            }
            else
            {
                Refresh();
                formatTable();
                btnResetSearch.Visible = false;
                txtBuscador.Size = new System.Drawing.Size(359, 35);
                txtBuscador.Location = new System.Drawing.Point(246, 114);
            }
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes frmClientes = new Clientes(user);
            frmClientes.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estas seguro que deseas cerrar la aplicación", "TodoBus", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmLogin = new Login();
            frmLogin.Show();
        }

        private void btnSpare_Click(object sender, EventArgs e)
        {
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios frmUsuario = new Usuarios(user);
            frmUsuario.Show();
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

        private void btnBrands_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marca frmB = new Marca(user);
            frmB.Show();
        }

        private void btnSpareTypes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category ct = new Category(user);
            ct.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubClasses frmSub = new SubClasses(user);
            frmSub.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void formatTable()
        {
            if (dgvRepuestos.DataSource != null)
            {                
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.Name = "Editar";
                btnEdit.Text = "Modificar";
                btnEdit.UseColumnTextForButtonValue = true;
                btnEdit.HeaderText = "Modificar";
                dgvRepuestos.Columns.Add(btnEdit);
                
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "Eliminar";
                btnDelete.Text = "Eliminar";
                btnDelete.UseColumnTextForButtonValue = true;
                btnDelete.HeaderText = "Eliminar";
                dgvRepuestos.Columns.Add(btnDelete);
                DataGridViewButtonColumn btnView = new DataGridViewButtonColumn();
                btnView.Name = "Ver";
                btnView.Text = "Ver";
                btnView.UseColumnTextForButtonValue = true;
                btnView.HeaderText = "Ver Imagen";
                dgvRepuestos.Columns.Add(btnView);


                //Renombro las columnas del dgv como quiera
                dgvRepuestos.Columns[0].HeaderText = "Id";
                dgvRepuestos.Columns[1].HeaderText = "Código";
                dgvRepuestos.Columns[2].HeaderText = "Nombre";
                dgvRepuestos.Columns[3].HeaderText = "Descripción";
                dgvRepuestos.Columns[3].Width = 185;
                dgvRepuestos.Columns[4].HeaderText = "Marca";
                dgvRepuestos.Columns[5].HeaderText = "Categoría";
                dgvRepuestos.Columns[5].Width = 200;
            }
        }

        private void dgvRepuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int? id = getId();
                string ur = control.imagen(id);
                string Cod = dgvRepuestos.Rows[e.RowIndex].Cells[1].Value.ToString();

                if (e.ColumnIndex == 6)
                {
                    if (id != null)
                    {
                        RegRepuest r = new RegRepuest(id, ur, Cod);
                        r.ShowDialog();

                    }
                }
                else if (e.ColumnIndex == 7)
                {
                    if (id != null)
                    {
                        DialogResult result = MessageBox.Show("¿Estas seguro que deseas eliminar este repuesto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        if (result == DialogResult.Yes)
                        {
                            ur = control.imagen(id);
                            if (control.delete(id))
                            {
                                if (File.Exists(ur))
                                {
                                    File.Delete(ur);
                                }
                                MessageBox.Show("El repuesto se ha eliminado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se puede eliminar este repuesto", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            Refresh();
                            formatTable();
                        }
                    }
                }
                else if (e.ColumnIndex == 8)
                {

                    if (ur == "Imagen no insertada")
                    {
                        MessageBox.Show("No hay imagenes que mostrar", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Imagen i = new Imagen(ur);
                        i.ShowDialog();
                    }
                }
            }
            catch
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Refresh();
            formatTable();
        }

        private void btnAssociateSpare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repuesto_Unidades repunit = new Repuesto_Unidades(user);
            repunit.Show();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

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
    }
}
