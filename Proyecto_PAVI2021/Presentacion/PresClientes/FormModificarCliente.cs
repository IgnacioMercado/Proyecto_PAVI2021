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

namespace Proyecto_PAVI2021.Presentacion.PresClientes
{
    public partial class FormModificarCliente : Form
    {
        private int id_cliente;

        ClienteService oCliente = new ClienteService();
        BarrioService oBarrio = new BarrioService();
        LocalidadService oLocalidad = new LocalidadService();

        public FormModificarCliente()
        {
            InitializeComponent();
        }
        public FormModificarCliente(int id_cliente)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;


        }

        private void LlenarComboConLista(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.SelectedIndex = -1;
        }

        private void FormModificarCliente_Load(object sender, EventArgs e)
        {
            LlenarCampos();
        }

        private void LlenarCampos()
        {
            DataTable tabla = new DataTable();
            tabla = oCliente.RecuperarClientePorId(id_cliente);
            txtNombre.Text = tabla.Rows[0]["Nombre"].ToString();
            txtApellido.Text = tabla.Rows[0]["Apellido"].ToString();
            txtTelefono.Text = tabla.Rows[0]["Telefono"].ToString();
            txtTipoDoc.Text = tabla.Rows[0]["Tipo_Doc"].ToString();
            txtNroDoc.Text = tabla.Rows[0]["Nro_Doc"].ToString();
            txtCalle.Text = tabla.Rows[0]["Calle"].ToString();
            txtAltura.Text = tabla.Rows[0]["Nro_Calle"].ToString();
            this.LlenarComboConLista(cmbLocalidades, oLocalidad.RecuperarTodos(), "Descripcion", "Id_Localidad");
            this.LlenarComboConLista(cmbBarrios, oBarrio.RecuperarPorLocalidad(Convert.ToInt32(tabla.Rows[0]["Id_Barrio"].ToString())), "Descripcion", "Id_Barrio");
            this.cmbBarrios.SelectedValue = tabla.Rows[0]["Id_Barrio"].ToString();
            this.cmbLocalidades.SelectedValue = tabla.Rows[0]["Id_Localidad"].ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, nro_doc, tipo_doc, telefono, calle, altura, id_barrio;
            nombre = apellido = nro_doc = tipo_doc = telefono = calle = altura = id_barrio = string.Empty;
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            telefono = txtTelefono.Text;
            tipo_doc = txtTipoDoc.Text;
            nro_doc = txtNroDoc.Text;
            calle = txtCalle.Text;
            altura = txtAltura.Text;
            if(cmbBarrios.SelectedIndex != -1)
            {
                id_barrio = cmbBarrios.SelectedValue.ToString();
            }

            if (nombre == "" || apellido == "" || telefono == "" || nro_doc == "" || tipo_doc == "" || calle == "" || altura == "" || cmbBarrios.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de intentar modificar al cliente");
            }
            else
            {
                oCliente.ModificarClientePorId(id_cliente, nombre, apellido, telefono, tipo_doc, nro_doc, calle, altura, id_barrio);
                MessageBox.Show("Cliente modificado");
                this.Close();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbLocalidades_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbBarrios.SelectedIndex = -1;
            this.LlenarComboConLista(cmbBarrios, oBarrio.RecuperarPorLocalidad((int)cmbLocalidades.SelectedValue), "Descripcion", "Id_Barrio");
        }
    }
}
