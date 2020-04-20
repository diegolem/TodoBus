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
        private int total_unidades;
        private string marca_unidad;
        private string nombre_cliente;
        private string descripcion;
        private string disenio_pintura;
        private int anio;
        private string modelo;
        private string numero_fabricacion_carroceria;
        private string numero_fabricacion_chasis;
        private string marca_carroceria;
        private string marca_chasis;
        private string marca_motor;

        public int Id { get => id; set => id = value; }
        public int Total_unidades { get => total_unidades; set => total_unidades = value; }
        public string Marca_unidad { get => marca_unidad; set => marca_unidad = value; }
        public string Nombre_cliente { get => nombre_cliente; set => nombre_cliente = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Disenio_pintura { get => disenio_pintura; set => disenio_pintura = value; }
        public int Anio { get => anio; set => anio = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Numero_fabricacion_carroceria { get => numero_fabricacion_carroceria; set => numero_fabricacion_carroceria = value; }
        public string Numero_fabricacion_chasis { get => numero_fabricacion_chasis; set => numero_fabricacion_chasis = value; }
        public string Marca_carroceria { get => marca_carroceria; set => marca_carroceria = value; }
        public string Marca_chasis { get => marca_chasis; set => marca_chasis = value; }
        public string Marca_motor { get => marca_motor; set => marca_motor = value; }
    }
}
