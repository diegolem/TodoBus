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
        public List<FakeUnits> getAllUnits()
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
                    List<FakeUnits> customL = new List<FakeUnits>();
                    foreach (var unit in lst)
                    {
                        FakeUnits unitF = new FakeUnits();
                        unitF.Id = unit.id;
                        unitF.Medidas = unit.measure_description;
                        unitF.Totalunidades = unit.total;
                        unitF.Brandname = unit.brands.name;
                        unitF.Clientname = unit.clients.client_name;
                        customL.Add(unitF);
                    }
                    return customL;
                }
                else
                {
                    List<FakeUnits> newU = new List<FakeUnits>();
                    return newU;
                }
            }
        }
    }
}
