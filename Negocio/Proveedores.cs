using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Proveedores
    {
        public static List<Entidad.Proveedores> ObtenerTodos()
        {
            return Datos.Proveedor.ObtenerProveedores();
        }
    }
}
