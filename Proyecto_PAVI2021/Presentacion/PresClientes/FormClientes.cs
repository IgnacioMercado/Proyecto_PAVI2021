using Proyecto_PAVI2021.Negocio;
using Proyecto_PAVI2021.Presentacion.PresClientes;
using Proyecto_PAVI2021.Presentacion.PresFactura;
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
    public partial class FormClientes : Form
    {
        public int Id_Cliente_Seleccionado = -1;
        private string modo;
        ClienteService oCliente = new ClienteService();
        BarrioService oBarrio = new BarrioService();
        LocalidadService oLocalidad = new LocalidadService();

        public FormClientes(string modo)
        {
            InitializeComponent();
            this.modo = modo;
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            this.CargarGrilla(dgvClientes, oCliente.RecuperarTodos());
            this.LlenarComboConLista(cmbLocalidades, oLocalidad.RecuperarTodos(), "Descripcion", "Id_Localidad");
            

            if (this.modo == "seleccionar")
            {
                this.Text = "Seleccionar Cliente";
                this.btnSeleccionar.Show();
                this.lblSeleccionar.Show();
            }
        }

        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void LlenarComboConLista(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.SelectedIndex = -1;
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
                    tabla.Rows[i]["Nro_Calle"],
                    tabla.Rows[i]["Barrio"],
                    tabla.Rows[i]["Localidad"]);

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, telefono, nro_doc, tipo_doc, calle, altura, barrio, localidad;
            nombre = apellido = telefono = nro_doc = tipo_doc = calle = altura = barrio = localidad = string.Empty;
            if (txtNombre.Text != "")
                nombre = txtNombre.Text;
            if (txtApellido.Text != "")
                apellido = txtApellido.Text;
            if (txtTelefono.Text != "")
                telefono = txtTelefono.Text;
            if (txtNroDoc.Text != "")
                nro_doc = txtNroDoc.Text;
            if (txtCalle.Text != "")
                calle = txtCalle.Text;
            if (txtAltura.Text != "")
                altura = txtAltura.Text;
            if (cboTipoDoc.SelectedIndex != -1)
                tipo_doc = cboTipoDoc.Text;
            if (cmbBarrios.SelectedIndex != -1)
                barrio = cmbBarrios.SelectedValue.ToString();
            if (cmbLocalidades.SelectedIndex != -1)
                localidad = cmbLocalidades.SelectedValue.ToString();


            this.CargarGrilla(dgvClientes, oCliente.RecuperarFiltrados(nombre, apellido, telefono, tipo_doc, nro_doc, calle, altura, barrio, localidad));
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
            dgvClientes.Refresh();
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Id_Cliente_Seleccionado = (int)dgvClientes.CurrentRow.Cells[0].Value;
            this.Close();            
        }

        private void cmbLocalidades_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbBarrios.SelectedIndex = -1;
            this.LlenarComboConLista(cmbBarrios, oBarrio.RecuperarPorLocalidad((int)cmbLocalidades.SelectedValue), "Descripcion", "Id_Barrio");
        }
    }
}
