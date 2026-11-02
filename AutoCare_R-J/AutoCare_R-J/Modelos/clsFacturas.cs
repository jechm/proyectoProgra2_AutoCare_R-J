using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCare_R_J.Modelos
{
    internal class clsFacturas
    {
        string strCodigo;
        double dblPrecio;
        double dblDescuento;
        double dblSubtotal;
        double dblTotal;
        string strDescripcionServicio;
        string strServicio;
        string strVehiculo;
        string strFecha;
        string strRepuesto;
        string strPrecioRepuesto; 

        // Constructor vacío de la clase facturas
        public clsFacturas() { }

        // Método constructor de la clase facturas
        public clsFacturas(string strCodigo, double dblPrecio, double dblDescuento,
            double dblSubtotal, double dblTotal, string strDescripcionServicio,
            string strServicio, string strVehiculo, string strFecha,
            string strRepuesto, string strPrecioRepuesto)
        {
            this.strCodigo = strCodigo;
            this.dblPrecio = dblPrecio;
            this.dblDescuento = dblDescuento;
            this.dblSubtotal = dblSubtotal;
            this.dblTotal = dblTotal;
            this.strDescripcionServicio = strDescripcionServicio;
            this.strServicio = strServicio;
            this.strVehiculo = strVehiculo;
            this.strFecha = strFecha;
            this.strRepuesto = strRepuesto;
            this.strPrecioRepuesto = strPrecioRepuesto;
        }

        // Getters y setters de la clase facturas
        public string Codigo { get => strCodigo; set => strCodigo = value; }
        public double Precio { get => dblPrecio; set => dblPrecio = value; }
        public double Descuento { get => dblDescuento; set => dblDescuento = value; }
        public double Subtotal { get => dblSubtotal; set => dblSubtotal = value; }
        public double Total { get => dblTotal; set => dblTotal = value; }
        public string DescripcionServicio { get => strDescripcionServicio; set => strDescripcionServicio = value; }
        public string Servicio { get => strServicio; set => strServicio = value; }
        public string Vehiculo { get => strVehiculo; set => strVehiculo = value; }
        public string Fecha { get => strFecha; set => strFecha = value; }
        public string Repuesto { get => strRepuesto; set => strRepuesto = value; }
        public string PrecioRepuesto { get => strPrecioRepuesto; set => strPrecioRepuesto = value; }
    }
}