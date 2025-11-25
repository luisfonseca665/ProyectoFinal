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
    public partial class FrmActuProducto : Form
    {
        private byte[] _fotoActual;
        private ProductosController _producto = new ProductosController();

        public Action ProductoActualizadoCallback { get; set; }
        public FrmActuProducto()
        {
            InitializeComponent();
        }
        public void CargarProducto(Producto producto)
        {
            txtCodigo.Text = producto.Codigo;
            txtNombre.Text = producto.Nombre;
            txtDescripcion.Text = producto.Descripcion;
            txtPrecio.Text = producto.Precio.ToString("F2");
            nudStock.Value = producto.Stock;
            _fotoActual = producto.Foto;
            MostrarFoto(producto.Foto);
            txtCodigo.ReadOnly = true;
        }
        private void MostrarFoto(byte[] fotoBytes)
        {
            if (fotoBytes != null && fotoBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(fotoBytes))
                {
                    pbProducto.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pbProducto.Image = null;
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _fotoActual = File.ReadAllBytes(openFile.FileName);
                    pbProducto.ImageLocation = openFile.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (txtCodigo.Text.Trim().Length != 13)
            {
                MessageBox.Show("El Código debe tener exactamente 13 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return;
            }

            if (txtNombre.Text.Trim().Length < 4)
            {
                MessageBox.Show("El Nombre debe tener al menos 4 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(txtDescripcion.Text.Trim()))
            {
                MessageBox.Show("La Descripción es obligatoria.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return;
            }


            if (!decimal.TryParse(txtPrecio.Text.Trim(), out decimal precio))
            {
                MessageBox.Show("El Precio debe ser un número válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }

            if (precio <= 0)
            {
                MessageBox.Show("El Precio debe ser mayor a 0.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }


            if (decimal.Round(precio, 2) != precio)
            {
                MessageBox.Show("El Precio no puede tener más de 2 decimales.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }


            int stock = (int)nudStock.Value;
            if (stock <= 0)
            {
                MessageBox.Show("El Stock debe ser mayor a 0.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudStock.Focus();
                return;
            }


            Producto productoActualizado = new Producto
            {
                Codigo = txtCodigo.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Precio = precio,
                Stock = stock,
                Foto = _fotoActual,
                Descontinuado = false
            };


            if (_producto.ActualizarProducto(productoActualizado))
            {
                MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                ProductoActualizadoCallback?.Invoke();
            }
            else
            {
                MessageBox.Show("Error al actualizar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
