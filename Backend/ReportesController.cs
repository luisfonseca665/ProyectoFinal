using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace ProyectoFinal.Backend
{
    public class ReportesController
    {
        private Conexion Conexion = new Conexion();

        /// <summary>
        /// Obtiene un DataTable con las ventas totales y unidades por producto para un rango de fechas.
        /// </summary>
        public DataTable ObtenerVentasPorRango(DateTime inicio, DateTime fin)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = Conexion.ObtenerConexion())
            {
                DateTime pInicio = inicio.Date;
                DateTime pFin = fin.Date.AddDays(1).AddSeconds(-1);

                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("spReporteVentasPorProducto", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("pInicio", pInicio);
                        cmd.Parameters.AddWithValue("pFin", pFin);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    throw new Exception("Error al obtener ventas por rango: " + ex.Message);
                }
            }
            return dt;
        }

        /// <summary>
        /// Combina los resultados de ventas de dos periodos en una lista comparativa.
        /// </summary>
        public List<ProductoComparativo> ObtenerComparativoVentas(DateTime inicio1, DateTime fin1, DateTime inicio2, DateTime fin2)
        {
            DataTable dtPeriodo1 = ObtenerVentasPorRango(inicio1, fin1);
            DataTable dtPeriodo2 = ObtenerVentasPorRango(inicio2, fin2);
            var clavesPeriodo1 = dtPeriodo1.AsEnumerable().Select(r => r.Field<string>("Clave")).ToList();
            var clavesPeriodo2 = dtPeriodo2.AsEnumerable().Select(r => r.Field<string>("Clave")).ToList();
            var todasLasClaves = clavesPeriodo1.Union(clavesPeriodo2).Distinct();
            var listaComparativa = new List<ProductoComparativo>();

            foreach (string clave in todasLasClaves)
            {
                var producto = new ProductoComparativo { Clave = clave };
                DataRow[] fila1 = dtPeriodo1.Select($"Clave = '{clave}'");
                if (fila1.Length > 0)
                {
                    producto.Nombre = fila1[0].Field<string>("Nombre");
                    producto.MontoPeriodo1 = fila1[0].Field<decimal>("Monto");
                    producto.unidadesPeriodo1 = Convert.ToInt32(fila1[0]["Unidades"]);
                }

                DataRow[] fila2 = dtPeriodo2.Select($"Clave = '{clave}'");
                if (fila2.Length > 0)
                {
                    if (string.IsNullOrEmpty(producto.Nombre))
                    {
                        producto.Nombre = fila2[0].Field<string>("Nombre");
                    }
                    producto.MontoPeriodo2 = fila2[0].Field<decimal>("Monto");
                    producto.unidadesPeriodo2 = Convert.ToInt32(fila2[0]["Unidades"]);
                }

                listaComparativa.Add(producto);
            }
            return listaComparativa.OrderByDescending(p => p.MontoPeriodo1 + p.MontoPeriodo2).ToList();
        }
    }
}