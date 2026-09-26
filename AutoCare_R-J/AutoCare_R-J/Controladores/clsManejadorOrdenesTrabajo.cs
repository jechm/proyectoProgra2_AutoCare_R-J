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
        //creacion de la lista de ordenes de trabajo
        List<clsOrdenesDeTrabajo> lstOrdenesTrabajo = new List<clsOrdenesDeTrabajo>();


        //creacion de objeto de la clase ordenes de trabajo, con el prefijo ob para indicar que es un objeto
        clsOrdenesDeTrabajo obOrdenTrabajo = new clsOrdenesDeTrabajo();
        //creacion de metodo para agregar una orden de trabajo, con el prefijo str para indicar que es una variable de tipo string
        public void agregarOrdenTrabajo(string strCodigo, DateTime dtFechaRecepción, 
            string strServicio, string strVehiculo, 
            string strEstado, string strRepuestos)
        {
            try
            {
                //Aqui se agrego la logica de creacion de una orden de trabajo
                obOrdenTrabajo.Codigo = strCodigo;
                obOrdenTrabajo.FechaRecepción = dtFechaRecepción;
                obOrdenTrabajo.Servicio = strServicio;
                obOrdenTrabajo.Vehiculo = strVehiculo;
                obOrdenTrabajo.Estado = strEstado;
                obOrdenTrabajo.Repuestos = strRepuestos;

                //se agregara el objeto orden de trabajo a la lista de ordenes de trabajo
                lstOrdenesTrabajo.Add(obOrdenTrabajo);
            }
            catch (Exception ex)
            {
                //Aqui se puede agregar la logica para manejar la excepcion
                throw new Exception("Error al agregar la orden de trabajo: " + ex.Message);
            }
        }
        public void BuscarOrdenTrabajo(string strCodigo)
        {
            //Aqui se agrego la logica para buscar una orden de trabajo en una base de datos o lista
            Producto ordenTrabajoEncontrada = lstOrdenesTrabajo.FirstOrDefault(o => o.Codigo == strCodigo);
            if (ordenTrabajoEncontrada != null)
            {
            }
            else
            {
                //Aqui se agrego la logica para manejar el caso en que no se encuentre la orden de trabajo
                throw new Exception("Orden de trabajo no encontrada");
            }
        }
    }
}
