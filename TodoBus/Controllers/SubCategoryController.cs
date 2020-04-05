using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBus.Models;


namespace TodoBus.Controllers
{
    class SubCategoryController
    {
        public int save(string name, string code, int category_id)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    var lst = from d in db.spare_subcategories
                              where d.name == name
                              select d;

                    if(lst.Count() == 0)
                    {
                        spare_subcategories subCategory = new spare_subcategories();
                        subCategory.name = name;
                        subCategory.code = code;
                        subCategory.category_id = category_id;

                        db.spare_subcategories.Add(subCategory);
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

        public bool edit(string name, string code, int category_id, spare_subcategories subCategory)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    subCategory.name = name;
                    subCategory.code = code;
                    subCategory.category_id = category_id;

                    db.Entry(subCategory).State = System.Data.Entity.EntityState.Modified;
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
        public bool countSubCategories()
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                var lst = from d in db.spare_subcategories
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


        public List<FakeSubCategories> getAllSubCategories()
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.spare_subcategories
                          join c in db.spare_categories on d.category_id equals c.id
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<FakeSubCategories> customL = new List<FakeSubCategories>();
                    foreach (var sub in lst)
                    {
                        FakeSubCategories subF = new FakeSubCategories();
                        subF.Id = sub.id;
                        subF.Codigo = sub.code;
                        subF.Nombre = sub.name;
                        subF.NombreCategoria = sub.spare_categories.name;
                        customL.Add(subF);
                    }
                    return customL;
                }
                else
                {
                    List<FakeSubCategories> newSC = new List<FakeSubCategories>();
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

                    spare_subcategories subc = db.spare_subcategories.Find(id);
                    if (subc.spare_categories != null)
                    {
                        return false;
                    }
                    else
                    {
                        db.spare_subcategories.Remove(subc);

                        db.SaveChanges();
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public spare_subcategories getSubCategory(int? id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    spare_subcategories sc = db.spare_subcategories.Find(id);
                    return sc;
                }
                catch
                {
                    return null;
                }
            }
        }

        public spare_categories getCategory(int? id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    spare_categories sc = db.spare_categories.Find(id);
                    return sc;
                }
                catch
                {
                    return null;
                }

            }
        }

        public void getSubCategories(ref List<int> categoriesId, ref List<string> fillcmb)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                //Obtengo todos los registros de mi tabla con la cual se supone tengo que llenar mi combobox
                var lst = from d in db.spare_categories
                          select d;
                //Creo una lista y itero la lista que viene de la BDD para llenar la lista que servira para el combobox
                foreach (var category in lst)
                {
                    fillcmb.Add(category.name);
                    //Llenamos tambien la lista de los id de las categorias para ocuparla en el registro
                    categoriesId.Add(category.id);
                }
            }
        }
    }
}
