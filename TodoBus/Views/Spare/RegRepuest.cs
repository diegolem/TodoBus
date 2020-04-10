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

        List<int> Subcategory = new List<int>();
        List<string> fillSubcategories = new List<string>();

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
                int idSubcategoria = -1;
                int idSubclase = -1;

                if (fillSubcategories[0] != "No hay subcategorías asociadas")
                {
                    idSubcategoria = Subcategory[cmbSubcategory.SelectedIndex];
                }

                if(fillcmb3[0] != "No hay subclases asociadas")
                {
                    idSubclase = Subclase[cmbSubclass.SelectedIndex];
                }

            string im = "Imagen no insertada";
                if(ckModImagen.Checked==false && ckModImagen.Visible==true)
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
                            bool save = sc.save(txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], idSubclase, url, idSubcategoria);
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
                                bool edit = sc.Modificar(id, codi, txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], idSubclase, url, idSubcategoria);
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
                                bool edit = sc.Modificar(id, codi, txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], idSubclase, url, idSubcategoria);
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


                            bool save = sc.save(txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], idSubclase, im, idSubcategoria);
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
                                bool edit = sc.Modificar(id, codi, txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], idSubclase, im, idSubcategoria);
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
                                bool edit = sc.Modificar(id, codi, txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], idSubclase, im, idSubcategoria);
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
                            bool save = sc.save(txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], idSubclase, url, idSubcategoria);
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
                                bool edit = sc.Modificar(id, codi, txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], idSubclase, url, idSubcategoria);
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
                                bool edit = sc.Modificar(id, codi, txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], idSubclase, url, idSubcategoria);
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
                            bool save = sc.save(txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], idSubclase, im, idSubcategoria);
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
                                bool edit = sc.Modificar(id,codi, txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], idSubclase, im, idSubcategoria);
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
                                    bool edit = sc.Modificar(id, codi, txtNombre.Text, typeid[cmbCategory.SelectedIndex], brandid[cmbBrand.SelectedIndex], idSubclase, im, idSubcategoria);
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
            fillcmb1.Clear();
            fillcmb2.Clear();
            

            sc.llenarCMB(ref typeid, ref brandid, ref fillcmb1, ref fillcmb2);

            cmbCategory.DataSource = fillcmb1;
            cmbBrand.DataSource = fillcmb2;
        }

        public void LlenarSubCategory(int id)
        {
            Subcategory.Clear();
            fillSubcategories.Clear();

            Subclase.Clear();
            fillcmb3.Clear();

            cmbSubcategory.DataSource = null;
            cmbSubclass.DataSource = null;

            sc.llenarCmbSubcategories(ref Subcategory, ref fillSubcategories, id);
            cmbSubcategory.DataSource = fillSubcategories;
        }

        public void LlenarSubClass(int id)
        {
            Subclase.Clear();
            fillcmb3.Clear();

            cmbSubclass.DataSource = null;

            sc.llenarCmbSubclasses(ref Subclase, ref fillcmb3, id);
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

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.DataSource != null)
            {
                LlenarSubCategory(typeid[cmbCategory.SelectedIndex]);
            }
        }

        private void cmbSubcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubcategory.DataSource != null)
            {
                LlenarSubClass(Subcategory[cmbSubcategory.SelectedIndex]);
            }
        }
    }
}
