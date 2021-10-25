using Proyecto_PAVI2021.Negocio;
using Proyecto_PAVI2021.Presentacion.PresClientes;
using Proyecto_PAVI2021.Presentacion.PresProveedores;
using ProyectoAutopartes.Negocio;
using ProyectoAutopartes.Presentacion.PresFactura;
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
    public partial class FormProveedores : Form
    {
        public int Id_Cliente_Seleccionado = -1;
        public int Id_Proveedor_Seleccionado = -1;
        private string modo;       
        Cliente oCliente = new Cliente();
        Proveedor oProveedor = new Proveedor();
        Barrio oBarrio = new Barrio();
        Localidad oLocalidad = new Localidad();
        public FormProveedores(string modo)
        {
            InitializeComponent();
            this.modo = modo;
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            this.CargarGrilla(dgvProveedores, oProveedor.RecuperarTodos());
            this.CargarCombo(cboBarrio, oBarrio.RecuperarTodos());
            this.CargarCombo(cboLocalidad, oLocalidad.RecuperarTodos());

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

        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["Id_Proveedor"],
                    tabla.Rows[i]["Nombre"],
                    tabla.Rows[i]["Telefono"],
                    tabla.Rows[i]["CUIT"],
                    tabla.Rows[i]["Calle"],
                    tabla.Rows[i]["Nro_Calle"],
                    tabla.Rows[i]["Id_Barrio"],
                    tabla.Rows[i]["Id_Localidad"]);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, telefono, nro_doc, tipo_doc, calle, altura;
            nombre = apellido = telefono = nro_doc = tipo_doc = calle = altura = string.Empty;
            if (txtNombre.Text != "")
                nombre = txtNombre.Text;
            
            if (txtTelefono.Text != "")
                telefono = txtTelefono.Text;
            if (txtCuit.Text != "")
                tipo_doc = txtCuit.Text;
            
            if (txtCalle.Text != "")
                calle = txtCalle.Text;
            if (txtAltura.Text != "")
                altura = txtAltura.Text;

            this.CargarGrilla(dgvProveedores, oCliente.RecuperarFiltrados(nombre, apellido, telefono, tipo_doc, nro_doc, calle, altura));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar este Proveedor?.", "Confirmación de baja de Proveedor", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                oProveedor.BorrarProveedor((int)dgvProveedores.CurrentRow.Cells[0].Value);
                MessageBox.Show("Proveedor eliminado");
            }
            
            this.CargarGrilla(dgvProveedores, oProveedor.RecuperarTodos());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //FormModificarCliente fmc = new FormModificarCliente((int)dgvProveedores.CurrentRow.Cells[0].Value);
            FormModificarProveedor fmp = new FormModificarProveedor((int)dgvProveedores.CurrentRow.Cells[0].Value);
            fmp.ShowDialog();
            this.CargarGrilla(dgvProveedores, oProveedor.RecuperarTodos());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //FormAltaCliente fac = new FormAltaCliente();
            //fac.ShowDialog();
            this.CargarGrilla(dgvProveedores, oProveedor.RecuperarTodos());
            FormAltaProveedor fap = new FormAltaProveedor();
            fap.ShowDialog();
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
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
            Id_Proveedor_Seleccionado = (int)dgvProveedores.CurrentRow.Cells[0].Value;
            this.Close();            
        }
    }
}
