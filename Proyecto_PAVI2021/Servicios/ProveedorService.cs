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

        public void RegistrarProveedor(string nombre, string telefono, string cuit, string calle, string altura, int id_barrio, int id_localidad)
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
        
        public DataTable RecuperarProveedorPorId(int id)
        {
            return dao.RecuperarProveedorPorId(id);
        }


    }
}
