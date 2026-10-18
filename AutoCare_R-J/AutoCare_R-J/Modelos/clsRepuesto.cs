using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCare_R_J.Modelos
{
    internal class clsRepuesto
    {
        private string strCodigoRepuesto;
        private string strNombreRepuesto;
        private string strDescripcion;
        private string strCategoria;
        private string strMarca;
        private decimal decPrecio;
        private int intExistencias;
        private string strEstado;





        public string Codigo
        { 
            get { return strCodigoRepuesto; } 
        }
        public string Nombre
        {
            get { return strNombreRepuesto; } 
            set { strNombreRepuesto = value; }
        }

        public string Descripcion
        {
            get { return strDescripcion; }
            set { strDescripcion = value; }
        }

        public string Categoria 
        {
            get { return strCategoria; } 
            set { strCategoria = value; } 
        }
        public string Marca 
        {
            get { return strMarca; }
            set { strMarca = value;}

        }
        public decimal Precio 
        { 
            get {return decPrecio; }
            set {decPrecio = value; }
        }
        public int Existencias 
        { 
            get {return intExistencias; }
            set {intExistencias = value; }
        }

        public string Estado
        {
            get { return strEstado; }
            set { strEstado = value; }
        }


        public clsRepuesto(string pCodigo,string pNombre, string pDescripcion, string pCategoria, string pMarca, decimal pPrecio, int PExistencias, string pEstado)
        {
            this.strCodigoRepuesto = pCodigo;
            this.strNombreRepuesto= pNombre;
            this.strEstado=pEstado;
            this.strDescripcion=pDescripcion;
            this.strCategoria=pCategoria;
            this.strMarca=pMarca;
            this.decPrecio=pPrecio;
            this.intExistencias=PExistencias;

    }
    }
}
