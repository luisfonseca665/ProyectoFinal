using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;

namespace ProyectoFinal.Backend
{
    public class EmpleadoController
    {
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

        /// <summary>
        /// Registrar un nuevo empleado usando un Stored Procedure.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool Registrar(Empleado e)
        {
            if (string.IsNullOrEmpty(e.Nombre) || string.IsNullOrEmpty(e.Usuario) || string.IsNullOrEmpty(e.Password))
            {
                return false;
            }

            string spName = "spinsertempleado";

            using (MySqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(spName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("pnombre", e.Nombre);
                    cmd.Parameters.AddWithValue("papellidos", e.Apellidos);
                    cmd.Parameters.AddWithValue("ptelefono", e.Telefono);
                    cmd.Parameters.AddWithValue("pcorreo", e.Correo);
                    cmd.Parameters.AddWithValue("pusuario", e.Usuario);
                    cmd.Parameters.AddWithValue("ptipo", e.Tipo);
                    cmd.Parameters.AddWithValue("ppassword", e.Password);
                    MySqlParameter fotoParam = new MySqlParameter("pfoto", MySqlDbType.LongBlob);

                    if (e.Foto != null && e.Foto.Length > 0)
                    {
                        fotoParam.Value = e.Foto;
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
                    MessageBox.Show($"Error de Base de Datos: {ex.Message}", "Error SQL", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
            }
        }



        /// <summary>
        /// Recupera todos los empleados de la base de datos.
        /// </summary>
        /// <returns></returns>
        public DataTable Empleados()
        {
            DataTable dt = new DataTable();
            string query = "select foto, id, nombre, apellidos, usuario, correo, telefono, tipo, activo from empleados";

            try
            {
                using (MySqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

            return dt;
        }

        /// <summary>
        /// Eliminamos un empleado por su ID usando un Stored Procedure.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public bool Eliminar(int id)
        {
            if (id <= 0)
            {
                return false;
            }

            string spName = "spdeleteempleado";

            using (MySqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(spName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("pid", id);
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"No se pudo eliminar el registro. Error: {ex.Message}",
                                                         "Error de Base de Datos",
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error inesperado: {ex.Message}", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        /// <summary>
        /// Actualiza la información de un empleado usando un Stored Procedure.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>

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
                cmd.Parameters.Add("@pfoto", MySqlDbType.LongBlob, e.Foto?.Length ?? 0).Value = e.Foto ?? (object)DBNull.Value;
                cmd.Parameters.AddWithValue("@pactivo", true);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}