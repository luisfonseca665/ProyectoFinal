using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Backend;

namespace ProyectoFinal.Frontend
{
    /// <summary>
    /// Representa el formulario de inicio de sesión.
    /// </summary>
    public partial class FrmLogin : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FrmLogin"/>.
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Ayuda a iniciar sesión en la aplicación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EmpleadoController consulta = new EmpleadoController();
            Empleado empleadoLogueado = consulta.Login(txtUsuario.Text.Trim(), txtPassword.Text.Trim());

            if (empleadoLogueado != null && empleadoLogueado.Id > 0)
            {
                Sesion.UsuarioActual = txtUsuario.Text.Trim();

                MessageBox.Show($"Bienvenido, {empleadoLogueado.Nombre} ({empleadoLogueado.Tipo}).", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                using (FrmMenu menu = new FrmMenu(empleadoLogueado))
                {
                    if (menu.ShowDialog() == DialogResult.OK)
                    {
                        this.Show();
                        txtPassword.Clear();
                        txtUsuario.Clear();
                        txtUsuario.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Verifique sus credenciales e intente de nuevo.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        /// <summary>
        /// Etiqueta para registrar un nuevo usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblRegistro_Click(object sender, EventArgs e)
        {
            FrmRegistroNU registro = new FrmRegistroNU();
            registro.Show();
            this.Hide();
            registro.FormClosed += (s, args) => this.Show();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}