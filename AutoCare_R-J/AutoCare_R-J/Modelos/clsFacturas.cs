using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCare_R_J.Modelos
{
    internal class clsFacturas
    {
        // Properties used by clsManejadorFacturas
        public string Codigo { get; set; }
        public double Precio { get; set; }
        public double Descuento { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }
        public string DescripcionServicio { get; set; }
        public string Servicio { get; set; }
        public string Vehiculo { get; set; }
        public string Fecha { get; set; }
        public string Repuesto { get; set; }
        public double PrecioRepuesto { get; set; }
    }
}
