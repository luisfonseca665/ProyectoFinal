using ProyectoFinal.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Frontend
{
    /// <summary>
    /// Representa el formulario para agregar un nuevo empleado al sistema.
    /// </summary>
    public partial class FrmAgregarEmpleado : Form
    {
        private EmpleadoController controller = new EmpleadoController();
        private byte[] fotoBytes = null;

        public Action EmpleadoAgregadoCallback { get; set; }


        /// <summary>
        /// Inicializa una nueva instancia de FrmAgregarEmpleado.
        /// </summary>

        public FrmAgregarEmpleado()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los tipos de empleados en el ComboBox al cargar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FrmAgregarEmpleado_Load(object sender, EventArgs e)
        {
            cnbTipo.Items.Clear();
            cnbTipo.Items.Add("admin");
            cnbTipo.Items.Add("cajero");
            cnbTipo.SelectedIndex = 0;
        }


        /// <summary>
        /// Agrega un nuevo empleado al sistema cuando se hace clic en el botón "Agregar".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Complete todos los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNombre.Text.Trim().Length < 2)
            {
                MessageBox.Show("El nombre debe tener al menos 2 caracteres.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (txtApellidos.Text.Trim().Length < 2)
            {
                MessageBox.Show("Los apellidos deben tener al menos 2 caracteres.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellidos.Focus();
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtTelefono.Text.Trim(), @"^\d{10}$"))
            {
                MessageBox.Show("El teléfono debe contener exactamente 10 dígitos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return;
            }

            try
            {
                string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(txtCorreo.Text.Trim(), patronCorreo))
                {
                    MessageBox.Show("Por favor ingrese un correo electrónico válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCorreo.Focus();
                    return;
                }
            }
            catch
            {
                return;
            }

            if (txtUsuario.Text.Trim().Length < 3)
            {
                MessageBox.Show("El usuario debe tener al menos 3 caracteres.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (cnbTipo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de empleado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string password = txtContraseña.Text.Trim();

            if (password.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Empleado emp = new Empleado()
            {
                Nombre = txtNombre.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Usuario = txtUsuario.Text.Trim(),
                Password = txtContraseña.Text.Trim(),
                Tipo = cnbTipo.SelectedItem.ToString(),
                Foto = fotoBytes
            };

            if (controller.InsertarEmpleado(emp))
            {
                MessageBox.Show("Empleado registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                EmpleadoAgregadoCallback?.Invoke();
                this.Close();
            }
        }


        /// <summary>
        /// Ayuda a seleccionar y cargar una foto para el empleado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagenes|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image img = Image.FromFile(ofd.FileName);
                    pictureFoto.Image = img;
                    pictureFoto.SizeMode = PictureBoxSizeMode.StretchImage;

                    using (var ms = new MemoryStream())
                    {
                        img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        fotoBytes = ms.ToArray();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar imagen: " + ex.Message);
                }
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
            cnbTipo.SelectedIndex = 0;
            pictureFoto.Image = null;
            fotoBytes = null;
        }

        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void pictureFoto_Click(object sender, EventArgs e) { }
        private void txtContraseña_TextChanged(object sender, EventArgs e) { }
        private void txtUsuario_TextChanged(object sender, EventArgs e) { }
        private void txtCorreo_TextChanged(object sender, EventArgs e) { }
        private void txtTelefono_TextChanged(object sender, EventArgs e) { }
        private void txtApellidos_TextChanged(object sender, EventArgs e) { }
        private void txtNombre_TextChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
    }
}