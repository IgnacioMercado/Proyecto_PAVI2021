using Proyecto_PAVI2021.Datos;
using Proyecto_PAVI2021.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Datos.Daos
{
    class PersonalDao : IPersonal
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT p.Legajo, p.Nombre, p.Apellido, u.Nombre_Usuario as Usuario, pf.Nombre as Rol, p.Telefono, p.Tipo_Doc, p.Nro_Doc, p.Calle, p.Nro_Calle, b.Descripcion as Barrio, l.Descripcion as Localidad " +
                "FROM PERSONAL p JOIN USUARIOS u on p.Id_Usuario = u.Id_Usuario JOIN BARRIOS b on p.Id_Barrio = b.Id_Barrio JOIN LOCALIDADES l on b.Id_Localidad = l.Id_Localidad " +
                "JOIN PERFILES pf on u.Id_Perfil = pf.Id_Perfil " +
                "WHERE p.Borrado = 0";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable RecuperarFiltrados(string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura, string usuario, string barrio, string localidad)
        {
            string consulta = "SELECT p.Legajo, p.Nombre, p.Apellido, u.Nombre_Usuario as Usuario, pf.Nombre as Rol, p.Telefono, p.Tipo_Doc, p.Nro_Doc, p.Calle, p.Nro_Calle, b.Descripcion as Barrio, l.Descripcion as Localidad " +
                "FROM PERSONAL p JOIN USUARIOS u on p.Id_Usuario = u.Id_Usuario JOIN BARRIOS b on p.Id_Barrio = b.Id_Barrio JOIN LOCALIDADES l on b.Id_Localidad = l.Id_Localidad " +
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
                consulta += " AND b.Id_Localidad = " + localidad;

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public void RegistrarPersonal(string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura, string id_barrio, string id_localidad, string id_usuario)
        {
            string consulta = "INSERT INTO PERSONAL (Tipo_Doc, Nro_Doc, Nombre, Apellido, Telefono, Calle, Nro_Calle, Id_Barrio, Id_Localidad, Id_Usuario) " +
                              "VALUES ('" + tipo_doc + "', '" + nro_doc + "', '" + nombre + "', '" + apellido + "', '" + telefono + "', '" + calle + "', '" + altura
                              + "', " + id_barrio + ", " + id_localidad + ", " + id_usuario + ")";

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }

        public void ModificarPersonalPorLegajo(int legajo, string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura, string barrio, string localidad, string usuario)
        {
            string consulta = "UPDATE PERSONAL SET Nombre = '" + nombre + "', Apellido = '" + apellido + "', Telefono = '" + telefono + "', Tipo_Doc = '" + tipo_doc + "', Nro_Doc = '" + nro_doc + "', Calle = '" + calle + "', Nro_Calle = '" + altura + "', Id_Barrio = " + barrio + ", Id_Usuario = " + usuario + " WHERE Legajo = " + legajo;

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }

        public void BorrarPersonal(int Legajo)
        {
            string consulta = "UPDATE PERSONAL SET Borrado = 1 WHERE Legajo = " + Legajo;

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }

        public DataTable RecuperarPersonalPorLegajo(int legajo)
        {
            string consulta = "SELECT p.Legajo, p.Nombre, p.Apellido, u.Nombre_Usuario as Usuario, u.Id_Usuario, p.Telefono, p.Tipo_Doc, p.Nro_Doc, p.Calle, p.Nro_Calle, b.Descripcion as Barrio, l.Descripcion as Localidad, b.Id_Barrio, l.Id_Localidad " +
                "FROM PERSONAL p JOIN USUARIOS u on p.Id_Usuario = u.Id_Usuario JOIN BARRIOS b on p.Id_Barrio = b.Id_Barrio JOIN LOCALIDADES l on b.Id_Localidad = l.Id_Localidad " +
                "JOIN PERFILES pf on u.Id_Perfil = pf.Id_Perfil " +
                "WHERE p.Borrado = 0 AND p.Legajo = " + legajo;

            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
