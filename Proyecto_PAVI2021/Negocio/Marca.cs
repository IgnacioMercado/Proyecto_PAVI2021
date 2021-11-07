using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Negocio
{
    class Marca
    {
        private int id_marca;
        private string descripcion;
        private bool borrado;

        public bool Borrado { get => borrado; set => borrado = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Id_marca { get => id_marca; set => id_marca = value; }
    }
}
