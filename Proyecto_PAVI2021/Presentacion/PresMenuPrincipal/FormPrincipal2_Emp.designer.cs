
namespace Proyecto_PAVI2021.Presentacion.PresPrincipal
{
    partial class FormPrincipal2_Emp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal2_Emp));
            this.panelMenú = new System.Windows.Forms.Panel();
            this.panelProduccion = new System.Windows.Forms.Panel();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnMateriales = new System.Windows.Forms.Button();
            this.btnLotes = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.paneldatos = new System.Windows.Forms.Panel();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenú.SuspendLayout();
            this.panelProduccion.SuspendLayout();
            this.paneldatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenú
            // 
            this.panelMenú.AutoScroll = true;
            this.panelMenú.BackColor = System.Drawing.Color.LightSalmon;
            this.panelMenú.Controls.Add(this.panelProduccion);
            this.panelMenú.Controls.Add(this.btnProd);
            this.panelMenú.Controls.Add(this.paneldatos);
            this.panelMenú.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenú.Location = new System.Drawing.Point(0, 0);
            this.panelMenú.Name = "panelMenú";
            this.panelMenú.Size = new System.Drawing.Size(200, 599);
            this.panelMenú.TabIndex = 0;
            // 
            // panelProduccion
            // 
            this.panelProduccion.BackColor = System.Drawing.Color.Sienna;
            this.panelProduccion.Controls.Add(this.btnCompras);
            this.panelProduccion.Controls.Add(this.btnMarcas);
            this.panelProduccion.Controls.Add(this.btnMateriales);
            this.panelProduccion.Controls.Add(this.btnLotes);
            this.panelProduccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProduccion.Location = new System.Drawing.Point(0, 94);
            this.panelProduccion.Name = "panelProduccion";
            this.panelProduccion.Size = new System.Drawing.Size(200, 150);
            this.panelProduccion.TabIndex = 6;
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.BurlyWood;
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.Crimson;
            this.btnCompras.Location = new System.Drawing.Point(0, 99);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(200, 33);
            this.btnCompras.TabIndex = 4;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.Color.BurlyWood;
            this.btnMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.ForeColor = System.Drawing.Color.Crimson;
            this.btnMarcas.Location = new System.Drawing.Point(0, 66);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(200, 33);
            this.btnMarcas.TabIndex = 3;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcas.UseVisualStyleBackColor = false;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnMateriales
            // 
            this.btnMateriales.BackColor = System.Drawing.Color.BurlyWood;
            this.btnMateriales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMateriales.ForeColor = System.Drawing.Color.Crimson;
            this.btnMateriales.Location = new System.Drawing.Point(0, 33);
            this.btnMateriales.Name = "btnMateriales";
            this.btnMateriales.Size = new System.Drawing.Size(200, 33);
            this.btnMateriales.TabIndex = 2;
            this.btnMateriales.Text = "Materiales";
            this.btnMateriales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMateriales.UseVisualStyleBackColor = false;
            this.btnMateriales.Click += new System.EventHandler(this.btnMateriales_Click);
            // 
            // btnLotes
            // 
            this.btnLotes.BackColor = System.Drawing.Color.BurlyWood;
            this.btnLotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLotes.ForeColor = System.Drawing.Color.Crimson;
            this.btnLotes.Location = new System.Drawing.Point(0, 0);
            this.btnLotes.Name = "btnLotes";
            this.btnLotes.Size = new System.Drawing.Size(200, 33);
            this.btnLotes.TabIndex = 1;
            this.btnLotes.Text = "Lotes";
            this.btnLotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLotes.UseVisualStyleBackColor = false;
            this.btnLotes.Click += new System.EventHandler(this.btnLotes_Click);
            // 
            // btnProd
            // 
            this.btnProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProd.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnProd.FlatAppearance.BorderSize = 3;
            this.btnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProd.ForeColor = System.Drawing.Color.Maroon;
            this.btnProd.Location = new System.Drawing.Point(0, 60);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(200, 34);
            this.btnProd.TabIndex = 5;
            this.btnProd.Text = "Producción";
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // paneldatos
            // 
            this.paneldatos.Controls.Add(this.labelNombreUsuario);
            this.paneldatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneldatos.Location = new System.Drawing.Point(0, 0);
            this.paneldatos.Name = "paneldatos";
            this.paneldatos.Size = new System.Drawing.Size(200, 60);
            this.paneldatos.TabIndex = 1;
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.Location = new System.Drawing.Point(12, 21);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(138, 20);
            this.labelNombreUsuario.TabIndex = 0;
            this.labelNombreUsuario.Text = "Nombre Usuario";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(900, 535);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 33);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Proyecto_PAVI2021.Properties.Resources.fondo_1;
            this.pictureBox1.Location = new System.Drawing.Point(-223, -201);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1522, 947);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal2_Emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 599);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panelMenú);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal2_Emp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.FormPrincipal2_Load);
            this.panelMenú.ResumeLayout(false);
            this.panelProduccion.ResumeLayout(false);
            this.paneldatos.ResumeLayout(false);
            this.paneldatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenú;
        private System.Windows.Forms.Panel paneldatos;
        private System.Windows.Forms.Panel panelProduccion;
        private System.Windows.Forms.Button btnMateriales;
        private System.Windows.Forms.Button btnLotes;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNombreUsuario;
    }
}