using ProyectoAutopartes.Datos.Daos;
using ProyectoAutopartes.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Servicios
{
    class LocalidadService
    {
        private ILocalidad dao;

        public LocalidadService()
        {
            dao = new LocalidadDao();
        }

        public void RegistrarLocalidad(string nombre)
        {
            dao.RegistrarLocalidad(nombre);
        }

        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }

        public DataTable RecuperarFiltrados(string id)
        {
            return dao.RecuperarFiltrados(id);
        }

        public DataTable RecuperarPorDescripcion(string nombre)
        {
            return dao.RecuperarPorDescripcion(nombre);
        }

        public void ModificarLocalidadPorId(string id, string descripcion)
        {
            dao.ModificarLocalidadPorId(id, descripcion);
        }

    }
}
