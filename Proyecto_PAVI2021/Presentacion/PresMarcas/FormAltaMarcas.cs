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

namespace Proyecto_PAVI2021.Presentacion.PresMarcas
{
    public partial class FormAltaMarcas : Form
    {
        MarcaService oMarca = new MarcaService();
        public FormAltaMarcas()
        {
            InitializeComponent();
        }

        private void FormAltaMarcas_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string descripcion;
            descripcion = txtNombre.Text.ToString();
            if (descripcion == "")
            {
                MessageBox.Show("Por favor, complete el campo antes de intentar modificar la marca");
            }
            else
            {
                oMarca.RegistrarMarca(descripcion);
                MessageBox.Show("Marca registrada");
                this.Close();
            }
        }
    }
}
