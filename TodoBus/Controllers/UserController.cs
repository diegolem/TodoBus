﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBus.Models;

namespace TodoBus.Controllers
{
    class UserController
    {
        public bool save(string name, string last_name, string email, int age, string password)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    //Defino el nuevo objeto
                    users Usuarios = new users();
                    //Luego obtengo todos los valores y los asigno a los campos del nuevo objeto
                    Usuarios.name = name;
                    Usuarios.last_name = last_name;
                    Usuarios.email = email;
                    Usuarios.age = age;
                    Usuarios.password = password;
                    //Para el combobox, obtengo del arreglo de categoria el valor, que posea el arreglo en el indice que
                    //se ha seleccionado en el comboBox menos 1, porque en el combobox se empieza desde 1
                    

                    //Añado a mi tabla la subcategoria(objeto)
                    db.users.Add(Usuarios);
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

        public bool edit(string name, string last_name, string email, int age, string password, int id, users Usuarios)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    Usuarios.name = name;
                    Usuarios.last_name = last_name;
                    Usuarios.email = email;
                    Usuarios.age = age;
                    Usuarios.id = id;
                    Usuarios.age = age;
                    Usuarios.password = password;
                    Usuarios.id = id;
                    db.Entry(Usuarios).State = System.Data.Entity.EntityState.Modified;
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
        public List<FakeUsers> getAllUsers()
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.users
                          where d.id != 1
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<FakeUsers> customL = new List<FakeUsers>();
                    foreach (var user in lst)
                    {
                        FakeUsers userF = new FakeUsers();
                        userF.Id = user.id;
                        userF.Nombre = user.name;
                        userF.Apellido = user.last_name;
                        userF.Edad = user.age;
                        customL.Add(userF);
                    }
                    return customL;
                }
                else
                {
                    List<FakeUsers> newUser = new List<FakeUsers>();
                    return newUser;
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
                    users usu = db.users.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.users.Remove(usu);
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
        public users getUser(int? id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    users usr = db.users.Find(id);
                    return usr;
                }
                catch
                {
                    return null;
                }
            }
        }
        
    }
}
