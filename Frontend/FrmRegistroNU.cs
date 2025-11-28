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
    /// Representa el formulario para registrar nuevos empleados.
    /// </summary>
    public partial class FrmRegistroNU : Form
    {
        private EmpleadoController controller = new EmpleadoController();
        private byte[] fotoBytes = null;


        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FrmRegistroNU"/>.
        /// </summary>
        public FrmRegistroNU()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cargar el formulario y configurar el combo box de tipo de empleado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRegistroNU_Load(object sender, EventArgs e)
        {
            cnbTipo.Items.Clear();
            cnbTipo.Items.Add("admin");
            cnbTipo.Items.Add("cajero");
            cnbTipo.SelectedIndex = 0;
        }

        /// <summary>
        /// Boton para cargar la foto del empleado.
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
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// boton para agregar un nuevo empleado con validaciones.
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

            if (cnbTipo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de empleado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(txtTelefono.Text.Trim(), @"^\d{10}$"))
            {
                MessageBox.Show("El teléfono debe contener exactamente 10 dígitos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return;
            }

            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtCorreo.Text.Trim(), patronCorreo))
            {
                MessageBox.Show("Por favor ingrese un correo electrónico válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            if (txtUsuario.Text.Trim().Length < 3)
            {
                MessageBox.Show("El usuario debe tener al menos 3 caracteres.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            string password = txtContraseña.Text.Trim();
            if (password.Length < 8 ||
                !Regex.IsMatch(password, @"[A-Z]") ||
                !Regex.IsMatch(password, @"[a-z]") ||
                !Regex.IsMatch(password, @"[0-9]"))
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, incluyendo una mayúscula, una minúscula y un número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                return;
            }

            Empleado emp = new Empleado()
            {
                Nombre = txtNombre.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Usuario = txtUsuario.Text.Trim(),
                Password = password,
                Tipo = cnbTipo.SelectedItem.ToString(),
                Foto = fotoBytes
            };

            if (controller.InsertarEmpleado(emp))
            {
                MessageBox.Show("Empleado registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmLogin login = new FrmLogin();
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar el empleado. Verifique que el usuario no esté duplicado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Boton para cerrar la aplicacion y volver al login.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}