using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Datos
{
    class BDHelper
    {
        private static BDHelper instancia;
        private SqlConnection conexion;
        private SqlCommand comando;
        string cadenaConexion;

        private BDHelper()
        {
            conexion = new SqlConnection(); // establece la conexion con SQL
            comando = new SqlCommand(); // permite manipular la BD
            cadenaConexion = @"Data Source=DESKTOP-RJE4TPG\SQLEXPRESS;Initial Catalog=Proyecto_PAVI2021;Integrated Security=True";
        }

        public static BDHelper obtenerInstancia()
        {
            if (instancia == null)
                instancia = new BDHelper();
            return instancia;
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
    }
}
