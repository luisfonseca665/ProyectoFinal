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

        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            List<Empleado> lista = _empleado.ObtenerEmpleados();
            dvgEmpleados.DataSource = null;
            dvgEmpleados.DataSource = lista;

            if (dvgEmpleados.Columns["Foto"] != null) dvgEmpleados.Columns["Foto"].Visible = false;
            if (dvgEmpleados.Columns["Password"] != null) dvgEmpleados.Columns["Password"].Visible = false;

            dvgEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void VolverAEmpleados()
        {
            CargarEmpleados();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarEmpleado frm = new FrmAgregarEmpleado();
            frm.EmpleadoAgregadoCallback = () => {
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

            frmActu.EmpleadoActualizadoCallback = () => {
                pnlApp.Controls.Clear();
                CargarEmpleados();
            };

            FormPanel(frmActu);
        }
    }
}