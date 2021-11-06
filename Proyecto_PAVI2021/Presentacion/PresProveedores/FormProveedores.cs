using Proyecto_PAVI2021.Negocio;
using Proyecto_PAVI2021.Presentacion.PresClientes;
using Proyecto_PAVI2021.Presentacion.PresProveedores;
using Proyecto_PAVI2021.Presentacion.PresFactura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PAVI2021.Servicios;

namespace Proyecto_PAVI2021.Presentacion.PresProveedores
{    
    public partial class FormProveedores : Form
    {
        public int Id_Cliente_Seleccionado = -1;
        public int Id_Proveedor_Seleccionado = -1;
        private string modo;       
        Cliente oCliente = new Cliente();
        ProveedorService oProveedor = new ProveedorService();
        BarrioService oBarrio = new BarrioService();
        LocalidadService oLocalidad = new LocalidadService();
        public FormProveedores(string modo)
        {
            InitializeComponent();
            this.modo = modo;
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            this.CargarGrilla(dgvProveedores, oProveedor.RecuperarTodos());
            this.LlenarComboConLista(cboLocalidad, oLocalidad.RecuperarTodos(), "Descripcion", "Id_Localidad");

            if (this.modo == "seleccionar")
            {
                this.Text = "Seleccionar Proveedor";
                this.btnSeleccionar.Show();
                this.lblSeleccionar.Show();
            }
        }

        private void LlenarComboConLista(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.SelectedIndex = -1;
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
                    tabla.Rows[i]["DescripcionB"],
                    tabla.Rows[i]["DescripcionL"]);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, telefono, cuit, calle, altura, id_barrio, id_localidad;
            nombre = telefono = cuit = calle = altura = id_barrio = id_localidad = string.Empty;
            if (txtNombre.Text != "")
                nombre = txtNombre.Text;
            
            if (txtTelefono.Text != "")
                telefono = txtTelefono.Text;
            if (txtCuit.Text != "")
                cuit = txtCuit.Text;
            
            if (txtCalle.Text != "")
                calle = txtCalle.Text;
            if (txtAltura.Text != "")
                altura = txtAltura.Text;
            if (cboLocalidad.SelectedIndex != -1)
                id_localidad = cboLocalidad.SelectedValue.ToString();
            if (cboBarrio.SelectedIndex != -1)
                id_barrio = cboBarrio.SelectedValue.ToString();

            

            this.CargarGrilla(dgvProveedores, oProveedor.RecuperarFiltrados(nombre, telefono, cuit, calle, altura, id_barrio, id_localidad));
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

        private void cboLocalidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.LlenarComboConLista(cboBarrio, oBarrio.RecuperarPorLocalidad((int)cboLocalidad.SelectedValue), "Descripcion", "Id_Barrio");
        }
    }
}
