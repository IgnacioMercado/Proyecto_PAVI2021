using Proyecto_PAVI2021.Negocio;
using Proyecto_PAVI2021.Presentacion;
using Proyecto_PAVI2021.Presentacion.PresProveedores;
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

namespace Proyecto_PAVI2021.Presentacion.PresCompras
{
    public partial class FormCompras : Form
    {
        public int Id_Cliente_Seleccionado;
        public int Id_Proveedor_Seleccionado;
        public int Legajo_Empleado_Seleccionado;
        public int Nro_Factura;
        
        private List<string> TiposFactura = new List<string> { "A", "B", "C" };
        ClienteService oClienteSeleccionado = new ClienteService();
        ProveedorService oProveedorSeleccionado = new ProveedorService();
        LocalidadService oLocalidad = new LocalidadService();
        BarrioService oBarrio = new BarrioService();
        private readonly MaterialService materialService;
        private readonly ClienteService clienteService;
        private readonly BindingList<DetalleFactura> listaDetalleFactura;
        private readonly FacturaService facturaService;
        private readonly LoteService loteService;
        private readonly PersonalService personalService;
        private readonly MarcaService marcaService;

        public FormCompras()
        {
            InitializeComponent();
            materialService = new MaterialService();
            clienteService = new ClienteService();
            listaDetalleFactura = new BindingList<DetalleFactura>();
            facturaService = new FacturaService();
            loteService = new LoteService();
            personalService = new PersonalService();
            marcaService = new MarcaService();
            dgvDetalle.AutoGenerateColumns = false;
        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            InicializarFormulario();

            this.txtFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");            
            cboTipoFactura.DataSource = TiposFactura;            
            cboTipoFactura.SelectedIndex = -1;
            LlenarComboConLista(cmbMarca, marcaService.RecuperarTodos(), "Descripcion", "Id_Marca");
            this.cmbArticulo.SelectedIndexChanged += new System.EventHandler(this.cmbArticulo_SelectedIndexChanged);
            dgvDetalle.DataSource = listaDetalleFactura;
            CargarCombo(cboLocalidad, oLocalidad.RecuperarTodos());
            CargarCombo(cboBarrio, oBarrio.RecuperarTodos());

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

        private void CargarProveedor()
        {
            if(Id_Proveedor_Seleccionado != -1)
            {
                DataTable tabla = new DataTable();


                tabla = oProveedorSeleccionado.RecuperarProveedorPorId(Id_Proveedor_Seleccionado);
                this.txtNombre.Text = tabla.Rows[0]["Nombre"].ToString();
                this.txtTelefono.Text = tabla.Rows[0]["Telefono"].ToString();
                this.txtCUIT.Text = tabla.Rows[0]["CUIT"].ToString();
                this.txtCalle.Text = tabla.Rows[0]["Calle"].ToString();
                this.txtNro_Calle.Text = tabla.Rows[0]["Nro_Calle"].ToString();
                this.cboBarrio.SelectedValue = tabla.Rows[0]["Id_Barrio"].ToString();
                this.cboLocalidad.SelectedValue = tabla.Rows[0]["Id_Localidad"].ToString();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            int cantidad = 0;
            int.TryParse(txtCantidad.Text, out cantidad);
            bool resultado = int.TryParse(txtNroFactura2.Text, out int nroF);

            if (cantidad == 0)
            {
                MessageBox.Show("Ingrese una cantidad mayor a 0");
            }
            else
            {
                if(resultado == true)
                {
                    Nro_Factura = int.Parse(txtNroFactura2.Text);
                    var material = (Material)cmbArticulo.SelectedItem;
                    string nroFactura = txtNroFactura.Text;
                    string legajo = txtLegajoEmpleado.Text;


                    if (listaDetalleFactura.Count == 0)
                    {

                        listaDetalleFactura.Add(new DetalleFactura()
                        {
                            Material = material,
                            Cantidad = cantidad
                        });
                    }
                    else
                    {
                        int index = listaDetalleFactura.IndexOf(listaDetalleFactura.Where(df => df.id_material == material.Id_material).FirstOrDefault());
                        if (index != -1)
                        {
                            listaDetalleFactura[index].Cantidad += cantidad;
                            dgvDetalle.Refresh();

                        }
                        else
                        {
                            listaDetalleFactura.Add(new DetalleFactura()
                            {
                                Material = material,
                                Cantidad = cantidad
                            });
                        }
                    }

                
                }
                else
                {
                    MessageBox.Show("Ingrese un numero de factura valido", "Error numero de factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };






                InicializarDetalle();
                
                
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
                if (cboTipoFactura.SelectedIndex == -1 || txtNombre.Text == "" || txtNombreEmpleado.Text == "" || txtNroFactura.Text =="" || txtNroFactura2.Text == "")
                {
                    MessageBox.Show("Por favor, ingrese los datos necesarios. \nRecuerde que todos los campos son obligatorios", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    var facturaCompra = new FacturaCompra
                    {
                        Fecha = dtpFecha.Value,
                        //FALTA EL NUMERO DE FACTURA
                        //NroFactura = int.Parse(txtNroFactura.Text),
                        NroFactura = int.Parse(txtNroFactura2.Text),
                        Id_Proveedor = Id_Proveedor_Seleccionado,
                        TipoFactura = cboTipoFactura.SelectedItem.ToString(),
                        DetalleFactura = listaDetalleFactura,
                        Legajo_Empleado = Legajo_Empleado_Seleccionado

                    };



                    if (facturaService.ValidarDatos(facturaCompra))
                    {
                        facturaService.Crear(facturaCompra);

                        MessageBox.Show(string.Concat("La factura nro: ", facturaCompra.IdFactura, " se registró correctamente."), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            if(Legajo_Empleado_Seleccionado != -1)
            {
                DataTable tabla = new DataTable();
                Personal oEmpleadoSeleccionado = new Personal();
                tabla = personalService.RecuperarPersonalPorLegajo(Legajo_Empleado_Seleccionado);
                this.txtNombreEmpleado.Text = tabla.Rows[0]["Nombre"].ToString();
                this.txtApellidoEmpleado.Text = tabla.Rows[0]["Apellido"].ToString();
                this.txtLegajoEmpleado.Text = tabla.Rows[0]["Legajo"].ToString();
            }

        }

        private void InicializarFormulario()
        {
            this.txtNombre.Text = "";
            this.txtTelefono.Text = "";
            this.txtCUIT.Text = "";
            //this.txtIdBarrio.Text = "";
            this.txtCalle.Text = "";
            this.txtNro_Calle.Text = "";
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        private void cmbMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbArticulo.SelectedIndex = -1;
            this.LlenarComboConLista(cmbArticulo, materialService.GetAllByMarcaId((int)cmbMarca.SelectedValue), "Nombre", "Id_material");
        }

        private void btnSeleccionarProveedor_Click(object sender, EventArgs e)
        {
            FormProveedores fpv = new FormProveedores("seleccionar");
            fpv.ShowDialog();
            this.Id_Proveedor_Seleccionado = fpv.Id_Proveedor_Seleccionado;
            CargarProveedor();
        }
    }
}
