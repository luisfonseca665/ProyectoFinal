using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinal.Frontend
{
    public partial class ProductoCardControl : UserControl
    {
        public string CodigoProducto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int StockDisponible { get; set; }

        public event EventHandler<AddToCartEventArgs> OnAddToCartClick;
        public event EventHandler<string> OnRemoveClick;
        public ProductoCardControl()
        {
            InitializeComponent();
        }

        public void CargarDatos(string codigo, string nombre, decimal precio, int stock, byte[] fotoBytes)
        {
            this.CodigoProducto = codigo;
            this.PrecioUnitario = precio;
            this.StockDisponible = stock;

            lblNombre.Text = nombre;
            lblPrecio.Text = "$" + precio.ToString("N2");
            numCantidad.Maximum = stock;

            if (fotoBytes != null && fotoBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(fotoBytes))
                {
                    picFoto.Image = Image.FromStream(ms);
                }
            }
            else
            {
                picFoto.Image = null;
                picFoto.BackColor = Color.DarkGray;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            numCantidad.Value = 0;
            OnRemoveClick?.Invoke(this, this.CodigoProducto);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (numCantidad.Value > 0)
            {
                AddToCartEventArgs args = new AddToCartEventArgs
                {
                    Codigo = this.CodigoProducto,
                    Nombre = lblNombre.Text,
                    Cantidad = (int)numCantidad.Value,
                    Precio = this.PrecioUnitario
                };

                OnAddToCartClick?.Invoke(this, args);

                numCantidad.Value = 0;
            }
            else
            {
                MessageBox.Show("Selecciona una cantidad mayor a 0.");
            }
        }
    }

    public class AddToCartEventArgs : EventArgs
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}