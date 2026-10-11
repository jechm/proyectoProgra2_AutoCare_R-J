using System;
using System.Collections.Generic;
using System.Linq;
using AutoCare_R_J.Modelos;

namespace AutoCare_R_J.Controladores
{
    internal class clsManejadorFacturas
    {
        // Creación de la lista de facturas
        private List<clsFacturas> lstFacturas = new List<clsFacturas>();

        // Método para generar el siguiente código automático (ej. FAC-001)
        public string ObtenerSiguienteCodigo()
        {
            int siguienteNumero = lstFacturas.Count + 1;
            return $"FAC-{siguienteNumero:D3}";
        }

        // Creación de método para agregar una factura
        public void AgregarFactura(double dblPrecio, double dblDescuento,
            double dblSubtotal, double dblTotal, string strDescripcionServicio,
            string strServicio, string strVehiculo, string strFecha,
            string strRepuesto, double dblPrecioRepuesto)
        {
            try
            {
                clsFacturas nuevaFactura = new clsFacturas();

                nuevaFactura.Codigo = ObtenerSiguienteCodigo();
                nuevaFactura.Precio = dblPrecio;
                nuevaFactura.Descuento = dblDescuento;
                nuevaFactura.Subtotal = dblSubtotal;
                nuevaFactura.Total = dblTotal;
                nuevaFactura.DescripcionServicio = strDescripcionServicio;
                nuevaFactura.Servicio = strServicio;
                nuevaFactura.Vehiculo = strVehiculo;
                nuevaFactura.Fecha = strFecha;
                nuevaFactura.Repuesto = strRepuesto;
                nuevaFactura.PrecioRepuesto = dblPrecioRepuesto;

                lstFacturas.Add(nuevaFactura);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la factura: " + ex.Message);
            }
        }

        // Método para buscar una factura por código o por vehículo
        public clsFacturas BuscarFactura(string strCodigo, string strVehiculo = "")
        {
            clsFacturas facturaEncontrada = lstFacturas.FirstOrDefault(f => f.Codigo == strCodigo || (!string.IsNullOrEmpty(strVehiculo) && f.Vehiculo == strVehiculo));

            if (facturaEncontrada == null)
            {
                throw new Exception("Factura no encontrada");
            }

            return facturaEncontrada;
        }

        // Método para eliminar una factura por código
        public void EliminarFactura(string strCodigo)
        {
            clsFacturas facturaEncontrada = lstFacturas.FirstOrDefault(f => f.Codigo == strCodigo);

            if (facturaEncontrada != null)
            {
                lstFacturas.Remove(facturaEncontrada);
            }
            else
            {
                throw new Exception("Factura no encontrada");
            }
        }

        // Método para modificar una factura
        public void ModificarFactura(string strCodigo, double dblPrecio,
            double dblDescuento, double dblSubtotal, double dblTotal,
            string strDescripcionServicio, string strServicio, string strVehiculo,
            string strFecha, string strRepuesto, double dblPrecioRepuesto)
        {
            clsFacturas facturaEncontrada = lstFacturas.FirstOrDefault(f => f.Codigo == strCodigo);

            if (facturaEncontrada != null)
            {
                facturaEncontrada.Precio = dblPrecio;
                facturaEncontrada.Descuento = dblDescuento;
                facturaEncontrada.Subtotal = dblSubtotal;
                facturaEncontrada.Total = dblTotal;
                facturaEncontrada.DescripcionServicio = strDescripcionServicio;
                facturaEncontrada.Servicio = strServicio;
                facturaEncontrada.Vehiculo = strVehiculo;
                facturaEncontrada.Fecha = strFecha;
                facturaEncontrada.Repuesto = strRepuesto;
                facturaEncontrada.PrecioRepuesto = dblPrecioRepuesto;
            }
            else
            {
                throw new Exception("Factura no encontrada");
            }
        }

        // Método para listar todas las facturas
        public List<clsFacturas> ListarFacturas()
        {
            return lstFacturas;
        }
    }
}