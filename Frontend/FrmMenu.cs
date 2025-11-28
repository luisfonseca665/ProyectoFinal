using ProyectoFinal.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Frontend
{
    /// <summary>
    /// Representa el formulario principal del menú de la aplicación.
    /// </summary>
    public partial class FrmMenu : Form
    {
        private Empleado _empleadoActual;
        private Form factivo = null;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FrmMenu"/>.
        /// </summary>
        /// <param name="empleado"></param>
        public FrmMenu(Empleado empleado)
        {
            InitializeComponent();
            pnlApp.AutoScroll = true;
            _empleadoActual = empleado;
            byte[] fotoBytes = _empleadoActual.Foto;

            if (fotoBytes != null && fotoBytes.Length > 0)
            {
                try
                {
                 
                    using (MemoryStream ms = new MemoryStream(fotoBytes))
                    {
                        pcbUsuario.Image = Image.FromStream(ms);
                        pcbUsuario.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la foto: " + ex.Message, "Error de Imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
            }
            if (_empleadoActual.Tipo.ToLower() == "cajero")
            {
                btnEmpleados.Visible = false;
                btnAuditorias.Visible = false;
            }
        }

        /// <summary>
        /// Pantalla activa dentro del panel principal.
        /// </summary>
        /// <param name="activo"></param>
        private void FormPanel(Form activo)
        {
            if (factivo != null)
            {
                factivo.Close();
                factivo.Dispose();

            }
            factivo = activo;
            activo.TopLevel = false;
            activo.FormBorderStyle = FormBorderStyle.None;

            activo.Dock = DockStyle.Fill;

            pnlApp.Controls.Clear();
            pnlApp.Controls.Add(activo);

            activo.BringToFront();
            activo.Show();
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            string usuario = _empleadoActual.Usuario;
            lblusuario.Text = usuario;

            if (_empleadoActual.Tipo.ToLower() == "cajero")
            {
                btnEmpleados.Visible = false;
                btnAuditorias.Visible = false;
            }
        }
        /// <summary>
        /// Boton para abrir el formulario de ventas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnTienda_Click(object sender, EventArgs e)
        {
            FormPanel(new FrmVentas());
        }

        private void pnlApp_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Boton para cerrar sesion y volver al formulario de login.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que deseas cerrar sesion?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
                FrmLogin loginForm = new FrmLogin();
                loginForm.Show();
            }
        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Boton para abrir el formulario de empleados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            FormPanel(new FrmEmpleados());
        }


        /// <summary>
        /// Boton para abrir el formulario de productos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormPanel(new FrmProductos());
        }


        /// <summary>
        /// Boton para abrir el formulario de auditorias.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAuditorias_Click(object sender, EventArgs e)
        {
            FormPanel(new FrmAuditoria());
        }


        /// <summary>
        /// Boton para abrir el formulario de usuarios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormPanel(new FrmEmpleados());
        }


        /// <summary>
        /// Boton para abrir el formulario de reportes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormPanel(new FrmReportes());
        }

        private void pcbUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
