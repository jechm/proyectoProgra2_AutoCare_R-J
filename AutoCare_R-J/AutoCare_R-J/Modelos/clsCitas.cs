using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCare_R_J.Modelos
{
    internal class clsCitas
    {
        //Atributos cita
        private string strCodigoCita;
        private string strCodigoCliente;
        private string strCodigoVehiculo;
        private string strCodigoTecnico;
        private DateTime dtFechaCita;
        private DateTime dtHoraCita;
        private string strCodigoServiciosolicitado;
        private string strEstadoCita;

        //Propiedades Cita
        public string CodigoCita
        {
            get {  return strCodigoCita; }
        }

        public string CodigoCliente
        {
            get { return strCodigoCliente; }
            set { strCodigoCliente = value; }
        }

        public string CodigoVehiculo
        {
            get { return strCodigoVehiculo; }
            set { strCodigoVehiculo = value; }
        }

        public string CodigoTecnico
        {
            get { return strCodigoTecnico; }
            set { strCodigoTecnico = value; }
        }

        public DateTime FechaCita
        {
            get { return dtFechaCita; }
            set {  dtFechaCita = value; }
        }

        public DateTime HoraCita
        {
            get { return dtHoraCita; }
            set { dtHoraCita = value; }
        }

        public string CodigoServiciosolicitado
        {
            get { return strCodigoServiciosolicitado; }
            set { strCodigoServiciosolicitado = value; }
        }
        public string EstadoCita
        {
            get { return strEstadoCita; }
            set{ strEstadoCita = value; }
        }

        //Constructor de Citas
        public clsCitas(string pCodigoCita,
            string pCodigoCliente, string pCodigoVehiculo,
            string pCodigoTecnico,
            DateTime pFecha, DateTime pHora,
            string pCodigoServiciosolicitado,
            string pEstado
            )
        {

            this.strCodigoCita=pCodigoCita;
            this.strCodigoCliente=pCodigoCliente;
            this.strCodigoVehiculo=pCodigoVehiculo;
            this.strCodigoTecnico=pCodigoTecnico;
            this.dtFechaCita=pFecha;
            this.dtHoraCita=pHora;
            this.strCodigoServiciosolicitado = pCodigoServiciosolicitado;
            this.strEstadoCita=pEstado;
   
        }
    }
}
