using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Backend
{

    public class ProductosController
    {
        /// <summary>
        ///  Funcion para obtener productos
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
                    System.Console.WriteLine($"Error al obtener productos ({spName}): {ex.Message}");
                }
            }
            return productos;
        }

        /// <summary>
        /// Funcion para insertar productos
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
                    MySqlCommand cmd = new MySqlCommand(spName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros de datos estándar
                    cmd.Parameters.AddWithValue("pcodigo", producto.Codigo);
                    cmd.Parameters.AddWithValue("pnombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("pdescripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("pprecio", producto.Precio);
                    cmd.Parameters.AddWithValue("pstock", producto.Stock);

                    // Parámetro de la foto (BLOB)
                    MySqlParameter fotoParam = new MySqlParameter("pfoto", MySqlDbType.Blob);

                    if (producto.Foto != null && producto.Foto.Length > 0)
                    {
                        fotoParam.Value = producto.Foto;
                    }
                    else
                    {
                        // Envía DBNull.Value para NULL en la base de datos
                        fotoParam.Value = DBNull.Value;
                    }

                    // Añade el parámetro de la foto al comando
                    cmd.Parameters.Add(fotoParam);

                    // Ejecuta el comando
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (MySqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show($"Error de Base de Datos: {ex.Message}", "Error SQL", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        /// <summary>
        /// Funcion para actualizar productos
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool ActualizarProducto(Producto producto)
        {
            // Validación clave para la actualización
            if (string.IsNullOrEmpty(producto.Codigo))
            {
                MessageBox.Show("Error: El Código del producto es obligatorio para la actualización.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Opcional: Validación de precio, si es obligatorio
            if (producto.Precio <= 0)
            {
                MessageBox.Show("Error: El Precio debe ser mayor a cero.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string spName = "spupdateproducto";
            using (MySqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(spName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("pcodigo", producto.Codigo);
                    cmd.Parameters.AddWithValue("pnombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("pdescripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("pprecio", producto.Precio);
                    cmd.Parameters.AddWithValue("pstock", producto.Stock);
                    cmd.Parameters.AddWithValue("pdescontinuado", producto.Descontinuado);

                    MySqlParameter fotoParam = new MySqlParameter("pfoto", MySqlDbType.Blob);
                    fotoParam.Value = (producto.Foto != null && producto.Foto.Length > 0)
                                      ? (object)producto.Foto
                                      : DBNull.Value;

                    cmd.Parameters.Add(fotoParam);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error de Base de Datos al actualizar:\n{ex.Message}", "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        /// <summary>
        ///  funcion para descontinuar/Eliminación Lógica
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
                    MySqlCommand cmd = new MySqlCommand(spName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pcodigo", codigo);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (MySqlException ex)
                {
                    System.Console.WriteLine($"Error al descontinuar producto ({spName}): {ex.Message}");
                    return false;
                }
            }
        }
    }
}
