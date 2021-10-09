using Proyecto_PAVI2021.Datos;
using ProyectoAutopartes.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Datos.Daos
{
    class ClienteDao : ICliente
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT c.Id_Cliente, c.Nombre, c.Apellido, c.Telefono, c.Tipo_Doc, c.Nro_Doc, c.Calle, c.Nro_Calle FROM CLIENTES c WHERE c.Borrado = 0";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable RecuperarFiltrados(string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura)
        {
            string consulta = "SELECT c.Id_Cliente, c.Nombre, c.Apellido, c.Telefono, c.Tipo_Doc, c.Nro_Doc, c.Calle, c.Nro_Calle FROM CLIENTES c WHERE c.Borrado = 0";

            if (!string.IsNullOrEmpty(nombre))
                consulta += " AND c.Nombre LIKE '%" + nombre + "%'";
            if (!string.IsNullOrEmpty(apellido))
                consulta += " AND c.Apellido LIKE '%" + apellido + "%'";
            if (!string.IsNullOrEmpty(telefono))
                consulta += " AND c.Telefono LIKE '%" + telefono + "%'";
            if (!string.IsNullOrEmpty(tipo_doc))
                consulta += " AND c.Tipo_Doc LIKE '%" + tipo_doc + "%'";
            if (!string.IsNullOrEmpty(nro_doc))
                consulta += " AND c.Nro_Doc LIKE '%" + nro_doc + "%'";
            if (!string.IsNullOrEmpty(calle))
                consulta += " AND c.Calle LIKE '%" + calle + "%'";
            if (!string.IsNullOrEmpty(altura))
                consulta += " AND c.Nro_Calle LIKE '%" + altura + "%'";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public void RegistrarCliente(string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura, string fecha_alta)
        {
            string consulta = "INSERT INTO CLIENTES (Tipo_Doc, Nro_Doc, Nombre, Apellido, Telefono, Calle, Nro_Calle, Fecha_Alta) " +
                              "VALUES ('" + tipo_doc + "', '" + nro_doc + "', '" + nombre + "', '" + apellido + "', '" + telefono + "', '" + calle + "', '" + altura + "', CONVERT(DateTime, '" + fecha_alta + "', 103))";

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }

        public void ModificarClientePorId(int id_cliente, string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura)
        {
            string consulta = "UPDATE CLIENTES SET Nombre = '" + nombre + "', Apellido = '" + apellido + "', Telefono = '" + telefono + "', Tipo_Doc = '" + tipo_doc + "', Nro_Doc = '" + nro_doc + "', Calle = '" + calle + "', Nro_Calle = '" + altura + "' WHERE Id_Cliente = " + id_cliente;

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }

        public void BorrarCliente(int idCliente)
        {
            string consulta = "UPDATE CLIENTES SET Borrado = 1 WHERE Id_Cliente = " + idCliente;

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }

        public DataTable RecuperarClientePorId(int id_cliente)
        {
            string consulta = "SELECT c.Id_Cliente, c.Nombre, c.Apellido, c.Telefono, c.Tipo_Doc, c.Nro_Doc, c.Calle, c.Nro_Calle FROM CLIENTES c WHERE c.Borrado = 0 AND c.Id_Cliente = " + id_cliente;

            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
