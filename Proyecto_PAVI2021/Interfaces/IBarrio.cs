﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Interfaces
{
    interface IBarrio
    {
        DataTable RecuperarTodos();
        DataTable RecuperarFiltrados(string descripcion, string id_localidad);
        void RegistrarBarrio(string descripcion, string id_localidad);
        void ModificarBarrioPorId(int id_barrio, string descripcion, string id_localidad);
        void EliminarBarrio(int id_barrio);
        DataTable RecuperarPorLocalidad(int id_localidad);

        DataTable RecuperarBarrioPorId(int id_barrio);
    }
}
