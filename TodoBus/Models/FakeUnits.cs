using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoBus.Models
{
    class FakeUnits
    {
        private int id;
        private string medidas;
        private int totalunidades;
        private string brandname;
        private string clientname;

        public int Id { get => id; set => id = value; }
        public string Medidas { get => medidas; set => medidas = value; }
        public int Totalunidades { get => totalunidades; set => totalunidades = value; }
        public string Brandname { get => brandname; set => brandname = value; }
        public string Clientname { get => clientname; set => clientname = value; }
    }
}
