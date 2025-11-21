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
        public FrmMenu(Empleado empleado)
        {
            InitializeComponent();
            _empleadoActual = empleado;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            string usuario = _empleadoActual.Usuario;
            lblusuario.Text = usuario;
        }

        private void btnTienda_Click(object sender, EventArgs e)
        {

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
    }
}
