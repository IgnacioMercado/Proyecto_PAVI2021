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
    public partial class FormMarcas : Form
    {
        MarcaService oMarca = new MarcaService();
        public FormMarcas()
        {
            InitializeComponent();
        }

        private void FormMarcas_Load(object sender, EventArgs e)
        {
            this.CargarGrilla(dgvMarcas, oMarca.RecuperarTodos());
        }

        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["Id_Marca"],
                    tabla.Rows[i]["Descripcion"]);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar esta marca?.", "Confirmación de baja de marca", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                oMarca.EliminarMarca((int)dgvMarcas.CurrentRow.Cells[0].Value);
                MessageBox.Show("Marca eliminada");
            }

            this.CargarGrilla(dgvMarcas, oMarca.RecuperarTodos());
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string descripcion;
            descripcion = string.Empty;
            if (txtNombre.Text != "")
                descripcion = txtNombre.Text;
            this.CargarGrilla(dgvMarcas, oMarca.RecuperarFiltrados(descripcion));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAltaMarcas fam = new FormAltaMarcas();
            fam.ShowDialog();
            this.CargarGrilla(dgvMarcas, oMarca.RecuperarTodos());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificarMarcas fmm = new FormModificarMarcas((int)dgvMarcas.CurrentRow.Cells[0].Value);

            fmm.ShowDialog();
            this.CargarGrilla(dgvMarcas, oMarca.RecuperarTodos());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
