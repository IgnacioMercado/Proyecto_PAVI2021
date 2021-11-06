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
    public partial class FormAltaBarrio : Form
    {
        BarrioService oBarrio = new BarrioService();
        LocalidadService oLocalidad = new LocalidadService();
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

        private void FormAltaBarrio_Load(object sender, EventArgs e)
        {
            this.CargarCombo(cmbLocalidad, oLocalidad.RecuperarTodos());
        }
        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
