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
        //Creacion de la lista de facturas
        List<clsFacturas> lstFacturas = new List<clsFacturas>();

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
            try
            {
                //Aqui se agrego la logica de creacion de una factura
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

                //Se agregara el objeto factura a la lista de facturas
                lstFacturas.Add(obFactura);
            }
            catch (Exception ex)
            {
                //Aqui se puede agregar la logica para manejar la excepcion
                throw new Exception("Error al agregar la factura: " + ex.Message);
            }
        }

        public void BuscarFactura(string strCodigo)
        {
            //Aqui se agrego la logica para buscar una factura en una base de datos o lista
            Producto facturaEncontrada = lstFacturas.FirstOrDefault(f => f.Codigo == strCodigo);
            if (facturaEncontrada != null)
            {
            }
            else
            {
                //Aqui se agrego la logica para manejar el caso en que no se encuentre la factura
                throw new Exception("Factura no encontrada");
            }
        }
    }
}
