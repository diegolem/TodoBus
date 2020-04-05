using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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
        List<int> Subclase = new List<int>();
        List<string> fillcmb1 = new List<string>();
        List<string> fillcmb2 = new List<string>();
        List<string> fillcmb3 = new List<string>();
        spare LoadSpare = new spare();
        
        public string Dic;
        public int? id;
        string codi;
        public RegRepuest(int? id=null,string ur=null,string cod=null)
        {
            InitializeComponent();
            this.id = id;
            this.Dic = ur;
            this.codi = cod;
        }
        public void CargarDatos()
        {
            if (id != null)
            {
                bool fd = sc.find(id, txtNombre, cmbSubclass, cmbBrand, bunifuImageButton2);
                if (fd)
                {
                    btnRegCliente.Text = "Modificar";
                    btnRegCliente.TextAlign = ContentAlignment.MiddleCenter;
                    ckModImagen.Visible = true;
                    ckModImagen.Checked = false;
                    bunifuImageButton2.Enabled = false;

                }

            }
        }
        public static void DeleteFile(string path)
        {
            if (!File.Exists(path))
            {
                return;
            }        
            try
            {
                File.Delete(path);
            }
            catch
            {

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
            try
            {
            string im = "Imagen no insertada";
                if(ckModImagen.Checked==false)
                {
                    im = Dic;
                }
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(btnRegCliente, "No puede dejar campos vacíos");
            }
            else
            {
                string Carpeta = Application.StartupPath + @"\Imagenes";
                if (Directory.Exists(Carpeta))
                {
                    try
                    {
                        bunifuImageButton2.Image = Image.FromFile(openFileDialog1.FileName);
                        bunifuImageButton2.Tag = openFileDialog1.FileName;
                        string nombre = Path.GetFileName(bunifuImageButton2.Tag.ToString());
                        string url = Carpeta + @"\" + nombre;
                        bunifuImageButton2.Image.Save(url);
                        if (btnRegCliente.Text == "Registrar Repuesto")
                        {
                            bool save = sc.save(txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], Subclase[cmbSubclass.SelectedIndex], url);
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
                            if (Dic == im)
                            {
                                bool edit = sc.Modificar(id, codi, txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], Subclase[cmbSubclass.SelectedIndex], url, LoadSpare);
                                if (edit)
                                {
                                    Limpiar();
                                    MessageBox.Show("El Repuesto se ha Modificado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                DeleteFile(Dic);
                                bool edit = sc.Modificar(id, codi, txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], Subclase[cmbSubclass.SelectedIndex], url, LoadSpare);
                                if (edit)
                                {
                                    Limpiar();
                                    MessageBox.Show("El Repuesto se ha Modificado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                        }
                    }
                    catch
                    {
                        if (btnRegCliente.Text == "Registrar Repuesto")
                        {


                            bool save = sc.save(txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], Subclase[cmbSubclass.SelectedIndex], im);
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
                            if (Dic == im)
                            {
                                bool edit = sc.Modificar(id, codi, txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], Subclase[cmbSubclass.SelectedIndex], im, LoadSpare);
                                if (edit)
                                {
                                    Limpiar();
                                    MessageBox.Show("El Repuesto se ha Modificado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                DeleteFile(Dic);
                                bool edit = sc.Modificar(id, codi, txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], Subclase[cmbSubclass.SelectedIndex], im, LoadSpare);
                                if (edit)
                                {
                                    Limpiar();
                                    MessageBox.Show("El Repuesto se ha Modificado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }


                            }
                        }
                    }
                }
                else
                {
                    Directory.CreateDirectory(Carpeta);
                    try
                    {
                        bunifuImageButton2.Image = Image.FromFile(openFileDialog1.FileName);
                        bunifuImageButton2.Tag = openFileDialog1.FileName;
                        string nombre = Path.GetFileName(bunifuImageButton2.Tag.ToString());
                        string url = Carpeta + @"\" + nombre;
                        bunifuImageButton2.Image.Save(url);
                        if (btnRegCliente.Text == "Registrar Repuesto")
                        {
                            bool save = sc.save(txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], Subclase[cmbSubclass.SelectedIndex], url);
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
                            if (Dic == im)
                            {
                                bool edit = sc.Modificar(id, codi, txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], Subclase[cmbSubclass.SelectedIndex], url, LoadSpare);
                                if (edit)
                                {
                                    Limpiar();
                                    MessageBox.Show("El Repuesto se ha Modificado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                DeleteFile(Dic);
                                bool edit = sc.Modificar(id, codi, txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], Subclase[cmbSubclass.SelectedIndex], url, LoadSpare);
                                if (edit)
                                {
                                    Limpiar();
                                    MessageBox.Show("El Repuesto se ha Modificado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                        }
                    }
                    catch
                    {
                        if (btnRegCliente.Text == "Registrar Repuesto")
                        {
                            bool save = sc.save(txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], Subclase[cmbSubclass.SelectedIndex], im);
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
                            if (Dic == im)
                            {
                                bool edit = sc.Modificar(id,codi, txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], Subclase[cmbSubclass.SelectedIndex], im, LoadSpare);
                                if (edit)
                                {
                                    Limpiar();
                                    MessageBox.Show("El Repuesto se ha Modificado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                DeleteFile(Dic);
                                {
                                    bool edit = sc.Modificar(id, codi, txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], Subclase[cmbSubclass.SelectedIndex], im, LoadSpare);
                                    if (edit)
                                    {
                                        Limpiar();
                                        MessageBox.Show("El Repuesto se ha Modificado exitosamente", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }

                }

            }
        }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
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
            Subclase.Clear();
            fillcmb1.Clear();
            fillcmb2.Clear();
            fillcmb3.Clear();
            

            sc.llenarCMB(ref typeid, ref brandid,ref Subclase, ref fillcmb1, ref fillcmb2,ref fillcmb3);
            cmbCategory.DataSource = fillcmb1;
            cmbBrand.DataSource = fillcmb2;
            cmbSubclass.DataSource = fillcmb3;


        }
        #endregion

        private void RegRepuest_Load(object sender, EventArgs e)
        {
            Llenar();
            CargarDatos();
        }

        private void ckModImagen_CheckedChanged(object sender, EventArgs e)
        {
            if(ckModImagen.Checked==true)
            {
                bunifuImageButton2.Enabled = true;
            }
            if(ckModImagen.Checked == false)
            {
                bunifuImageButton2.Enabled = false;
            }
        }
    }
}
