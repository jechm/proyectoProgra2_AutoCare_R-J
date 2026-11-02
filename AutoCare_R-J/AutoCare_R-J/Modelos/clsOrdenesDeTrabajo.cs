using System;

namespace AutoCare_R_J.Modelos
{
    public class clsOrdenesDeTrabajo
    {
        // Atributos privados
        private string strCodigo;
        private DateTime dtFechaRecepcion;
        private string strServicio;
        private string strVehiculo;
        private string strEstado;
        private string strRepuestos;

        // Propiedades con Get y Set explícitos
        public string Codigo
        {
            get { return strCodigo; }
            set { strCodigo = value; }
        }

        public DateTime FechaRecepcion
        {
            get { return dtFechaRecepcion; }
            set { dtFechaRecepcion = value; }
        }

        public string Servicio
        {
            get { return strServicio; }
            set { strServicio = value; }
        }

        public string Vehiculo
        {
            get { return strVehiculo; }
            set { strVehiculo = value; }
        }

        public string Estado
        {
            get { return strEstado; }
            set { strEstado = value; }
        }

        public string Repuestos
        {
            get { return strRepuestos; }
            set { strRepuestos = value; }
        }

        // Constructor lleno
        public clsOrdenesDeTrabajo(string pCodigo, DateTime pFechaRecepcion, string pServicio, string pVehiculo, string pEstado, string pRepuestos)
        {
            this.strCodigo = pCodigo;
            this.dtFechaRecepcion = pFechaRecepcion;
            this.strServicio = pServicio;
            this.strVehiculo = pVehiculo;
            this.strEstado = pEstado;
            this.strRepuestos = pRepuestos;
        }

        // Constructor vacío 
        public clsOrdenesDeTrabajo()
        {
        }

        public string OrdenTrabajo
        {
            get { return $"{strServicio} - {strVehiculo}"; }

        }
    }
}