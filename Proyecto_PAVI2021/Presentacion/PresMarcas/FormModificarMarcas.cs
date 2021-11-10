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
    public partial class FormModificarMarcas : Form
    {
        private int id_marca;
        MarcaService oMarca = new MarcaService();
        public FormModificarMarcas()
        {
            InitializeComponent();
        }
        public FormModificarMarcas(int id_marca)
        {
            InitializeComponent();
            this.id_marca = id_marca;
        }

        private void FormModificarMarcas_Load(object sender, EventArgs e)
        {
            this.CargarDatosPrevios();
        }

        private void btnModificar1_Click(object sender, EventArgs e)
        {
            string descripcion;
            descripcion = txtNombre.Text.ToString();
            if (descripcion == "")
            {
                MessageBox.Show("Por favor, complete el campo antes de intentar modificar la marca");
            }
            else
            {
                oMarca.ModificarMarcaPorId(id_marca, descripcion);
                MessageBox.Show("Marca modificada");
                this.Close();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatosPrevios()
        {
            DataTable tabla = oMarca.RecuperarMarcaPorId(id_marca);
            txtNombre.Text = tabla.Rows[0]["Descripcion"].ToString();

        }
    }
}
