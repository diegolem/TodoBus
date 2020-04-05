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
        public bool save(int brand_id, int client_id, string description, int total)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    units unidad = new units();

                    unidad.brand_id = brand_id;
                    unidad.client_id = client_id;
                    unidad.total = total;
                    unidad.measure_description = description;

                    db.units.Add(unidad);

                    clients client = db.clients.Find(client_id);
                    client.units_total += total;
                    db.Entry(client).State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool countUnits()
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                var lst = from d in db.units
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

        public bool edit(int brand_id, int client_id, string description, int total, units unidad, int oldTotal)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    unidad.brand_id = brand_id;
                    unidad.client_id = client_id;
                    unidad.total = total;
                    unidad.measure_description = description;

                    db.Entry(unidad).State = System.Data.Entity.EntityState.Modified;

                    clients client = db.clients.Find(client_id);
                    client.units_total -= oldTotal;
                    client.units_total += total;
                    db.Entry(client).State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool delete(int? id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    
                    units unit = db.units.Find(id);
                    db.units.Remove(unit);
                    db.SaveChanges();
                    
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public units getUnit(int? id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    units un = db.units.Find(id);
                    return un;
                }
                catch
                {
                    return null;
                }
            }
        }

        public void getBrands(ref List<int> brandsId, ref List<string> fillcmb)
        {
            using(TodoBusEntities db = new TodoBusEntities())
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

        public void getClients(ref List<int> clientsId, ref List<string> fillcmb)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                var lst = from d in db.clients
                          select d;
                foreach (var client in lst)
                {
                    fillcmb.Add(client.client_name);
                    clientsId.Add(client.id);
                }
            }
        }

        public brands getBrand(int? id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    brands br = db.brands.Find(id);
                    return br;
                }
                catch
                {
                    return null;
                }

            }
        }

        public clients getClient(int? id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    clients cl = db.clients.Find(id);
                    return cl;
                }
                catch
                {
                    return null;
                }

            }
        }

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
