using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Datos
{
    public class BDHelper
    {
        private static BDHelper instancia;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlTransaction transaccion;
        string cadenaConexion;

        public BDHelper()
        {
            conexion = new SqlConnection(); // establece la conexion con SQL
            comando = new SqlCommand(); // permite manipular la BD
            cadenaConexion = @"Data Source=DESKTOP-RJE4TPG\SQLEXPRESS;Initial Catalog=Proyecto_PAVI2021_2daVersion;Integrated Security=True";
            conexion.ConnectionString = cadenaConexion;
        }

        public static BDHelper obtenerInstancia()
        {
            if (instancia == null)
                instancia = new BDHelper();

            return instancia;
        }

        public void BeginTransaction()
        {
            if (conexion.State == ConnectionState.Open)
                transaccion = conexion.BeginTransaction();
        }

        public void Commit()
        {
            if  (transaccion != null)
                transaccion.Commit();
        }

        public void Rollback()
        {
            if (transaccion != null)
                transaccion.Rollback();
        }

        public void Open()
        {
            if (conexion.State != ConnectionState.Open)
                conexion.Open();
        }

        public void Close()
        {
            if (conexion.State != ConnectionState.Closed)
                conexion.Close();
        }

        public DataTable consultar(string consulta)
        {            
            DataTable tabla = new DataTable();
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;
            tabla.Load(comando.ExecuteReader());
            conexion.Close();

            return tabla;
        }

        public void EjecutarConsulta(string consulta)
        {            
            DataTable tabla = new DataTable();
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public DataTable ConsultaSQL(string strSql)
        {


            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            
            conexion.Open();
            try
            {
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                //  El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos

                tabla.Load(cmd.ExecuteReader());
                //  La función retorna el objeto datatable con 0, 1 o mas registros
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public DataTable ConsultaSQLConParametros(string strSql, List<object> sqlParam)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;

                var indice = 0;
                foreach (var param in sqlParam)
                {
                    if (param != null)
                    {
                        var n_param = "param" + Convert.ToString(indice + 1);
                        cmd.Parameters.AddWithValue(n_param, param);
                    }
                    indice++;
                }

                tabla.Load(cmd.ExecuteReader());

                //  La función retorna el objeto datatable con 0, 1 o mas registros
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// Resumen:
        ///      Se utiliza para sentencias SQL del tipo “Select” con parámetros recibidos desde la interfaz
        ///      La función recibe por valor una sentencia sql como string y un diccionario de objetos como parámetros
        /// Devuelve:
        ///      un objeto de tipo DataTable con el resultado de la consulta
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        public DataTable ConsultaSQLConParametros(string strSql, Dictionary<string, object> prs)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                foreach (var item in prs)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }

                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un valor entero con el número de filas afectadas por la sentencia ejecutada
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        //SIN PARAMETROS

        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un valor entero con el número de filas afectadas por la sentencia ejecutada
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        ///              
        //SIN PARAMETROS
        public int EjecutarSQL(string strSql)
        {
            // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”

            SqlCommand cmd = new SqlCommand();

            int rtdo = 0;

            // Try Catch Finally
            // Trata de ejecutar el código contenido dentro del bloque Try - Catch
            // Si hay error lo capta a través de una excepción
            // Si no hubo error
            try
            {
                cmd.Connection = conexion;
                cmd.Transaction = transaccion;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;








                // Retorna el resultado de ejecutar el comando
                rtdo = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rtdo;
        }

        //CON PARAMETROS
        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un valor entero con el número de filas afectadas por la sentencia ejecutada
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        public int EjecutarSQLCONPARAMETROS(string strSql, Dictionary<string, object> parametros = null)
        {
            // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”

            SqlCommand cmd = new SqlCommand();

            int rtdo = 0;

            // Try Catch Finally
            // Trata de ejecutar el código contenido dentro del bloque Try - Catch
            // Si hay error lo capta a través de una excepción
            // Si no hubo error
            try
            {
                cmd.Connection = conexion;
                cmd.Transaction = transaccion;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                foreach (var item in parametros)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }


                // Retorna el resultado de ejecutar el comando
                rtdo = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rtdo;
        }


        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Select”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un valor entero
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        public object ConsultaSQLScalar(string strSql)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = conexion;
                cmd.Transaction = transaccion;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;
                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
        }
    }
}
