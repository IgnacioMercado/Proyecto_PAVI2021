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
    public partial class FormAltaBarrio : Form
    {
        Barrio oBarrio = new Barrio();
        public FormAltaBarrio()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string descripcion;
            descripcion = txtNombre.Text;

            if (descripcion == "")
            {
                MessageBox.Show("Por favor, complete todos los campos antes registrar el barrio");
            }
            else
            {
                oBarrio.RegistrarBarrio(descripcion);
                MessageBox.Show("Barrio registrado");
                this.Close();
            }
        }        
    }
}
