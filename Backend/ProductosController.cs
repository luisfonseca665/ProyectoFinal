using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinal.Backend
{

    /// <summary>
    /// proporciona métodos para gestionar productos en la base de datos.
    /// </summary>
    public class ProductosController
    {
        private Conexion Conexion = new Conexion();

        /// <summary>
        /// Metodo para obtener los productos disponibles para la venta
        /// </summary>
        /// <returns></returns>
        public DataTable ObtenerProductosParaVenta()
        {
            using (MySqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT codigo, nombre, precio, stock, foto FROM productos WHERE descontinuado = FALSE AND stock > 0";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }


        /// <summary>
        /// Recibe la lista de productos desde la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();
            string spName = "spgetproductos";

            using (MySqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(spName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productos.Add(new Producto
                            {
                                Codigo = reader["codigo"].ToString(),
                                Nombre = reader["nombre"].ToString(),
                                Descripcion = reader["descripcion"].ToString(),
                                Precio = reader.GetDecimal("precio"),
                                Stock = reader.GetInt32("stock"),
                                Descontinuado = reader.GetBoolean("descontinuado"),
                                Foto = reader["foto"] is DBNull ? null : (byte[])reader["foto"]
                            });
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            return productos;
        }


        /// <summary>
        /// Inserta un nuevo producto en la base de datos utilizando un procedimiento almacenado
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool InsertarProducto(Producto producto)
        {
            if (string.IsNullOrEmpty(producto.Codigo) || producto.Precio <= 0)
            {
                return false;
            }

            string spName = "spinsertproducto";
            using (MySqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();

                    string usuario = Sesion.UsuarioActual;
                    string sqlUsuario = $"SET @usuario_actual = '{usuario}';";
                    using (MySqlCommand cmdUser = new MySqlCommand(sqlUsuario, conn))
                    {
                        cmdUser.ExecuteNonQuery();
                    }

                    MySqlCommand cmd = new MySqlCommand(spName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pcodigo", producto.Codigo);
                    cmd.Parameters.AddWithValue("pnombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("pdescripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("pprecio", producto.Precio);
                    cmd.Parameters.AddWithValue("pstock", producto.Stock);

                    MySqlParameter fotoParam = new MySqlParameter("pfoto", MySqlDbType.Blob);
                    if (producto.Foto != null && producto.Foto.Length > 0)
                    {
                        fotoParam.Value = producto.Foto;
                    }
                    else
                    {
                        fotoParam.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(fotoParam);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error SQL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


        /// <summary>
        /// Metodo para actualizar un producto existente en la base de datos utilizando un procedimiento almacenado
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool ActualizarProducto(Producto producto)
        {
            if (string.IsNullOrEmpty(producto.Codigo))
            {
                MessageBox.Show("El Código es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (producto.Precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string spName = "spupdateproducto";
            using (MySqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();

                    string usuario = Sesion.UsuarioActual;
                    string sqlUsuario = $"SET @usuario_actual = '{usuario}';";
                    using (MySqlCommand cmdUser = new MySqlCommand(sqlUsuario, conn))
                    {
                        cmdUser.ExecuteNonQuery();
                    }

                    MySqlCommand cmd = new MySqlCommand(spName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("pcodigo", producto.Codigo);
                    cmd.Parameters.AddWithValue("pnombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("pdescripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("pprecio", producto.Precio);
                    cmd.Parameters.AddWithValue("pstock", producto.Stock);
                    cmd.Parameters.AddWithValue("pdescontinuado", producto.Descontinuado);

                    MySqlParameter fotoParam = new MySqlParameter("pfoto", MySqlDbType.Blob);
                    fotoParam.Value = (producto.Foto != null && producto.Foto.Length > 0) ? (object)producto.Foto : DBNull.Value;
                    cmd.Parameters.Add(fotoParam);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error SQL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


        /// <summary>
        /// Metodo para eliminar un producto de la base de datos utilizando un procedimiento almacenado
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public bool EliminarProducto(string codigo)
        {
            string spName = "spdeleteproducto";
            using (MySqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();

                    string usuario = Sesion.UsuarioActual;
                    string sqlUsuario = $"SET @usuario_actual = '{usuario}';";
                    using (MySqlCommand cmdUser = new MySqlCommand(sqlUsuario, conn))
                    {
                        cmdUser.ExecuteNonQuery();
                    }

                    MySqlCommand cmd = new MySqlCommand(spName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("pcodigo", codigo);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error SQL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}