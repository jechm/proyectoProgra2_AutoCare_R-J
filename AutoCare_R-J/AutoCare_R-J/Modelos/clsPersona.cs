using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private string strDireccion;    
        private string strEstado;

        //Propiedades de una persona
        public string Codigo{
            get {  return strCodigoPersona; }
            
        }

        public string Nombre
        {
            get { return strNombrePersona; }
            set{strNombrePersona = value; }
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
        
        public string Direccion
        {
            get { return strDireccion; }
            set { strDireccion = value; }
        }

        public string Estado
        {
            get { return strEstado;}
            set { strEstado = value; }
            
        }

        //Constructor
        public clsPersona(string pCodigo, string pNombre, string pApellido, string pDpi, string pTelefono, string pCorreo, string pDireccion, string pEStado) 
        {
            validarYAsignarDatosBase(pCodigo, pNombre, pApellido, pDpi, pTelefono, pCorreo, pDireccion, pEStado);

        }

        private void validarYAsignarDatosBase(string pCodigo, string pNombre, string pApellido, string pDpi, string pTelefono, string pCorreo, string pDireccion, string pEstado)
        {
            revisarSiEstaVacio(pCodigo, "El código");
            revisarSiEstaVacio(pNombre, "El nombre");
            revisarSiEstaVacio(pApellido, "El apellido");
            revisarSiEstaVacio(pDpi, "El DPI");
            revisarSiEstaVacio(pTelefono, "El teléfono");
            revisarSiEstaVacio(pCorreo, "El correo");

            this.strCodigoPersona = pCodigo;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.strDPIPersona = pDpi;
            this.Telefono = pTelefono;
            this.Correo = pCorreo;
            this.Direccion = string.IsNullOrWhiteSpace(pDireccion) ? "No Indica" : pDireccion;
            this.strEstado = string.IsNullOrWhiteSpace(pEstado) ? "Activo" : pEstado;
        }

        private void revisarSiEstaVacio(string pValor, string pCampo)
        {
            if (string.IsNullOrWhiteSpace(pValor))
            {
                throw new ArgumentException(pCampo + " no debe de estar vacío.");
            }

        }

    }
}
