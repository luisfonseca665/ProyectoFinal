using ProyectoFinal.Backend;
using System;
using System.Collections.Generic;
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
            try
            {
                List<Auditoria> lista = controller.ObtenerAuditoria();
                dvgAuditorias.DataSource = null;
                dvgAuditorias.DataSource = lista;

                DiseñarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DiseñarGrid()
        {
            if (dvgAuditorias.Columns.Count > 0)
            {
                dvgAuditorias.Columns["Origen"].HeaderText = "Tipo";
                dvgAuditorias.Columns["Origen"].Width = 80;

                dvgAuditorias.Columns["Referencia"].HeaderText = "Clave / ID";
                dvgAuditorias.Columns["Referencia"].Width = 100;

                dvgAuditorias.Columns["Accion"].Width = 70;

                dvgAuditorias.Columns["ValorAnterior"].HeaderText = "Valor Anterior";
                dvgAuditorias.Columns["ValorNuevo"].HeaderText = "Valor Nuevo";

                dvgAuditorias.Columns["Usuario"].Width = 80;
                dvgAuditorias.Columns["Fecha"].Width = 120;

                dvgAuditorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}