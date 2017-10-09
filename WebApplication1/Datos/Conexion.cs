using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        //protected static string Conn = "Data Source=SVRAR71;Initial Catalog=ticketsdesa;integrated security=false; Pooling=False; User Id=UserTickets; password=Tiqu3t@DGSI;";
        protected static string Conn = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        protected static SqlConnection ObtenerConexionTickets()
        {
            SqlConnection cn = new SqlConnection(Conn);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return cn;
            }
        }

        protected static SqlDataAdapter ObtenerAdpterTickets(SqlCommand storeP)
        {
            SqlDataAdapter adp;
            try
            {
                adp = new SqlDataAdapter(storeP);
                storeP.Connection = ObtenerConexionTickets();
                return adp;
            }
            catch (Exception ex)
            {
                storeP.Connection.Close();
                return null;
            }
        }
    }
}
