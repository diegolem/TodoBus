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

        public bool save(int brand_id, int client_id, string description, int total,string painting_design,string model, int anio, string num_fc, string num_fch,int brand_bodywork_id, int brand_chassis_id, int brand_motor_id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    units unidad = new units();

                    unidad.measure_description = description;
                    unidad.total = total;
                    unidad.diseño_pintura = painting_design;
                    unidad.año = anio;
                    unidad.modelo = model;
                    unidad.numero_FC = num_fc;
                    unidad.numero_FCH = num_fch;
                    unidad.marca_carroceria = brand_bodywork_id;
                    unidad.marca_chasis = brand_chassis_id;
                    unidad.marca_motor = brand_motor_id;
                    unidad.brand_id = brand_id;
                    unidad.client_id = client_id;

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

        public bool edit(int brand_id, int client_id, string description, int total, units unidad, int oldTotal, string painting_design, string model, int anio, string num_fc, string num_fch, int brand_bodywork_id, int brand_chassis_id, int brand_motor_id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    unidad.measure_description = description;
                    unidad.total = total;
                    unidad.diseño_pintura = painting_design;
                    unidad.año = anio;
                    unidad.modelo = model;
                    unidad.numero_FC = num_fc;
                    unidad.numero_FCH = num_fch;
                    unidad.marca_carroceria = brand_bodywork_id;
                    unidad.marca_chasis = brand_chassis_id;
                    unidad.marca_motor = brand_motor_id;
                    unidad.brand_id = brand_id;
                    unidad.client_id = client_id;

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

        public void getBrands(ref List<int> brandsId, ref List<string> fillcmb, ref List<string> fillcmb1, ref List<string> fillcmb2, ref List<string> fillcmb3)
        {
            using(TodoBusEntities db = new TodoBusEntities())
            {
                var lst = from d in db.brands
                          select d;
                foreach (var brand in lst)
                {
                    fillcmb.Add(brand.name);
                    fillcmb1.Add(brand.name);
                    fillcmb2.Add(brand.name);
                    fillcmb3.Add(brand.name);
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
                var lst = from d in db.units
                          join c in db.clients on d.client_id equals c.id
                          select d;
                
                if (lst.Count() > 0)
                {
                    List<FakeUnits> customL = new List<FakeUnits>();
                    foreach (var unit in lst)
                    {
                        FakeUnits unitF = new FakeUnits();

                        unitF.Id = unit.id;
                        unitF.Total_unidades = unit.total;
                        unitF.Marca_unidad = unit.brands.name;
                        unitF.Nombre_cliente = unit.clients.client_name;
                        unitF.Descripcion = (unit.measure_description.Length > 0 ? unit.measure_description : "No especificada");
                        unitF.Disenio_pintura = (unit.diseño_pintura.Length > 0 ? unit.diseño_pintura : "No especificado");
                        unitF.Anio = (int)unit.año;
                        unitF.Modelo = (unit.modelo.Length > 0 ? unit.modelo : "No especificado");
                        unitF.Numero_fabricacion_carroceria = (unit.numero_FC.Length > 0 ? unit.numero_FC : "No especificado");
                        unitF.Numero_fabricacion_chasis = (unit.numero_FCH.Length > 0 ? unit.numero_FCH : "No especificado");
                        unitF.Marca_carroceria = unit.brands_bodywork.name;
                        unitF.Marca_chasis = unit.brands_chassis.name;
                        unitF.Marca_motor = unit.brands_motor.name;

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

        public void buscar(ref Bunifu.Framework.UI.BunifuCustomDataGrid dgv, string cadena, string index)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                var lst = from d in db.units
                          select d;

                if (index == "Unidades Totales")
                {
                    lst = lst.Where(c => c.total.ToString().Contains(cadena));
                    
                }
                else if (index == "Descripción General")
                {
                    lst = lst.Where(c => c.measure_description.Contains(cadena));
                }
                else if (index == "Marca Unidad")
                {
                    lst = lst.Where(c => c.brands.name.Contains(cadena));
                }
                else if (index == "Cliente")
                {
                    lst = lst.Where(c => c.clients.client_name.Contains(cadena));
                }
                else if (index == "Diseño de Pintura")
                {
                    lst = lst.Where(c => c.diseño_pintura.Contains(cadena));
                }
                else if (index == "Año de la Unidad")
                {
                    lst = lst.Where(c => c.año.ToString().Contains(cadena));
                }
                else if (index == "Num. Fabricación Carrocería")
                {
                    lst = lst.Where(c => c.numero_FC.Contains(cadena));
                }
                else if (index == "Num. Fabricación Chasis")
                {
                    lst = lst.Where(c => c.numero_FCH.Contains(cadena));
                }
                else if (index == "Marca Carrocería")
                {
                    lst = lst.Where(c => c.brands_bodywork.name.Contains(cadena));
                }
                else if (index == "Marca Chasis")
                {
                    lst = lst.Where(c => c.brands_chassis.name.Contains(cadena));
                }
                else if (index == "Marca Motor")
                {
                    lst = lst.Where(c => c.brands_motor.name.Contains(cadena));
                }
                else if (index == "Modelo")
                {
                    lst = lst.Where(c => c.modelo.Contains(cadena));
                }

                if (lst.Count() > 0)
                {
                    List<FakeUnits> customL = new List<FakeUnits>();
                    foreach (var unit in lst)
                    {
                        FakeUnits unitF = new FakeUnits();

                        unitF.Id = unit.id;
                        unitF.Total_unidades = unit.total;
                        unitF.Marca_unidad = unit.brands.name;
                        unitF.Nombre_cliente = unit.clients.client_name;
                        unitF.Descripcion = (unit.measure_description.Length > 0 ? unit.measure_description : "No especificada");
                        unitF.Disenio_pintura = (unit.diseño_pintura.Length > 0 ? unit.diseño_pintura : "No especificado");
                        unitF.Anio = (int)unit.año;
                        unitF.Modelo = (unit.modelo.Length > 0 ? unit.modelo : "No especificado");
                        unitF.Numero_fabricacion_carroceria = (unit.numero_FC.Length > 0 ? unit.numero_FC : "No especificado");
                        unitF.Numero_fabricacion_chasis = (unit.numero_FCH.Length > 0 ? unit.numero_FCH : "No especificado");
                        unitF.Marca_carroceria = unit.brands_bodywork.name;
                        unitF.Marca_chasis = unit.brands_chassis.name;
                        unitF.Marca_motor = unit.brands_motor.name;

                        customL.Add(unitF);
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
                    List<FakeUnits> newCl = new List<FakeUnits>();
                    dgv.DataSource = newCl;
                }
            }
        }
    }
}
