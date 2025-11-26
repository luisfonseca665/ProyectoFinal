using System;

namespace ProyectoFinal.Backend
{
    public class Auditoria
    {
        public string Origen { get; set; }        // Dice si es "Producto" o "Empleado"
        public string Referencia { get; set; }    // Guarda el Código o el ID
        public string Accion { get; set; }        // Insert, Update, Delete
        public string ValorAnterior { get; set; }
        public string ValorNuevo { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }

        public Auditoria() { }
    }
}