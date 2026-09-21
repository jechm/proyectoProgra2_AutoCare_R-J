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
        private string strPuesto; //indica el puesto dentro de la empresa
        private string strRol;  //permite habilitar distindos permisos dentro del sistema
        private decimal decSueldo;
        private string strUsuario;
        private string strContraseña;

        //Propiedades de un especificos de un empleado
        public string Rol
        {
            get { return strRol; }
        }

        public decimal Sueldo
        {
            get { return decSueldo; }
        }

        public string Usuario
        {
            get { return strUsuario; }
        }

        public string Contraseña
        {
            get { return strContraseña; }
        }


        public clsEmpleado(string pCodigo, string pNombre, string pApellido, string pDpi, string pTelefono, string pCorreo, string pEstado, string pPuesto,string pRol, decimal pSueldo, string pUsuario, string pContraseña) 
            : base(pCodigo, pNombre, pApellido, pDpi, pTelefono, pCorreo, pEstado)
        {
            this.strPuesto = pPuesto;
            this.strRol = pRol;
            this.decSueldo = pSueldo;
            this.strUsuario=pUsuario;
            this.strContraseña = pContraseña;
                        
        }

        /*
        
        */


    }
}
