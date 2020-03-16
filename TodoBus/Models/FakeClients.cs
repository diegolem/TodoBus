using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoBus.Models
{
    class FakeClients
    {
        private int id;
        private string nombreEmpresa;
        private string nombreContacto;
        private string telefono;
        private string telefonoAlternativo;
        private string direccion;
        private string email;
        private string emailAlternativo;
        private int totalUnidades;
        private string tipoCliente;
        private string user;

        public int Id { get => id; set => id = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string NombreContacto { get => nombreContacto; set => nombreContacto = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string TelefonoAlternativo { get => telefonoAlternativo; set => telefonoAlternativo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public string EmailAlternativo { get => emailAlternativo; set => emailAlternativo = value; }
        public int TotalUnidades { get => totalUnidades; set => totalUnidades = value; }
        public string TipoCliente { get => tipoCliente; set => tipoCliente = value; }
        public string User { get => user; set => user = value; }
    }
}
