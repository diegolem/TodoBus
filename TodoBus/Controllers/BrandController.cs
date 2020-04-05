using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBus.Models;

namespace TodoBus.Controllers
{
    class BrandController
    {
        public int save(string name, string descript)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    var lst = from d in db.brands
                              where d.name == name
                              select d;
                    if(lst.Count() == 0)
                    {
                        brands Marca = new brands();

                        Marca.name = name;
                        Marca.description = descript;

                        db.brands.Add(Marca);
                        db.SaveChanges();
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                catch
                {
                    return 0;
                }
            }
        }

        public bool edit(string name, string descript, brands brand)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    brand.name = name;
                    brand.description = descript;

                    db.Entry(brand).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public List<FakeBrands> getAllBrands()
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.brands
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<FakeBrands> customL = new List<FakeBrands>();
                    foreach (var brand in lst)
                    {
                        FakeBrands brandF = new FakeBrands();
                        brandF.Id = brand.id;
                        brandF.Nombre = brand.name;
                        brandF.Descripcion = (brand.description != "" ? brand.description : "No hay descripción");
                        customL.Add(brandF);
                    }
                    return customL;
                }
                else
                {
                    List<FakeBrands> newBR = new List<FakeBrands>();
                    return newBR;
                }
            }
        }

        public bool countBrands()
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                var lst = from d in db.brands
                          select d;
                if(lst.Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public brands getBrand(int? id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    brands br = db.brands.Find(id);
                    return br;
                }
                catch
                {
                    return null;
                }
            }
        }

        public bool delete(int? id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    //Se obtiene el objeto a borrar
                    brands brdn = db.brands.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.brands.Remove(brdn);
                    //Guardamos cambios
                    db.SaveChanges();
                    //Si todo bien regreso true
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
