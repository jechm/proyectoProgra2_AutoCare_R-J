using System;
using AutoCare_R_J.Modelos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCare_R_J.Controladores
{
    internal class clsManejadorOrdenesTrabajo
    {
        //creacion de objeto de la clase ordenes de trabajo, con el prefijo ob para indicar que es un objeto
        clsOrdenesDeTrabajo obOrdenTrabajo = new clsOrdenesDeTrabajo();
        //creacion de metodo para agregar una orden de trabajo, con el prefijo str para indicar que es una variable de tipo string
        public void agregarOrdenTrabajo(string strCodigo, DateTime dtFechaRecepción, 
            string strServicio, string strVehiculo, 
            string strEstado, string strRepuestos)
        {
            obOrdenTrabajo.Codigo = strCodigo;
            obOrdenTrabajo.FechaRecepción = dtFechaRecepción;
            obOrdenTrabajo.Servicio = strServicio;
            obOrdenTrabajo.Vehiculo = strVehiculo;
            obOrdenTrabajo.Estado = strEstado;
            obOrdenTrabajo.Repuestos = strRepuestos;
        }
    }
}
