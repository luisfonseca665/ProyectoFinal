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
    /// Representa el formulario para gestionar empleados.
    /// </summary>
    public partial class FrmEmpleados : Form
    {
        private EmpleadoController _empleado = new EmpleadoController();
        private Form factivo = null;


        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FrmEmpleados"/>.
        /// </summary>
        public FrmEmpleados()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Cargar los empleados al cargar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }


        /// <summary>
        /// Funcion para cargar los empleados en el DataGridView.
        /// </summary>
        private void CargarEmpleados()
        {
            List<Empleado> lista = _empleado.ObtenerEmpleados();
            dvgEmpleados.DataSource = null;
            dvgEmpleados.DataSource = lista;

            if (dvgEmpleados.Columns["Foto"] != null) dvgEmpleados.Columns["Foto"].Visible = false;
            if (dvgEmpleados.Columns["Password"] != null) dvgEmpleados.Columns["Password"].Visible = false;

            dvgEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        /// <summary>
        /// Recarga la lista de empleados al volver del formulario de agregar o editar empleado.
        /// </summary>
        private void VolverAEmpleados()
        {
            CargarEmpleados();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarEmpleado frm = new FrmAgregarEmpleado();
            frm.EmpleadoAgregadoCallback = () =>
            {
                pnlApp.Controls.Clear();
                CargarEmpleados();
            };
            FormPanel(frm);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un empleado de la lista.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Empleado empSeleccionado = (Empleado)dvgEmpleados.CurrentRow.DataBoundItem;

            var confirmacion = MessageBox.Show($"¿Está seguro de ELIMINAR al empleado '{empSeleccionado.Nombre}'?", "Confirmar Eliminación",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                if (_empleado.EliminarEmpleado(empSeleccionado.Id))
                {
                    MessageBox.Show("Empleado eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEmpleados();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dvgEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un empleado para actualizar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Empleado emp = (Empleado)dvgEmpleados.CurrentRow.DataBoundItem;

            FrmEditarEmpleados frmActu = new FrmEditarEmpleados();
            frmActu.CargarEmpleado(emp);

            frmActu.EmpleadoActualizadoCallback = () =>
            {
                pnlApp.Controls.Clear();
                CargarEmpleados();
            };

            FormPanel(frmActu);
        }

        private void dvgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}