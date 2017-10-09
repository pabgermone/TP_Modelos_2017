using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Producto
    {
        public static List<Entidad.Producto> ObtenerProductos()
        {
            return Datos.Producto.ObtenerProductos();
        }
    }
}
