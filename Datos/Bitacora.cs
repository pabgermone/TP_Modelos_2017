using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Bitacora : DAL
    {
       public static string GrabarRegistro(string usuario, string descripcion)
       {
           List<SqlParameter> ListParametros = new List<SqlParameter>();

           ListParametros.Add(new SqlParameter("Descripcion", descripcion));
           ListParametros.Add(new SqlParameter("Usuario", usuario));

           string mensaje = DAL.EjecutarStore("BitacoraIngresar",ListParametros.ToArray());
      
           return mensaje;
       }

        public static List<Entidad.Bitacora> ObtenerBitacora()
        {
          List<Entidad.Bitacora> ListaBitacora = new List<Entidad.Bitacora>();
          DataTable dt = DAL.ObtenerTabla("BitacoraLeer", null);

          

          foreach (DataRow item in dt.Rows)
          {
              Entidad.Bitacora Bitacora = new Entidad.Bitacora();

              Bitacora.idRegistro = Convert.ToInt32(item["IdRegistro"]);
              Bitacora.Descripcion = (item["Descripcion"]).ToString();
              Bitacora.Usuario = (item["Usuario"]).ToString();
              Bitacora.Fecha =  Convert.ToDateTime((item["Fecha"]));

              ListaBitacora.Add(Bitacora);
          }
          return ListaBitacora;
        }

    }
}
