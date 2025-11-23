using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Backend;
using System.IO;

namespace ProyectoFinal.Frontend
{
    public partial class FrmEmpleados : Form
    {
        EmpleadoController controller = new EmpleadoController();

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TablaEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado.");
                return;
            }

            int id = Convert.ToInt32(TablaEmpleados.SelectedRows[0].Cells["idempleado"].Value);

            FrmEditarEmpleados frm = new FrmEditarEmpleados(id);
            frm.ShowDialog();
            CargarEmpleados();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (TablaEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(TablaEmpleados.SelectedRows[0].Cells["idempleado"].Value);

            if (MessageBox.Show("¿Seguro que deseas eliminar este empleado?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            bool ok = controller.Eliminar(id);

            if (ok)
            {
                MessageBox.Show("Empleado eliminado ✅");
                CargarEmpleados();
            }
            else
            {
                MessageBox.Show("Error al eliminar ❌");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarEmpleados()
        {
            DataTable dt = controller.Empleados();

            // ✅ Renombrar columna "id" a "idempleado"
            if (dt.Columns.Contains("id"))
                dt.Columns["id"].ColumnName = "idempleado";

            // ✅ Limpiar columnas
            TablaEmpleados.Columns.Clear();

            // ✅ Columna de imagen
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Foto";
            imgCol.Name = "Foto";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            TablaEmpleados.Columns.Add(imgCol);

            // ✅ Asignar datos
            TablaEmpleados.DataSource = dt;

            // ✅ Mover foto al inicio
            TablaEmpleados.Columns["Foto"].DisplayIndex = 0;

            // ✅ Procesar imágenes
            foreach (DataGridViewRow row in TablaEmpleados.Rows)
            {
                if (row.IsNewRow) continue;

                object value = row.Cells["foto"].Value;

                // ✅ Verificar existencia real del valor
                if (value == null || value == DBNull.Value)
                {
                    row.Cells["Foto"].Value = null;
                    continue;
                }

                // ✅ Convertir a bytes
                byte[] bytes = value as byte[];

                // ✅ Validar que realmente haya datos
                if (bytes == null || bytes.Length == 0)
                {
                    row.Cells["Foto"].Value = null;
                    continue;
                }

                // ✅ Intentar convertir a imagen
                try
                {
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        row.Cells["Foto"].Value = Image.FromStream(ms);
                    }
                }
                catch
                {
                    // ✅ Si no es imagen válida, dejar vacío
                    row.Cells["Foto"].Value = null;
                }
            }

            // ✅ Ocultar columna original
            if (TablaEmpleados.Columns.Contains("foto"))
                TablaEmpleados.Columns["foto"].Visible = false;

            // ✅ Tamaño filas
            TablaEmpleados.RowTemplate.Height = 70;

            TablaEmpleados.Refresh();
        }





        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarEmpleado frm = new FrmAgregarEmpleado();
            frm.ShowDialog();

        }

        private void FrmEmpleados_Load_1(object sender, EventArgs e)
        {

        }
    }
}
