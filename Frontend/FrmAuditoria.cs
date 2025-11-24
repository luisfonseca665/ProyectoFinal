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
    public partial class FrmAuditoria : Form
    {
        private AuditoriaController controller = new AuditoriaController();
        public FrmAuditoria()
        {
            InitializeComponent();
        }

        private void FrmAuditoria_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            List<Auditoria> lista = controller.ObtenerAuditoria();
            dvgAuditorias.DataSource = null;

            dvgAuditorias.DataSource = lista;

            if (dvgAuditorias.Columns["Id"] != null)
            {
                dvgAuditorias.Columns["Id"].Visible = false;
            }
            dvgAuditorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
