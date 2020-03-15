using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBus.Models;

namespace TodoBus.Controllers
{
    class UnitController
    {
        public List<units> getAllUnits()
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.units
                          join c in db.clients on d.client_id equals c.id
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    return lst.ToList();
                }
                else
                {
                    List<units> newU = new List<units>();
                    return newU;
                }
            }
        }
    }
}
