using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProyectoFinal.Backend
{
    /// <summary>
    /// Proporciona métodos para manejar las ventas
    /// </summary>
    public class VentasController
    {
        /// <summary>
        /// Representa el detalle de una venta
        /// </summary>
        public class DetalleVentaModelo
        {
            public string CodigoProducto { get; set; }
            public int Cantidad { get; set; }
            public decimal Precio { get; set; }
        }

        private Conexion Conexion = new Conexion();


        /// <summary>
        /// Metodo para obtener los empleados activos
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Metodo para buscar un producto por su codigo
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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


        /// <summary>
        /// Metodo para registrar una venta
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <param name="total"></param>
        /// <param name="listaProductos"></param>
        /// <param name="mensaje"></param>
        /// <returns></returns>

        public bool RegistrarVenta(int idEmpleado, decimal total, List<DetalleVentaModelo> listaProductos, out string mensaje)
        {
            mensaje = string.Empty;

            using (MySqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();

                    string usuario = string.IsNullOrEmpty(Sesion.UsuarioActual) ? "admin" : Sesion.UsuarioActual;

                    using (MySqlCommand cmdUser = new MySqlCommand($"SET @usuario_actual = '{usuario}';", conn))
                    {
                        cmdUser.ExecuteNonQuery();
                    }

                    MySqlTransaction transaccion = conn.BeginTransaction();

                    try
                    {
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = conn;
                        cmd.Transaction = transaccion;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.CommandText = "spinsertventa";
                        cmd.Parameters.AddWithValue("pidempleado", idEmpleado);
                        cmd.Parameters.AddWithValue("ptotal", total);

                        MySqlParameter paramId = new MySqlParameter("pidventa", MySqlDbType.Int32);
                        paramId.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(paramId);

                        cmd.ExecuteNonQuery();

                        int idVentaGenerada = Convert.ToInt32(paramId.Value);
                        cmd.Parameters.Clear();

                        cmd.CommandText = "spinsertdetalle_updatestock";

                        cmd.Parameters.Add("pidventa", MySqlDbType.Int32);
                        cmd.Parameters.Add("pcodigo", MySqlDbType.VarChar);
                        cmd.Parameters.Add("pcantidad", MySqlDbType.Int32);
                        cmd.Parameters.Add("pprecio", MySqlDbType.Decimal);

                        foreach (var producto in listaProductos)
                        {
                            cmd.Parameters["pidventa"].Value = idVentaGenerada;
                            cmd.Parameters["pcodigo"].Value = producto.CodigoProducto;
                            cmd.Parameters["pcantidad"].Value = producto.Cantidad;
                            cmd.Parameters["pprecio"].Value = producto.Precio;

                            cmd.ExecuteNonQuery();
                        }

                        transaccion.Commit();
                        mensaje = "Venta registrada con éxito. Folio: " + idVentaGenerada;
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                        mensaje = "Error al guardar venta: " + ex.Message;
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    mensaje = "Error de conexión: " + ex.Message;
                    return false;
                }
            }
        }
    }
}