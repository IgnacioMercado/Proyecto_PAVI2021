using Proyecto_PAVI2021.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAutopartes.Presentacion.PresBarrios
{
    public partial class FormModificarBarrio : Form
    {
        private int id_barrio;
        Barrio oBarrio = new Barrio();

        public FormModificarBarrio()
        {
            InitializeComponent();
        }

        public FormModificarBarrio(int id_barrio)
        {
            InitializeComponent();
            this.id_barrio = id_barrio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBarrios ventana = new FormBarrios();
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
            }
        }
    }
}
