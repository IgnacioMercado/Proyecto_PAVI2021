using Proyecto_PAVI2021.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Negocio
{
    class Usuario
    {
        private int id_usuario;
        private string nombre;
        private string contraseña;
        private DateTime fecha_alta;
        private int id_perfil;
        private bool borrado;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public DateTime Fecha_alta { get => fecha_alta; set => fecha_alta = value; }
        public int Id_perfil { get => id_perfil; set => id_perfil = value; }
        public bool Borrado { get => borrado; set => borrado = value; }

        public int validarUsuario(string nombre, string clave)
        {
            string consulta = "SELECT * FROM USUARIOS WHERE Nombre_Usuario='" + nombre + "' AND Contraseña_Usuario='" + clave + "'";

            BDHelper oDatos = new BDHelper();
            DataTable tabla = oDatos.consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (int)tabla.Rows[0][0];
            else
                return 0;
        }

        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT u.Id_Usuario, u.Nombre_Usuario, u.Fecha_Alta, p.Nombre as Perfil FROM USUARIOS u JOIN PERFILES p on u.Id_Perfil = p.Id_Perfil WHERE u.Borrado = 0";

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }

        public DataTable RecuperarPorIdUsuario(int id_usuario)
        {
            string consulta = "SELECT u.Id_Usuario, u.Nombre_Usuario, u.Contraseña_Usuario, u.Fecha_Alta, p.Id_Perfil, p.Nombre as Perfil FROM USUARIOS u JOIN PERFILES p on u.Id_Perfil = p.Id_Perfil " +
                "WHERE u.Borrado = 0 AND Id_Usuario = " + id_usuario;

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }

        //Utilizar funcion de conversion convert
        //CONVERT(DateTime, '01/12/2021', 103) 
        //Pasar dia mes y año y usar consultas Date Year Month

        public DataTable RecuperarFiltrados(string desde, string hasta, string rol)
        {
            string consulta = "SELECT u.Id_Usuario, u.Nombre_Usuario, u.Fecha_Alta, p.Nombre as Perfil FROM USUARIOS u JOIN PERFILES p on u.Id_Perfil = p.Id_Perfil WHERE u.Borrado = 0";

            consulta += " AND u.Fecha_Alta BETWEEN  CONVERT(DateTime, '" + desde + "', 103)  AND CONVERT (DateTime, '" + hasta + "',103) ";

            if (!string.IsNullOrEmpty(rol))
                consulta += " AND u.Id_Perfil = " + rol;

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }

        public void BorrarUsuario(int idUsuario)
        {
            string consulta = "UPDATE USUARIOS SET Borrado = 1 WHERE Id_Usuario = " + idUsuario;
            BDHelper oDatos = new BDHelper();
            oDatos.EjecutarConsulta(consulta);
            
        }

        public void RegistrarUsuario(string nombre, string contraseña, string fecha_alta, string rol)
        {
            string consulta = "INSERT INTO USUARIOS (Nombre_Usuario, Contraseña_Usuario, Fecha_Alta, Id_Perfil) " +
                              "VALUES ('" + nombre + "', '" + contraseña + "', '" + fecha_alta + "', " + rol + ")";
            BDHelper oDatos = new BDHelper();
            oDatos.EjecutarConsulta(consulta);
        }

        public void ModificarUsuarioPorId(int id_usuario, string nombre, string contraseña, string rol)
        {

            string consulta = "UPDATE USUARIOS SET Nombre_Usuario = '" + nombre + "', Contraseña_Usuario = '" + contraseña + "', Id_Perfil = " + rol + " WHERE Id_Usuario = " + id_usuario;
            BDHelper oDatos = new BDHelper();
            oDatos.EjecutarConsulta(consulta);
        }
    }
}
