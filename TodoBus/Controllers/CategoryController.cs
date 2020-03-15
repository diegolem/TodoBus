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
        public bool save(string name, string code, int id)
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
                    //Para el combobox, obtengo del arreglo de categoria el valor, que posea el arreglo en el indice que
                    //se ha seleccionado en el comboBox menos 1, porque en el combobox se empieza desde 1
                    Category.id = id;

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

        public bool edit(string name, string code, int id, spare_categories Category)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    Category.name = name;
                    Category.code = code;
                    Category.id = id;

                    db.Entry(Category).State = System.Data.Entity.EntityState.Modified;
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
        public List<spare_categories> getAllCategories()
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
                    return lst.ToList();
                }
                else
                {
                    List<spare_categories> newC = new List<spare_categories>();
                    return newC;
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
                    spare_categories categor = db.spare_categories.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.spare_categories.Remove(categor);
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
