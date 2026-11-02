using System;
using System.Collections.Generic;

namespace AutoCare_R_J.Modelos
{
    internal class clsCita
    {
        //Atributos cita
        private string strCodigoCita;
        private string strCodigoCliente;
        private string strCodigoVehiculo;
        private string strCodigoTecnico;
        private DateTime dtFechaCitaHora;
        private string strEstadoCita;
        private string strObservaciones;

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

        public string CodigoTecnico
        {
            get { return strCodigoTecnico; }
            set { strCodigoTecnico = value; }
        }

        public DateTime FechaHoraCita
        {
            get { return dtFechaCitaHora; }
            set { dtFechaCitaHora = value; }
        }

        public string EstadoCita
        {
            get { return strEstadoCita; }
            set { strEstadoCita = value; }
        }

        public string Observaciones
        {
            get { return strObservaciones; }
            set { strObservaciones = value; }
        }




        //Constructor de Citas
        public clsCita(string pCodigoCita,
            string pCodigoCliente, string pCodigoVehiculo,
            string pCodigoTecnico,
            DateTime pFechaHora,
            string pEstado,
            string pObservaciones
            )
        {

            ValidacionyAsignacion(pCodigoCita, pCodigoCliente, pCodigoVehiculo, pCodigoTecnico, pFechaHora, pEstado, pObservaciones);


        }

        private void ValidacionyAsignacion(string pCodigoCita, string pCodigoCliente, string pCodigoVehiculo, string pCodigoTecnico, DateTime pFechaHora, string pEstado, string pObservaciones)
        {
            if (string.IsNullOrWhiteSpace(pCodigoCita))
            {
                throw new ArgumentException("El código de la cita no puede estar vacío.");
            }
            if (string.IsNullOrWhiteSpace(pCodigoCliente))
            {
                throw new ArgumentException("El cliente no es válido.");
            }
            if (string.IsNullOrWhiteSpace(pCodigoVehiculo))
            {
                throw new ArgumentException("El vehículo no es válido.");
            }
            if (string.IsNullOrWhiteSpace(pCodigoTecnico))
            {
                throw new ArgumentException("El técnico no es válido.");
            }
            if (pFechaHora < DateTime.Now)
            {
                throw new ArgumentException("La fecha y hora de la cita no puede ser en el pasado.");
            }
            if (string.IsNullOrWhiteSpace(pEstado))
            {
                throw new ArgumentException("El estado de la cita no puede estar vacío.");
            }
            this.strCodigoCita = pCodigoCita;
            this.CodigoCliente = pCodigoCliente;
            this.CodigoVehiculo = pCodigoVehiculo;
            this.CodigoTecnico = pCodigoTecnico;
            this.FechaHoraCita = pFechaHora;
            this.EstadoCita = pEstado;
            this.Observaciones = pObservaciones;
        }
    }
}

