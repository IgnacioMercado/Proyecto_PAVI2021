
namespace ProyectoAutopartes.Presentacion.PresPagosFactura
{
    partial class FormPagosFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtRestante = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFP = new System.Windows.Forms.Label();
            this.cmbFP = new System.Windows.Forms.ComboBox();
            this.dgvFormasPago = new System.Windows.Forms.DataGridView();
            this.colIdFormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtIngresado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormasPago)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtIngresado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtRestante);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblFP);
            this.panel1.Controls.Add(this.cmbFP);
            this.panel1.Controls.Add(this.dgvFormasPago);
            this.panel1.Location = new System.Drawing.Point(11, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 264);
            this.panel1.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(740, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 17);
            this.label16.TabIndex = 21;
            this.label16.Text = "Quitar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(611, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Agregar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::ProyectoAutopartes.Properties.Resources.equis_3;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(694, 11);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(40, 39);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::ProyectoAutopartes.Properties.Resources.agregar_2;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(565, 11);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(40, 39);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtRestante
            // 
            this.txtRestante.Enabled = false;
            this.txtRestante.Location = new System.Drawing.Point(666, 225);
            this.txtRestante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRestante.Name = "txtRestante";
            this.txtRestante.Size = new System.Drawing.Size(121, 22);
            this.txtRestante.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(547, 228);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 17);
            this.label19.TabIndex = 16;
            this.label19.Text = "Monto Restante";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(396, 19);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(111, 22);
            this.txtMonto.TabIndex = 8;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Monto";
            // 
            // lblFP
            // 
            this.lblFP.AutoSize = true;
            this.lblFP.Location = new System.Drawing.Point(12, 22);
            this.lblFP.Name = "lblFP";
            this.lblFP.Size = new System.Drawing.Size(105, 17);
            this.lblFP.TabIndex = 6;
            this.lblFP.Text = "Forma de Pago";
            // 
            // cmbFP
            // 
            this.cmbFP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFP.FormattingEnabled = true;
            this.cmbFP.Location = new System.Drawing.Point(124, 19);
            this.cmbFP.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFP.Name = "cmbFP";
            this.cmbFP.Size = new System.Drawing.Size(160, 24);
            this.cmbFP.TabIndex = 5;
            // 
            // dgvFormasPago
            // 
            this.dgvFormasPago.AllowUserToAddRows = false;
            this.dgvFormasPago.AllowUserToDeleteRows = false;
            this.dgvFormasPago.AllowUserToResizeColumns = false;
            this.dgvFormasPago.AllowUserToResizeRows = false;
            this.dgvFormasPago.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFormasPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormasPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdFormaPago,
            this.colDescripcion});
            this.dgvFormasPago.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvFormasPago.Location = new System.Drawing.Point(15, 63);
            this.dgvFormasPago.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFormasPago.Name = "dgvFormasPago";
            this.dgvFormasPago.ReadOnly = true;
            this.dgvFormasPago.RowHeadersVisible = false;
            this.dgvFormasPago.RowHeadersWidth = 51;
            this.dgvFormasPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormasPago.Size = new System.Drawing.Size(506, 187);
            this.dgvFormasPago.TabIndex = 0;
            // 
            // colIdFormaPago
            // 
            this.colIdFormaPago.HeaderText = "Forma de Pago";
            this.colIdFormaPago.MinimumWidth = 6;
            this.colIdFormaPago.Name = "colIdFormaPago";
            this.colIdFormaPago.ReadOnly = true;
            this.colIdFormaPago.Width = 250;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Monto";
            this.colDescripcion.MinimumWidth = 6;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            this.colDescripcion.Width = 125;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(6, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(308, 25);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Seleccione las formas de pago";
            // 
            // txtIngresado
            // 
            this.txtIngresado.Enabled = false;
            this.txtIngresado.Location = new System.Drawing.Point(666, 189);
            this.txtIngresado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIngresado.Name = "txtIngresado";
            this.txtIngresado.Size = new System.Drawing.Size(121, 22);
            this.txtIngresado.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Total Ingresado";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(666, 154);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 22);
            this.txtTotal.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Total a pagar";
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.Location = new System.Drawing.Point(749, 385);
            this.lblConfirmar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(74, 18);
            this.lblConfirmar.TabIndex = 74;
            this.lblConfirmar.Text = "Confirmar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(648, 386);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 18);
            this.label9.TabIndex = 73;
            this.label9.Text = "Volver Atrás";
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = global::ProyectoAutopartes.Properties.Resources.volver_atras;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.Location = new System.Drawing.Point(661, 323);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(60, 60);
            this.btnAtras.TabIndex = 72;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackgroundImage = global::ProyectoAutopartes.Properties.Resources.tick_2;
            this.btnContinuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnContinuar.Location = new System.Drawing.Point(756, 323);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(60, 60);
            this.btnContinuar.TabIndex = 71;
            this.btnContinuar.UseVisualStyleBackColor = true;
            // 
            // FormPagosFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(828, 415);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormPagosFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formas de Pago por Factura";
            this.Load += new System.EventHandler(this.FormPagosFactura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormasPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvFormasPago;
        private System.Windows.Forms.Label lblFP;
        private System.Windows.Forms.ComboBox cmbFP;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdFormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.TextBox txtRestante;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIngresado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnContinuar;
    }
}