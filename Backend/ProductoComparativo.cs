using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Backend
{
    /// <summary>
    /// Nos da el get y set de los productos comparativos
    /// </summary>
    public class ProductoComparativo
    {
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public int unidadesPeriodo1 { get; set; }
        public int unidadesPeriodo2 { get; set; }
        public decimal MontoPeriodo1 { get; set; }
        public decimal MontoPeriodo2 { get; set; }

    }
}
