using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Backend
{
    public class Auditoria
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Accion { get; set; } // Insert, Update, Delete
        public string ValorAnterior { get; set; }
        public string ValorNuevo { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }

        public Auditoria() { }
    }
}
