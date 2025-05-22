using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_CompraAutos
{
    internal interface IACCIONES
    {
        List<auto> MostrarAuto();
        bool Agregar(int id, string marca, string modelo, int anio, string color, double precio, string estado);
        bool Actualizar(int idactu, string marcaactu, string modeloactu, int anioactu, string coloractu, double precioactu, string estadoactu);
        bool Eliminar(int id);
        bool ExportarExcel();
        bool ImportarExcel();
        //abc
    }
}
