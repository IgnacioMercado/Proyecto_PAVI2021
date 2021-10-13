﻿using Proyecto_PAVI2021.Negocio;
using Proyecto_PAVI2021.Presentacion;
using ProyectoAutopartes.Negocio;
using ProyectoAutopartes.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAutopartes.Presentacion.PresFactura
{
    public partial class FormAltaFactura : Form
    {
        public int Id_Cliente_Seleccionado;
        public int Legajo_Empleado_Seleccionado;
        private List<string> TiposFactura = new List<string> { "A", "B", "C" };
        Cliente oClienteSeleccionado = new Cliente();
        private readonly MaterialService materialService;
        private readonly ClienteService clienteService;
        private readonly BindingList<DetalleFactura> listaDetalleFactura;
        private readonly FacturaService facturaService;
        private readonly LoteService loteService;
        private readonly PersonalService personalService;

        public FormAltaFactura()
        {
            InitializeComponent();
            materialService = new MaterialService();
            clienteService = new ClienteService();
            listaDetalleFactura = new BindingList<DetalleFactura>();
            facturaService = new FacturaService();
            loteService = new LoteService();
            personalService = new PersonalService();
            dgvDetalle.AutoGenerateColumns = false;
        }

        private void FormAltaFactura_Load(object sender, EventArgs e)
        {
            InicializarFormulario();

            this.txtFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");            
            cboTipoFactura.DataSource = TiposFactura;            
            cboTipoFactura.SelectedIndex = -1;
            this.LlenarComboConLista(cmbArticulo, materialService.GetAll(), "Nombre", "Id_material");
            this.cmbArticulo.SelectedIndexChanged += new System.EventHandler(this.cmbArticulo_SelectedIndexChanged);
            dgvDetalle.DataSource = listaDetalleFactura;

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
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            FormClientes fcs = new FormClientes("seleccionar");
            fcs.ShowDialog();
            this.Id_Cliente_Seleccionado = fcs.Id_Cliente_Seleccionado;
            
            if (this.Id_Cliente_Seleccionado != -1)
                this.CargarCliente();
        }




        private void CargarCliente()
        {
            DataTable tabla = new DataTable();
            Cliente oClienteSeleccionado = new Cliente();
            tabla = oClienteSeleccionado.RecuperarClientePorId(Id_Cliente_Seleccionado);
            this.txtNombre.Text = tabla.Rows[0]["Nombre"].ToString();
            this.txtApellido.Text = tabla.Rows[0]["Apellido"].ToString();
            this.txtTipoDoc.Text = tabla.Rows[0]["Tipo_Doc"].ToString();
            this.txtNroDoc.Text = tabla.Rows[0]["Nro_Doc"].ToString();
            this.txtCalle.Text = tabla.Rows[0]["Calle"].ToString();
            this.txtAltura.Text = tabla.Rows[0]["Nro_Calle"].ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            int.TryParse(txtCantidad.Text, out cantidad);

            if (cantidad == 0)
            {
                MessageBox.Show("Ingrese una cantidad mayor a 0");
            }
            else
            {
                var material = (Material)cmbArticulo.SelectedItem;
                var oLote = (Lote)cmbLote.SelectedItem;
                if (cantidad > oLote.Stock_lote)
                {
                    MessageBox.Show("No hay suficiente stock de ese material en este lote \nEl stock actual en el lote " + oLote.Id_lote + " es de " + oLote.Stock_lote + " unidades\nEl stock de " + material.Nombre + " sumando todos sus lotes es de " + material.Stock + " unidades", "Problema de stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    listaDetalleFactura.Add(new DetalleFactura()
                    {
                        Material = material,
                        Cantidad = cantidad,
                        Id_lote = oLote.Id_lote
                    });

                    InicializarDetalle();
                }
                
            }
            

            //CalcularTotales();

            //InicializarDetalle();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

                if (dgvDetalle.CurrentRow != null)
                {
                    var detalleSeleccionado = (DetalleFactura)dgvDetalle.CurrentRow.DataBoundItem;
                    listaDetalleFactura.Remove(detalleSeleccionado);
                }

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboTipoFactura.SelectedIndex == -1 || txtNombre.Text == "" || txtNombreEmpleado.Text == "")
                {
                    MessageBox.Show("Por favor, ingrese los datos necesarios. \nRecuerde que todos los campos son obligatorios", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    var factura = new FacturaVenta
                    {
                        Fecha = dtpFecha.Value,
                        Id_Cliente = Id_Cliente_Seleccionado,
                        TipoFactura = cboTipoFactura.SelectedItem.ToString(),
                        DetalleFactura = listaDetalleFactura,
                        Legajo_Empleado = Legajo_Empleado_Seleccionado

                    };



                    if (facturaService.ValidarDatos(factura))
                    {
                        facturaService.Crear(factura);

                        MessageBox.Show(string.Concat("La factura nro: ", factura.IdFactura, " se generó correctamente."), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        InicializarFormulario();

                    }
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la factura! " + ex.Message + ex.StackTrace, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cmbArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbArticulo.SelectedItem != null )
            {
                this.LlenarComboConLista(cmbLote, loteService.GetConfirmedFilteredByMaterial(Convert.ToInt32(cmbArticulo.SelectedValue.ToString())), "Id_lote", "Id_lote");
            }
            
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarEmpleado_Click(object sender, EventArgs e)
        {
            FormPersonal fps = new FormPersonal("seleccionar");
            fps.ShowDialog();
            this.Legajo_Empleado_Seleccionado = fps.Legajo_Empleado_Seleccionado;
            CargarEmpleado();
        }

        private void CargarEmpleado()
        {
            DataTable tabla = new DataTable();
            Personal oEmpleadoSeleccionado = new Personal();
            tabla = personalService.RecuperarPersonalPorLegajo(Legajo_Empleado_Seleccionado);
            this.txtNombreEmpleado.Text = tabla.Rows[0]["Nombre"].ToString();
            this.txtApellidoEmpleado.Text = tabla.Rows[0]["Apellido"].ToString();
            this.txtLegajoEmpleado.Text = tabla.Rows[0]["Legajo"].ToString();
        }

        private void InicializarFormulario()
        {
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtTipoDoc.Text = "";
            this.txtNroDoc.Text = "";
            this.txtCalle.Text = "";
            this.txtAltura.Text = "";
            this.txtNombreEmpleado.Text = "";
            this.txtLegajoEmpleado.Text = "";
            this.txtApellidoEmpleado.Text = "";
            cboTipoFactura.SelectedIndex = -1;
            InicializarDetalle();

        }

        private void InicializarDetalle()
        {
            cmbArticulo.SelectedIndex = -1;
            cmbLote.SelectedIndex = -1;
            txtCantidad.Text = "";
        }
    }
}
