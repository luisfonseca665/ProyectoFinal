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
                string fechaInicio = inicio.ToString("yyyy-MM-dd 00:00:00");
                string fechaFin = fin.ToString("yyyy-MM-dd 23:59:59");

                string query = @"
                    SELECT 
                        P.codigo AS 'Clave',
                        P.nombre AS 'Nombre',
                        SUM(DV.cantidad) AS 'Unidades',
                        SUM(DV.cantidad * DV.precio) AS 'Monto'
                    FROM ventas V
                    INNER JOIN detalleventas DV ON V.id = DV.idventa
                    INNER JOIN productos P ON DV.codigoproducto = P.codigo
                    WHERE V.fecha BETWEEN @Inicio AND @Fin
                    GROUP BY P.codigo, P.nombre
                    ORDER BY Monto DESC";

                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Inicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@Fin", fechaFin);

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