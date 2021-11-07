using Proyecto_PAVI2021.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Datos.Daos
{
    class MarcaDao : IMarca
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM MARCAS WHERE Borrado = 0";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
