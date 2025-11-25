using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ProyectoFinal.Backend;
using Excel = Microsoft.Office.Interop.Excel;

namespace ProyectoFinal.Frontend
{
    public partial class FrmReportes : Form
    {
        ReportesController controlador = new ReportesController();

        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            dtpInicio.Value = new DateTime(hoy.Year, hoy.Month, 1);
            dtpFin.Value = hoy;
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
    }
}