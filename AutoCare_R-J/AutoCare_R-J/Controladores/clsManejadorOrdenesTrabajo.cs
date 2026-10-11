using System;
using System.Collections.Generic;
using System.Linq;
using AutoCare_R_J.Modelos;

namespace AutoCare_R_J.Controladores
{
    internal class clsManejadorOrdenesTrabajo
    {
        // Creación de la lista de órdenes de trabajo
        private List<clsOrdenesDeTrabajo> lstOrdenesTrabajo = new List<clsOrdenesDeTrabajo>();

        // Método para generar el siguiente código automático (ej. ORD-001)
        public string ObtenerSiguienteCodigo()
        {
            int siguienteNumero = lstOrdenesTrabajo.Count + 1;
            return $"ORD-{siguienteNumero:D3}";
        }

        // Creación de método para agregar una orden de trabajo
        public void AgregarOrdenTrabajo(DateTime dtFechaRecepcion, string strServicio, string strVehiculo, string strEstado, string strRepuestos)
        {
            try
            {
                clsOrdenesDeTrabajo nuevaOrden = new clsOrdenesDeTrabajo();

                nuevaOrden.Codigo = ObtenerSiguienteCodigo();
                nuevaOrden.FechaRecepción = dtFechaRecepcion;
                nuevaOrden.Servicio = strServicio;
                nuevaOrden.Vehiculo = strVehiculo;
                nuevaOrden.Estado = strEstado;
                nuevaOrden.Repuestos = strRepuestos;

                lstOrdenesTrabajo.Add(nuevaOrden);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la orden de trabajo: " + ex.Message);
            }
        }

        // Método para buscar una orden de trabajo por código o por vehículo
        public clsOrdenesDeTrabajo BuscarOrdenTrabajo(string strCodigo, string strVehiculo = "")
        {
            clsOrdenesDeTrabajo ordenEncontrada = lstOrdenesTrabajo.FirstOrDefault(o => o.Codigo == strCodigo || (!string.IsNullOrEmpty(strVehiculo) && o.Vehiculo == strVehiculo));

            if (ordenEncontrada == null)
            {
                throw new Exception("Orden de trabajo no encontrada");
            }

            return ordenEncontrada;
        }

        // Método para eliminar una orden de trabajo
        public void EliminarOrdenTrabajo(string strCodigo)
        {
            clsOrdenesDeTrabajo ordenEncontrada = lstOrdenesTrabajo.FirstOrDefault(o => o.Codigo == strCodigo);

            if (ordenEncontrada != null)
            {
                lstOrdenesTrabajo.Remove(ordenEncontrada);
            }
            else
            {
                throw new Exception("Orden de trabajo no encontrada");
            }
        }

        // Método para modificar una orden de trabajo
        public void ModificarOrdenTrabajo(string strCodigo, DateTime dtFechaRecepcion, string strServicio, string strVehiculo, string strEstado, string strRepuestos)
        {
            clsOrdenesDeTrabajo ordenEncontrada = lstOrdenesTrabajo.FirstOrDefault(o => o.Codigo == strCodigo);

            if (ordenEncontrada != null)
            {
                ordenEncontrada.FechaRecepción = dtFechaRecepcion;
                ordenEncontrada.Servicio = strServicio;
                ordenEncontrada.Vehiculo = strVehiculo;
                ordenEncontrada.Estado = strEstado;
                ordenEncontrada.Repuestos = strRepuestos;
            }
            else
            {
                throw new Exception("Orden de trabajo no encontrada");
            }
        }

        // Método para listar todas las órdenes de trabajo
        public List<clsOrdenesDeTrabajo> ListarOrdenesTrabajo()
        {
            return lstOrdenesTrabajo;
        }
    }
}