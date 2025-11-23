using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Backend
{
    public class AuditoriaController
    {
        public List<Auditoria> ObtenerAuditoria()
        {
            List<Auditoria> lista = new List<Auditoria>();

            using (MySqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM auditoriaproductos ORDER BY fecha DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Auditoria aud = new Auditoria();
                                aud.Id = Convert.ToInt32(reader["id"]);
                                aud.Codigo = reader["codigo"].ToString();
                                aud.Accion = reader["accion"].ToString();

                                aud.ValorAnterior = Convert.ToString(reader["valoranterior"]);
                                aud.ValorNuevo = Convert.ToString(reader["valornuevo"]);
                                aud.Usuario = reader["usuario"].ToString();
                                aud.Fecha = Convert.ToDateTime(reader["fecha"]);
                                lista.Add(aud);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer auditoría: " + ex.Message);
                }
            }

            return lista;
        }
    }
}
