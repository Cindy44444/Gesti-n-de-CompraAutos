using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_CompraAutos
{
    internal class Usuarios
    {
        List<Usuarios> usuarios = new List<Usuarios>()
        {
            new Usuarios ("Cindy","4454"),
        };

        public Usuarios(string user, string password)
        {
            this.user = user;
            this.password = password;
        }

        public List<Usuarios>GetUsuarios()
        {
            try
            {
                return usuarios;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string user {  get; set; }
       public string password { get; set; }

    }
}
