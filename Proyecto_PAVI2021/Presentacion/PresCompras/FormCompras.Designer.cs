﻿
namespace Proyecto_PAVI2021.Presentacion.PresCompras
{
    partial class FormCompras
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoFactura = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnSeleccionarProveedor = new System.Windows.Forms.Button();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNro_Calle = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboLocalidad = new System.Windows.Forms.ComboBox();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNroFactura = new System.Windows.Forms.GroupBox();
            this.txtNroFactura2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.cmbArticulo = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.colIdMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.btnSeleccionarEmpleado = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLegajoEmpleado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblGrabar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.txtNroFactura.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Factura:";
            // 
            // cboTipoFactura
            // 
            this.cboTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFactura.FormattingEnabled = true;
            this.cboTipoFactura.Location = new System.Drawing.Point(97, 17);
            this.cboTipoFactura.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoFactura.Name = "cboTipoFactura";
            this.cboTipoFactura.Size = new System.Drawing.Size(92, 21);
            this.cboTipoFactura.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(62, 20);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(92, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // btnSeleccionarProveedor
            // 
            this.btnSeleccionarProveedor.Location = new System.Drawing.Point(691, 15);
            this.btnSeleccionarProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionarProveedor.Name = "btnSeleccionarProveedor";
            this.btnSeleccionarProveedor.Size = new System.Drawing.Size(142, 26);
            this.btnSeleccionarProveedor.TabIndex = 4;
            this.btnSeleccionarProveedor.Text = "Seleccionar Proveedor";
            this.btnSeleccionarProveedor.UseVisualStyleBackColor = true;
            this.btnSeleccionarProveedor.Click += new System.EventHandler(this.btnSeleccionarProveedor_Click);
            // 
            // txtCUIT
            // 
            this.txtCUIT.Enabled = false;
            this.txtCUIT.Location = new System.Drawing.Point(379, 17);
            this.txtCUIT.Margin = new System.Windows.Forms.Padding(2);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(92, 20);
            this.txtCUIT.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CUIT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Barrio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Calle:";
            // 
            // txtCalle
            // 
            this.txtCalle.Enabled = false;
            this.txtCalle.Location = new System.Drawing.Point(62, 56);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(2);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(92, 20);
            this.txtCalle.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Altura:";
            // 
            // txtNro_Calle
            // 
            this.txtNro_Calle.Enabled = false;
            this.txtNro_Calle.Location = new System.Drawing.Point(238, 56);
            this.txtNro_Calle.Margin = new System.Windows.Forms.Padding(2);
            this.txtNro_Calle.Name = "txtNro_Calle";
            this.txtNro_Calle.Size = new System.Drawing.Size(92, 20);
            this.txtNro_Calle.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(238, 20);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(92, 20);
            this.txtTelefono.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefono:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboLocalidad);
            this.groupBox1.Controls.Add(this.cboBarrio);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.btnSeleccionarProveedor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNro_Calle);
            this.groupBox1.Controls.Add(this.txtCUIT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCalle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(8, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(845, 89);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedor";
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Location = new System.Drawing.Point(595, 55);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(121, 21);
            this.cboLocalidad.TabIndex = 18;
            // 
            // cboBarrio
            // 
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(379, 56);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(121, 21);
            this.cboBarrio.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(537, 63);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "Localidad";
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtNroFactura.Controls.Add(this.txtNroFactura2);
            this.txtNroFactura.Controls.Add(this.label11);
            this.txtNroFactura.Controls.Add(this.dtpFecha);
            this.txtNroFactura.Controls.Add(this.txtFecha);
            this.txtNroFactura.Controls.Add(this.label8);
            this.txtNroFactura.Controls.Add(this.cboTipoFactura);
            this.txtNroFactura.Controls.Add(this.label1);
            this.txtNroFactura.Location = new System.Drawing.Point(8, 5);
            this.txtNroFactura.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Padding = new System.Windows.Forms.Padding(2);
            this.txtNroFactura.Size = new System.Drawing.Size(845, 51);
            this.txtNroFactura.TabIndex = 16;
            this.txtNroFactura.TabStop = false;
            this.txtNroFactura.Text = "Factura";
            // 
            // txtNroFactura2
            // 
            this.txtNroFactura2.Location = new System.Drawing.Point(475, 17);
            this.txtNroFactura2.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroFactura2.Name = "txtNroFactura2";
            this.txtNroFactura2.Size = new System.Drawing.Size(92, 20);
            this.txtNroFactura2.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(405, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Nro Factura:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(281, 18);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(109, 20);
            this.dtpFecha.TabIndex = 20;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(741, 20);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(92, 20);
            this.txtFecha.TabIndex = 19;
            this.txtFecha.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Fecha:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.cmbMarca);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Controls.Add(this.lblArticulo);
            this.groupBox3.Controls.Add(this.cmbArticulo);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.dgvDetalle);
            this.groupBox3.Location = new System.Drawing.Point(8, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(845, 327);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(22, 28);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "Marca";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(69, 23);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(85, 21);
            this.cmbMarca.TabIndex = 21;
            this.cmbMarca.SelectionChangeCommitted += new System.EventHandler(this.cmbMarca_SelectionChangeCommitted);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(688, 25);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Borrar articulo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(562, 25);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Agregar articulo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Cantidad";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(455, 22);
            this.txtCantidad.Mask = "99999";
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(35, 20);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.ValidatingType = typeof(int);
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(186, 26);
            this.lblArticulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(42, 13);
            this.lblArticulo.TabIndex = 4;
            this.lblArticulo.Text = "Articulo";
            // 
            // cmbArticulo
            // 
            this.cmbArticulo.FormattingEnabled = true;
            this.cmbArticulo.Location = new System.Drawing.Point(238, 23);
            this.cmbArticulo.Name = "cmbArticulo";
            this.cmbArticulo.Size = new System.Drawing.Size(121, 21);
            this.cmbArticulo.TabIndex = 3;
            this.cmbArticulo.SelectedIndexChanged += new System.EventHandler(this.cmbArticulo_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::Proyecto_PAVI2021.Properties.Resources.equis_3;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(654, 16);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(30, 32);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::Proyecto_PAVI2021.Properties.Resources.agregar_2;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(528, 15);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(30, 32);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AllowUserToResizeColumns = false;
            this.dgvDetalle.AllowUserToResizeRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdMaterial,
            this.colNombre,
            this.colPrecio,
            this.colCantidad,
            this.colImporte});
            this.dgvDetalle.GridColor = System.Drawing.Color.PeachPuff;
            this.dgvDetalle.Location = new System.Drawing.Point(28, 67);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.RowTemplate.Height = 24;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(783, 224);
            this.dgvDetalle.TabIndex = 0;
            // 
            // colIdMaterial
            // 
            this.colIdMaterial.DataPropertyName = "Id_material";
            this.colIdMaterial.HeaderText = "#Material";
            this.colIdMaterial.Name = "colIdMaterial";
            this.colIdMaterial.ReadOnly = true;
            this.colIdMaterial.Width = 60;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "MaterialDescripcion";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 320;
            // 
            // colPrecio
            // 
            this.colPrecio.DataPropertyName = "PrecioUnitario";
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.DataPropertyName = "Cantidad";
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colImporte
            // 
            this.colImporte.DataPropertyName = "Importe";
            this.colImporte.HeaderText = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.txtNroFactura);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(9, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 221);
            this.panel1.TabIndex = 65;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtApellidoEmpleado);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtNombreEmpleado);
            this.groupBox4.Controls.Add(this.btnSeleccionarEmpleado);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtLegajoEmpleado);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(8, 153);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(845, 53);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Empleado a cargo";
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.Enabled = false;
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(238, 20);
            this.txtApellidoEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(92, 20);
            this.txtApellidoEmpleado.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Nombre:";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Enabled = false;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(62, 20);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(92, 20);
            this.txtNombreEmpleado.TabIndex = 3;
            // 
            // btnSeleccionarEmpleado
            // 
            this.btnSeleccionarEmpleado.Location = new System.Drawing.Point(528, 17);
            this.btnSeleccionarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionarEmpleado.Name = "btnSeleccionarEmpleado";
            this.btnSeleccionarEmpleado.Size = new System.Drawing.Size(129, 26);
            this.btnSeleccionarEmpleado.TabIndex = 4;
            this.btnSeleccionarEmpleado.Text = "Seleccionar Empleado";
            this.btnSeleccionarEmpleado.UseVisualStyleBackColor = true;
            this.btnSeleccionarEmpleado.Click += new System.EventHandler(this.btnSeleccionarEmpleado_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(188, 22);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Apellido:";
            // 
            // txtLegajoEmpleado
            // 
            this.txtLegajoEmpleado.Enabled = false;
            this.txtLegajoEmpleado.Location = new System.Drawing.Point(384, 21);
            this.txtLegajoEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtLegajoEmpleado.Name = "txtLegajoEmpleado";
            this.txtLegajoEmpleado.Size = new System.Drawing.Size(92, 20);
            this.txtLegajoEmpleado.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(341, 22);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Legajo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(9, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 346);
            this.panel2.TabIndex = 66;
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackgroundImage = global::Proyecto_PAVI2021.Properties.Resources.guardar;
            this.btnGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGrabar.Location = new System.Drawing.Point(734, 607);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(45, 49);
            this.btnGrabar.TabIndex = 67;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = global::Proyecto_PAVI2021.Properties.Resources.volver_atras;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.Location = new System.Drawing.Point(808, 607);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(45, 49);
            this.btnAtras.TabIndex = 68;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblGrabar
            // 
            this.lblGrabar.AutoSize = true;
            this.lblGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrabar.Location = new System.Drawing.Point(734, 658);
            this.lblGrabar.Name = "lblGrabar";
            this.lblGrabar.Size = new System.Drawing.Size(45, 15);
            this.lblGrabar.TabIndex = 70;
            this.lblGrabar.Text = "Grabar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(802, 658);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 69;
            this.label9.Text = "Volver Atrás";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label17.Location = new System.Drawing.Point(14, 235);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(301, 17);
            this.label17.TabIndex = 11;
            this.label17.Text = "Aclaración: Todos los campos son obligatorios";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::Proyecto_PAVI2021.Properties.Resources._216169_delete_icon__1_;
            this.btnLimpiar.Location = new System.Drawing.Point(36, 607);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(45, 49);
            this.btnLimpiar.TabIndex = 71;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 658);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 15);
            this.label18.TabIndex = 72;
            this.label18.Text = "Limpiar Campos";
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(884, 680);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblGrabar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de compra";
            this.Load += new System.EventHandler(this.FormCompras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.txtNroFactura.ResumeLayout(false);
            this.txtNroFactura.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnSeleccionarProveedor;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNro_Calle;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox txtNroFactura;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblGrabar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.ComboBox cmbArticulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtCantidad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Button btnSeleccionarEmpleado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLegajoEmpleado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboLocalidad;
        private System.Windows.Forms.ComboBox cboBarrio;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNroFactura2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbMarca;
    }
}