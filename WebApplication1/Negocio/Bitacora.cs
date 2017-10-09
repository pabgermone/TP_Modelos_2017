using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Bitacora
    {
        public static string RegistrarBitacora(string usuario, string descripcion)
        {
           return Datos.Bitacora.GrabarRegistro(usuario, descripcion);
        }

        public static List<Entidad.Bitacora> ObtenerBitacora()
        {
         return Datos.Bitacora.ObtenerBitacora();
        }
    }
}
