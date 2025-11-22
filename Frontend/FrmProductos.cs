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
    public partial class FrmProductos : Form
    {
        private ProductosController _productos = new ProductosController();
        public FrmProductos()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos()
        {
            List<Producto> lista = _productos.ObtenerProductos();
            dvgProductos.DataSource = lista;

            dvgProductos.Columns["Codigo"].HeaderText = "CLAVE";
            dvgProductos.Columns["Precio"].DefaultCellStyle.Format = "C";

            dvgProductos.Columns["Descontinuado"].Visible = false;
            dvgProductos.Columns["Foto"].Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgProductos.CurrentRow == null) {
                MessageBox.Show("Por favor, seleccione un producto de la lista.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string producto = dvgProductos.CurrentRow.Cells["Codigo"].Value.ToString();
            string nombre = dvgProductos.CurrentRow.Cells["Nombre"].Value.ToString();

            var ola = MessageBox.Show($"¿Está seguro de DESCONTINUAR el producto '{nombre}'?","Confirmar Eliminación",
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
    }
}
