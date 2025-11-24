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
    public partial class FrmMenu : Form
    {
        private Empleado _empleadoActual;
        private Form factivo = null;
        public FrmMenu(Empleado empleado)
        {
            InitializeComponent();
            _empleadoActual = empleado;
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
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            string usuario = _empleadoActual.Usuario;
            lblusuario.Text = usuario;

            if (_empleadoActual.Tipo.ToLower() == "cajero")
            {
                btnEmpleados.Visible = false;
                btnAuditorias.Visible = false;
            }
        }

        private void btnTienda_Click(object sender, EventArgs e)
        {
            FormPanel(new FrmVentas());
        }

        private void pnlApp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPanel(new FrmEmpleados());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormPanel(new FrmProductos());
        }

        private void btnAuditorias_Click(object sender, EventArgs e)
        {
            FormPanel(new FrmAuditoria());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormPanel(new FrmEmpleados());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormPanel(new FrmReportes());
        }
    }
}
