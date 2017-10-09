using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Datos
{
    public class Proveedor : DAL
    {
        public static List<Entidad.Proveedores> ObtenerProveedores()
        {

            List<Entidad.Proveedores> Proveedores = new List<Entidad.Proveedores>();
            DataTable dt = DAL.ObtenerTablaConsulta("select * from Proveedores");

            foreach (DataRow item in dt.Rows)
            {

                Entidad.Proveedores Proveedor = new Entidad.Proveedores
                {
                    idProveedor = Convert.ToInt32(item["IdProveedor"]),
                    Descripcion = Convert.ToString(item["Descripcion"]),
                    DVH = Convert.ToString(item["DVH"]),
                    Direccion = Convert.ToString(item["Direccion"])

                };

                Proveedores.Add(Proveedor);
            }

            return Proveedores;
        }
    }
}
