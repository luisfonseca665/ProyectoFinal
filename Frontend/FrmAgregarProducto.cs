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
    /// Representa el formulario para agregar un nuevo producto al sistema.
    /// </summary>
    public partial class FrmAgregarProducto : Form
    {
        private byte[] _foto;
        public Action ProductoAgregadoCallback { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de FrmAgregarProducto.
        /// </summary>
        public FrmAgregarProducto()
        {
            InitializeComponent();
        }




        /// <summary>
        /// Nos permite subir la foto del producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Nos permite agregar un nuevo producto al sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarProducto_Click(object sender, EventArgs e)
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


            Producto nuevoProducto = new Producto
            {
                Codigo = txtCodigo.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Precio = precio,
                Stock = stock,
                Foto = _foto
            };


            ProductosController controller = new ProductosController();
            if (controller.InsertarProducto(nuevoProducto))
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

        private void limpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            nudStock.Value = 0;
            pbProducto.Image = null;
            _foto = null;
        }

        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbProducto_Click(object sender, EventArgs e)
        {

        }

        private void nudStock_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
