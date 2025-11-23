using ProyectoFinal.Backend;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinal.Frontend
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
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

                VentasController controller = new VentasController();
                string mensajeResultado;

                bool exito = controller.RegistrarVenta(idEmpleado, totalVenta, listaDetalles, out mensajeResultado);

                if (exito)
                {
                    MessageBox.Show(mensajeResultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvVenta.Rows.Clear();
                    txtTotal.Text = "0.00";
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

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            VentasController controller = new VentasController();
            DataTable dtEmpleados = controller.ObtenerEmpleados();

            if (dtEmpleados != null)
            {
                cboEmpleados.DataSource = dtEmpleados;
                cboEmpleados.DisplayMember = "NombreCompleto";
                cboEmpleados.ValueMember = "id";
                cboEmpleados.SelectedIndex = -1;
            }

            dgvVenta.Columns.Add("Codigo", "Código");
            dgvVenta.Columns.Add("Producto", "Producto");
            dgvVenta.Columns.Add("Precio", "Precio");
            dgvVenta.Columns.Add("Cantidad", "Cantidad");
            dgvVenta.Columns.Add("Total", "Total");
            
            dgvVenta.AllowUserToAddRows = false;
            dgvVenta.ReadOnly = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text)) 
            {
                MessageBox.Show("Ingresa el código del producto.");
                return;
            }

            string codigo = txtCodigo.Text.Trim();
            int cantidad = 1;


            try
            {
                VentasController controller = new VentasController();

                DataTable dtProducto = controller.BuscarProductoPorCodigo(codigo);

                if (dtProducto.Rows.Count > 0)
                {
                    DataRow row = dtProducto.Rows[0];
                    string nombre = row["nombre"].ToString();
                    decimal precio = Convert.ToDecimal(row["precio"]);
                    decimal subtotal = precio * cantidad;

                    bool existe = false;
                    foreach (DataGridViewRow fila in dgvVenta.Rows)
                    {
                        if (fila.Cells["Codigo"].Value != null && fila.Cells["Codigo"].Value.ToString() == codigo)
                        {
                            int cantActual = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                            fila.Cells["Cantidad"].Value = cantActual + cantidad;
                            fila.Cells["Total"].Value = (cantActual + cantidad) * precio;
                            existe = true;
                            break;
                        }
                    }

                    if (!existe)
                    {
                        dgvVenta.Rows.Add(codigo, nombre, precio, cantidad, subtotal);
                    }

                    CalcularTotal();
                    txtCodigo.Clear();
                    txtCodigo.Focus();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                    txtCodigo.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar producto: " + ex.Message);
            }
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
    }
}