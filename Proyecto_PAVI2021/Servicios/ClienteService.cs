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
    class ClienteService
    {
        private ICliente dao;

        public ClienteService()
        {
            dao = new ClienteDao();
        }

        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }

        public DataTable RecuperarFiltrados(string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura)
        {
            return dao.RecuperarFiltrados(nombre, apellido, telefono, tipo_doc, nro_doc, calle, altura);
        }

        public void RegistrarCliente(string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura, string fecha_alta)
        {
            dao.RegistrarCliente(nombre, apellido, telefono, tipo_doc, nro_doc, calle, altura, fecha_alta);
        }

        public void ModificarClientePorId(int id_cliente, string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura)
        {
            dao.ModificarClientePorId(id_cliente, nombre, apellido, telefono, tipo_doc, nro_doc, calle, altura);
        }

        public void BorrarCliente(int idCliente)
        {
            dao.BorrarCliente(idCliente);
        }

        public DataTable RecuperarClientePorId(int id_cliente)
        {
            return dao.RecuperarClientePorId(id_cliente);
        }
    }
}
