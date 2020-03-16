using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoBus.Models
{
    class FakeSubClasses
    {
        private int id;
        private string codigo;
        private string nombre;
        private string nombreSubCategoria;

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NombreSubCategoria { get => nombreSubCategoria; set => nombreSubCategoria = value; }
    }
}
