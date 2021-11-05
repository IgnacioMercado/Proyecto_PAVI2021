
namespace Proyecto_PAVI2021.Reportes
{
    partial class FormReporteVentasXE
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtVentasXEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetGeneral = new Proyecto_PAVI2021.Reportes.DataSetGeneral();
            this.dtVentasXClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvVentasXE = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaAltaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaAltaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentasXEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentasXClienteBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtVentasXEmpleadoBindingSource
            // 
            this.dtVentasXEmpleadoBindingSource.DataMember = "dtVentasXEmpleado";
            this.dtVentasXEmpleadoBindingSource.DataSource = this.DataSetGeneral;
            // 
            // DataSetGeneral
            // 
            this.DataSetGeneral.DataSetName = "DataSetGeneral";
            this.DataSetGeneral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtVentasXClienteBindingSource
            // 
            this.dtVentasXClienteBindingSource.DataMember = "dtVentasXCliente";
            this.dtVentasXClienteBindingSource.DataSource = this.DataSetGeneral;
            // 
            // rvVentasXE
            // 
            reportDataSource1.Name = "DataSetVentasXEmpleado";
            reportDataSource1.Value = this.dtVentasXEmpleadoBindingSource;
            this.rvVentasXE.LocalReport.DataSources.Add(reportDataSource1);
            this.rvVentasXE.LocalReport.ReportEmbeddedResource = "Proyecto_PAVI2021.Reportes.ReporteVentaXEmpleado.rdlc";
            this.rvVentasXE.Location = new System.Drawing.Point(9, 141);
            this.rvVentasXE.Margin = new System.Windows.Forms.Padding(2);
            this.rvVentasXE.Name = "rvVentasXE";
            this.rvVentasXE.ServerReport.BearerToken = null;
            this.rvVentasXE.Size = new System.Drawing.Size(741, 408);
            this.rvVentasXE.TabIndex = 0;
            this.rvVentasXE.Load += new System.EventHandler(this.rvVentasXE_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpFechaAltaHasta);
            this.groupBox1.Controls.Add(this.dtpFechaAltaDesde);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(740, 61);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleado";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(457, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "y";
            this.label6.Visible = false;
            // 
            // dtpFechaAltaHasta
            // 
            this.dtpFechaAltaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAltaHasta.Location = new System.Drawing.Point(484, 33);
            this.dtpFechaAltaHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaAltaHasta.Name = "dtpFechaAltaHasta";
            this.dtpFechaAltaHasta.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaAltaHasta.TabIndex = 39;
            this.dtpFechaAltaHasta.Visible = false;
            // 
            // dtpFechaAltaDesde
            // 
            this.dtpFechaAltaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAltaDesde.Location = new System.Drawing.Point(341, 33);
            this.dtpFechaAltaDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaAltaDesde.Name = "dtpFechaAltaDesde";
            this.dtpFechaAltaDesde.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaAltaDesde.TabIndex = 38;
            this.dtpFechaAltaDesde.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(58, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(103, 20);
            this.txtNombre.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Fecha de Alta Entre";
            this.label4.Visible = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(202, 33);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(103, 20);
            this.txtApellido.TabIndex = 27;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLimpiar.Location = new System.Drawing.Point(577, 15);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(73, 37);
            this.btnLimpiar.TabIndex = 38;
            this.btnLimpiar.Text = "Limpiar Filtros";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnGenerar.Location = new System.Drawing.Point(656, 15);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(73, 37);
            this.btnGenerar.TabIndex = 37;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.dtpFechaHasta);
            this.groupBox2.Controls.Add(this.btnGenerar);
            this.groupBox2.Controls.Add(this.dtpFechaDesde);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(9, 76);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(740, 61);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Factura";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(202, 33);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaHasta.TabIndex = 37;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(58, 33);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaDesde.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Fecha Desde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Fecha Hasta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(679, 615);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 57;
            this.label7.Text = "Volver Atrás";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAtras.ForeColor = System.Drawing.Color.Black;
            this.btnAtras.Image = global::Proyecto_PAVI2021.Properties.Resources.volver_atras;
            this.btnAtras.Location = new System.Drawing.Point(686, 555);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(52, 57);
            this.btnAtras.TabIndex = 56;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FormReporteVentasXE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(758, 634);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rvVentasXE);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReporteVentasXE";
            this.Text = "Reporte de Ventas por Empleado";
            this.Load += new System.EventHandler(this.FormReporteVentasXE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtVentasXEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentasXClienteBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvVentasXE;
        private System.Windows.Forms.BindingSource dtVentasXClienteBindingSource;
        private DataSetGeneral DataSetGeneral;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaAltaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaAltaHasta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.BindingSource dtVentasXEmpleadoBindingSource;
    }
}