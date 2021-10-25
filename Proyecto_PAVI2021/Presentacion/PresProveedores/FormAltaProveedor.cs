using Proyecto_PAVI2021.Negocio;
using ProyectoAutopartes.Negocio;
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
        Barrio oBarrio = new Barrio();
        Localidad oLocalidad = new Localidad();
        Cliente oCliente = new Cliente();
        Proveedor oProv = new Proveedor();

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
            id_barrio = (int)cboBarrio.SelectedValue;
            id_localidad = (int)cboLocalidad.SelectedValue;

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
            this.CargarCombo(cboBarrio, oBarrio.RecuperarTodos());
            this.CargarCombo(cboLocalidad, oLocalidad.RecuperarTodos());

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
