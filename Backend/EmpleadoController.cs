using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;

namespace ProyectoFinal.Backend
{
    public class EmpleadoController
    {
        /// Inicio de sesión buscando el usuario y la contraseña (hasheada con SHA2-256) y que esté activo.
        public Empleado Login(string usuario, string contra)
        {
            Empleado empleado = null;
            string query = "select id, nombre, apellidos, usuario, correo, telefono, tipo, foto, activo from empleados " +
                           "where usuario = @usuario and password = SHA2(@contra, 256) and activo = true";

            using (MySqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contra", contra); 

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    empleado = new Empleado()
                    {
                        Id = dr.GetInt32("id"),
                        Nombre = dr.GetString("nombre"),
                        Apellidos = dr.GetString("apellidos"),
                        Usuario = dr.GetString("usuario"),
                        Correo = dr.GetString("correo"),
                        Telefono = dr.GetString("telefono"),
                        Tipo = dr.GetString("tipo"),
                        Activo = dr.GetBoolean("activo")
                    };

                    if (!dr.IsDBNull(dr.GetOrdinal("foto")))
                    {
                        long len = dr.GetBytes(dr.GetOrdinal("foto"), 0, null, 0, 0);
                        byte[] buffer = new byte[len];
                        dr.GetBytes(dr.GetOrdinal("foto"), 0, buffer, 0, (int)len);
                        empleado.Foto = buffer;
                    }
                }
            }
            return empleado;
        }

        /// Registra un nuevo empleado en la base de datos, hasheando la contraseña automáticamente.
        public bool Registrar(Empleado e)
        {
            string query = "call spinsertempleado(@pnombre, @papellidos, @ptelefono, @pcorreo, @pusuario, SHA2(@ppassword, 256), @ptipo, @pfoto)";

            using (MySqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@pnombre", e.Nombre);
                cmd.Parameters.AddWithValue("@papellidos", e.Apellidos);
                cmd.Parameters.AddWithValue("@ptelefono", e.Telefono);
                cmd.Parameters.AddWithValue("@pcorreo", e.Correo);
                cmd.Parameters.AddWithValue("@pusuario", e.Usuario);

                cmd.Parameters.AddWithValue("@ppassword", e.Password);
                cmd.Parameters.AddWithValue("@ptipo", e.Tipo);

                cmd.Parameters.Add("@pfoto", MySqlDbType.Blob, e.Foto?.Length ?? 0).Value = e.Foto ?? (object)DBNull.Value;

                return cmd.ExecuteNonQuery() > 0;
            }
        }


        /// Obtenemos todos los empleados (activos e inactivos) en un DataTable.
        public DataTable Empleados()
        {
            DataTable dt = new DataTable();
            string query = "select foto, id, nombre, apellidos, usuario, correo, telefono, tipo, activo from empleados";

            try
            {
                using (MySqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();
                    MessageBox.Show("✅ Conexión OK");

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    da.Fill(dt);

                    MessageBox.Show("Filas cargadas: " + dt.Rows.Count);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ ERROR: " + ex.Message);
            }

            return dt;
        }


        public bool Eliminar(int id)
        {
            using (MySqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("spdeleteempleado", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@pid", id);

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool Actualizar(Empleado e)
        {
            using (MySqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("spupdateempleado", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pid", e.Id);
                cmd.Parameters.AddWithValue("@pnombre", e.Nombre);
                cmd.Parameters.AddWithValue("@papellidos", e.Apellidos);
                cmd.Parameters.AddWithValue("@ptelefono", e.Telefono);
                cmd.Parameters.AddWithValue("@pcorreo", e.Correo);
                cmd.Parameters.AddWithValue("@pusuario", e.Usuario);
                cmd.Parameters.AddWithValue("@ppassword", e.Password);
                cmd.Parameters.AddWithValue("@ptipo", e.Tipo);
                cmd.Parameters.Add("@pfoto", MySqlDbType.Blob, e.Foto?.Length ?? 0).Value = e.Foto ?? (object)DBNull.Value;
                cmd.Parameters.AddWithValue("@pactivo", true);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}