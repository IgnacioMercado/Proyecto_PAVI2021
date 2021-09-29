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
        private SqlConnection conexion = new SqlConnection();
        private SqlCommand comando = new SqlCommand();
        private string cadenaConexion = @"Data Source=DESKTOP-RJE4TPG\SQLEXPRESS;Initial Catalog=Proyecto_PAVI2021;Integrated Security=True";

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
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;
            comando.ExecuteReader();
        }

    }
}
