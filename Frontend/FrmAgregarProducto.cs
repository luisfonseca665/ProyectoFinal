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
    public partial class FrmAgregarProducto : Form
    {
        private byte[] _foto;
        public Action ProductoAgregadoCallback { get; set; }
        public FrmAgregarProducto()
        {
            InitializeComponent();
        }


        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _foto = File.ReadAllBytes(openfile.FileName);
                    pbProducto.ImageLocation = openfile.FileName;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            /// Valido los datos de entrada
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El Precio debe ser un número válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }

            /// El control numStock ya devuelve un decimal, lo convertimos a int o lo dejamos como decimal
            /// Asumimos que el Stock del modelo es 'int'.
            int stock = (int)nudStock.Value;

            /// Cree el objeto Producto
            Producto nuevoProducto = new Producto
            {
                Codigo = txtCodigo.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Precio = precio,
                Stock = stock,
                Foto = _foto
            };

            /// Validamos campos obligatorios que la función no chequea (Nombre, Descripción, etc.)
            if (string.IsNullOrEmpty(nuevoProducto.Nombre) || string.IsNullOrEmpty(nuevoProducto.Descripcion))
            {
                MessageBox.Show("El Nombre y la Descripción son obligatorios.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ///  Llamamos a la lógica de la base de datos
            ProductosController ola = new ProductosController();
            if (ola.InsertarProducto(nuevoProducto))
            {
                MessageBox.Show("Producto agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                ProductoAgregadoCallback?.Invoke();
            }
            else
            {
                MessageBox.Show("No se pudo agregar el producto. Revise el código o la conexión a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarCampos() {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            nudStock.Value = 0;
            pbProducto.Image = null;
            _foto = null;
        }
    }
}
