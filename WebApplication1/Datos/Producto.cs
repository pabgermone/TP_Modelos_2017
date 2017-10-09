using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Producto : DAL
    {
        public static List<Entidad.Producto> ObtenerProductos()
        { 

            List<Entidad.Producto> Productos = new List<Entidad.Producto>();
            DataTable dt = DAL.ObtenerTablaConsulta("select * from Producto");

            foreach (DataRow item in dt.Rows)
            {

                Entidad.Producto Producto = new Entidad.Producto
                {
                     idProducto = Convert.ToInt32(item["IdProducto"]),
                     Cantidad = Convert.ToInt32(item["Cantidad"]),
                     Descripcion = Convert.ToString(item["Descripcion"]),
                     Valor = Convert.ToInt32(item["Valor"]),
                   
                };

                Productos.Add(Producto);
            }

            return Productos;
        }
    }
}
