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
        //creacion de la lista de vehiculos, con el prefijo lst para indicar que es una lista
        List<clsVehiculos> lstVehiculos = new List<clsVehiculos>();
        //creacion de objeto de la clase vehiculos, con el prefijo ob para indicar que es un objeto
        clsVehiculos obVehiculo = new clsVehiculos();

        //creacion de metodo para agregar un vehiculo, con el prefijo str para indicar que es una variable de tipo string
        public void agregarVehiculo(string strCodigo, string strPropietario, 
            string strPlaca, string strEstado, 
            string strColor, string strMarca, 
            string strModelo, string strTipo, 
            string strAño)
        {
            //Se tomara la precaucion de manejar cualquier excepcion que pueda ocurrir al agregar un vehiculo
            try
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

                //Se agregara el objeto vehiculo a la lista de vehiculos
                lstVehiculos.Add(obVehiculo);
            }
            catch (Exception ex)
            {
                //Aqui se agrego la logica para manejar la excepcion
                throw new Exception("Error al agregar el vehiculo: " + ex.Message);

            }

        public void BuscarVehiculo(string strCodigo)
        {
            //Aqui se agrego la logica para buscar un vehiculo en una base de datos o lista
            Producto vehiculoEncontrado = lstVehiculos.FirstOrDefault(v => v.Codigo == strCodigo);

            if (vehiculoEncontrado != null)
            {

            }
            else
            {
                //Aqui se agrego la logica para manejar el caso en que no se encuentre el vehiculo
                throw new Exception("Vehiculo no encontrado");
            }
        }
    }
}
