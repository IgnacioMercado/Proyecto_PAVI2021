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

namespace Proyecto_PAVI2021.Presentacion.PresPagosFactura
{    
    public partial class FormPagosFactura : Form
    {
        double TotalAPagar, TotalIngresado, MontoRestante = 0;
        FormaDePagoService oFormaPagoService = new FormaDePagoService();
        public BindingList<PagoPorFactura> listaPagosPorFactura = new BindingList<PagoPorFactura>();

        public FormPagosFactura(double total)
        {
            InitializeComponent();
            this.TotalAPagar = total;
            dgvFormasPago.AutoGenerateColumns = false;
        }

        private void FormPagosFactura_Load(object sender, EventArgs e)
        {
            this.CargarCombo(cmbFP, oFormaPagoService.RecuperarTodos(), 1, 0);            
            this.dgvFormasPago.Columns[1].DefaultCellStyle.Format = "C2";
            this.txtTotal.Text = TotalAPagar.ToString("C2");
            this.txtIngresado.Text = TotalIngresado.ToString("C2");
            this.txtRestante.Text = TotalAPagar.ToString("C2");
        }

        private void CargarCombo(ComboBox combo, DataTable tabla, int display, int value)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[display].ColumnName;
            combo.ValueMember = tabla.Columns[value].ColumnName;
            combo.SelectedIndex = -1;
        }     

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double monto = 0;
            double.TryParse(txtMonto.Text, out monto);

            if (this.cmbFP.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una forma de pago");
            }
            else
            {
                if (monto <= 0)
                {
                    MessageBox.Show("Ingrese un monto mayor a 0");
                }
                else
                {
                    listaPagosPorFactura.Add(new PagoPorFactura()
                    {
                        Id_forma_pago = (int)cmbFP.SelectedValue,
                        Monto = monto,
                    });
                    dgvFormasPago.Rows.Add(cmbFP.Text, monto);
                    CalcularTotales(monto);
                    InicializarFormaPago();
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvFormasPago.CurrentRow != null)
            {
                var pagoSeleccionado = (PagoPorFactura)dgvFormasPago.CurrentRow.DataBoundItem;
                listaPagosPorFactura.Remove(pagoSeleccionado);
                this.CalcularTotales(pagoSeleccionado.Monto);
            }            
        }

        private void CalcularTotales(double monto)
        {
            this.TotalIngresado += monto;
            this.MontoRestante = TotalAPagar - TotalIngresado;
            this.txtIngresado.Text = TotalIngresado.ToString("C2");
            this.txtRestante.Text = MontoRestante.ToString("C2");
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir solo ingreso de numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void InicializarFormaPago()
        {
            this.cmbFP.SelectedIndex = -1;
            this.txtMonto.Clear();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (this.dgvFormasPago.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos una forma de pago");
            }
            else
            {
                if (this.txtTotal.Text != this.txtIngresado.Text)
                {
                    MessageBox.Show("El monto Total Ingresado debe ser igual al monto Total a Pagar");
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
