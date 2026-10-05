using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCare_R_J.Modelos
{
    internal class clsVehiculos
    {
        //creacion de propiedades de la clase vehiculos
        string strCodigo;
        string strPropietario;
        string strPlaca;
        string strEstado;
        string strColor;
        string strMarca;
        string strModelo;
        string strTipo;
        string strAño;

        //creacion de constructor de la clase vehiculos
        public clsVehiculos(string strCodigo, string strPropietario, 
            string strPlaca, string strEstado, 
            string strColor, string strMarca,
            string strModelo, string strTipo, 
            string strAño)
        {
            this.strCodigo = strCodigo;
            this.strPropietario = strPropietario;
            this.strPlaca = strPlaca;
            this.strEstado = strEstado;
            this.strColor = strColor;
            this.strMarca = strMarca;
            this.strModelo = strModelo;
            this.strTipo = strTipo;
            this.strAño = strAño;
        }

        //creacion de constructor vacio de la clase vehiculos
        public clsVehiculos(){}

        //creacion de metodos get y set de la clase vehiculos
        public string Codigo { get => strCodigo; set => strCodigo = value; }
        public string Propietario { get => strPropietario; set => strPropietario = value; }
        public string Placa { get => strPlaca; set => strPlaca = value; }
        public string Estado { get => strEstado; set => strEstado = value; }
        public string Color { get => strColor; set => strColor = value; }
        public string Marca { get => strMarca; set => strMarca = value; }
        public string Modelo { get => strModelo; set => strModelo = value; }
        public string Tipo { get => strTipo; set => strTipo = value; }
        public string Año { get => strAño; set => strAño = value; }
    }
}
