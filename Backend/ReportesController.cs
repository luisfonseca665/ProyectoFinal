using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProyectoFinal.Backend
{
    public class ReportesController
    {
        private Conexion Conexion = new Conexion();

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
                    throw new Exception(ex.Message);
                }
            }
            return dt;
        }
    }
}