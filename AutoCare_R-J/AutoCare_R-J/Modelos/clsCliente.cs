using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCare_R_J.Modelos
{
    internal class clsCliente : clsPersona
    {

        //Atributos especificos de un cliente
        private string strNit; 
        private decimal decSaldo;  



        //Propiedades de un especificos de un cliente
        public string Nit
        {
            get { return strNit; }
        }

        public decimal Saldo
        {
            get { return decSaldo; }
            set { decSaldo = value; }
        }


        public clsCliente(string pCodigo, string pNombre, string pApellido, string pDpi, string pTelefono, string pCorreo, string pEstado, string pNit, decimal pSaldo)
            : base(pCodigo, pNombre, pApellido, pDpi, pTelefono, pCorreo, pEstado)
        {
            this.strNit = pNit;
            this.decSaldo = pSaldo;

        }
    }
}
