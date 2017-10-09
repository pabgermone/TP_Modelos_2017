using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAL : Conexion
    {
        public DAL()
        {
            // construct code here.
        }

        /// <summary>
        /// Ejecuta un SP y devuelve un mensaje si no funciono
        /// </summary>
        protected static string EjecutarStore(string store, SqlParameter[] parametros)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexionTickets();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = store;

            foreach (SqlParameter param in parametros)
            {
                comando.Parameters.Add(param);
            }

            try
            {
                comando.ExecuteNonQuery();
                comando.Connection.Close();
                return string.Empty;
            }
            catch (Exception ex)
            {
                comando.Connection.Close();
                return ex.Message;
            }
        }


        protected static object EjecutarConsulta(string consulta)
        {

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexionTickets();
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;

            try
            {
                object obj = comando.ExecuteReader();
                comando.Connection.Close();
                return string.Empty;
            }
            catch (Exception ex)
            {
                comando.Connection.Close();
                return ex.Message;
            }
        }

        /// <summary>
        /// Ejecuta un SP y devuelve el objeto si es que se obtuvo
        /// </summary>
        protected static object ObtenerDato(string store, SqlParameter[] parametros)
        {

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexionTickets();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = store;

            foreach (SqlParameter param in parametros)
            {
                comando.Parameters.Add(param);
            }
            try
            {
                object obj = comando.ExecuteScalar();
                comando.Connection.Close();
                if (obj == null)
                    obj = string.Empty;
                return obj;
            }
            catch (Exception ex)
            {
                comando.Connection.Close();
                return null;
            }
        }

        /// <summary>
        /// realiza una consulta a la base de datos con la cadena que se le envia, devuelve el objetvo
        /// </summary>
        protected static object ObtenerDatoConsulta(string consulta)
        {

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexionTickets();
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;

            try
            {
                object obj = comando.ExecuteScalar();
                comando.Connection.Close();
                if (obj == null)
                    obj = string.Empty;
                return obj;
            }
            catch (Exception ex)
            {
                comando.Connection.Close();
                return null;
            }
        }

     


        protected static DataTable ObtenerTabla(string store, SqlParameter[] parametros)
        {

            SqlCommand comando = new SqlCommand();
            SqlDataAdapter adp = Conexion.ObtenerAdpterTickets(comando);
            DataTable dt = new DataTable();

            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = store;

            if (parametros != null)
            {
                foreach (SqlParameter param in parametros)
                {
                    comando.Parameters.Add(param);
                }
            }
            try
            {
                adp.Fill(dt);
                comando.Connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                comando.Connection.Close();
                return null;
            }
        }

        protected static List<object> DevolverListaObjeto(string store, SqlParameter[] parametros)
        {
            List<object> ListObject = new List<object>();
            SqlCommand comando = new SqlCommand();
            SqlDataAdapter adp = Conexion.ObtenerAdpterTickets(comando);
            DataTable dt = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = store;

            if (parametros != null)
            {
                foreach (SqlParameter param in parametros)
                {
                    comando.Parameters.Add(param);
                }
            }

            try
            {
                adp.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ListObject.Add(dr);
                }
                comando.Connection.Close();
            }
            catch (Exception ex)
            {
                comando.Connection.Close();
                throw ex;
            }

            return ListObject;
        }

        protected static List<object> DevolverListaObjetoConsulta(string consulta)
        {
            List<object> ListObject = new List<object>();
            SqlCommand comando = new SqlCommand();
            SqlDataAdapter adp = Conexion.ObtenerAdpterTickets(comando);
            DataTable dt = new DataTable();

            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;

            try
            {
                adp.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ListObject.Add(dr);
                }
                comando.Connection.Close();
            }
            catch (Exception ex)
            {
                comando.Connection.Close();
                throw ex;
            }
            return ListObject;
        }

        protected static DataTable ObtenerTablaConsulta(string consulta)
        {

            SqlCommand comando = new SqlCommand();
            SqlDataAdapter adp = Conexion.ObtenerAdpterTickets(comando);
            DataTable dt = new DataTable();

            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;

            try
            {
                adp.Fill(dt);
                comando.Connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                comando.Connection.Close();
                return null;
            }
        }
    }
}
