using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TodoBus.Models;

namespace TodoBus.Controllers
{
    class LoginController
    {
        public static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
        public bool Verificar(string pass,string correo)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    var lst = from d in db.users
                              where d.email == correo
                              && d.password == pass
                              select d;
                    if(lst.Count()>0)
                    {
                        return true;
                    }
                    
                        return false;
                    
                }
                catch
                {
                    return false;
                }
            }
        }

        public users getUser(string pass, string correo)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    var lst = from d in db.users
                              where d.email == correo
                              && d.password == pass
                              select d;
                    if(lst.Count() > 0){
                        return lst.First();
                    }
                    else
                    {
                        return null;
                    }
                }
                catch
                {
                    return null;
                }
            }
        }
        public string recoverPassword(string userRegisting)
        {
            using(TodoBusEntities db =new TodoBusEntities())
            {
                try
                {
                    var lst = from d in db.users
                              where d.email == userRegisting
                              select d;

                    if(lst.Count()>0)
                    {
                        users Usuarios = new users();
                        string Nombre = Usuarios.name;
                        string Apellido = Usuarios.last_name;
                        string nombreCom = Nombre + " " + Apellido;
                        var mailService = new SystemSupportMail();
                        mailService.sendMail(
                          subject: "SYSTEM: Recuperar Contraseña",
                          body: "Hola, " + nombreCom + "\nEstas solicitando recuperar tu contraseña.\n" +
                          "Tu código de recuperación es el siguiente : 1234\n"+
                          "No compartas tu codigo de recuperación por ningún motivo.",
                          
                          recipientMail: new List<string> { userRegisting }
                          );
                        return "Hola, " + nombreCom + "\nEstas solicitando recuperar tu contraseña.\n" + "Por favor revisa tu correo electrónico";
                    }
                    else
                    {
                        return "No se ha podido encontrar ningún usuario relacionado con el correo que nos proporcionaste";
                    }
                }
                catch
                {
                    return "Ocurrio un error, revisa tu conexión";
                }
            }
        }
    }
}
