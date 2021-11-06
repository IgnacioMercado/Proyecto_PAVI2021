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
        public FormAltaCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, nro_doc, tipo_doc, telefono, calle, altura;
            string fechaAlta = DateTime.Now.ToString("dd/MM/yyyy");
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            telefono = txtTelefono.Text;
            tipo_doc = txtTipoDoc.Text;
            nro_doc = txtNroDoc.Text;
            calle = txtCalle.Text;
            altura = txtAltura.Text;

            if (nombre == "" || apellido == "" || telefono == "" || nro_doc == "" || tipo_doc == "" || calle == "" || altura == "")
            {
                MessageBox.Show("Por favor, complete todos los campos antes de intentar registrar al cliente");
            }
            else
            {
                oCliente.RegistrarCliente(nombre, apellido, telefono, tipo_doc, nro_doc, calle, altura, fechaAlta);
                MessageBox.Show("Cliente registrado");
                this.Close();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();       
        }
    }
}
