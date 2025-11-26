using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Backend
{
    public class Conexion
    {
        private static string cadena = "server=localhost;database=ventas;user=root;password=1234; Allow User Variables=True;";
        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadena);
        }
    }
}
