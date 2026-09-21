using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCare_R_J.Modelos
{
    internal abstract class clsPersona
    {
        //Atributos de una persona
        private string strCodigoPersona;
        private string strNombrePersona;
        private string strApellidoPersona;
        private string strDPIPersona;
        private string strTelefono;
        private string strCorreoPersona;
        private string strEstado;

        //Propiedades de una persona
        public string Codigo{
            get {  return strCodigoPersona; }
            
        }

        public string Nombre
        {
            get { return strNombrePersona; }
            set{strApellidoPersona = value; }
        }

        public string Apellido
        {
            get { return strApellidoPersona; }
            set { strApellidoPersona = value; }
        }

        public string DPI
        {
            get { return strDPIPersona; }
            
        }

        public string Telefono
        {
            get { return strTelefono; }
            set { strTelefono = value; }
        }

        public string Correo
        {
            get { return strCorreoPersona; }
            set { strCorreoPersona = value; }
        }

        public string Estado
        {
            get { return strEstado;}
            set { strEstado = value; }
            
        }

        //Constructor
        public clsPersona(string pCodigo, string pNombre, string pApellido, string pDpi, string pTelefono, string pCorreo, string pEstado) 
        {
            this.strCodigoPersona=pCodigo;
            this.strNombrePersona = pNombre;
            this.strApellidoPersona = pApellido;
            this.strDPIPersona = pDpi;
            this.strTelefono = pTelefono;
            this.strCorreoPersona = pCorreo;
            this.strEstado = pEstado;
    }

    }
}
