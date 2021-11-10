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
        LocalidadService oLocalidad = new LocalidadService();

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
            if (descripcion == "" || cmbLocalidad.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete el campo antes de intentar modificar el barrio");
            }
            else
            {
                oBarrio.ModificarBarrioPorId(id_barrio, descripcion, cmbLocalidad.SelectedValue.ToString());
                MessageBox.Show("Barrio modificado");
                this.Close();
            }
        }
        private void LlenarComboConLista(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.SelectedIndex = -1;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CargarComboDatosPrevios()
        {
            DataTable tabla = oBarrio.RecuperarBarrioPorId(id_barrio);
            cmbLocalidad.SelectedValue = tabla.Rows[0]["Id_Localidad"].ToString();
            txtNombre.Text = tabla.Rows[0]["Descripcion"].ToString();
        }

        private void FormModificarBarrio_Load(object sender, EventArgs e)
        {
            this.LlenarComboConLista(cmbLocalidad, oLocalidad.RecuperarTodos(), "Descripcion", "Id_Localidad");
            this.CargarComboDatosPrevios();
        }
    }
}
