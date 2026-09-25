using System;
using AutoCare_R_J.Modelos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCare_R_J.Controladores
{
    internal class clsManejadorFacturas
    {
        //Creacion de objeto de la clase facturas
        clsFacturas obFactura = new clsFacturas();

        //Creacion de metodo para agregar una factura
        public void AgregarFactura(string strCodigo, double dblPrecio, 
            double dblDescuento, double dblSubtotal, 
            double dblTotal, string strDescripcionServicio, 
            string strServicio, string strVehiculo, 
            string strFecha, string strRepuesto, 
            double dblPrecioRepuesto)
        {
            obFactura.Codigo = strCodigo;
            obFactura.Precio = dblPrecio;
            obFactura.Descuento = dblDescuento;
            obFactura.Subtotal = dblSubtotal;
            obFactura.Total = dblTotal;
            obFactura.DescripcionServicio = strDescripcionServicio;
            obFactura.Servicio = strServicio;
            obFactura.Vehiculo = strVehiculo;
            obFactura.Fecha = strFecha;
            obFactura.Repuesto = strRepuesto;
            obFactura.PrecioRepuesto = dblPrecioRepuesto;
        }
    }
}
