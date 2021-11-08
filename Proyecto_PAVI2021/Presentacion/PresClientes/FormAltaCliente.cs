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

namespace Proyecto_PAVI2021.Presentacion
{
    public partial class FormAltaCliente : Form

    {
        ClienteService oCliente = new ClienteService();
        LocalidadService oLocalidad = new LocalidadService();
        BarrioService oBarrio = new BarrioService();
        public FormAltaCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, nro_doc, tipo_doc, telefono, calle, altura, barrio;
            nombre = apellido = nro_doc = tipo_doc = telefono = calle = altura = barrio = string.Empty;
            string fechaAlta = DateTime.Now.ToString("dd/MM/yyyy");
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            telefono = txtTelefono.Text;
            tipo_doc = cboTipoDoc.Text;
            nro_doc = txtNroDoc.Text;
            calle = txtCalle.Text;
            altura = txtAltura.Text;
            if (cmbBarrios.SelectedIndex != -1)
                barrio = cmbBarrios.SelectedValue.ToString();

            if (nombre == "" || apellido == "" || telefono == "" || nro_doc == "" || tipo_doc == "" || calle == "" || altura == "" || barrio == "")
            {
                MessageBox.Show("Por favor, complete todos los campos antes de intentar registrar al cliente");
            }
            else
            {
                oCliente.RegistrarCliente(nombre, apellido, telefono, tipo_doc, nro_doc, calle, altura, fechaAlta, barrio);
                MessageBox.Show("Cliente registrado");
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();       
        }

        private void FormAltaCliente_Load(object sender, EventArgs e)
        {
            this.LlenarComboConLista(cmbLocalidades, oLocalidad.RecuperarTodos(), "Descripcion", "Id_Localidad");
        }

        private void txtTipoDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbLocalidades_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbBarrios.SelectedIndex = -1;
            this.LlenarComboConLista(cmbBarrios, oBarrio.RecuperarPorLocalidad((int)cmbLocalidades.SelectedValue), "Descripcion", "Id_Barrio");
        }
    }
}
