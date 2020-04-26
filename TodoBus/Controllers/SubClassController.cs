using System;
using System.Collections.Generic;
using System.Linq;
using TodoBus.Models;
using System.Windows.Forms;

namespace TodoBus.Controllers
{
    class SubClassController
    {
        public int save(string code, string name, int subcategory_id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    var lst = from d in db.spare_subclasses
                              where d.name == name
                              select d;
                    if (lst.Count() == 0)
                    {
                        spare_subclasses Subclase = new spare_subclasses();

                        Subclase.code = code;
                        Subclase.name = name;
                        Subclase.subcategory_id = subcategory_id;

                        db.spare_subclasses.Add(Subclase);
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
                {
                    return false;
                }
            }
        }

        public bool countSubClasses()
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                var lst = from d in db.spare_subclasses
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

        public void getSubClasses(ref List<int> SubcategoryId, ref List<string> fillcmb)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                var lst = from d in db.spare_subcategories
                          select d;
                foreach (var Subcategory in lst)
                {
                    fillcmb.Add(Subcategory.name);
                    SubcategoryId.Add(Subcategory.id);
                }
            }
        }

        public void buscar(ref Bunifu.Framework.UI.BunifuCustomDataGrid dgv, string cadena, string index)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {

                var lst = from d in db.spare_subclasses
                          join c in db.spare_subcategories on d.subcategory_id equals c.id
                          select d;

                if (index == "Código")
                {
                    lst = lst.Where(c => c.code.Contains(cadena));
                }
                else if (index == "Nombre")
                {
                    lst = lst.Where(c => c.name.Contains(cadena));
                }
                else if (index == "Subcategoría")
                {
                    lst = lst.Where(c => c.spare_subcategories.name.Contains(cadena));
                }

                if (lst.Count() > 0)
                {
                    List<FakeSubClasses> customL = new List<FakeSubClasses>();
                    foreach (var subclass in lst)
                    {
                        FakeSubClasses ClassF = new FakeSubClasses();
                        ClassF.Id = subclass.id;
                        ClassF.Codigo = subclass.code;
                        ClassF.Nombre = subclass.name;
                        ClassF.NombreSubCategoria = subclass.spare_subcategories.name;
                        customL.Add(ClassF);

                        if (dgv.DataSource != null)
                        {
                            dgv.Columns.Clear();
                        }

                        dgv.DataSource = null;
                        dgv.DataSource = customL;

                    }
                }
                else
                {
                    List<FakeSubClasses> newCl = new List<FakeSubClasses>();
                    dgv.DataSource = newCl;
                }


            }
        }
    }
}
