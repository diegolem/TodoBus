using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoBus.Models
{
    class FakeSpareUnit
    {
        private int spare_id;
        private string codigo;
        private string nombre;
        private string nombreMarca;
        private string nombreCategoria;

        public int Spare_id { get => spare_id; set => spare_id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NombreMarca { get => nombreMarca; set => nombreMarca = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
    }
}
