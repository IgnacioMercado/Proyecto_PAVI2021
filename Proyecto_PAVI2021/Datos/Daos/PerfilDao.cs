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
    class PerfilDao : IPerfil
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM PERFILES WHERE Borrado = 0 ORDER BY Id_Perfil";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
