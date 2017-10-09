using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Usuario : DAL
    {
        public static Entidad.Usuario LoginUsuario(string nombre, string pass)
        {
            List<SqlParameter> ListParametros = new List<SqlParameter>();
            
            ListParametros.Add(new SqlParameter("Nombre", nombre));
            ListParametros.Add(new SqlParameter("Contraseña", pass));

            DataTable data = DAL.ObtenerTabla("BuscarUsuario", ListParametros.ToArray());
            //string query = String.Format("select * from Usuario where Nombre = '"+ nombre +"' and Contraseña = '" + pass +"'");
            //DataTable dt = DAL.ObtenerTablaConsulta(query);
            Entidad.Usuario usuario = new Entidad.Usuario();

            foreach (DataRow item in data.Rows)
            {
                usuario.IdUsuario = Convert.ToInt32(item["idUsuario"]);
                usuario.Nombre = Convert.ToString(item["Nombre"]);
                usuario.Contraseña = Convert.ToString(item["Contraseña"]);
                usuario.Rol = Convert.ToInt32(item["Rol"]);
                usuario.Bloqueado = Convert.ToBoolean(item["Bloqueado"]);
            }

            return usuario;
        }

        public static string RegistroUsuario(string nombre, string password)
        {

            List<SqlParameter> ListParametros = new List<SqlParameter>();
            
            ListParametros.Add(new SqlParameter("Usuario", nombre));
            ListParametros.Add(new SqlParameter("Password", password));

            string valor = DAL.EjecutarStore("RegistroUsuario", ListParametros.ToArray());

            return valor;
        
        }

        public static bool UsuarioBloqueado(string nombre, int bloqueo)
        {

            List<SqlParameter> ListParametros = new List<SqlParameter>();

            ListParametros.Add(new SqlParameter("User", nombre));
            ListParametros.Add(new SqlParameter("Bloquear", bloqueo));

            string valor = DAL.EjecutarStore("UsuarioBloqueado", ListParametros.ToArray());

            if (valor == string.Empty)
            {
             return true;
            }
            else { return false; }
        }

        public static List<Entidad.Usuario> ObtenerUsuarios()
        { 
        
                List<Entidad.Usuario> listado = new List<Entidad.Usuario>();
                List<object> ListObj = new List<object>();

                ListObj = DAL.DevolverListaObjetoConsulta("select * from Usuario");

                foreach (DataRow item in ListObj)
                {
                    Entidad.Usuario user = new Entidad.Usuario
                    {
                        Nombre = Convert.ToString(item["Nombre"]),
                        Rol = Convert.ToInt32(item["Rol"]),
                        Bloqueado = Convert.ToBoolean(item["Bloqueado"])
             
                    };

                    listado.Add(user);
                }

                return listado;
            }

        }
    
}
