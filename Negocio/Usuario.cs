using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Usuario
    {
        public static Entidad.Usuario Login(string user, string pass)
        {
            Entidad.Usuario Usuario = Datos.Usuario.LoginUsuario(user, pass);
            return Usuario;
        }

        public static string RegistrarUsuario(string nombre, string pass)
        {
            return Datos.Usuario.RegistroUsuario(nombre, pass);
        }

        public static bool UsuarioBloqueado(string nombre, int bloqueo)
        {
            return Datos.Usuario.UsuarioBloqueado(nombre, bloqueo);
        }

        public static List<Entidad.Usuario> ObtenerUsuarios()
        {
            return Datos.Usuario.ObtenerUsuarios();
        }
    }
}
