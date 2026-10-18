using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCare_R_J.Modelos
{
    internal class clsEmpleado : clsPersona
    {

        //Atributos especificos de un empleado
        //private string strPuesto; //indica el puesto dentro de la empresa
        private string strRol;  //permite habilitar distindos permisos dentro del sistema
        private decimal decSueldo;
        private string strUsuario;
        private string strContraseña;


        //Propiedades de un especificos de un empleado
        /*public string Puesto
        {
            get { return strPuesto; }
            set { strPuesto = value; }
        }*/

        public string Rol
        {
            get { return strRol; }
            set { strRol = value; }
        }

        public decimal Sueldo
        {
            get { return decSueldo; }
            set { decSueldo = value; }
        }

        public string Usuario
        {
            get { return strUsuario; }
        }

        public string Contraseña
        {
            get { return strContraseña; }
        }



        public clsEmpleado(string pCodigo, string pNombre, string pApellido, string pDpi, string pTelefono, string pCorreo, string pDireccion, string pEstado, string pRol, decimal pSueldo, string pUsuario, string pContraseña) 
            : base(pCodigo, pNombre, pApellido, pDpi, pTelefono, pCorreo, pDireccion, pEstado)
        {
            this.Rol = pRol;
            this.Sueldo = pSueldo;
            this.strUsuario=pUsuario;
            this.strContraseña = pContraseña;
                        
        }

        public void actualizarEmpleado(string pNombre, string pApellido, string pTelefono, string pCorreo, string pDireccion, string pEstado, string pRol, decimal pSueldo, string pUsuario, string pContraseña)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Telefono = pTelefono;
            this.Correo = pCorreo;
            this.Direccion = pDireccion;
            this.Estado = pEstado;
            this.strRol = pRol;
            this.decSueldo = pSueldo;
            this.strUsuario = pUsuario;
            this.strContraseña = pContraseña;
        }

        /*
        
        */


    }
}
