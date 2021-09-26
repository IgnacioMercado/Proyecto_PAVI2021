using Proyecto_PAVI2021.Negocio;
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
        Cliente oCliente = new Cliente();

        public FormModificarCliente()
        {
            InitializeComponent();
        }
        public FormModificarCliente(int id_cliente)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
        }


        private void FormModificarCliente_Load(object sender, EventArgs e)
        {
            LlenarCampos();
        }

        private void LlenarCampos()
        {
            DataTable tabla = new DataTable();
            Cliente oClienteSeleccionado = new Cliente();
            tabla = oClienteSeleccionado.RecuperarClientePorId(id_cliente);
            txtNombre.Text = tabla.Rows[0]["Nombre"].ToString();
            txtApellido.Text = tabla.Rows[0]["Apellido"].ToString();
            txtTelefono.Text = tabla.Rows[0]["Telefono"].ToString();
            txtTipoDoc.Text = tabla.Rows[0]["Tipo_Doc"].ToString();
            txtNroDoc.Text = tabla.Rows[0]["Nro_Doc"].ToString();
            txtCalle.Text = tabla.Rows[0]["Calle"].ToString();
            txtAltura.Text = tabla.Rows[0]["Nro_Calle"].ToString();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, nro_doc, tipo_doc, telefono, calle, altura;
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            telefono = txtTelefono.Text;
            tipo_doc = txtTipoDoc.Text;
            nro_doc = txtNroDoc.Text;
            calle = txtCalle.Text;
            altura = txtAltura.Text;
            if (nombre == "" || apellido == "" || telefono == "" || nro_doc == "" || tipo_doc == "" || calle == "" || altura == "")
            {
                MessageBox.Show("Por favor, complete todos los campos antes de intentar modificar al cliente");
            }
            else
            {
                oCliente.ModificarClientePorId(id_cliente, nombre, apellido, telefono, tipo_doc, nro_doc, calle, altura);
                MessageBox.Show("Cliente modificado con exito");
            }

        }

        private void btnModificar1_Click(object sender, EventArgs e)
        {
            string nombre, apellido, nro_doc, tipo_doc, telefono, calle, altura;
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            telefono = txtTelefono.Text;
            tipo_doc = txtTipoDoc.Text;
            nro_doc = txtNroDoc.Text;
            calle = txtCalle.Text;
            altura = txtAltura.Text;
            if (nombre == "" || apellido == "" || telefono == "" || nro_doc == "" || tipo_doc == "" || calle == "" || altura == "")
            {
                MessageBox.Show("Por favor, complete todos los campos antes de intentar modificar al cliente");
            }
            else
            {
                oCliente.ModificarClientePorId(id_cliente, nombre, apellido, telefono, tipo_doc, nro_doc, calle, altura);
                MessageBox.Show("Cliente modificado con exito");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ventana = new Form1("");
        }
    }
}
