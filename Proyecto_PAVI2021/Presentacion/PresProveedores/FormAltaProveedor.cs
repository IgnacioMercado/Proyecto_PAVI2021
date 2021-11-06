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

namespace Proyecto_PAVI2021.Presentacion.PresProveedores
{
    public partial class FormAltaProveedor : Form

    {
        BarrioService oBarrio = new BarrioService();
        LocalidadService oLocalidad = new LocalidadService();
        ProveedorService oProv = new ProveedorService();

        public FormAltaProveedor()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre, telefono, cuit, calle, altura;
            int id_barrio, id_localidad;
            //string fechaAlta = DateTime.Now.ToString("dd/MM/yyyy");

            nombre = txtNombre.Text;
            telefono = txtTelefono.Text;
            cuit = txtCuit.Text;
            calle = txtCalle.Text;
            altura = txtAltura.Text;
            id_barrio = (int)cmbBarrio.SelectedValue;
            id_localidad = (int)cmbLocalidad.SelectedValue;

            if (nombre == "" || telefono == "" || cuit == "" || calle == "" || altura == "" || id_barrio == -1 || id_localidad == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de intentar registrar al Proveedor");
            }
            else
            {
                
                this.Close();
                oProv.RegistrarProveedor(nombre, telefono, cuit, calle, altura, id_barrio, id_localidad);
                MessageBox.Show("Proveedor registrado");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();       
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormAltaProveedor_Load(object sender, EventArgs e)
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

        private void cboBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboBarrio_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cboLocalidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cmbLocalidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            this.LlenarComboConLista(cmbBarrio, oBarrio.RecuperarPorLocalidad(Convert.ToInt32(cmbLocalidad.SelectedValue)), "Descripcion", "Id_Barrio");
        }
    }
}
