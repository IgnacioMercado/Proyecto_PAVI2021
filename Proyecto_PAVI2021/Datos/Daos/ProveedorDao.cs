﻿using Proyecto_PAVI2021.Datos;
using Proyecto_PAVI2021.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Datos.Daos
{
    class ProveedorDao : IProveedor
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT p.Id_Proveedor, p.Nombre, p.Telefono, p.CUIT, p.Calle, p.Nro_Calle, b.Descripcion as DescripcionB, l.Descripcion as DescripcionL FROM PROVEEDORESS p JOIN BARRIOS b on p.Id_Barrio = b.Id_Barrio JOIN LOCALIDADES l on l.Id_Localidad = b.Id_Localidad WHERE p.Borrado = 0";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable RecuperarFiltrados(string nombre, string telefono, string cuit, string calle, string altura, string id_barrio, string id_localidad)
        {
            string consulta = "SELECT p.Id_Proveedor, p.Nombre, p.Telefono, p.CUIT, p.Calle, p.Nro_Calle, b.Descripcion as DescripcionB, l.Descripcion as DescripcionL FROM PROVEEDORESS p JOIN BARRIOS b on p.Id_Barrio = b.Id_Barrio JOIN LOCALIDADES l on l.Id_Localidad = b.Id_Localidad WHERE p.Borrado = 0";

            if (!string.IsNullOrEmpty(nombre))
                consulta += " AND p.Nombre LIKE '%" + nombre + "%'";
            if (!string.IsNullOrEmpty(telefono))
                consulta += " AND p.Telefono LIKE '%" + telefono + "%'";
            if (!string.IsNullOrEmpty(cuit))
                consulta += " AND p.CUIT LIKE '%" + cuit + "%'";
            if (!string.IsNullOrEmpty(calle))
                consulta += " AND p.Calle LIKE '%" + calle + "%'";
            if (!string.IsNullOrEmpty(altura))
                consulta += " AND p.Nro_Calle LIKE '%" + altura + "%'";
            if (!string.IsNullOrEmpty(id_barrio))
                consulta += " AND p.Id_Barrio LIKE '%" + id_barrio + "%'";
            if (!string.IsNullOrEmpty(id_localidad))
                consulta += " AND b.Id_Localidad LIKE '%" + id_localidad + "%'";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public void RegistrarProveedor(string nombre, string telefono, string cuit, string calle, string altura, int id_barrio, int id_localidad)
        {
            string consulta = "INSERT INTO PROVEEDORESS (Nombre, Apellido, Telefono, Calle, Nro_Calle,Id_Barrio) " +
                              "VALUES ('" + nombre + "', '" + telefono + "', '" + calle + "', '" + altura + "', " + id_barrio + ")";

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }

        public void ModificarProveedorPorId(int id, string nombre, string telefono, string cuit, string calle, string altura, int id_barrio, int id_localidad)
        {
            string consulta = "UPDATE CLIENTES SET Nombre = '" + nombre + "', Telefono = '" + telefono + "', CUIT = '" + cuit + "', Calle = '" + calle + "', Nro_Calle = '" 
                                + altura +"', Id_Barrio = " + id_barrio + " WHERE Id_Proveedor = " + id;

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }

        public void BorrarProveedor(int id)
        {
            string consulta = "UPDATE PROVEEDORESS SET Borrado = 1 WHERE Id_Proveedor = " + id;

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }

        public DataTable RecuperarProveedorPorId(int id_proveedor)
        {
            string consulta = "SELECT p.Id_Proveedor, p.Nombre, p.Telefono, p.CUIT, p.Calle, p.Nro_Calle, b.Descripcion as DescripcionB, l.Descripcion as DescripcionL, p.Id_Barrio, b.Id_Localidad FROM PROVEEDORESS p JOIN BARRIOS b on p.Id_Barrio = b.Id_Barrio JOIN LOCALIDADES l on l.Id_Localidad = b.Id_Localidad WHERE p.Borrado = 0 AND p.Id_Proveedor = " + id_proveedor;

            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
