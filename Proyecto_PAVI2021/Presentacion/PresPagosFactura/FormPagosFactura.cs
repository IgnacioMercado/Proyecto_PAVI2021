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

namespace ProyectoAutopartes.Presentacion.PresPagosFactura
{
    public partial class FormPagosFactura : Form
    {
        FormaDePagoService oFormaPagoService = new FormaDePagoService();
        public FormPagosFactura()
        {
            InitializeComponent();
        }

        private void FormPagosFactura_Load(object sender, EventArgs e)
        {
            this.CargarCombo(cmbFP, oFormaPagoService.RecuperarTodos(), 1, 0);
        }

        private void CargarCombo(ComboBox combo, DataTable tabla, int display, int value)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[display].ColumnName;
            combo.ValueMember = tabla.Columns[value].ColumnName;
            combo.SelectedIndex = -1;
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
