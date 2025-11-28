using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Backend
{
    /// <summary>
    /// Get y Set de los empleados
    /// </summary>
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Tipo { get; set; }
        public byte[] Foto { get; set; }
        public bool Activo { get; set; }
    }
}
