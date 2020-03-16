using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoBus.Models
{
    class FakeSubCategories
    {
        private int id;
        private string codigo;
        private string nombre;
        private string nombreCategoria;

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
    }
}
