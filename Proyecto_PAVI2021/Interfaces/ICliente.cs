using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Interfaces
{
    interface ICliente
    {
        DataTable RecuperarTodos();


        DataTable RecuperarFiltrados(string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura, string barrio, string localidad);


        void RegistrarCliente(string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura, string fecha_alta, string barrio);


        void ModificarClientePorId(int id_cliente, string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura);


        void BorrarCliente(int idCliente);


        DataTable RecuperarClientePorId(int id_cliente);

    }
}
