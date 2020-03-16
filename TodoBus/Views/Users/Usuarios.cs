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
using TodoBus.Views.SpareCategory;
using TodoBus.Views.Units;
using TodoBus.Views.Users;
using TodoBus.Models;
using TodoBus.Controllers;

namespace TodoBus
{
    public partial class Usuarios : Form
    {
        UserController userController = new UserController();
        public Usuarios()
        {
            InitializeComponent();
            btnUsers.Enabled = false;
        }

        private void btnRegUsuario_Click(object sender, EventArgs e)
        {
            RegUsuario frmRegUsers = new RegUsuario();
            frmRegUsers.ShowDialog();
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            this.Hide();
            Unidades frmUnits = new Unidades();
            frmUnits.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnSpare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repuestos frmRespuestos = new Repuestos();
            frmRespuestos.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marca frmM = new Marca();
            frmM.Show();
        }

        private void btnSpareTypes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category ct = new Category();
            ct.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
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

        private void btnUserConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosUsuario frmConfig = new DatosUsuario();
            frmConfig.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void formatTable()
        {
            if (dgvUsuarios.DataSource != null)
            {
                
                //Y ahora añadimos el boton modificar a la tabla
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.Name = "Editar";
                btnEdit.Text = "Modificar";
                btnEdit.UseColumnTextForButtonValue = true;
                btnEdit.HeaderText = "Modificar";
                dgvUsuarios.Columns.Add(btnEdit);
                //ahora el boton eliminar
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "Eliminar";
                btnDelete.Text = "Eliminar";
                btnDelete.UseColumnTextForButtonValue = true;
                btnDelete.HeaderText = "Eliminar";
                dgvUsuarios.Columns.Add(btnDelete);

                dgvUsuarios.Columns[0].HeaderText = "Id";
                dgvUsuarios.Columns[1].HeaderText = "Nombre";
                dgvUsuarios.Columns[2].HeaderText = "Apellido";
                dgvUsuarios.Columns[3].HeaderText = "Edad";
            }
        }
        private void Refresh()
        {
            if (dgvUsuarios.DataSource != null)
            {
                //Si esto no estaba vacio limpio todas las columas del Grid
                dgvUsuarios.Columns.Clear();
            }
            dgvUsuarios.DataSource = null;

            List<FakeUsers> users = new List<FakeUsers>();
            users = userController.getAllUsers();
            if (users.Count() > 0)
            {
                dgvUsuarios.DataSource = users;
            }
            else
            {
                dgvUsuarios.DataSource = null;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Refresh();
            formatTable();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Refresh();
            formatTable();
        }
    }
}
