using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_CompraAutos
{
    internal class Usuarios
    {
        private const string V = "123";
        List<Usuarios> usuarios = new List<Usuarios>()
        {
            new Usuarios {user ="Cindy", password ="4454" }
        };

        public Usuarios(string user, string password)
        {
            this.user = user;
            this.password = password;
        }

        public List<Usuarios>ObtenerUsuarios()
        {
            return usuarios;
        }
        public Usuarios() { }

        public string user {  get; set; }
       public string password { get; set; }

    }
}
