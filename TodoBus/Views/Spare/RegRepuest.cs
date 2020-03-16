using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TodoBus.Models;

namespace TodoBus
{
    public partial class RegRepuest : Form
    {
        Controllers.SpareController sc = new Controllers.SpareController();
        List<int> typeid = new List<int>();
        List<int> brandid = new List<int>();
        List<string> fillcmb1 = new List<string>();
        List<string> fillcmb2 = new List<string>();
        public RegRepuest(int? id)
        {
            InitializeComponent();
            if(id!=null)
            {
               bool fd=sc.find(id, txtCodigo, txtNombre, cmbType, cmbBrand, bunifuImageButton2);
                if(fd)
                {
                    btnRegCliente.Text = "Modificar";
                    btnRegCliente.TextAlign = ContentAlignment.MiddleCenter;
                }
                
            }
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegCliente_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text==""|| txtCodigo.Text==""|| bunifuImageButton2.Image==null)
            {
                errorProvider1.SetError(btnRegCliente, "No puede dejar campos ni imagen vacía");
            }
            else
            {
                bunifuImageButton2.Image = Image.FromFile(openFileDialog1.FileName);

                bunifuImageButton2.Tag = openFileDialog1.FileName;
                string nombre = Path.GetFileName(bunifuImageButton2.Tag.ToString());
                string Carpeta = Application.StartupPath + @"\Imagenes";
                string url = Carpeta + @"\" + nombre;
                if (Directory.Exists(Carpeta))
                {

                    
                    try
                    {
                        bunifuImageButton2.Image.Save(url);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar la imagen" + ex);
                    }
                    bool save = sc.save(txtCodigo.Text, txtNombre.Text, typeid[cmbType.SelectedIndex], brandid[cmbBrand.SelectedIndex], url);
                    if (save)
                    {
                        Limpiar();
                        MessageBox.Show("El Repuesto se ha ingresado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Directory.CreateDirectory(Carpeta);
                    try
                    {
                        bunifuImageButton2.Image.Save(url);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar la imagen" + ex);
                    }
                    bool save = sc.save(txtCodigo.Text, txtNombre.Text, typeid[cmbType.SelectedIndex], brandid[cmbBrand.SelectedIndex], url);
                    if (save)
                    {
                        Limpiar();
                        MessageBox.Show("El Repuesto se ha ingresado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

            
           
        
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png (*.png)|*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string url = openFileDialog1.FileName;


                bunifuImageButton2.SizeMode = PictureBoxSizeMode.StretchImage;
                bunifuImageButton2.Load(url);

            }



        }

        private void bunifuImageButton2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        public void Limpiar()
        {
            {
                txtCodigo.Text = "";
                txtNombre.Text = "";
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        #region helper
        public void Llenar()
        {
            typeid.Clear();
            brandid.Clear();
            fillcmb1.Clear();
            fillcmb2.Clear();

            sc.llenarCMB(ref typeid, ref brandid, ref fillcmb1, ref fillcmb2);
            cmbType.DataSource = fillcmb1;
            cmbBrand.DataSource = fillcmb2;

        }
        #endregion

        private void RegRepuest_Load(object sender, EventArgs e)
        {
            Llenar();
        }
    }
}
