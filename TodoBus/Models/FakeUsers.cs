using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoBus.Models
{
    class FakeUsers
    {
        private int id;
        private string nombre;
        private string apellido;
        private string email;
        private int? edad;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int? Edad { get => edad; set => edad = value; }
        public string Email { get => email; set => email = value; }
    }
}
