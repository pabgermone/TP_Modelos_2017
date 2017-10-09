using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Backup : DAL
    {

        public static string BackUpCrear(string ruta, string nombre)
        {
            try
            {
                List<SqlParameter> ListParametros = new List<SqlParameter>();
                ListParametros.Add(new SqlParameter("@BackupPath", ruta));
                ListParametros.Add(new SqlParameter("@NameBackup", nombre));

                string retorno = DAL.EjecutarStore("dbo.BackupDatabase", ListParametros.ToArray());
                return retorno;
            }
            catch (Exception)
            {
                return "Error al crear el archivo";
                throw;
            }
        
        }

        public static string RestaurarBackup(string ruta, string nombre)
        {
            try
            {
                //string completo = ruta + nombre + ".bak";

                //List<SqlParameter> ListParametros = new List<SqlParameter>();
                //ListParametros.Add(new SqlParameter("@Archivo", completo));
                //string retorno = DAL.EjecutarStore("dbo.BackupRestore", ListParametros.ToArray());
                //return retorno;

                string completo = ruta + nombre + ".bak";

                //string retorno = DAL.EjecutarConsulta("USE [master]; ALTER DATABASE DiamondZapatos SET OFFLINE WITH ROLLBACK IMMEDIATE; DROP DATABASE [DiamondZapatos]; RESTORE DATABASE [DiamondZapatos] FROM DISK = '"+ completo +"' WITH  REPLACE").ToString();
                string retorno = DAL.EjecutarConsulta(@"use master; RESTORE DATABASE DiamondZapatos FROM DISK = '" + completo + "'").ToString();
                return retorno;

            }
            catch (Exception)
            {
                return "Error al restaurar el archivo";
                throw;
            }
        }

    }
}
