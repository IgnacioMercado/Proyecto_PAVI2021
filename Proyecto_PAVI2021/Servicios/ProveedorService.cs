using Proyecto_PAVI2021.Datos;
using Proyecto_PAVI2021.Datos.Daos;
using Proyecto_PAVI2021.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Servicios
{
    class ProveedorService
    {
        private IProveedor dao;

        public ProveedorService()
        {
            dao = new ProveedorDao();
        }

        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }

        public DataTable RecuperarFiltrados(string nombre, string telefono, string cuit, string calle, string altura, string id_barrio, string id_localidad)
        {
            return dao.RecuperarFiltrados(nombre, telefono, cuit, calle, altura, id_barrio, id_localidad);
        }

        public void RegistrarCliente(string nombre, string telefono, string cuit, string calle, string altura, int id_barrio, int id_localidad)
        {
            dao.RegistrarProveedor(nombre, telefono, cuit, calle, altura, id_barrio, id_localidad);
        }

        public void ModificarProveedorPorId(int id, string nombre, string telefono, string cuit, string calle, string altura, int id_barrio, int id_localidad)
        {
            dao.ModificarProveedorPorId(id, nombre, telefono, cuit, calle, altura, id_barrio, id_localidad);
        }

        public void BorrarProveedor(int id)
        {
            dao.BorrarProveedor(id);
        }

        public DataTable RecuperarProveedorPorId(int id_proveedor)
        {
            string consulta = "SELECT p.Id_Proveedor, p.Nombre, p.Telefono, p.CUIT, p.Calle, p.Nro_Calle, p.Id_Barrio, p.Id_Localidad FROM PROVEEDORESS p WHERE p.Borrado = 0 AND p.Id_Proveedor = " + id_proveedor;

            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
