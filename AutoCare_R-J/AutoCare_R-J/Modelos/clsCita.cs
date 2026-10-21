using System;
using System.Collections.Generic;

namespace AutoCare_R_J.Modelos
{
    internal class clsCita
    {
        //Atributos cita
        private string strCodigoCita;
        private string strCodigoCliente; //cliente
        private string strCodigoVehiculo; //vehiculo del cliente
        private DateTime dtFechaCita; //fehca de la cita
        private IList<string> strCodigoServiciosolicitado; //servicio solicitado

        private DateTime dtHoraCita; //hora de la cita
        private string strCodigoTecnico; //tecnico solo de ser necesario
        private string strObservaciones;
        private string strEstadoCita; // abierta, en proceso, cerrada, cancelada

        //Propiedades Cita
        public string CodigoCita
        {
            get { return strCodigoCita; }
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

        public IList<string> CodigoServiciosolicitado
        {
            get { return strCodigoServiciosolicitado; }
            set { strCodigoServiciosolicitado = value; }
        }

        public string Observaciones
        {
            get { return strObservaciones; }
            set { strObservaciones = value; }
        }
        public string CodigoTecnico
        {
            get { return strCodigoTecnico; }
            set { strCodigoTecnico = value; }
        }

        public DateTime FechaCita
        {
            get { return dtFechaCita; }
            set { dtFechaCita = value; }
        }

        public DateTime HoraCita
        {
            get { return dtHoraCita; }
            set { dtHoraCita = value; }
        }


        public string EstadoCita
        {
            get { return strEstadoCita; }
            set { strEstadoCita = value; }
        }

        //Constructor de Citas
        public clsCita(string pCodigoCita,
            string pCodigoCliente, string pCodigoVehiculo,
            string pCodigoTecnico,
            DateTime pFecha, DateTime pHora,
            IList<string> pCodigoServiciosolicitado,
            string pEstado
            )
        {

            this.strCodigoCita = pCodigoCita;
            this.strCodigoCliente = pCodigoCliente;
            this.strCodigoVehiculo = pCodigoVehiculo;
            this.strCodigoTecnico = pCodigoTecnico;
            this.dtFechaCita = pFecha;
            this.dtHoraCita = pHora;
            this.strCodigoServiciosolicitado = pCodigoServiciosolicitado;
            this.strEstadoCita = pEstado;

        }


    }
}
