using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_CompraAutos
{
    internal class Vehiculo
    {
        public Vehiculo() { }

        public Vehiculo(int id, string marca, string modelo, int anio, string color)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
            this.color = color;
        }

        public int id {  get; set; }
        public string  marca { get; set; }
        public string modelo { get; set; }
        public int anio { get; set; }
        public string color { get; set; }

    }
}
