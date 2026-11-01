using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCare_R_J.Modelos
{
    internal class clsEmpleado : clsPersona
    {

        //Atributos especificos de un empleado
        //private string strPuesto; //indica el puesto dentro de la empresa
        private string strRol;  //permite habilitar distindos permisos dentro del sistema
        private decimal decSueldo;
        private string strUsuario;
        private string strContrasenia;


        //Propiedades de un especificos de un empleado


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

        public string Contrasenia
        {
            get { return strContrasenia; }
            set { strContrasenia = value; }
        }



        public clsEmpleado(string pCodigo, string pNombre, string pApellido, string pDpi, string pTelefono, string pCorreo, string pDireccion, string pEstado, string pUsuario, string pContraseña, string pRol, decimal pSueldo) 
            : base(pCodigo, 
                  pNombre, 
                  pApellido, 
                  pDpi, 
                  pTelefono, 
                  pCorreo, 
                  pDireccion, 
                  pEstado
                  )
        {
            
            
            validarYAsignarDatos(pUsuario, pContraseña, pRol, pSueldo);
                        
        }

        private void validarYAsignarDatos(string pUsuario, string pContraseña, string pRol, decimal pSueldo)
        {
            this.Rol = string.IsNullOrWhiteSpace(pRol) ? "Empleado" : pRol;
            this.Sueldo = pSueldo <= 0 ? 4200 : pSueldo; // Asignar 4200 si el sueldo es menor o igual a 0

            if(string.IsNullOrWhiteSpace(pUsuario))
            {
                throw new ArgumentException("El usuario no debe de estar vacío.");
                
            }

            if(string.IsNullOrWhiteSpace(pContraseña))
            {
                throw new ArgumentException("La contraseña no debe de estar vacía.");
               
            }

            this.strUsuario = pUsuario;
            this.Contrasenia = pContraseña;

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
            this.strContrasenia = pContraseña;
        }

        /*
        
        */


    }
}
