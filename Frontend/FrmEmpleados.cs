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
    public partial class FrmEmpleados : Form
    {
        private EmpleadoController _empleado = new EmpleadoController();
        private Form factivo = null;
        public event Action ola;
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void CargarEmpleados()
        {
            DataTable dt = _empleado.Empleados();
            dvgEmpleados.DataSource = dt;
            if (dvgEmpleados.Columns.Contains("foto")) dvgEmpleados.Columns["foto"].Visible = false;
        }

        private void VolverAEmpleados()
        {
            FormPanel(new FrmEmpleados());
        }

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

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarEmpleado frm = new FrmAgregarEmpleado();
            frm.EmpleadoAgregadoCallback = VolverAEmpleados;
            FormPanel(frm);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un empleado de la lista.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEmpleado = Convert.ToInt32(dvgEmpleados.CurrentRow.Cells["id"].Value);
            string nombre = dvgEmpleados.CurrentRow.Cells["nombre"].Value.ToString();

            var confirmacion = MessageBox.Show($"¿Está seguro de ELIMINAR al empleado '{nombre}'?", "Confirmar Eliminación",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                if (_empleado.Eliminar(idEmpleado))
                {
                    MessageBox.Show("Empleado eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEmpleados();
                }
                // El 'else' no es necesario porque el controlador ya muestra el MessageBox de error
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dvgEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un empleado para actualizar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView row = (DataRowView)dvgEmpleados.CurrentRow.DataBoundItem;

            Empleado emp = new Empleado();
            emp.Id = Convert.ToInt32(row["id"]);
            emp.Nombre = row["nombre"].ToString();
            emp.Apellidos = row["apellidos"].ToString();
            emp.Usuario = row["usuario"].ToString();
            emp.Correo = row["correo"].ToString();
            emp.Telefono = row["telefono"].ToString();
            emp.Tipo = row["tipo"].ToString();
            // La foto puede ser DBNull, hay que manejarlo
            emp.Foto = row["foto"] != DBNull.Value ? (byte[])row["foto"] : null;
            FrmEditarEmpleados frmActu = new FrmEditarEmpleados();
            frmActu.CargarEmpleado(emp);
            frmActu.EmpleadoActualizadoCallback = VolverAEmpleados;
            FormPanel(frmActu);
        }
    }
}
