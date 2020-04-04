using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TodoBus.Views.Brands;
using TodoBus.Views.SpareCategoriesSubClasses;
using TodoBus.Views.SpareCategory;
using TodoBus.Views.Units;
using TodoBus.Views.Users;
using TodoBus.Controllers;
using TodoBus.Models;

namespace TodoBus
{
    public partial class Usuarios : Form
    {
        UserController userController = new UserController();
        users user = new users();
        public Usuarios(users userS)
        {
            InitializeComponent();
            this.user = userS;
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
            Unidades frmUnits = new Unidades(user);
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
            Clientes frmClientes = new Clientes(user);
            frmClientes.Show();
        }

        private void btnSpare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repuestos frmRespuestos = new Repuestos(user);
            frmRespuestos.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
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

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
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
                btnEdit.FlatStyle = FlatStyle.Flat;
                btnEdit.Text = "Modificar";
                btnEdit.UseColumnTextForButtonValue = true;
                btnEdit.HeaderText = "Modificar";
                dgvUsuarios.Columns.Add(btnEdit);
                //ahora el boton eliminar
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.FlatStyle = FlatStyle.Flat;
                btnDelete.Text = "Eliminar";
                btnDelete.UseColumnTextForButtonValue = true;
                btnDelete.HeaderText = "Eliminar";
                dgvUsuarios.Columns.Add(btnDelete);

                dgvUsuarios.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUsuarios.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUsuarios.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUsuarios.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUsuarios.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUsuarios.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUsuarios.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvUsuarios.Columns[0].HeaderText = "Id";
                dgvUsuarios.Columns[0].Width = 30;
                dgvUsuarios.Columns[1].HeaderText = "Nombre";
                dgvUsuarios.Columns[2].HeaderText = "Apellido";
                dgvUsuarios.Columns[3].HeaderText = "Edad";
                dgvUsuarios.Columns[3].Width = 50;
                dgvUsuarios.Columns[4].HeaderText = "Correo";
                dgvUsuarios.Columns[4].Width = 150;


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
            users = userController.getAllUsers(user.id);
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

        private int? getId()
        {
            //Metodo para obtener el id de la columna seleccionada
            try
            {
                //Y le decimos que obtenga de mi dgv el valor de la celda 0(que es id) de la fila que se encuentre seleccionada
                return int.Parse(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Los index empiezan desde 0, asi que verificamos en que columna estan los botones modificar y eliminar, para obtener correctamente el id
            int? id = getId();

            if (e.ColumnIndex == 5)
            {
                if (id != null)
                {
                    ModUser mod = new ModUser(id);
                    mod.ShowDialog();
                }
            }
            else if (e.ColumnIndex == 6)
            {
                if (id != null)
                {
                    DialogResult result = MessageBox.Show("¿Estas seguro que deseas eliminar este Usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (result == DialogResult.Yes)
                    {
                        if (userController.delete(id))
                        {
                            MessageBox.Show("El Usuario se ha eliminado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error al eliminar el Usuario", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        Refresh();
                        formatTable();
                    }
                }
            }
        }
    }
}
