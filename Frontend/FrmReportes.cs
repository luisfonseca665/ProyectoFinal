using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ProyectoFinal.Backend;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoFinal.Frontend
{
    public partial class FrmReportes : Form
    {
        ReportesController controlador = new ReportesController();
        private List<ProductoComparativo> _datosComparativos;

        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            dtpInicio.Value = new DateTime(hoy.Year, hoy.Month, 1);
            dtpFin.Value = hoy;
            dtpMes1.Value = new DateTime(hoy.Year, hoy.Month, 1);
            dtpMes2.Value = hoy.AddMonths(-1);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = controlador.ObtenerVentasPorRango(dtpInicio.Value, dtpFin.Value);
                dgvReporte.DataSource = dt;

                if (dgvReporte.Columns.Count > 0)
                {
                    dgvReporte.Columns["Monto"].DefaultCellStyle.Format = "C2";
                    dgvReporte.Columns["Unidades"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvReporte.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvReporte.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvReporte.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            ExportarExcel();
        }

        private void ExportarExcel()
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            try
            {
                worksheet.Cells[2, 2] = "Reporte de venta por producto";
                worksheet.Range["B2"].Font.Bold = true;
                worksheet.Range["B2"].Font.Size = 14;

                worksheet.Cells[4, 2] = "Fecha inicio:";
                worksheet.Cells[5, 2] = "Fecha fin:";

                worksheet.Cells[4, 3] = dtpInicio.Value.ToShortDateString();
                worksheet.Cells[5, 3] = dtpFin.Value.ToShortDateString();

                Excel.Range rangoFechas = worksheet.Range["C4", "C5"];
                rangoFechas.Interior.Color = ColorTranslator.ToOle(Color.LightGreen);
                rangoFechas.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                int filaInicioTabla = 7;
                for (int i = 0; i < dgvReporte.Columns.Count; i++)
                {
                    worksheet.Cells[filaInicioTabla, i + 2] = dgvReporte.Columns[i].HeaderText;
                }

                Excel.Range rangoEncabezados = worksheet.Range[worksheet.Cells[filaInicioTabla, 2], worksheet.Cells[filaInicioTabla, dgvReporte.Columns.Count + 1]];
                rangoEncabezados.Interior.Color = ColorTranslator.ToOle(Color.LightBlue);
                rangoEncabezados.Font.Bold = true;
                rangoEncabezados.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                for (int i = 0; i < dgvReporte.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvReporte.Columns.Count; j++)
                    {
                        worksheet.Cells[i + filaInicioTabla + 1, j + 2] = dgvReporte.Rows[i].Cells[j].Value;
                    }
                }

                int filaFinal = filaInicioTabla + dgvReporte.Rows.Count;
                Excel.Range rangoDatos = worksheet.Range[worksheet.Cells[filaInicioTabla, 2], worksheet.Cells[filaFinal, dgvReporte.Columns.Count + 1]];
                rangoDatos.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                worksheet.Range[$"E{filaInicioTabla + 1}:E{filaFinal}"].NumberFormat = "$ #,##0.00";

                worksheet.Columns.AutoFit();
                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message);
                excelApp.Quit();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaMes1 = dtpMes1.Value;
                DateTime inicio1 = new DateTime(fechaMes1.Year, fechaMes1.Month, 1);
                DateTime fin1 = inicio1.AddMonths(1).AddDays(-1);

                DateTime fechaMes2 = dtpMes2.Value;
                DateTime inicio2 = new DateTime(fechaMes2.Year, fechaMes2.Month, 1);
                DateTime fin2 = inicio2.AddMonths(1).AddDays(-1);
                if (inicio1.Year == inicio2.Year && inicio1.Month == inicio2.Month)
                {
                    MessageBox.Show("Debe seleccionar dos meses diferentes para realizar la comparación.", "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chGrafica.Series.Clear();
                    chGrafica.Titles.Clear();
                    return;
                }
                List<ProductoComparativo> datos = controlador.ObtenerComparativoVentas(inicio1, fin1, inicio2, fin2);
                ConfigurarGrafica(datos, inicio1, inicio2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte comparativo: " + ex.Message, "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Configura y dibuja la gráfica de barras comparativa.
        /// </summary>
        private void ConfigurarGrafica(List<ProductoComparativo> datos, DateTime inicio1, DateTime inicio2)
        {
            chGrafica.Series.Clear();
            chGrafica.ChartAreas.Clear();
            chGrafica.Titles.Clear();
            if (chGrafica.ChartAreas.Count > 0)
            {
                chGrafica.ChartAreas[0].AxisX.CustomLabels.Clear();
            }
            chGrafica.Titles.Add("Comparativa entre meses");
            ChartArea chartArea = new ChartArea();
            chGrafica.ChartAreas.Add(chartArea);
            string nombrePeriodo1 = inicio1.ToString("MMMM yyyy");
            string nombrePeriodo2 = inicio2.ToString("MMMM yyyy");

            Series serie1 = new Series($"Ventas del mes:\n{nombrePeriodo1}")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Wheat,
                IsValueShownAsLabel = false,
                IsXValueIndexed = true,
                XValueType = ChartValueType.String
            };

            Series serie2 = new Series($"Ventas del mes:\n{nombrePeriodo2}")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Brown,
                IsValueShownAsLabel = false,
                IsXValueIndexed = true,
                XValueType = ChartValueType.String
            };

            for (int i = 0; i < datos.Count; i++)
            {
                var producto = datos[i];
                string xLabel = producto.Nombre;
                serie1.Points.AddXY(xLabel, producto.MontoPeriodo1);
                serie2.Points.AddXY(xLabel, producto.MontoPeriodo2);
                serie1.Points[i].AxisLabel = xLabel + "\n" + producto.Clave;
            }

            chGrafica.Series.Add(serie1);
            chGrafica.Series.Add(serie2);

            chartArea.AxisY.LabelStyle.Format = "$#,##0.00";
            chartArea.AxisY.Interval = 500;
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Maximum = 5000;

            chGrafica.Legends[0].Docking = Docking.Bottom;
            chGrafica.Legends[0].Alignment = StringAlignment.Center;
            chartArea.AxisX.IsMarginVisible = false;

            chGrafica.DataBind();
        }



        private void btnexpo_Click(object sender, EventArgs e)
        {

        }
    }
}