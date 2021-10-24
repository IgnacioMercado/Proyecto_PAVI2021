using Proyecto_PAVI2021.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Negocio
{
    class Proveedor
    {

        private int id_proveedor;
        private string nombre;
        private string telefono;
        private string cuit;
        private string calle;
        private string nro_calle;
        private int id_barrio;
        private int id_localidad;
        private bool borrado;

        public int Id_Proveedor { get => id_proveedor; set => id_proveedor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Cuit { get => cuit; set => cuit = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Nro_calle { get => nro_calle; set => nro_calle = value; }
        public int Id_Barrio { get => id_barrio; set => id_barrio = value; }
        public int Id_Localidad { get => id_localidad; set => id_localidad = value; }
        public bool Borrado { get => borrado; set => borrado = value; }

        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT p.Id_Proveedor, p.Nombre, p.Telefono, p.CUIT, p.Calle, p.Nro_Calle, p.Id_Barrio, p.Id_Localidad FROM PROVEEDORESS p WHERE p.Borrado = 0";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }
        public DataTable RecuperarFiltrados(string nombre, string telefono, string cuit, string calle, string altura, string id_barrio, string id_localidad)
        {
            string consulta = "SELECT p.Id_Proveedor, p.Nombre, p.Telefono, p.CUIT, p.Calle, p.Nro_Calle, p.Id_Barrio, p.Id_Localidad FROM PROVEEDORESS p WHERE p.Borrado = 0";

            if (!string.IsNullOrEmpty(nombre))
                consulta += " AND p.Nombre LIKE '%"       + nombre + "%'";
            if (!string.IsNullOrEmpty(telefono))
                consulta += " AND p.Telefono LIKE '%"     + telefono + "%'";
            if (!string.IsNullOrEmpty(cuit))
                consulta += " AND p.CUIT LIKE '%"         + cuit + "%'";
            if (!string.IsNullOrEmpty(calle))
                consulta += " AND p.Calle LIKE '%"        + calle + "%'";
            if (!string.IsNullOrEmpty(altura))
                consulta += " AND p.Nro_Calle LIKE '%"    + altura + "%'";
            if (!string.IsNullOrEmpty(id_barrio))
                consulta += " AND p.Id_Barrio LIKE '%"    + id_barrio + "%'";
            if (!string.IsNullOrEmpty(id_localidad))
                consulta += " AND p.Id_Localidad LIKE '%" + id_localidad + "%'";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }
        public DataTable RecuperarProveedorPorId(int id_proveedor)
        {
            string consulta = "SELECT p.Id_Proveedor, p.Nombre, p.Telefono, p.CUIT, p.Calle, p.Nro_Calle, p.Id_Barrio, p.Id_Localidad FROM PROVEEDORESS p WHERE p.Borrado = 0 AND p.Id_Proveedor = " + id_proveedor;

            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
