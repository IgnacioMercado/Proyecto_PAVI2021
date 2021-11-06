using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PAVI2021.Negocio;
using Proyecto_PAVI2021.Servicios;

namespace Proyecto_PAVI2021
{
    public partial class frmLogin : Form
    {
        private Usuario miUsuario = new Usuario();
        private UsuarioService oUsuario = new UsuarioService();
        
        internal Usuario MiUsuario { get => miUsuario; set => miUsuario = value; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnIngresar.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtUsuario.Text)) 
            {
                MessageBox.Show("Debe ingresar un Usuario...");
                this.txtUsuario.Focus();
                return;
            }
            if (this.txtClave.Text==string.Empty)
            {
                MessageBox.Show("Debe ingresar una Contraseña...");
                this.txtClave.Focus();
                return;
            }

            this.miUsuario.Nombre = this.txtUsuario.Text;
            this.miUsuario.Contraseña = this.txtClave.Text;

            this.miUsuario.Id_usuario = this.oUsuario.validarUsuario(miUsuario.Nombre, miUsuario.Contraseña);

            if (miUsuario.Id_usuario != 0)
            {
                //MessageBox.Show("Login OK", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtClave.Text = string.Empty;
                this.txtUsuario.Focus();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            ControlBotones();
        }

        private void ControlBotones()
        {
            //pregunto si el nombre de usuario sin espacios es distinto de vacío y
            // si son todas letras
            if (txtUsuario.Text.Trim() != string.Empty && txtUsuario.Text.All(Char.IsLetter))

            {
                btnIngresar.Enabled = true;
                errorProvider1.SetError(txtUsuario, "");
            }
            else
            {
                if (!(txtUsuario.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(txtUsuario, "el nombre solo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(txtUsuario, "Debe introducir un nombre de usuario");
                }
                btnIngresar.Enabled = false;
                txtUsuario.Focus();
            }
        }
    }
}
