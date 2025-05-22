using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_CompraAutos
{
    internal class auto: Vehiculo
    {
        public auto() { }

        public auto(int id, string marca, string modelo, int anio, string color, double precio, string estado)
            :base(id, marca, modelo, anio, color)
        {
            this.precio = precio;
            this.estado = estado;
        }

        public double precio {  get; set; }
        public string estado { get; set; }
    }
}
