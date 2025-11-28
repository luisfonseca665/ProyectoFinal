using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ProyectoFinal.Backend;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoFinal.Frontend
{
    /// <summary>
    /// Representa el formulario para generar reportes de ventas.
    /// </summary>
    public partial class FrmReportes : Form
    {
        ReportesController controlador = new ReportesController();
        private List<ProductoComparativo> _datosComparativos;


        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FrmReportes"/>.
        /// </summary>
        public FrmReportes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cargar el formulario y establecer fechas predeterminadas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReportes_Load(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            dtpInicio.Value = new DateTime(hoy.Year, hoy.Month, 1);
            dtpFin.Value = hoy;
            dtpMes1.Value = new DateTime(hoy.Year, hoy.Month, 1);
            dtpMes2.Value = hoy.AddMonths(-1);
        }


        /// <summary>
        /// Boton que genera el reporte de ventas por rango de fechas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Boton para exportar el reporte de ventas a Excel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvReporte.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            ExportarExcel();
        }

        /// <summary>
        /// Boton para exportar el reporte de ventas a Excel y ventas.
        /// </summary>
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

        /// <summary>
        /// Boton para generar el documento excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                _datosComparativos = datos;

                ConfigurarGrafica(datos, inicio1, inicio2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte comparativo: " + ex.Message, "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodo para configurar la grafica
        /// </summary>
        /// <param name="datos"></param>
        /// <param name="inicio1"></param>
        /// <param name="inicio2"></param>
        private void ConfigurarGrafica(List<ProductoComparativo> datos, DateTime inicio1, DateTime inicio2)
        {
            chGrafica.Series.Clear();
            chGrafica.ChartAreas.Clear();
            chGrafica.Titles.Clear();
            chGrafica.Legends.Clear();

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

            Legend legend = new Legend();
            chGrafica.Legends.Add(legend);
            chGrafica.Legends[0].Docking = Docking.Bottom;
            chGrafica.Legends[0].Alignment = StringAlignment.Center;

            chartArea.AxisY.LabelStyle.Format = "$#,##0.00";
            chartArea.AxisY.Interval = 500;
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Maximum = 5000;

            chartArea.AxisX.IsMarginVisible = false;

            chGrafica.DataBind();
        }

        /// <summary>
        /// Boton para exportar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnexpo_Click(object sender, EventArgs e)
        {
            if (_datosComparativos == null || _datosComparativos.Count == 0)
            {
                MessageBox.Show("Primero genere la gráfica comparativa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ExportarComparativoExcel();
        }

        /// <summary>
        /// Metodo para exportar la grafica en excel
        /// </summary>
        private void ExportarComparativoExcel()
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            try
            {
                worksheet.Cells[2, 2] = "Reporte Comparativo de Ventas";
                worksheet.Range["B2"].Font.Bold = true;
                worksheet.Range["B2"].Font.Size = 14;

                worksheet.Cells[4, 2] = "Periodo 1:";
                worksheet.Cells[4, 3] = dtpMes1.Value.ToString("MMMM yyyy");

                worksheet.Cells[5, 2] = "Periodo 2:";
                worksheet.Cells[5, 3] = dtpMes2.Value.ToString("MMMM yyyy");

                int fila = 8;
                worksheet.Cells[fila, 2] = "Producto";
                worksheet.Cells[fila, 3] = "Ventas Mes 1";
                worksheet.Cells[fila, 4] = "Ventas Mes 2";
                worksheet.Cells[fila, 5] = "Diferencia ($)";

                Excel.Range headers = worksheet.Range[$"B{fila}:E{fila}"];
                headers.Font.Bold = true;
                headers.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                headers.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                fila++;

                foreach (var item in _datosComparativos)
                {
                    worksheet.Cells[fila, 2] = item.Nombre;
                    worksheet.Cells[fila, 3] = item.MontoPeriodo1;
                    worksheet.Cells[fila, 4] = item.MontoPeriodo2;
                    worksheet.Cells[fila, 5] = item.MontoPeriodo2 - item.MontoPeriodo1;
                    fila++;
                }

                Excel.Range rangoDatos = worksheet.Range[$"C9:E{fila - 1}"];
                rangoDatos.NumberFormat = "$ #,##0.00";

                Excel.Range todoRango = worksheet.Range[$"B8:E{fila - 1}"];
                todoRango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                worksheet.Columns.AutoFit();

                string tempPath = Path.GetTempFileName() + ".png";
                chGrafica.SaveImage(tempPath, ChartImageFormat.Png);

                int filaImagen = fila + 2;
                Excel.Range rangoImagen = worksheet.Range[$"B{filaImagen}"];

                dynamic shapes = worksheet.Shapes;
                shapes.AddPicture(tempPath, 0, 1, rangoImagen.Left, rangoImagen.Top, 400, 250);

                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message);
                excelApp.Quit();
            }
        }


        /// <summary>
        /// Cargar los componentes en el panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            DateTime hoy = DateTime.Now;
            dtpInicio.Value = new DateTime(hoy.Year, hoy.Month, 1);
            tbpComparativo.Controls.Add(chGrafica);
            chGrafica.Dock = DockStyle.Fill;
            chGrafica.Location = new Point(30, 200);
            chGrafica.Size = new Size(876, 418);
            chGrafica.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }
    }
}