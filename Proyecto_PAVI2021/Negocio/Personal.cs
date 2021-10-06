using Proyecto_PAVI2021.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Negocio
{
    class Personal
    {
        private int legajo;
        private string tipo_doc;
        private string nro_doc;
        private string nombre;
        private string apellido;
        private string telefono;
        private string calle;
        private string nro_calle;
        private int id_barrio;
        private int id_localidad;
        private int id_usuario;
        private bool borrado;

        public int Legajo { get => legajo; set => legajo = value; }
        public string Tipo_doc { get => tipo_doc; set => tipo_doc = value; }
        public string Nro_doc { get => nro_doc; set => nro_doc = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Nro_calle { get => nro_calle; set => nro_calle = value; }
        public int Id_barrio { get => id_barrio; set => id_barrio = value; }
        public int Id_localidad { get => id_localidad; set => id_localidad = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public bool Borrado { get => borrado; set => borrado = value; }

        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT p.Legajo, p.Nombre, p.Apellido, u.Nombre_Usuario as Usuario, pf.Nombre as Rol, p.Telefono, p.Tipo_Doc, p.Nro_Doc, p.Calle, p.Nro_Calle, b.Descripcion as Barrio, l.Descripcion as Localidad " +
                "FROM PERSONAL p JOIN USUARIOS u on p.Id_Usuario = u.Id_Usuario JOIN BARRIOS b on p.Id_Barrio = b.Id_Barrio JOIN LOCALIDADES l on p.Id_Localidad = l.Id_Localidad " +
                "JOIN PERFILES pf on u.Id_Perfil = pf.Id_Perfil " +
                "WHERE p.Borrado = 0";

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }

        public DataTable RecuperarFiltrados(string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura, string usuario, string barrio, string localidad)
        {
            string consulta = "SELECT p.Legajo, p.Nombre, p.Apellido, u.Nombre_Usuario as Usuario, pf.Nombre as Rol, p.Telefono, p.Tipo_Doc, p.Nro_Doc, p.Calle, p.Nro_Calle, b.Descripcion as Barrio, l.Descripcion as Localidad " +
                "FROM PERSONAL p JOIN USUARIOS u on p.Id_Usuario = u.Id_Usuario JOIN BARRIOS b on p.Id_Barrio = b.Id_Barrio JOIN LOCALIDADES l on p.Id_Localidad = l.Id_Localidad " +
                "JOIN PERFILES pf on u.Id_Perfil = pf.Id_Perfil " +
                "WHERE p.Borrado = 0";

            if (!string.IsNullOrEmpty(nombre))
                consulta += " AND p.Nombre LIKE '" + nombre + "%'";
            if (!string.IsNullOrEmpty(apellido))
                consulta += " AND p.Apellido LIKE '" + apellido + "%'";
            if (!string.IsNullOrEmpty(telefono))
                consulta += " AND p.Telefono LIKE '" + telefono + "%'";
            if (!string.IsNullOrEmpty(tipo_doc))
                consulta += " AND p.Tipo_Doc LIKE '" + tipo_doc + "%'";
            if (!string.IsNullOrEmpty(nro_doc))
                consulta += " AND p.Nro_Doc LIKE '" + nro_doc + "%'";
            if (!string.IsNullOrEmpty(calle))
                consulta += " AND p.Calle LIKE '" + calle + "%'";
            if (!string.IsNullOrEmpty(altura))
                consulta += " AND p.Nro_Calle LIKE '" + altura + "%'";
            if (!string.IsNullOrEmpty(usuario))
                consulta += " AND u.Nombre_Usuario LIKE '" + usuario + "%'";
            if (!string.IsNullOrEmpty(barrio))
                consulta += " AND p.Id_Barrio = " + barrio;
            if (!string.IsNullOrEmpty(localidad))
                consulta += " AND p.Id_Localidad = " + localidad;

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }

        public void RegistrarPersonal(string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura, string id_barrio, string id_localidad, string id_usuario)
        {
            string consulta = "INSERT INTO PERSONAL (Tipo_Doc, Nro_Doc, Nombre, Apellido, Telefono, Calle, Nro_Calle, Id_Barrio, Id_Localidad, Id_Usuario) " +
                              "VALUES ('" + tipo_doc + "', '" + nro_doc + "', '" + nombre + "', '" + apellido + "', '" + telefono + "', '" + calle + "', '" + altura 
                              + "', "+ id_barrio + ", " + id_localidad + ", " + id_usuario + ")";
            BDHelper oDatos = new BDHelper();
            oDatos.EjecutarConsulta(consulta);
        }

        public void ModificarPersonalPorLegajo(int legajo, string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura, string barrio, string localidad, string usuario)
        {
            string consulta = "UPDATE PERSONAL SET Nombre = '" + nombre + "', Apellido = '" + apellido + "', Telefono = '" + telefono + "', Tipo_Doc = '" + tipo_doc + "', Nro_Doc = '" + nro_doc + "', Calle = '" + calle + "', Nro_Calle = '" + altura + "', Id_Barrio = " + barrio + ", Id_Localidad = " + localidad + ", Id_Usuario = " + usuario + " WHERE Legajo = " + legajo;
            BDHelper oDatos = new BDHelper();
            oDatos.EjecutarConsulta(consulta);
        }
        public void BorrarPersonal(int Legajo)
        {
            string consulta = "UPDATE PERSONAL SET Borrado = 1 WHERE Legajo = " + Legajo;
            BDHelper oDatos = new BDHelper();
            oDatos.EjecutarConsulta(consulta);
        }

        public DataTable RecuperarPersonalPorLegajo(int legajo)
        {
            string consulta = "SELECT p.Legajo, p.Nombre, p.Apellido, u.Nombre_Usuario as Usuario, p.Telefono, p.Tipo_Doc, p.Nro_Doc, p.Calle, p.Nro_Calle, b.Descripcion as Barrio, l.Descripcion as Localidad " +
                "FROM PERSONAL p JOIN USUARIOS u on p.Id_Usuario = u.Id_Usuario JOIN BARRIOS b on p.Id_Barrio = b.Id_Barrio JOIN LOCALIDADES l on p.Id_Localidad = l.Id_Localidad " +
                "JOIN PERFILES pf on u.Id_Perfil = pf.Id_Perfil " +
                "WHERE p.Borrado = 0 AND p.Legajo = " + legajo;

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }

    }
}

