﻿
namespace Proyecto_PAVI2021.Presentacion.PresLotes
{
    partial class FormLotes
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
            this.label10 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbConfirmado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbArticulo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLotes = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirmacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.cmbMarca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpHasta);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpDesde);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbConfirmado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbEmpleado);
            this.panel1.Controls.Add(this.cmbArticulo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvLotes);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 379);
            this.panel1.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(213, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 15);
            this.label10.TabIndex = 95;
            this.label10.Text = "Confirmar Lote";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Image = global::Proyecto_PAVI2021.Properties.Resources.tick_2;
            this.btnConfirmar.Location = new System.Drawing.Point(218, 298);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(66, 59);
            this.btnConfirmar.TabIndex = 94;
            this.btnConfirmar.Text = "7";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(110, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 15);
            this.label9.TabIndex = 93;
            this.label9.Text = "Registrar Lote";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = global::Proyecto_PAVI2021.Properties.Resources._326501_add_circle_icon__2_;
            this.btnAgregar.Location = new System.Drawing.Point(115, 298);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(66, 59);
            this.btnAgregar.TabIndex = 92;
            this.btnAgregar.Text = "6";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(742, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 91;
            this.label7.Text = "Volver Atrás";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.LightBlue;
            this.btnAtras.ForeColor = System.Drawing.Color.Black;
            this.btnAtras.Image = global::Proyecto_PAVI2021.Properties.Resources.volver_atras;
            this.btnAtras.Location = new System.Drawing.Point(743, 298);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(63, 59);
            this.btnAtras.TabIndex = 90;
            this.btnAtras.Text = "8";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 89;
            this.label8.Text = "Consultar";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnConsultar.Image = global::Proyecto_PAVI2021.Properties.Resources._4801315_glass_magnifier_magnifying_search_searching_icon__1_;
            this.btnConsultar.Location = new System.Drawing.Point(12, 298);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(66, 59);
            this.btnConsultar.TabIndex = 88;
            this.btnConsultar.Text = "5";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(51, 65);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca.TabIndex = 1;
            this.cmbMarca.SelectionChangeCommitted += new System.EventHandler(this.cmbMarca_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Marca *";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(278, 17);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(103, 20);
            this.dtpHasta.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "Fecha hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(83, 17);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(103, 20);
            this.dtpDesde.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Fecha desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Confirmacion *";
            // 
            // cmbConfirmado
            // 
            this.cmbConfirmado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfirmado.FormattingEnabled = true;
            this.cmbConfirmado.Items.AddRange(new object[] {
            "Confirmado",
            "Sin confirmar"});
            this.cmbConfirmado.Location = new System.Drawing.Point(686, 65);
            this.cmbConfirmado.Name = "cmbConfirmado";
            this.cmbConfirmado.Size = new System.Drawing.Size(121, 21);
            this.cmbConfirmado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Empleado *";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(474, 65);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpleado.TabIndex = 3;
            // 
            // cmbArticulo
            // 
            this.cmbArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArticulo.FormattingEnabled = true;
            this.cmbArticulo.Location = new System.Drawing.Point(262, 65);
            this.cmbArticulo.Name = "cmbArticulo";
            this.cmbArticulo.Size = new System.Drawing.Size(121, 21);
            this.cmbArticulo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Articulo *";
            // 
            // dgvLotes
            // 
            this.dgvLotes.AllowUserToAddRows = false;
            this.dgvLotes.AllowUserToDeleteRows = false;
            this.dgvLotes.AllowUserToResizeColumns = false;
            this.dgvLotes.AllowUserToResizeRows = false;
            this.dgvLotes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colEmpleado,
            this.colArticulo,
            this.colMarca,
            this.colCantidad,
            this.colFecha,
            this.colConfirmacion});
            this.dgvLotes.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvLotes.Location = new System.Drawing.Point(11, 112);
            this.dgvLotes.Name = "dgvLotes";
            this.dgvLotes.ReadOnly = true;
            this.dgvLotes.RowHeadersVisible = false;
            this.dgvLotes.RowHeadersWidth = 51;
            this.dgvLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLotes.Size = new System.Drawing.Size(795, 180);
            this.dgvLotes.TabIndex = 0;
            this.dgvLotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLotes_CellClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id_lote";
            this.colId.HeaderText = "Lote";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // 
            // colEmpleado
            // 
            this.colEmpleado.HeaderText = "Empleado";
            this.colEmpleado.MinimumWidth = 6;
            this.colEmpleado.Name = "colEmpleado";
            this.colEmpleado.ReadOnly = true;
            this.colEmpleado.Width = 150;
            // 
            // colArticulo
            // 
            this.colArticulo.HeaderText = "Articulo";
            this.colArticulo.MinimumWidth = 6;
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.ReadOnly = true;
            this.colArticulo.Width = 160;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.MinimumWidth = 6;
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            this.colMarca.Width = 120;
            // 
            // colCantidad
            // 
            this.colCantidad.DataPropertyName = "Stock_lote";
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 70;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha creacion";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 120;
            // 
            // colConfirmacion
            // 
            this.colConfirmacion.HeaderText = "Confirmación";
            this.colConfirmacion.MinimumWidth = 6;
            this.colConfirmacion.Name = "colConfirmacion";
            this.colConfirmacion.ReadOnly = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(19, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(54, 20);
            this.lblTitulo.TabIndex = 78;
            this.lblTitulo.Text = "Lotes";
            // 
            // FormLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(840, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormLotes";
            this.Text = "Lotes";
            this.Load += new System.EventHandler(this.FormLotes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLotes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbConfirmado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbArticulo;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmacion;
    }
}