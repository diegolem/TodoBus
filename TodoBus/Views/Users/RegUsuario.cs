using System;
using System.Windows.Forms;
using TodoBus.Controllers;
using TodoBus.Models;

namespace TodoBus
{
    public partial class RegUsuario : Form
    {
        ValidationController valid = new ValidationController();
        UserController UserC = new UserController();
        AlertController alerts = new AlertController();

        public RegUsuario()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
           PasswordtextBox.UseSystemPasswordChar = !Checkbox1.Checked;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegCliente_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                try
                {
                    //Mando a llamar el metodo de guardar del controller y paso los parametros
                    int save = UserC.save(txtname.Text, txtlastname.Text, txtemail.Text, PasswordtextBox.Text);
                    if (save == 1)
                    {
                        DialogResult result = MessageBox.Show("El usuario se ha ingresado exitosamente\n\n¿Quieres registrar otro usuario?", "TodoBus", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            clearFields();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else if (save == 2)
                    {
                        alerts.errorInSaveChanges("un usuario");
                    }
                    else
                    {
                        alerts.errorInSaveChanges("");
                    }
                }
                catch
                {
                    alerts.errorInSaveChanges("");
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
            if (!(valid.isString(PasswordtextBox.Text)))
            {
                Ep1.SetError(PasswordtextBox, "Contraseña no puede quedar vacía");
                return false;
            }
            return true;
        }

        private void clearFields()
        {
            txtname.Text = "";
            txtlastname.Text = "";
            txtemail.Text = "";
            PasswordtextBox.Text = "";
        }

        
    }
}
