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
    public partial class FrmEditarEmpleados : Form
    {
        private int _empleadoId;
        private EmpleadoController controller = new EmpleadoController();
        private byte[] _fotoActual;
        public Action EmpleadoActualizadoCallback { get; set; }
        public FrmEditarEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEditarEmpleados_Load(object sender, EventArgs e)
        {
            if (cnbTipo.Items.Count == 0)
            {
                cnbTipo.Items.Add("admin");
                cnbTipo.Items.Add("cajero");
            }
        }
        public void CargarEmpleado(Empleado e)
        {
            _empleadoId = e.Id;
            txtNombre.Text = e.Nombre;
            txtApellidos.Text = e.Apellidos;
            txtTelefono.Text = e.Telefono;
            txtCorreo.Text = e.Correo;
            txtUsuario.Text = e.Usuario;

            // Nota: La contraseña NO se carga por seguridad (es hash). 
            // El usuario debe escribir una nueva si quiere cambiarla.
            txtContraseña.Text = "";

            // Seleccionar tipo
            cnbTipo.SelectedItem = e.Tipo;

            // Cargar Foto
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
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

            // Construir objeto
            Empleado emp = new Empleado()
            {
                Id = _empleadoId, // Importante: ID para el WHERE del Update
                Nombre = txtNombre.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Usuario = txtUsuario.Text.Trim(),
                Password = txtContraseña.Text.Trim(),
                Tipo = cnbTipo.SelectedItem?.ToString() ?? "cajero",
                Foto = _fotoActual
            };

            // Llamar al backend
            if (controller.Actualizar(emp))
            {
                MessageBox.Show("Empleado actualizado correctamente ✅", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Regresar a la tabla
                EmpleadoActualizadoCallback?.Invoke();
            }
        }

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
                    _fotoActual= ms.ToArray();
                }
            }
        }
    }
}
