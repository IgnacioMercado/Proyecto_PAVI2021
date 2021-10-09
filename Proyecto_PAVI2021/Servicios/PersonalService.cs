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
    class PersonalService
    {
        private IPersonal dao;

        public PersonalService()
        {
            dao = new PersonalDao();
        }

        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos()
        }

        public DataTable RecuperarFiltrados(string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura, string usuario, string barrio, string localidad)
        {
            return dao.RecuperarFiltrados(nombre, apellido, telefono, tipo_doc, nro_doc, calle, altura, usuario, barrio, localidad);
        }

        public void RegistrarPersonal(string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura, string id_barrio, string id_localidad, string id_usuario)
        {
            dao.RegistrarPersonal(nombre, apellido, telefono, tipo_doc, nro_doc, calle, altura, id_barrio, id_localidad, id_usuario);
        }

        public void ModificarPersonalPorLegajo(int legajo, string nombre, string apellido, string telefono, string tipo_doc, string nro_doc, string calle, string altura, string barrio, string localidad, string usuario)
        {
            dao.ModificarPersonalPorLegajo(legajo, nombre, apellido, telefono, tipo_doc, nro_doc, calle, altura, barrio, localidad, usuario);
        }

        public void BorrarPersonal(int Legajo)
        {
            dao.BorrarPersonal(Legajo);
        }

        public DataTable RecuperarPersonalPorLegajo(int legajo)
        {
            return dao.RecuperarPersonalPorLegajo(legajo);
        }
    }
}
