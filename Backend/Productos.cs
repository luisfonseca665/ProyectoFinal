using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Backend
{
    public class Producto
    {
        public string Codigo { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public bool Descontinuado { get; set; }
        public byte[] Foto { get; set; }

        public Producto() { }
    }
}
