using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCare_R_J.Modelos
{
    internal class clsServicios
    {
        //Creacion de propiedades de la clase servicios
        string strCodigo;
        string strNombre;
        string strCategoria;
        double dblCosto;
        string strDescripcion;
        string strDuracion;

        //creacion de constructor de la clase servicios
        public clsServicios(string strCodigo, string strNombre, 
            string strCategoria, double dblCosto, 
            string strDescripcion, string strDuracion)
        {
            this.strCodigo = strCodigo;
            this.strNombre = strNombre;
            this.strCategoria = strCategoria;
            this.dblCosto = dblCosto;
            this.strDescripcion = strDescripcion;
            this.strDuracion = strDuracion;
        }

        //creacion de constructor vacio de la clase servicios
        public clsServicios() { }

        //creacion de metodos get y set de la clase servicios
        public string Codigo { get => strCodigo; set => strCodigo = value; }
        public string Nombre { get => strNombre; set => strNombre = value; }
        public string Categoria { get => strCategoria; set => strCategoria = value; }
        public double Costo { get => dblCosto; set => dblCosto = value; }
        public string Descripcion { get => strDescripcion; set => strDescripcion = value; }
        public string Duracion { get => strDuracion; set => strDuracion = value; }

    }
}
