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

    }
}
