using Proyecto_PAVI2021.Negocio;
using Proyecto_PAVI2021.Presentacion.PresClientes;
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
    public partial class FormClientes : Form
    {
        Cliente oCliente = new Cliente();
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            this.CargarGrilla(dgvClientes, oCliente.RecuperarTodos());
        }

        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["Id_Cliente"],
                    tabla.Rows[i]["Nombre"],
                    tabla.Rows[i]["Apellido"],
                    tabla.Rows[i]["Telefono"],
                    tabla.Rows[i]["Tipo_Doc"],
                    tabla.Rows[i]["Nro_Doc"],
                    tabla.Rows[i]["Calle"],
                    tabla.Rows[i]["Nro_Calle"]);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, telefono, nro_doc, tipo_doc, calle, altura;
            nombre = apellido = telefono = nro_doc = tipo_doc = calle = altura = string.Empty;
            if (txtNombre.Text != "")
                nombre = txtNombre.Text;
            if (txtApellido.Text != "")
                apellido = txtApellido.Text;
            if (txtTelefono.Text != "")
                telefono = txtTelefono.Text;
            if (txtTipoDoc.Text != "")
                tipo_doc = txtTipoDoc.Text;
            if (txtNroDoc.Text != "")
                nro_doc = txtNroDoc.Text;
            if (txtCalle.Text != "")
                calle = txtCalle.Text;
            if (txtAltura.Text != "")
                altura = txtAltura.Text;

            this.CargarGrilla(dgvClientes, oCliente.RecuperarFiltrados(nombre, apellido, telefono, tipo_doc, nro_doc, calle, altura));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar este cliente?.", "Confirmación de baja de cliente", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                oCliente.BorrarCliente((int)dgvClientes.CurrentRow.Cells[0].Value);
                MessageBox.Show("Cliente eliminado");
            }
            
            this.CargarGrilla(dgvClientes, oCliente.RecuperarTodos());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificarCliente fmc = new FormModificarCliente((int)dgvClientes.CurrentRow.Cells[0].Value);

            fmc.ShowDialog();
            this.CargarGrilla(dgvClientes, oCliente.RecuperarTodos());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAltaCliente fac = new FormAltaCliente();
            fac.ShowDialog();
            this.CargarGrilla(dgvClientes, oCliente.RecuperarTodos());
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
