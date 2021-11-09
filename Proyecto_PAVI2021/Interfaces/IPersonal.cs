using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Interfaces
{
    interface IPersonal
    {
        DataTable RecuperarTodos();
        DataTable RecuperarFiltrados(string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura, string usuario, string barrio, string localidad);
        void RegistrarPersonal(string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura, string id_barrio, string id_localidad, string id_usuario);
        void ModificarPersonalPorLegajo(int legajo, string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura, string barrio, string localidad, string usuario);
        void BorrarPersonal(int Legajo);
        DataTable RecuperarPersonalPorLegajo(int legajo);
        DataTable validarUnicoUsuario(int id_usuario);
    }
}
