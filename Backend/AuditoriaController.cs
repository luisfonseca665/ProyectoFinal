using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProyectoFinal.Backend
{
    /// <summary>
    /// Clase para manejar la auditoría
    /// </summary>
    public class AuditoriaController
    {

        /// <summary>
        /// Menoto para obtener la auditoría completa
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Auditoria> ObtenerAuditoria()
        {
            List<Auditoria> lista = new List<Auditoria>();

            using (MySqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("spGetAuditoriaTotal", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Auditoria()
                                {
                                    Origen = reader["origen"].ToString(),
                                    Referencia = reader["referencia"].ToString(),
                                    Accion = reader["accion"].ToString(),

                                    ValorAnterior = reader["valoranterior"] != DBNull.Value ? reader["valoranterior"].ToString() : "",
                                    ValorNuevo = reader["valornuevo"] != DBNull.Value ? reader["valornuevo"].ToString() : "",

                                    Usuario = reader["usuario"].ToString(),
                                    Fecha = Convert.ToDateTime(reader["fecha"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al leer auditoría: " + ex.Message);
                }
            }
            return lista;
        }
    }
}