using ProyectoFinal.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Frontend
{

    /// <summary>
    /// Representa el formulario para editar los detalles de un empleado existente.
    /// </summary>
    public partial class FrmEditarEmpleados : Form
    {
        private int _empleadoId;
        private EmpleadoController controller = new EmpleadoController();
        private byte[] _fotoActual;
        public Action EmpleadoActualizadoCallback { get; set; }


        /// <summary>
        /// Inicializa una nueva instancia de FrmEditarEmpleados.
        /// </summary>
        public FrmEditarEmpleados()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Carga los tipos de empleados en el ComboBox al cargar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEditarEmpleados_Load(object sender, EventArgs e)
        {
            if (cnbTipo.Items.Count == 0)
            {
                cnbTipo.Items.Add("admin");
                cnbTipo.Items.Add("cajero");
            }
        }

        /// <summary>
        /// Función para cargar los datos del empleado en el formulario.
        /// </summary>
        /// <param name="e"></param>

        public void CargarEmpleado(Empleado e)
        {
            _empleadoId = e.Id;
            txtNombre.Text = e.Nombre;
            txtApellidos.Text = e.Apellidos;
            txtTelefono.Text = e.Telefono;
            txtCorreo.Text = e.Correo;
            txtUsuario.Text = e.Usuario;
            txtContraseña.Text = "";

            cnbTipo.SelectedItem = e.Tipo;

            _fotoActual = e.Foto;
            if (_fotoActual != null && _fotoActual.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(_fotoActual))
                {
                    pictureFoto.Image = Image.FromStream(ms);
                    pictureFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        /// <summary>
        /// Nos permite actualizar los datos del empleado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Nombre y Usuario son obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por seguridad, debe ingresar la contraseña actual o una nueva para confirmar cambios.", "Contraseña requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Empleado emp = new Empleado()
            {
                Id = _empleadoId,
                Nombre = txtNombre.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Usuario = txtUsuario.Text.Trim(),
                Password = txtContraseña.Text.Trim(),
                Tipo = cnbTipo.SelectedItem?.ToString() ?? "cajero",
                Foto = _fotoActual
            };

            if (controller.ActualizarEmpleado(emp))
            {
                MessageBox.Show("Empleado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmpleadoActualizadoCallback?.Invoke();
                this.Close();
            }
        }

        /// <summary>
        /// Boton queayuda a subir la foto del empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagenes|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                pictureFoto.Image = img;
                pictureFoto.SizeMode = PictureBoxSizeMode.StretchImage;

                using (var ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    _fotoActual = ms.ToArray();
                }
            }
        }

        private void label7_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void txtCorreo_TextChanged(object sender, EventArgs e) { }
        private void cnbTipo_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}