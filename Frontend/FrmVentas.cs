using ProyectoFinal.Backend;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal.Frontend
{
    public partial class FrmVentas : Form
    {
        VentasController ventasController = new VentasController();
        ProductosController productosController = new ProductosController();

        public FrmVentas()
        {
            InitializeComponent();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            dgvVenta.Columns.Clear();
            dgvVenta.Columns.Add("Codigo", "Código");
            dgvVenta.Columns.Add("Producto", "Producto");
            dgvVenta.Columns.Add("Precio", "Precio");
            dgvVenta.Columns.Add("Cantidad", "Cantidad");
            dgvVenta.Columns.Add("Total", "Total");

            dgvVenta.AllowUserToAddRows = false;
            dgvVenta.ReadOnly = true;
            dgvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CargarEmpleados();
            CargarCatalogoVisual();
        }

        private void CargarEmpleados()
        {
            DataTable dt = ventasController.ObtenerEmpleados();
            if (dt != null)
            {
                cboEmpleados.DataSource = dt;
                cboEmpleados.DisplayMember = "NombreCompleto";
                cboEmpleados.ValueMember = "id";
                cboEmpleados.SelectedIndex = -1;
            }
        }

        private void CargarCatalogoVisual()
        {
            flowLayoutPanel1.Controls.Clear();

            DataTable dtProductos = productosController.ObtenerProductosParaVenta();

            if (dtProductos == null) return;

            foreach (DataRow row in dtProductos.Rows)
            {
                ProductoCardControl tarjeta = new ProductoCardControl();

                byte[] foto = row["foto"] as byte[];
                string codigo = row["codigo"].ToString();
                string nombre = row["nombre"].ToString();
                decimal precio = Convert.ToDecimal(row["precio"]);
                int stock = Convert.ToInt32(row["stock"]);

                tarjeta.CargarDatos(codigo, nombre, precio, stock, foto);
                tarjeta.OnAddToCartClick += Tarjeta_OnAddToCartClick;
                tarjeta.OnRemoveClick += Tarjeta_OnRemoveClick;

                flowLayoutPanel1.Controls.Add(tarjeta);
            }
        }

        private void Tarjeta_OnAddToCartClick(object sender, AddToCartEventArgs e)
        {
            AgregarAlGrid(e.Codigo, e.Nombre, e.Precio, e.Cantidad);
        }

        private void Tarjeta_OnRemoveClick(object sender, string codigoProducto)
        {

            bool encontrado = false;

            for (int i = dgvVenta.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dgvVenta.Rows[i];

                if (row.Cells["Codigo"].Value != null &&
                    row.Cells["Codigo"].Value.ToString() == codigoProducto)
                {
                    dgvVenta.Rows.RemoveAt(i);
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                CalcularTotal();
            }
        }
        private void AgregarAlGrid(string codigo, string nombre, decimal precio, int cantidad)
        {
            bool existe = false;

            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {
                if (fila.Cells["Codigo"].Value != null && fila.Cells["Codigo"].Value.ToString() == codigo)
                {
                    int cantActual = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    int nuevaCantidad = cantActual + cantidad;

                    fila.Cells["Cantidad"].Value = nuevaCantidad;
                    fila.Cells["Total"].Value = nuevaCantidad * precio;

                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                decimal subtotal = precio * cantidad;
                dgvVenta.Rows.Add(codigo, nombre, precio, cantidad, subtotal);
            }

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {
                if (fila.Cells["Total"].Value != null)
                {
                    total += Convert.ToDecimal(fila.Cells["Total"].Value);
                }
            }
            txtTotal.Text = total.ToString("N2");
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.Rows.Count == 0)
            {
                MessageBox.Show("Debes agregar productos antes de cobrar.");
                return;
            }

            if (cboEmpleados.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un empleado.");
                return;
            }

            try
            {
                int idEmpleado = Convert.ToInt32(cboEmpleados.SelectedValue);
                decimal totalVenta = Convert.ToDecimal(txtTotal.Text);

                List<VentasController.DetalleVentaModelo> listaDetalles = new List<VentasController.DetalleVentaModelo>();

                foreach (DataGridViewRow fila in dgvVenta.Rows)
                {
                    if (fila.IsNewRow) continue;

                    var detalle = new VentasController.DetalleVentaModelo();

                    detalle.CodigoProducto = fila.Cells["Codigo"].Value.ToString();
                    detalle.Cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    detalle.Precio = Convert.ToDecimal(fila.Cells["Precio"].Value);

                    listaDetalles.Add(detalle);
                }

                string mensajeResultado;
                bool exito = ventasController.RegistrarVenta(idEmpleado, totalVenta, listaDetalles, out mensajeResultado);

                if (exito)
                {
                    MessageBox.Show(mensajeResultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvVenta.Rows.Clear();
                    txtTotal.Text = "0.00";
                    CargarCatalogoVisual();
                }
                else
                {
                    MessageBox.Show(mensajeResultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvVenta.Rows.Clear();
            txtTotal.Text = "0.00";
        }
    }
}