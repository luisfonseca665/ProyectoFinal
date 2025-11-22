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
                // Podrías lanzar una excepción o registrar un error aquí
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

                    cmd.Parameters.AddWithValue("pcodigo", producto.Codigo);
                    cmd.Parameters.AddWithValue("pnombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("pdescripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("pprecio", producto.Precio);
                    cmd.Parameters.AddWithValue("pstock", producto.Stock);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (MySqlException ex)
                {
                    System.Console.WriteLine($"Error al insertar producto ({spName}): {ex.Message}");
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
                    cmd.Parameters.AddWithValue("pfoto", producto.Foto ?? (object)DBNull.Value);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (MySqlException ex)
                {
                    System.Console.WriteLine($"Error al actualizar producto ({spName}): {ex.Message}");
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
