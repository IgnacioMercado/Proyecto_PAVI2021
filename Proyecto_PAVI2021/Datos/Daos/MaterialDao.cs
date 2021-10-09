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
    class MaterialDao : IMaterial
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT m.Id_Material, m.Nombre FROM MATERIALES m WHERE m.Borrado = 0";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
