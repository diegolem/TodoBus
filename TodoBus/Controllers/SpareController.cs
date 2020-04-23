using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBus.Models;
using System.Windows.Forms;
using System.IO;


namespace TodoBus.Controllers
{
    class SpareController
    {
        CodeController codeController = new CodeController();
        public bool save(string nombre,int Categoria,int marca,int SubClases ,string imagen, int subCategoria,string descripcion)
        {
            using(TodoBusEntities db=new TodoBusEntities())
            {
                try
                {
                    string codSubClass = "";                   
                    string codCategory = "";
                    string codsubCate = "";
                    string codigo;

                    spare oSpare = new spare();
                    spare_subclasses osubcla = new spare_subclasses();
                    spare_subcategories osubcat = new spare_subcategories();
                    spare_categories oCate = new spare_categories();

                    oCate = db.spare_categories.Find(Categoria);
                    codCategory = oCate.code;

                    osubcat = db.spare_subcategories.Find(subCategoria);
                    if (osubcat != null)
                    {
                        codsubCate = osubcat.code;
                    }

                    osubcla = db.spare_subclasses.Find(SubClases);
                    if(osubcla != null)
                    {
                        codSubClass = osubcla.code;
                    }

                    string cadena = codCategory + codsubCate + codSubClass;

                    int numero = codeController.findSpareCode(codCategory + "-" + codsubCate + "-" + codSubClass);

                    if (numero > 0)
                    {
                        codigo = cadena + this.complementaryCode(numero);

                        oSpare.code = codigo;
                        oSpare.name = nombre;
                        oSpare.spare_type_id = Categoria;
                        oSpare.brand_id = marca;
                        oSpare.image = imagen;
                        oSpare.description = descripcion;

                        db.spare.Add(oSpare);
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }

        public string complementaryCode(int numero)
        {
            string cadena = "";
            if (numero > 0 && numero <= 9)
            {
                cadena = "000" + numero.ToString();
            } else if (numero >= 10 && numero <= 99)
            {
                cadena = "00" + numero.ToString();
            } else if (numero >= 100 && numero <= 999)
            {
                cadena = "0" + numero.ToString();
            } else if (numero >= 1000 && numero <= 9999) {
                cadena = numero.ToString();
            }
            return cadena;
        }

        public bool Modificar(int? id, string codigoAnterior, string nombre, int Categoria, int marca, int SubClases, string imagen, int Subcategoria,string descripcion)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    string codSubClass = "";
                    string codCategory = "";
                    string codsubCate = "";                    
                    spare fnd = db.spare.Find(id);

                    spare_subclasses osubcla = new spare_subclasses();
                    spare_subcategories osubcat = new spare_subcategories();
                    spare_categories oCate = new spare_categories();

                    oCate = db.spare_categories.Find(Categoria);
                    codCategory = oCate.code;

                    osubcat = db.spare_subcategories.Find(Subcategoria);
                    if (osubcat != null)
                    {
                        codsubCate = osubcat.code;
                    }

                    osubcla = db.spare_subclasses.Find(SubClases);
                    if (osubcla != null)
                    {
                        codSubClass = osubcla.code;
                    }
                    //Probable nuevo codigo
                    string nuevoCodigo = codCategory + codsubCate + codSubClass;

                    int longitudCodigo = codigoAnterior.Length - 4;

                    string codigoAlfanumerico = codigoAnterior.Substring(0, longitudCodigo);

                    if (nuevoCodigo != codigoAlfanumerico)
                    {
                        int numero = codeController.findSpareCode(codCategory + "-" + codsubCate + "-" + codSubClass);
                        if (numero > 0)
                        {
                            fnd.code = nuevoCodigo + this.complementaryCode(numero);
                            fnd.name = nombre;
                            fnd.spare_type_id = Categoria;
                            fnd.brand_id = marca;
                            fnd.image = imagen;
                            fnd.description = descripcion;

                            db.Entry(fnd).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else{
                        fnd.name = nombre;
                        fnd.spare_type_id = Categoria;
                        fnd.brand_id = marca;
                        fnd.image = imagen;
                        fnd.description = descripcion;

                        db.Entry(fnd).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        return true;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }
        public void llenarCMB(ref List<int> typeid, ref List<int> brandid, ref List<string> fillcmb1, ref List<string> fillcmb2)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {             
                var lst1 = from d in db.spare_categories
                           select d;               
                foreach (var category in lst1)
                {
                    fillcmb1.Add("Código: " + category.code + " - " + category.name);
                    typeid.Add(category.id);
                }
                var lst2 = from d in db.brands
                           select d;           
                foreach (var Brand in lst2)
                {
                    fillcmb2.Add(Brand.name);                    
                    brandid.Add(Brand.id);
                }
            }
        }

        public void llenarCmbSubcategories(ref List<int> subcategoriesId, ref List<string> subcategoriesCmb, int category_id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                var lst = from d in db.spare_subcategories
                           where d.category_id == category_id
                           select d;
                if(lst.Count() > 0)
                {
                    foreach (var Subcategory in lst)
                    {
                        subcategoriesId.Add(Subcategory.id);
                        subcategoriesCmb.Add("Código: " + Subcategory.code + " - " + Subcategory.name);
                    }
                }
                else
                {
                    subcategoriesId.Add(-1);
                    subcategoriesCmb.Add("No hay subcategorías asociadas");
                }
            }
        }

        public void llenarCmbSubclasses(ref List<int> subclassesId, ref List<string> subclassesCmb, int subcategory_id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                var lst = from d in db.spare_subclasses
                          where d.subcategory_id == subcategory_id
                          select d;
                if(lst.Count() > 0)
                {
                    foreach (var Subclasses in lst)
                    {
                        subclassesId.Add(Subclasses.id);
                        subclassesCmb.Add("Código: " + Subclasses.code + " - " + Subclasses.name);
                    }
                }
                else
                {
                    subclassesId.Add(-1);
                    subclassesCmb.Add("No hay subclases asociadas");
                }
            }
        }

        public bool countSpares()
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                var lst = from d in db.spare
                          select d;
                if (lst.Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List<FakeSpare> getAllSpare()
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                
                var lst = from d in db.spare
                          join m in db.brands on d.brand_id equals m.id
                          join c in db.spare_categories on d.spare_type_id equals c.id
                          select d;
                
                if (lst.Count() > 0)
                {
                    List<FakeSpare> customL = new List<FakeSpare>();
                    foreach (var spare in lst)
                    {
                        FakeSpare spareF = new FakeSpare();
                        spareF.Id = spare.id;
                        spareF.Codigo = spare.code;
                        spareF.Nombre = spare.name;
                        spareF.Descripcion = spare.description;
                        spareF.NombreMarca = spare.brands.name;
                        spareF.NombreCategoria = spare.spare_categories.name;
                        customL.Add(spareF);
                    }
                    return customL;
                }
                else
                {
                    List<FakeSpare> newSC = new List<FakeSpare>();
                    return newSC;
                }
            }
        }
        public bool delete(int? id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                   
                    spare subc = db.spare.Find(id);
                    
                    db.spare.Remove(subc);
                    
                    db.SaveChanges();
                    
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public bool find(int? id,TextBox nombre,ComboBox tipo, ComboBox marca,PictureBox imagen,TextBox descripcion)
        {
            
            
            using(TodoBusEntities db=new TodoBusEntities())
            { 
                   
                 try
                 {
                    int type;
                    int? brand;
                    spare fnd = db.spare.Find(id);
                    type = fnd.spare_type_id;
                    brand = fnd.brand_id;
                    brands br = db.brands.Find(brand);
                    spare_categories sc = db.spare_categories.Find(type);

                    nombre.Text = fnd.name;
                    descripcion.Text = fnd.description;
                    tipo.SelectedItem = sc.name;
                    marca.SelectedItem = br.name;
                    try
                    {
                        imagen.Load(fnd.image);
                        
                    }
                    catch
                    {
                        
                    }
                    return true;
                 }
                catch
                {
                    return false;
                }
            }
            
        }
        public void Busqueda(DataGridView data,string dato,RadioButton codigo,RadioButton nombre, RadioButton marca, RadioButton categoria)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {

                var lst = from d in db.spare
                          join m in db.brands on d.brand_id equals m.id
                          join c in db.spare_categories on d.spare_type_id equals c.id
                          select d;

                
                
                brands brandsF = new brands();
                FakeCategories cateF = new FakeCategories();

                


                if (codigo.Checked == true)
                {
                    lst = lst.Where(d => d.code.Contains(dato));
                }
                else if (nombre.Checked == true)
                {
                    lst = lst.Where(d => d.name.Contains(dato));
                }
                else if (marca.Checked == true)
                {
                    lst = lst.Where(d => d.brands.name.Contains(dato));
                }
                else if (categoria.Checked == true)
                {
                    lst = lst.Where(d => d.spare_categories.name.Contains(dato));
                }


                if (lst.Count() > 0)
                {
                    List<FakeSpare> customL = new List<FakeSpare>();
                    foreach (var spare in lst)
                    {
                        FakeSpare spareF = new FakeSpare();
                        spareF.Id = spare.id;
                        spareF.Codigo = spare.code;
                        spareF.Nombre = spare.name;
                        spareF.Descripcion = spare.description;
                        spareF.NombreMarca = spare.brands.name;
                        spareF.NombreCategoria = spare.spare_categories.name;
                        customL.Add(spareF);
                        if (data.DataSource != null)
                        {

                            data.Columns.Clear();
                        }
                        data.DataSource = null;


                        data.DataSource = customL;

                    }
                }
                else
                {
                    List<FakeSpare> newSC = new List<FakeSpare>();
                    data.DataSource = newSC;
                }
                

            }
        }
        public string imagen(int? id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                spare fnd = db.spare.Find(id);
                return fnd.image;
            }
        }
    }

}
