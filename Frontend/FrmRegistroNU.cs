using ProyectoFinal.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Frontend
{
    public partial class FrmRegistroNU : Form
    {
        private EmpleadoController controller = new EmpleadoController();
        private byte[] fotoBytes = null;
        public FrmRegistroNU()
        {
            InitializeComponent();
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
                    fotoBytes = ms.ToArray();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Complete todos los campos obligatorios.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cnbTipo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de empleado.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtTelefono.Text) && !Regex.IsMatch(txtTelefono.Text, @"^\d+$"))
            {
                MessageBox.Show("El teléfono solo debe contener números.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!string.IsNullOrWhiteSpace(txtCorreo.Text) && !Regex.IsMatch(txtCorreo.Text, patronCorreo))
            {
                MessageBox.Show("Por favor ingrese un correo electrónico válido (ejemplo: usuario@gmail.com).", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtContraseña.Text.Trim().Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (controller.Registrar(emp))
            {
                MessageBox.Show("Empleado registrado correctamente", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar el empleado. Verifique que el usuario no esté duplicado.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FrmRegistroNU_Load(object sender, EventArgs e)
        {
            cnbTipo.Items.Clear();
            cnbTipo.Items.Add("admin");
            cnbTipo.Items.Add("cajero");
            cnbTipo.SelectedIndex = 0;
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }
    }
}
