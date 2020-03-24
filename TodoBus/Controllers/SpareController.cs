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
        public bool save(string nombre,int Categoria,int marca,int SubClases ,string imagen)
        {
            using(TodoBusEntities db=new TodoBusEntities())
            {
                try
                {
                    string codSubClass;                   
                    string codCategory;
                    string codigo;
                    spare_subclasses osubcla = new spare_subclasses();
                    spare_subcategories osubcat = new spare_subcategories();
                    spare_categories oCate = new spare_categories();
                    
                    spare oSpare = new spare();
                    osubcla = db.spare_subclasses.Find(SubClases);
                    codSubClass = osubcla.code;                   
                    oCate = db.spare_categories.Find(Categoria);
                    codCategory = oCate.code;
                    string cadena = codCategory + codSubClass;

                    var lst1 = from d in db.spare
                               select d;

                    lst1=lst1.Where(d => d.code.Contains(cadena));
                    int numero= lst1.Count()+1;
                    codigo = cadena + numero.ToString();
                    oSpare.code = codigo;
                    oSpare.name = nombre;
                    oSpare.spare_type_id = Categoria;
                    oSpare.brand_id = marca;
                    oSpare.image = imagen;

                    db.spare.Add(oSpare);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
                
            }
            
        }
        public void llenarCMB(ref List<int> typeid, ref List<int> brandid,ref List<int> subclase, ref List<string> fillcmb1, ref List<string> fillcmb2, ref List<string> fillcmb3)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {             
                var lst1 = from d in db.spare_categories
                           select d;               
                foreach (var category in lst1)
                {
                    fillcmb1.Add(category.name);
                   
                    typeid.Add(category.id);
                }
                var lst2 = from d in db.brands
                           select d;           
                foreach (var Brand in lst2)
                {
                    fillcmb2.Add(Brand.name);                    
                    brandid.Add(Brand.id);
                }
                var lst3 = from d in db.spare_subclasses
                           select d;
                foreach(var cla in lst3)
                {
                    fillcmb3.Add(cla.name);
                    subclase.Add(cla.id);
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
                        spareF.UrlImagen = spare.image;
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
        public bool find(int? id,TextBox nombre,ComboBox tipo, ComboBox marca,PictureBox imagen)
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
        public bool Modificar(string codigo, string nombre, int tipo, int marca, string imagen, spare sp)
        {
            using(TodoBusEntities db=new TodoBusEntities())
            {
                try
                {
                    sp.code = codigo;
                    sp.name = nombre;
                    sp.spare_type_id = tipo;
                    sp.brand_id = marca;
                    sp.image = imagen;
                    db.Entry(sp).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public void EliImage(string Url)
        {
            File.Delete(Url);            
        }
        public void GenCod()
        {

        }

    }

}
