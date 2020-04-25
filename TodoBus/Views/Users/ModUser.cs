using System;
using System.Windows.Forms;
using TodoBus.Controllers;
using TodoBus.Models;

namespace TodoBus
{
    public partial class ModUser : Form
    {
        public int? id;
        ValidationController valid = new ValidationController();
        UserController UserC = new UserController();

        users loadUser = new users();

        public ModUser(int? id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ModUser_Load(object sender, EventArgs e)
        {
            loadUser = UserC.getUser(id);
            if (loadUser != null)
            {
                txtname.Text = loadUser.name;
                txtlastname.Text = loadUser.last_name;
                txtemail.Text = loadUser.email;
            }
        }

        private void Checkbox1_OnChange(object sender, EventArgs e)
        {
            PasswordtextBox.UseSystemPasswordChar = !Checkbox1.Checked;
        }

        private void btnRegCliente_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                try
                {
                    bool edit = UserC.edit(txtname.Text, txtlastname.Text, txtemail.Text, PasswordtextBox.Text, loadUser);
                    if (edit)
                    {
                        MessageBox.Show("El Usuario se ha modificado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private bool validateFields()
        {
            Ep1.Clear();
            if (!(valid.isString(txtname.Text)))
            {
                Ep1.SetError(txtname, "El Nombre no puede quedar vacío");
                return false;
            }
            if (!(valid.isString(txtlastname.Text)))
            {
                Ep1.SetError(txtlastname, "El Apellido no puede quedar vacío");
                return false;
            }
            if (!(valid.isString(txtemail.Text)))
            {
                Ep1.SetError(txtemail, "El Correo no puede quedar vacío");
                return false;
            }

            if (!(valid.isEmail(txtemail.Text)))
            {
                Ep1.SetError(txtemail, "Porfavor ingresa un correo válido");
                return false;
            }
            return true;
        }
    }
}
