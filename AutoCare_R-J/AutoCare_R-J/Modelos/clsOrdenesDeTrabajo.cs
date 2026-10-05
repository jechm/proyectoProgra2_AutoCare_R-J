using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCare_R_J.Modelos
{
    internal class clsOrdenesDeTrabajo
    {
        //Creacion de propiedades de la clase ordenes de trabajo
        string strCodigo;
        DateTime dtFechaRecepción;
        string strServicio;
        string strVehiculo;
        string strEstado;
        string strRepuestos;

        //creacion de constructor de la clase ordenes de trabajo
        public clsOrdenesDeTrabajo(string strCodigo, DateTime dtFechaRecepción, string strServicio, string strVehiculo, string strEstado, string strRepuestos)
        {
            this.strCodigo = strCodigo;
            this.dtFechaRecepción = dtFechaRecepción;
            this.strServicio = strServicio;
            this.strVehiculo = strVehiculo;
            this.strEstado = strEstado;
            this.strRepuestos = strRepuestos;
        }

        //creacion de constructor vacio de la clase ordenes de trabajo
        public clsOrdenesDeTrabajo() { }

        //creacion de metodos get y set de la clase ordenes de trabajo
        public string Codigo { get => strCodigo; set => strCodigo = value; }
        public DateTime FechaRecepción { get => dtFechaRecepción; set => dtFechaRecepción = value; }
        public string Servicio { get => strServicio; set => strServicio = value; }
        public string Vehiculo { get => strVehiculo; set => strVehiculo = value; }
        public string Estado { get => strEstado; set => strEstado = value; }
        public string Repuestos { get => strRepuestos; set => strRepuestos = value; }

    }
}
