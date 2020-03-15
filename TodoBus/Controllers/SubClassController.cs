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

        public List<spare_subclasses> getAllSubclasses()
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.spare_subclasses
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    return lst.ToList();
                }
                else
                {
                    List<spare_subclasses> newSCl = new List<spare_subclasses>();
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
    }
}
