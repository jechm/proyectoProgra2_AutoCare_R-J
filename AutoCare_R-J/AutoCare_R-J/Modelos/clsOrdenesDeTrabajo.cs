using System;

namespace AutoCare_R_J.Modelos
{
    public class clsOrdenesDeTrabajo
    {
        // Propiedades automáticas de C# (más limpias y evitan errores de definición)
        public string Codigo { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public string Servicio { get; set; }
        public string Vehiculo { get; set; }
        public string Estado { get; set; }
        public string Repuestos { get; set; }

        // Constructor con parámetros
        public clsOrdenesDeTrabajo(string codigo, DateTime fechaRecepcion, string servicio, string vehiculo, string estado, string repuestos)
        {
            Codigo = codigo;
            FechaRecepcion = fechaRecepcion;
            Servicio = servicio;
            Vehiculo = vehiculo;
            Estado = estado;
            Repuestos = repuestos;
        }

        // Constructor vacío
        public clsOrdenesDeTrabajo()
        {
        }
    }
}