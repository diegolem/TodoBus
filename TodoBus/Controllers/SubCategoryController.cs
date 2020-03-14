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
        public bool save(string name, string code, int category_id)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    //Defino el nuevo objeto
                    spare_subcategories subCategory = new spare_subcategories();
                    //Luego obtengo todos los valores y los asigno a los campos del nuevo objeto
                    subCategory.name = name;
                    subCategory.code = code;
                    //Para el combobox, obtengo del arreglo de categoria el valor, que posea el arreglo en el indice que
                    //se ha seleccionado en el comboBox menos 1, porque en el combobox se empieza desde 1
                    subCategory.category_id = category_id;

                    //Añado a mi tabla la subcategoria(objeto)
                    db.spare_subcategories.Add(subCategory);
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

        public List<spare_subcategories> getAllSubCategories()
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.spare_subcategories
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    return lst.ToList();
                }
                else
                {
                    List<spare_subcategories> newSC = new List<spare_subcategories>();
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
                    //Se obtiene el objeto a borrar
                    spare_subcategories subc = db.spare_subcategories.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.spare_subcategories.Remove(subc);
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

        public void getCategories(ref List<int> categoriesId, ref List<string> fillcmb)
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
