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
            descripcion = string.Empty;
            
            descripcion = txtNombre.Text;

            if (descripcion == "" || cmbLocalidad.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes registrar el barrio");
            }
            else
            {
                oBarrio.RegistrarBarrio(descripcion, cmbLocalidad.SelectedValue.ToString()); ;
                MessageBox.Show("Barrio registrado");
                this.Close();
            }
        }

        private void FormAltaBarrio_Load(object sender, EventArgs e)
        {
            this.LlenarComboConLista(cmbLocalidad, oLocalidad.RecuperarTodos(), "Descripcion", "Id_Localidad");
        }
        private void LlenarComboConLista(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.SelectedIndex = -1;
        }
    }
}
