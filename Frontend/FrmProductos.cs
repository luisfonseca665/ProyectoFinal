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
    /// Representa el formulario para gestionar productos.
    /// </summary>
    public partial class FrmProductos : Form
    {
        private ProductosController _productos = new ProductosController();
        private Form factivo = null;
        public event Action ola;
        Empleado _em = new Empleado();

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FrmProductos"/>.
        /// </summary>
        public FrmProductos()
        {
            InitializeComponent();
            CargarProductos();
        }


        /// <summary>
        /// Pantalla de regreso a productos.
        /// </summary>
        private void VolverAProductos()
        {
            FormPanel(new FrmProductos());
        }

        /// <summary>
        /// Funcion para cargar los productos en el DataGridView.
        /// </summary>
        private void CargarProductos()
        {
            List<Producto> lista = _productos.ObtenerProductos();
            dvgProductos.DataSource = lista;
            dvgProductos.Columns["Precio"].DefaultCellStyle.Format = "C";

            dvgProductos.Columns["Descontinuado"].Visible = false;
            dvgProductos.Columns["Foto"].Visible = false;
        }



        /// <summary>
        /// Pantalla para mostrar formularios dentro del panel principal.
        /// </summary>
        /// <param name="activo"></param>
        private void FormPanel(Form activo)
        {
            if (factivo != null)
            {
                factivo.Close();
                factivo.Dispose();

            }
            factivo = activo;
            activo.TopLevel = false;
            activo.FormBorderStyle = FormBorderStyle.None;
            activo.Dock = DockStyle.Fill;

            pnlApp.Controls.Clear();
            pnlApp.Controls.Add(activo);

            activo.BringToFront();
            activo.Show();
        }



        /// <summary>
        /// Boton para eliminar un producto seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgProductos.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string producto = dvgProductos.CurrentRow.Cells["Codigo"].Value.ToString();
            string nombre = dvgProductos.CurrentRow.Cells["Nombre"].Value.ToString();

            var ola = MessageBox.Show($"¿Está seguro de DESCONTINUAR el producto '{nombre}'?", "Confirmar Eliminación",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ola == DialogResult.Yes)
            {
                if (_productos.EliminarProducto(producto))
                {
                    MessageBox.Show("Producto descontinuad con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos();
                }
                else
                {
                    MessageBox.Show("Error al intentar descontinuar el producto.", "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Boton para agregar un nuevo producto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto ola = new FrmAgregarProducto();
            ola.ProductoAgregadoCallback = VolverAProductos;
            FormPanel(ola);
        }


        /// <summary>
        /// Boton para actualizar un producto seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dvgProductos.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista para actualizar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Producto producto = dvgProductos.CurrentRow.DataBoundItem as Producto;

            if (producto != null)
            {
                FrmActuProducto frmActu = new FrmActuProducto();
                frmActu.CargarProducto(producto);
                frmActu.ProductoActualizadoCallback = VolverAProductos;
                FormPanel(frmActu);
            }
            else
            {
                MessageBox.Show("Error al obtener los datos del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dvgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
