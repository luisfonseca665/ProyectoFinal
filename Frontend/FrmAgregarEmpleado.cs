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
    public partial class FrmAgregarEmpleado : Form
    {
        private EmpleadoController controller = new EmpleadoController();
        private byte[] fotoBytes = null;

        private void FrmAgregarEmpleado_Load(object sender, EventArgs e)
        {
            cnbTipo.Items.Clear();
            cnbTipo.Items.Add("admin");
            cnbTipo.Items.Add("cajero");
        }
        public FrmAgregarEmpleado()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureFoto_Click(object sender, EventArgs e)
        {

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

            // Crear objeto empleado
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

            // Registrar empleado
            bool ok = controller.Registrar(emp);

            if (ok)
            {
                MessageBox.Show("Empleado registrado correctamente ✅", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el empleado ❌", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagenes|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                pictureFoto.Image = img;

                using (var ms = new MemoryStream())
                {
                    img.Save(ms, img.RawFormat);
                    fotoBytes = ms.ToArray();
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
            cnbTipo.SelectedIndex = -1;
            pictureFoto.Image = null;
            fotoBytes = null;
        }
    }
}
