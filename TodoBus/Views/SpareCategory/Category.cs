﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoBus.Views.Brands;
using TodoBus.Views.SpareCategoriesSubClasses;
using TodoBus.Views.Units;
using TodoBus.Views.Users;
using TodoBus.Models;
using TodoBus.Controllers;

namespace TodoBus.Views.SpareCategory
{
    public partial class Category : Form
    {
        CategoryController categoryController = new CategoryController();
        public Category()
        {
            InitializeComponent();
            btnSpareTypes.Enabled = false;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            RegCategory frmR = new RegCategory();
            frmR.ShowDialog();
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            this.Hide();
            Unidades frmUnits = new Unidades();
            frmUnits.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes frmClientes = new Clientes();
            frmClientes.Show();
        }

        private void btnSpare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repuestos frmR = new Repuestos();
            frmR.Show();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marca frmM = new Marca();
            frmM.Show();
        }

        private void btnSpareTypes_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubCategories frmSub = new SubCategories();
            frmSub.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubClasses frmSub = new SubClasses();
            frmSub.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios frmU = new Usuarios();
            frmU.Show();
        }

        private void btnUserConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosUsuario frmConfig = new DatosUsuario();
            frmConfig.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Categories_Load(object sender, EventArgs e)
        {
            //Llamo al metodo para llenar la tabla
            Refresh();
            formatTable();
        }
        private void formatTable()
        {
            if (dgvCategoria.DataSource != null)
            {
                //Eliminamos las columnas de relaciones, para evitar excepciones
                dgvCategoria.Columns.Remove("spare_subcategories");
                dgvCategoria.Columns.Remove("spare");
                //Y ahora añadimos el boton modificar a la tabla
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.Name = "Editar";
                btnEdit.Text = "Modificar";
                btnEdit.UseColumnTextForButtonValue = true;
                btnEdit.HeaderText = "Modificar";
                dgvCategoria.Columns.Add(btnEdit);
                //ahora el boton eliminar
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "Eliminar";
                btnDelete.Text = "Eliminar";
                btnDelete.UseColumnTextForButtonValue = true;
                btnDelete.HeaderText = "Eliminar";
                dgvCategoria.Columns.Add(btnDelete);
                //Renombro las columnas del dgv como quiera
                dgvCategoria.Columns[0].HeaderText = "Id";
                dgvCategoria.Columns[1].HeaderText = "Codigo";
                dgvCategoria.Columns[2].HeaderText = "Nombre de Categoria";
                dgvCategoria.Columns[2].Width = 205;
            }
        }
        #region  helper
        private void Refresh()
        {
            if (dgvCategoria.DataSource != null)
            {
                //Si esto no estaba vacio limpio todas las columas del Grid
                dgvCategoria.Columns.Clear();
            }
            dgvCategoria.DataSource = null;

            List<spare_categories> Categories = new List<spare_categories>();
            Categories = categoryController.getAllCategories();

            if (Categories.Count() > 0)
            {
                dgvCategoria.DataSource = Categories;
            }
            else
            {
                dgvCategoria.DataSource = null;
            }
        }

        private int? getId()
        {
            //Metodo para obtener el id de la columna seleccionada
            try
            {
                //Y le decimos que obtenga de mi dgv el valor de la celda 0(que es id) de la fila que se encuentre seleccionada
                return int.Parse(dgvCategoria.Rows[dgvCategoria.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Refresh();
            formatTable();
        }
    }
}
