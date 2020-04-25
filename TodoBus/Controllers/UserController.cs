using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBus.Models;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace TodoBus.Controllers
{
    class UserController
    {
        public int save(string name, string last_name, string email, string password)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (TodoBusEntities db = new TodoBusEntities())
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    try
                    {
                        var lst = from d in db.users
                                  where d.email == email
                                  select d;

                        if (lst.Count() == 0)
                        {
                            users Usuarios = new users();
                            Usuarios.name = name;
                            Usuarios.last_name = last_name;
                            Usuarios.email = email;
                            Usuarios.age = 30;

                            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                            StringBuilder builder = new StringBuilder();
                            for (int i = 0; i < bytes.Length; i++)
                            {
                                builder.Append(bytes[i].ToString("x2"));
                                string hashedPassword = builder.ToString();
                                Usuarios.password = hashedPassword;
                            }

                            db.users.Add(Usuarios);
                            db.SaveChanges();

                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                    catch
                    {
                        return 0;
                    }
                }
            }
        }

        public bool countUsers()
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                var lst = from d in db.users
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

        public bool edit(string name, string last_name, string email, string password, users Usuarios)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (TodoBusEntities db = new TodoBusEntities())
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    try
                    {
                        Usuarios.name = name;
                        Usuarios.last_name = last_name;
                        Usuarios.email = email;
                        if (password.Trim().Length > 0)
                        {
                            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                            StringBuilder builder = new StringBuilder();
                            for (int i = 0; i < bytes.Length; i++)
                            {
                                builder.Append(bytes[i].ToString("x2"));
                                string hashedPassword = builder.ToString();
                                Usuarios.password = hashedPassword;
                            }
                        }

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
        }

        public int modifyUserData( string name, string lastname, string email, string password, string newpass, users Usuarios)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    try
                    {
                        if (password.Trim().Length > 0)
                        {
                            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                            StringBuilder builder = new StringBuilder();
                            bool correctpass = false;
                            for (int i = 0; i < bytes.Length; i++)
                            {
                                builder.Append(bytes[i].ToString("x2"));
                                string hashedPassword = builder.ToString();
                                if(hashedPassword == Usuarios.password)
                                {
                                    correctpass = true;
                                }
                            }

                            if (correctpass)
                            {
                                byte[] bytess = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(newpass));
                                StringBuilder constructor = new StringBuilder();
                                for (int i = 0; i < bytess.Length; i++)
                                {
                                    builder.Append(bytes[i].ToString("x2"));
                                    string hashedPassword = builder.ToString();
                                    Usuarios.password = hashedPassword;
                                }

                                Usuarios.name = name;
                                Usuarios.last_name = lastname;
                                Usuarios.email = email;

                                db.Entry(Usuarios).State = System.Data.Entity.EntityState.Modified;
                                db.SaveChanges();

                                return 2;
                            }
                            else
                            {
                                Usuarios.name = name;
                                Usuarios.last_name = lastname;
                                Usuarios.email = email;
                                db.Entry(Usuarios).State = System.Data.Entity.EntityState.Modified;
                                db.SaveChanges();

                                return 3;
                            }
                        }
                        else
                        {
                            Usuarios.name = name;
                            Usuarios.last_name = lastname;
                            Usuarios.email = email;
                            db.Entry(Usuarios).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();

                            return 1;
                        }
                    }
                    catch
                    {
                        return 0;
                    }
                }
            }
        }

        public List<FakeUsers> getAllUsers(int user_id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                var lst = from d in db.users
                          where d.id != user_id
                          select d;
                if (lst.Count() > 0)
                {
                    List<FakeUsers> customL = new List<FakeUsers>();
                    foreach (var user in lst)
                    {
                        FakeUsers userF = new FakeUsers();
                        userF.Id = user.id;
                        userF.Nombre = user.name;
                        userF.Apellido = user.last_name;
                        userF.Email = user.email;
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

        public void Busqueda(DataGridView data, string dato)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {

                var lst = from d in db.users
                          select d;
                lst = lst.Where(d => d.name.Contains(dato));

                if (lst.Count() > 0)
                {
                    List<FakeUsers> customL = new List<FakeUsers>();
                    foreach (var user in lst)
                    {
                        FakeUsers UsersF = new FakeUsers();
                        UsersF.Id = user.id;
                        UsersF.Nombre = user.name;
                        UsersF.Apellido = user.last_name;
                        UsersF.Email = user.email;
                        customL.Add(UsersF);
                        if (data.DataSource != null)
                        {

                            data.Columns.Clear();
                        }
                        data.DataSource = null;


                        data.DataSource = customL;

                    }
                }
                else
                {
                    List<FakeUsers> newSC = new List<FakeUsers>();
                    data.DataSource = newSC;
                }


            }
        }

    }
}
