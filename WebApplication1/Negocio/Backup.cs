using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Backup
    {

        public static string CrearBackup(string ruta, string nombre)
        {
            return Datos.Backup.BackUpCrear(ruta, nombre);
        }

        public static string RestaurarBackup(string ruta, string nombre)
        {
            return Datos.Backup.RestaurarBackup(ruta, nombre);
        }

    }
}
