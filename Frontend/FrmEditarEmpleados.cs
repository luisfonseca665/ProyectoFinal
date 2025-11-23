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
    public partial class FrmEditarEmpleados : Form
    {
        private int empleadoId;
        private EmpleadoController controller = new EmpleadoController();
        private byte[] fotoBytesActual;
        public FrmEditarEmpleados(int id)
        {
            InitializeComponent();
            empleadoId = id;
        }

        private void FrmEditarEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
