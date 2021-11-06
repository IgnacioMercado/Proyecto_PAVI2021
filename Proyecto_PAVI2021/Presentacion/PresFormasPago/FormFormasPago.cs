using Proyecto_PAVI2021.Negocio;
using Proyecto_PAVI2021.Presentacion.PresClientes;
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

namespace Proyecto_PAVI2021.Presentacion.PresFormasPago
{
    public partial class FormFormasPago : Form
    {
        FormaDePagoService oFormaPago = new FormaDePagoService();
        bool nuevo = false;
        public FormFormasPago()
        {
            InitializeComponent();
        }

        private void FormFormasPago_Load(object sender, EventArgs e)
        {
            this.CargarGrilla(dgvFormasPago, oFormaPago.RecuperarTodos());
            this.habilitar(false);
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;
        }

        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["Id_Forma_Pago"],
                                tabla.Rows[i]["Descripcion"]);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar esta forma de pago?.", "Eliminar forma de pago",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                oFormaPago.EliminarFormaPago((int)dgvFormasPago.CurrentRow.Cells[0].Value);
                MessageBox.Show("Forma de pago eliminada", "Eliminar forma de pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.CargarGrilla(dgvFormasPago, oFormaPago.RecuperarTodos());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.habilitar(true);
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.txtFormaPago.Focus();            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.habilitar(true);
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.txtFormaPago.Clear();
            this.txtFormaPago.Focus();
            nuevo = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (this.txtFormaPago.Text == "")
            {
                MessageBox.Show("Debe ingresar una Forma de Pago", "Registrar/Modificar Forma de Pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFormaPago.Focus();
            }
            else
            {
                if (nuevo)
                {
                    oFormaPago.RegistrarFormaPago(this.txtFormaPago.Text);
                    MessageBox.Show("Forma de Pago registrada", "Registrar Forma de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nuevo = false;                    
                }
                else
                {
                    oFormaPago.ModificarFormaPago(this.txtFormaPago.Text, (int)this.dgvFormasPago.CurrentRow.Cells[0].Value);
                    MessageBox.Show("Forma de Pago modificada", "Modificar Forma de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                this.CargarGrilla(dgvFormasPago, oFormaPago.RecuperarTodos());
                this.habilitar(false);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CargarGrilla(dgvFormasPago, oFormaPago.RecuperarTodos());
            this.habilitar(false);            
            nuevo = false;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvFormasPago_SelectionChanged(object sender, EventArgs e)
        {
            txtFormaPago.Text = dgvFormasPago.CurrentRow.Cells[1].Value.ToString();            
        }

        private void dgvFormasPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnModificar.Enabled = true;
            this.btnEliminar.Enabled = true;
        }

        private void habilitar(bool x)
        {            
            this.btnConfirmar.Enabled = x;
            this.btnCancelar.Enabled = x;
            this.txtFormaPago.Enabled = x;
        }
    }
}
