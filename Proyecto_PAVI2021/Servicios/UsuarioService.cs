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
    class UsuarioService
    {
        private IUsuario dao;

        public UsuarioService()
        {
            dao = new UsuarioDao();
        }

        public int validarUsuario(string nombre, string clave)
        {
            return dao.validarUsuario(nombre, clave);
        }

        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }

        public DataTable RecuperarPorIdUsuario(int id_usuario)
        {
            return dao.RecuperarPorIdUsuario(id_usuario);
        }

        public DataTable RecuperarFiltrados(string desde, string hasta, string rol)
        {
            return dao.RecuperarFiltrados(desde, hasta, rol);
        }

        public void BorrarUsuario(int idUsuario)
        {
            dao.BorrarUsuario(idUsuario);
        }

        public void RegistrarUsuario(string nombre, string contraseña, string fecha_alta, string rol)
        {
            dao.RegistrarUsuario(nombre, contraseña, fecha_alta, rol);
        }

        public void ModificarUsuarioPorId(int id_usuario, string nombre, string contraseña, string rol)
        {
            dao.ModificarUsuarioPorId(id_usuario, nombre, contraseña, rol);
        }
    }
}
