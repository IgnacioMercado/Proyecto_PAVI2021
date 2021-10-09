using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Interfaces
{
    interface IUsuario
    {
        int validarUsuario(string nombre, string clave);
        DataTable RecuperarTodos();


        DataTable RecuperarPorIdUsuario(int id_usuario);


        DataTable RecuperarFiltrados(string desde, string hasta, string rol);

        void BorrarUsuario(int idUsuario);
        void RegistrarUsuario(string nombre, string contraseña, string fecha_alta, string rol);
        void ModificarUsuarioPorId(int id_usuario, string nombre, string contraseña, string rol);


    }
}
