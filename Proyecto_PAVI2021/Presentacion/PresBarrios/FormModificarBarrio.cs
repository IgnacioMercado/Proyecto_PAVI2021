using Proyecto_PAVI2021.Negocio;
using Proyecto_PAVI2021.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PAVI2021.Presentacion.PresBarrios
{
    public partial class FormModificarBarrio : Form
    {
        private int id_barrio;
        BarrioService oBarrio = new BarrioService();

        public FormModificarBarrio()
        {
            InitializeComponent();
        }

        public FormModificarBarrio(int id_barrio)
        {
            InitializeComponent();
            this.id_barrio = id_barrio;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar1_Click(object sender, EventArgs e)
        {
            string descripcion;
            descripcion = txtNombre.Text.ToString();
            if (descripcion == "")
            {
                MessageBox.Show("Por favor, complete el campo antes de intentar modificar el barrio");
            }
            else
            {
                oBarrio.ModificarBarrioPorId(id_barrio, descripcion);
                MessageBox.Show("Barrio modificado");
                this.Close();
            }
        }
    }
}
