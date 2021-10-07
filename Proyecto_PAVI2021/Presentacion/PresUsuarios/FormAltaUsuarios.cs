using Proyecto_PAVI2021.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PAVI2021.Presentacion
{
    public partial class FormAltaUsuarios : Form
    {
        Usuario oUsuario = new Usuario();
        Perfil oPerfil = new Perfil();
        public FormAltaUsuarios()
        {
            InitializeComponent();
        }

        private void FormAltaUsuarios_Load(object sender, EventArgs e)
        {
            this.CargarCombo(cmbPerfil, oPerfil.RecuperarTodos());
        }
        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre, contraseña, rol;

            string fechaAlta = DateTime.Now.ToString("dd/MM/yyyy");
            nombre = txtUsuario.Text.ToString();
            contraseña = txtContraseña.Text.ToString();
            rol = cmbPerfil.SelectedValue.ToString();
            //fecha corregida
            if(nombre == "" || contraseña == "" || rol == "")
            {
                MessageBox.Show("Por favor, complete todos los campos antes de intentar registrar al usuario");
            }
            else
            {
                oUsuario.RegistrarUsuario(nombre, contraseña, fechaAlta, rol);
                MessageBox.Show("Usuario registrado");
                this.Close();
                
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
