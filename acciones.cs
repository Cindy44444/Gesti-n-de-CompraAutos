using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_CompraAutos
{
    internal class acciones : IACCIONES
    {
        public bool Actualizar(int id, string marca, string modelo, int anio, string color, double precio, string estado)
        {
            throw new NotImplementedException();
        }

        public bool Agregar(int id, string marca, string modelo, int anio, string color, double precio, string estado)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public bool ExportarExcel()
        {
            throw new NotImplementedException();
        }

        public bool ImportarExcel()
        {
            throw new NotImplementedException();
        }

        public List<auto> MostrarAuto()
        {
            throw new NotImplementedException();
        }
    }
}
