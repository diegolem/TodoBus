using System;
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
    public partial class Repuestos : Form
    {
        SpareController control = new SpareController();
        public Repuestos()
        {
            InitializeComponent();
            btnSpare.Enabled = false;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscador_OnTextChange(object sender, EventArgs e)
        {

        }

        private void btnRegCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegRepuest frmRegSpare = new RegRepuest(null);
            frmRegSpare.Show();
        }

        private void Options_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region Helper
        private void Refresh()
        {
            if (dgvRepuestos.DataSource != null)
            {
                
                dgvRepuestos.Columns.Clear();
            }
            dgvRepuestos.DataSource = null;

            List<spare> spares = new List<spare>();
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
            Refresh();
            formatTable();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes frmClientes = new Clientes();
            frmClientes.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            Usuarios frmUsuario = new Usuarios();
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
            Unidades frmUnits = new Unidades();
            frmUnits.Show();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marca frmB = new Marca();
            frmB.Show();
        }

        private void btnSpareTypes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category ct = new Category();
            ct.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubClasses frmSub = new SubClasses();
            frmSub.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void formatTable()
        {
            if (dgvRepuestos.DataSource != null)
            {
                
                dgvRepuestos.Columns.Remove("brands");
                dgvRepuestos.Columns.Remove("spare_categories");
                dgvRepuestos.Columns.Remove("units_spare");
                
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

                //Renombro las columnas del dgv como quiera
                dgvRepuestos.Columns[0].HeaderText = "Id";
                dgvRepuestos.Columns[1].HeaderText = "Nombre";
                dgvRepuestos.Columns[2].HeaderText = "Imagen";
                dgvRepuestos.Columns[3].HeaderText = "Código";
                dgvRepuestos.Columns[4].HeaderText = "Marca";
                dgvRepuestos.Columns[5].HeaderText = "Categoría";
                dgvRepuestos.Columns[2].Width = 185;
            }
        }

        private void dgvRepuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int? id = getId();

            if (e.ColumnIndex == 6)
            {
                if (id != null)
                {
                    MessageBox.Show("Presionaste modificar " + id);
                    RegRepuest r = new RegRepuest(id);
                    this.Hide();
                    r.Show();
                    
                }
            }
            else if (e.ColumnIndex == 7)
            {
                if (id != null)
                {
                    DialogResult result = MessageBox.Show("¿Estas seguro que deseas eliminar esta subcategoría?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (result == DialogResult.Yes)
                    {
                        if (control.delete(id))
                        {
                            MessageBox.Show("La Subcategoria se ha eliminado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error al eliminar la categoria", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        Refresh();
                        formatTable();
                    }
                }
            }
        }
    }
}
