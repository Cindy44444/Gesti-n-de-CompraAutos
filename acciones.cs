using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_CompraAutos
{
    internal class acciones : IACCIONES
    {
        auto a = new auto();
        private List<auto> LISTAAUTOS = new List<auto>()
        {
            new auto(1,"McLare","Modelo Senna",2018,"Azul",750000,"No disponible"),
        };
        Correo correo = new Correo();

        public bool Actualizar(int idactu, string marcaactu, string modeloactu, int anioactu, string coloractu, double precioactu, string estadoactu)
        {
            try
            {
                var objetoeliminar = LISTAAUTOS.Find(x => x.id == idactu );
                if (objetoeliminar != null)
                {
                    LISTAAUTOS.Remove(objetoeliminar);
                    LISTAAUTOS.Add(new auto(idactu,marcaactu,modeloactu,anioactu,coloractu,precioactu,estadoactu));
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                return false;
            }
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
