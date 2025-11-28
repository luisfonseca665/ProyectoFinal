using ProyectoFinal.Backend;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinal.Frontend
{
    /// <summary>
    /// Representa el formulario para visualizar las auditorías del sistema.
    /// </summary>
    public partial class FrmAuditoria : Form
    {
        private AuditoriaController controller = new AuditoriaController();


        /// <summary>
        /// Inicializa una nueva instancia de FrmAuditoria.
        /// </summary>
        public FrmAuditoria()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga las auditorías al cargar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAuditoria_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }


        /// <summary>
        /// Función para cargar los datos de auditoría en el DataGridView.
        /// </summary>
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

        /// <summary>
        /// Cofiguración visual del DataGridView.
        /// </summary>

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