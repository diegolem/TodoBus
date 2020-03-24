using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBus.Models;

namespace TodoBus.Controllers
{
    class CategoryController
    {
        public bool save(string name, string code)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    //Defino el nuevo objeto
                    spare_categories Category = new spare_categories();
                    //Luego obtengo todos los valores y los asigno a los campos del nuevo objeto
                    Category.name = name;
                    Category.code = code;

                    //Añado a mi tabla la subcategoria(objeto)
                    db.spare_categories.Add(Category);
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
