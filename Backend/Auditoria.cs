using System;

namespace ProyectoFinal.Backend
{
    public class Auditoria
    {
        /// <summary>
        /// Get y Set del origen de la accion realizada
        /// </summary>
        public string Origen { get; set; }
        public string Referencia { get; set; }
        public string Accion { get; set; }
        public string ValorAnterior { get; set; }
        public string ValorNuevo { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }

        public Auditoria() { }
    }
}