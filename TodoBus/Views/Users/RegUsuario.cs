using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoBus.Controllers;
using TodoBus.Models;

namespace TodoBus
{
    public partial class RegUsuario : Form
    {
        ValidationController valid = new ValidationController();
        UserController UserC = new UserController();
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
                    bool save = UserC.save(txtname.Text, txtlastname.Text, txtemail.Text, int.Parse(numage.Text), PasswordtextBox.Text);
                    if (save)
                    {
                        //Limpio los controles
                        clearFields();
                        MessageBox.Show("El Usuario se ha ingresado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Ya existe una Usuario con estas mismas caracteristicas", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Ep1.SetError(txtlastname, "El Apelllido no puede quedar vacío");
                return false;
            }
            if (!(valid.isString(txtemail.Text)))
            {
                Ep1.SetError(txtemail, "El Correo no puede quedar vacío");
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
            numage.Text = "18";
            PasswordtextBox.Text = "";
        }

        
    }
}
