using System;
using System.Collections.Generic;
using System.Linq;
using AutoCare_R_J.Modelos;

namespace AutoCare_R_J.Controladores
{
    internal class clsManejadorVehiculos
    {
        // Creación de la lista de vehículos
        private List<clsVehiculos> lstVehiculos = new List<clsVehiculos>();

        // Método para generar el siguiente código automático (ej. VEH-001)
        public string ObtenerSiguienteCodigo()
        {
            int siguienteNumero = lstVehiculos.Count + 1;
            return $"VEH-{siguienteNumero:D3}";
        }

        // Método para agregar un vehículo
        public void AgregarVehiculo(string strPropietario, string strPlaca,
            string strEstado, string strColor, string strMarca,
            string strModelo, string strTipo, string strAño)
        {
            try
            {
                clsVehiculos nuevoVehiculo = new clsVehiculos();

                nuevoVehiculo.Codigo = ObtenerSiguienteCodigo();
                nuevoVehiculo.Propietario = strPropietario;
                nuevoVehiculo.Placa = strPlaca;
                nuevoVehiculo.Estado = strEstado;
                nuevoVehiculo.Color = strColor;
                nuevoVehiculo.Marca = strMarca;
                nuevoVehiculo.Modelo = strModelo;
                nuevoVehiculo.Tipo = strTipo;
                nuevoVehiculo.Año = strAño;

                lstVehiculos.Add(nuevoVehiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el vehículo: " + ex.Message);
            }
        }

        // Método para buscar un vehículo por código o por número de placa
        public clsVehiculos BuscarVehiculo(string strCodigo, string strPlaca = "")
        {
            clsVehiculos vehiculoEncontrado = lstVehiculos.FirstOrDefault(v => v.Codigo == strCodigo || (!string.IsNullOrEmpty(strPlaca) && v.Placa == strPlaca));

            if (vehiculoEncontrado == null)
            {
                throw new Exception("Vehículo no encontrado");
            }

            return vehiculoEncontrado;
        }

        // Método para eliminar un vehículo por código
        public void EliminarVehiculo(string strCodigo)
        {
            clsVehiculos vehiculoEncontrado = lstVehiculos.FirstOrDefault(v => v.Codigo == strCodigo);

            if (vehiculoEncontrado != null)
            {
                lstVehiculos.Remove(vehiculoEncontrado);
            }
            else
            {
                throw new Exception("Vehículo no encontrado");
            }
        }

        // Método para modificar un vehículo
        public void ModificarVehiculo(string strCodigo, string strPropietario,
            string strPlaca, string strEstado, string strColor,
            string strMarca, string strModelo, string strTipo, string strAño)
        {
            clsVehiculos vehiculoEncontrado = lstVehiculos.FirstOrDefault(v => v.Codigo == strCodigo);

            if (vehiculoEncontrado != null)
            {
                vehiculoEncontrado.Propietario = strPropietario;
                vehiculoEncontrado.Placa = strPlaca;
                vehiculoEncontrado.Estado = strEstado;
                vehiculoEncontrado.Color = strColor;
                vehiculoEncontrado.Marca = strMarca;
                vehiculoEncontrado.Modelo = strModelo;
                vehiculoEncontrado.Tipo = strTipo;
                vehiculoEncontrado.Año = strAño;
            }
            else
            {
                throw new Exception("Vehículo no encontrado");
            }
        }

        // Método para listar todos los vehículos
        public List<clsVehiculos> ListarVehiculos()
        {
            return lstVehiculos;
        }
    }
}