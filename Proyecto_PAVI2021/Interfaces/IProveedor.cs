using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProyectoAutopartes.Interfaces
{
    interface IProveedor
    {
        DataTable RecuperarTodos();


        DataTable RecuperarFiltrados(string nombre, string telefono, string cuit, string calle, string altura, string id_barrio, string id_localidad);


        void RegistrarProveedor(string nombre, string telefono, string cuit, string calle, string altura, int id_barrio, int id_localidad);


        void ModificarProveedorPorId(int id, string nombre, string apellido, string telefono, string calle, string altura,int id_barrio, int id_localidad);


        void BorrarProveedor(int id);

        DataTable RecuperarProveedorPorId(int id);
    }
}
