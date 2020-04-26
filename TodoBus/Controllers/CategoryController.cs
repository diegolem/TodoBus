using System;
using System.Collections.Generic;
using System.Linq;
using TodoBus.Models;

namespace TodoBus.Controllers
{
    class CategoryController
    {
        public int save(string code, string name)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    var lst = from d in db.spare_categories
                              where d.code == code && d.name == name
                              select d;

                    if(lst.Count() == 0)
                    {
                        spare_categories Category = new spare_categories();

                        Category.code = code;
                        Category.name = name;


                        db.spare_categories.Add(Category);
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

        public bool countCategories()
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                var lst = from d in db.spare_categories
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

        public bool edit(string code, string name, spare_categories Category)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    Category.code = code;
                    Category.name = name;

                    db.Entry(Category).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public List<FakeCategories> getAllCategories()
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.spare_categories
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<FakeCategories> customL = new List<FakeCategories>();
                    foreach (var Category in lst)
                    {
                        FakeCategories categoryF = new FakeCategories();
                        categoryF.Id = Category.id;
                        categoryF.Codigo = Category.code;
                        categoryF.Nombre = Category.name;
                        customL.Add(categoryF);
                    }
                    return customL;
                }
                else
                {
                    List<FakeCategories> newC = new List<FakeCategories>();
                    return newC;
                }
            }
        }

        public void buscar(ref Bunifu.Framework.UI.BunifuCustomDataGrid dgv, string cadena, string index)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                var lst = from d in db.spare_categories
                          select d;

                if (index == "Código")
                {
                    lst = lst.Where(c => c.code.Contains(cadena));
                }
                else if (index == "Nombre")
                {
                    lst = lst.Where(c => c.name.Contains(cadena));
                }

                if (lst.Count() > 0)
                {
                    List<FakeCategories> customL = new List<FakeCategories>();
                    foreach (var Category in lst)
                    {
                        FakeCategories categoryF = new FakeCategories();
                        categoryF.Id = Category.id;
                        categoryF.Codigo = Category.code;
                        categoryF.Nombre = Category.name;
                        customL.Add(categoryF);
                    }

                    if (dgv.DataSource != null)
                    {
                        dgv.Columns.Clear();
                    }

                    dgv.DataSource = null;
                    dgv.DataSource = customL;
                }
                else
                {
                    List<FakeCategories> newCl = new List<FakeCategories>();
                    dgv.DataSource = newCl;
                }
            }
        }

        public spare_categories getCategory(int? id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    spare_categories scat = db.spare_categories.Find(id);
                    return scat;
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

                    spare_categories categor = db.spare_categories.Find(id);
                    db.spare_categories.Remove(categor);
                    db.SaveChanges();

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
