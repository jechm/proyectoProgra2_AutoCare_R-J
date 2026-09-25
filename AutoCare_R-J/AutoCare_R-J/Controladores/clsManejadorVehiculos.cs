using AutoCare_R_J.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCare_R_J.Controladores
{
    internal class clsManejadorVehiculos
    {
        //creacion de objeto de la clase vehiculos, con el prefijo ob para indicar que es un objeto
        clsVehiculos obVehiculo = new clsVehiculos();

        //creacion de metodo para agregar un vehiculo, con el prefijo str para indicar que es una variable de tipo string
        public void agregarVehiculo(string strCodigo, string strPropietario, string strPlaca, string strEstado, string strColor, string strMarca, string strModelo, string strTipo, string strAño)
        {
            obVehiculo.Codigo = strCodigo;
            obVehiculo.Propietario = strPropietario;
            obVehiculo.Placa = strPlaca;
            obVehiculo.Estado = strEstado;
            obVehiculo.Color = strColor;
            obVehiculo.Marca = strMarca;
            obVehiculo.Modelo = strModelo;
            obVehiculo.Tipo = strTipo;
            obVehiculo.Año = strAño;
        }
    }
}
