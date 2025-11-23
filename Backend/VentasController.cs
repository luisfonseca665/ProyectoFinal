using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProyectoFinal.Backend
{
    public class VentasController
    {
        public class DetalleVentaModelo
        {
            public string CodigoProducto { get; set; }
            public int Cantidad { get; set; }
            public decimal Precio { get; set; }
        }

        private Conexion Conexion = new Conexion();

        public DataTable ObtenerEmpleados()
        {
            using (MySqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, CONCAT(nombre, ' ', apellidos) as NombreCompleto FROM empleados WHERE activo = true";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
                catch
                {
                    return null;
                }
            }
        }

        public DataTable BuscarProductoPorCodigo(string codigo)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = Conexion.ObtenerConexion())
            {
                string query = "SELECT codigo, nombre, precio, stock FROM productos WHERE codigo = @codigo";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    conn.Open();
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en base de datos: " + ex.Message);
                }
            }

            return dt;
        }

        public bool RegistrarVenta(int idEmpleado, decimal total, List<DetalleVentaModelo> listaProductos, out string mensaje)
        {
            mensaje = string.Empty;

            using (MySqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    MySqlTransaction transaccion = conn.BeginTransaction();

                    try
                    {
                        MySqlCommand cmdVenta = new MySqlCommand("spinsertventa", conn);
                        cmdVenta.CommandType = CommandType.StoredProcedure;
                        cmdVenta.Transaction = transaccion;

                        cmdVenta.Parameters.AddWithValue("pidempleado", idEmpleado);
                        cmdVenta.Parameters.AddWithValue("ptotal", total);
                        cmdVenta.Parameters.Add("pidventa", MySqlDbType.Int32).Direction = ParameterDirection.Output;

                        cmdVenta.ExecuteNonQuery();

                        int idVentaGenerada = Convert.ToInt32(cmdVenta.Parameters["pidventa"].Value);

                        foreach (var producto in listaProductos)
                        {
                            MySqlCommand cmdDetalle = new MySqlCommand("spinsertdetalle_updatestock", conn);
                            cmdDetalle.CommandType = CommandType.StoredProcedure;
                            cmdDetalle.Transaction = transaccion;

                            cmdDetalle.Parameters.AddWithValue("pidventa", idVentaGenerada);
                            cmdDetalle.Parameters.AddWithValue("pcodigo", producto.CodigoProducto);
                            cmdDetalle.Parameters.AddWithValue("pcantidad", producto.Cantidad);
                            cmdDetalle.Parameters.AddWithValue("pprecio", producto.Precio);

                            cmdDetalle.ExecuteNonQuery();
                        }

                        transaccion.Commit();
                        mensaje = "Venta registrada con éxito. ID: " + idVentaGenerada;
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                        mensaje = ex.Message;
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    return false;
                }
            }
        }
    }
}