using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBus.Models;

namespace TodoBus.Controllers
{
    class ClientController
    {
        public bool save(string nameE, string nameC, string correo, string correoA, string dir,string tel, string telA, int uni)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    //Defino el nuevo objeto
                    clients cliente = new clients();
                    //Luego obtengo todos los valores y los asigno a los campos del nuevo objeto
                    cliente.client_name = nameE;
                    cliente.contact_name = nameC;
                    cliente.email = correo;
                    cliente.alternative_email = correoA;
                    cliente.address = dir;
                    cliente.phone = tel;
                    cliente.alternative_phone = telA;
                    cliente.units_total = uni;

                    //Añado a mi tabla la subcategoria(objeto)
                    db.clients.Add(cliente);
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

        public List<FakeClients> getAllClients()
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.clients
                          join u in db.users on d.user_id equals u.id
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<FakeClients> customL = new List<FakeClients>();
                    foreach (var client in lst)
                    {
                        FakeClients clientF = new FakeClients();
                        clientF.Id = client.id;
                        clientF.NombreContacto = client.contact_name;
                        clientF.NombreEmpresa = client.client_name;
                        clientF.Telefono = client.phone;
                        clientF.TelefonoAlternativo = client.alternative_phone;
                        clientF.Direccion = client.address;
                        clientF.Email = client.email;
                        clientF.EmailAlternativo = client.alternative_email;
                        clientF.TotalUnidades = client.units_total;
                        clientF.TipoCliente = (client.client_type == 0 ? "Independiente": "Empresa");
                        clientF.User = client.users.name + " " + client.users.last_name;
                        customL.Add(clientF);
                    }
                    return customL;
                }
                else
                {
                    List<FakeClients> newCl = new List<FakeClients>();
                    return newCl;
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
                    clients client = db.clients.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.clients.Remove(client);
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

        public clients getClient(int? id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    clients c = db.clients.Find(id);
                    return c;
                }
                catch
                {
                    return null;
                }

            }
        }

        public bool edit(string nameE, string nameC, string correo, string correoA, string dir, string tel, string telA, int uni, clients cliente)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    cliente.client_name = nameE;
                    cliente.contact_name = nameC;
                    cliente.email = correo;
                    cliente.alternative_email = correoA;
                    cliente.address = dir;
                    cliente.phone = tel;
                    cliente.alternative_phone = telA;
                    cliente.units_total = uni;
                    db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
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
    }
}
