using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinal.Backend
{
    public class EmpleadoController
    {
        private Conexion Conexion = new Conexion();

        public Empleado Login(string usuario, string contra)
        {
            Empleado empleado = null;
            string query = "SELECT id, nombre, apellidos, usuario, correo, telefono, tipo, foto, activo FROM empleados WHERE usuario = @usuario AND password = SHA2(@contra, 256) AND activo = true";

            using (MySqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contra", contra);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            empleado = new Empleado
                            {
                                Id = Convert.ToInt32(dr["id"]),
                                Nombre = dr["nombre"].ToString(),
                                Apellidos = dr["apellidos"].ToString(),
                                Usuario = dr["usuario"].ToString(),
                                Correo = dr["correo"].ToString(),
                                Telefono = dr["telefono"].ToString(),
                                Tipo = dr["tipo"].ToString(),
                                Foto = dr["foto"] is DBNull ? null : (byte[])dr["foto"],
                                Activo = Convert.ToBoolean(dr["activo"])
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return empleado;
        }

        public List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> lista = new List<Empleado>();
            string query = "SELECT id, nombre, apellidos, telefono, correo, usuario, tipo, foto, activo FROM empleados WHERE activo = true";

            using (MySqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Empleado
                            {
                                Id = Convert.ToInt32(dr["id"]),
                                Nombre = dr["nombre"].ToString(),
                                Apellidos = dr["apellidos"].ToString(),
                                Telefono = dr["telefono"].ToString(),
                                Correo = dr["correo"].ToString(),
                                Usuario = dr["usuario"].ToString(),
                                Tipo = dr["tipo"].ToString(),
                                Foto = dr["foto"] is DBNull ? null : (byte[])dr["foto"],
                                Activo = Convert.ToBoolean(dr["activo"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return lista;
        }

        public bool InsertarEmpleado(Empleado empleado)
        {
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

                    using (MySqlCommand cmd = new MySqlCommand("spinsertempleado", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("pnombre", empleado.Nombre);
                        cmd.Parameters.AddWithValue("papellidos", empleado.Apellidos);
                        cmd.Parameters.AddWithValue("ptelefono", empleado.Telefono);
                        cmd.Parameters.AddWithValue("pcorreo", empleado.Correo);
                        cmd.Parameters.AddWithValue("pusuario", empleado.Usuario);
                        cmd.Parameters.AddWithValue("ppassword", empleado.Password);
                        cmd.Parameters.AddWithValue("ptipo", empleado.Tipo);

                        MySqlParameter fotoParam = new MySqlParameter("pfoto", MySqlDbType.Blob);
                        fotoParam.Value = (empleado.Foto != null) ? (object)empleado.Foto : DBNull.Value;
                        cmd.Parameters.Add(fotoParam);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        public bool ActualizarEmpleado(Empleado empleado)
        {
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

                    using (MySqlCommand cmd = new MySqlCommand("spupdateempleado", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("pid", empleado.Id);
                        cmd.Parameters.AddWithValue("pnombre", empleado.Nombre);
                        cmd.Parameters.AddWithValue("papellidos", empleado.Apellidos);
                        cmd.Parameters.AddWithValue("ptelefono", empleado.Telefono);
                        cmd.Parameters.AddWithValue("pcorreo", empleado.Correo);
                        cmd.Parameters.AddWithValue("pusuario", empleado.Usuario);
                        cmd.Parameters.AddWithValue("ppassword", empleado.Password ?? "");
                        cmd.Parameters.AddWithValue("ptipo", empleado.Tipo);
                        cmd.Parameters.AddWithValue("pactivo", true);

                        MySqlParameter fotoParam = new MySqlParameter("pfoto", MySqlDbType.Blob);
                        fotoParam.Value = (empleado.Foto != null) ? (object)empleado.Foto : DBNull.Value;
                        cmd.Parameters.Add(fotoParam);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        public bool EliminarEmpleado(int id)
        {
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

                    using (MySqlCommand cmd = new MySqlCommand("spdeleteempleado", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("pid", id);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
    }
}