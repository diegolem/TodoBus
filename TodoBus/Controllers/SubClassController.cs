using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBus.Models;

namespace TodoBus.Controllers
{
    class SubClassController
    {
        public bool save(string code, string name, int subcategory_id)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    //Defino el nuevo objeto
                    spare_subclasses Subclase = new spare_subclasses();
                    //Luego obtengo todos los valores y los asigno a los campos del nuevo objeto
                    Subclase.code = code;
                    Subclase.name = name;
                    Subclase.subcategory_id = subcategory_id;

                    //Añado a mi tabla la subcategoria(objeto)
                    db.spare_subclasses.Add(Subclase);
                    //Guardo los cambios para confirmar
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
        public bool edit(string code, string name, int subcategory_id, spare_subclasses Subclase)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    Subclase.code = code;
                    Subclase.name = name;
                    Subclase.subcategory_id = subcategory_id;
                    db.Entry(Subclase).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                { return false; 
                }
            }

        }
        public List<FakeSubClasses> getAllSubclasses()
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.spare_subclasses
                          join sc in db.spare_subcategories on d.subcategory_id equals sc.id
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<FakeSubClasses> customL = new List<FakeSubClasses>();
                    foreach (var sub in lst)
                    {
                        FakeSubClasses subF = new FakeSubClasses();
                        subF.Id = sub.id;
                        subF.Nombre = sub.name;
                        subF.Codigo = sub.code;
                        subF.NombreSubCategoria = sub.spare_subcategories.name;
                        customL.Add(subF);
                    }
                    return customL;
                }
                else
                {
                    List<FakeSubClasses> newSCl = new List<FakeSubClasses>();
                    return newSCl;
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
                    spare_subclasses subcl = db.spare_subclasses.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.spare_subclasses.Remove(subcl);
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
        public spare_subclasses getSubclass(int? id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    spare_subclasses ssc = db.spare_subclasses.Find(id);
                    return ssc;
                }
                catch
                {
                    return null;
                }
            }
        }
        public void getSubClass(ref List<int> brandsId, ref List<string> fillcmb)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                var lst = from d in db.brands
                          select d;
                foreach (var brand in lst)
                {
                    fillcmb.Add(brand.name);
                    brandsId.Add(brand.id);
                }
            }
        }
        public spare_subcategories getSubCategory(int? id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    spare_subcategories sbc = db.spare_subcategories.Find(id);
                    return sbc;
                }
                catch
                {
                    return null;
                }

            }
        }
    }
}
