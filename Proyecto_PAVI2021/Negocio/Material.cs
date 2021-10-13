using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Negocio
{
    class Material
    {
        private int id_material;
        private string nombre;
        private int stock;
        private int id_marca;
        private bool borrado;
        private Double precio;

        public int Id_material { get => id_material; set => id_material = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Stock { get => stock; set => stock = value; }

        public int Id_marca { get => id_marca; set => id_marca = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
