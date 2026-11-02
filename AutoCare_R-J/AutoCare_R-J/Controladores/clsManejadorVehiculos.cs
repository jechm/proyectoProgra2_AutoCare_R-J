using AutoCare_R_J.MetodosGlobales;
using AutoCare_R_J.Modelos;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;

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
            string strModelo, string strTipo, string strAnio)
        {
            try
            {
                clsVehiculos nuevoVehiculo = new clsVehiculos();

                nuevoVehiculo.Codigo = clsMetodosGlobales.ObtenerSiguienteCodigo("Vehiculo");
                nuevoVehiculo.Propietario = strPropietario;
                nuevoVehiculo.Placa = strPlaca;
                nuevoVehiculo.Marca = strMarca;
                nuevoVehiculo.Modelo = strModelo;
                nuevoVehiculo.Estado = strEstado;
                nuevoVehiculo.Color = strColor;
                nuevoVehiculo.Tipo = strTipo;
                nuevoVehiculo.Anio = strAnio;

                AgregarSql(nuevoVehiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el vehículo: " + ex.Message);
            }
        }

        // Método para buscar un vehículo por código o por número de placa
        public clsVehiculos BuscarVehiculo(string strCodigo, string strPropietario = "")
        {
            if (!string.IsNullOrEmpty(strCodigo))
            {
                BuscarSql(strCodigo, out clsVehiculos vehiculoEncontrado);
                if (vehiculoEncontrado == null)
                {
                    throw new Exception("Vehículo no encontrado");
                }
                return vehiculoEncontrado;
            }
            else if (!string.IsNullOrEmpty(strPropietario))
            {
                BuscarPropietarioSql(strPropietario, out clsVehiculos vehiculoEncontrado);
                if (vehiculoEncontrado == null)
                {
                    throw new Exception("Vehículo no encontrado");
                }
                return vehiculoEncontrado;
            }
            else
            {
                throw new Exception("Debe proporcionar un código o propietario para buscar el vehículo.");
            }
        }

        // Método para eliminar un vehículo por código
        public void EliminarVehiculo(string strCodigo)
        {
            
            if (strCodigo != null)
            {
                EliminarSql(strCodigo);
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
            // Validar que el código no esté vacío
            if (string.IsNullOrEmpty(strCodigo))
            {
                throw new Exception("El código del vehículo es obligatorio para modificar.");
            }

            try
            {
                var actualizado = new clsVehiculos
                {
                    Codigo = strCodigo.Trim(),
                    Propietario = strPropietario,
                    Placa = strPlaca.Trim(),
                    Marca = strMarca.Trim(),
                    Modelo = strModelo.Trim(),
                    Estado = strEstado.Trim(),
                    Color = strColor.Trim(),
                    Tipo = strTipo.Trim(),
                    Anio = strAño.Trim()
                };

                // Llamamos al método SQL que ya tienes hecho
                ActualizarSql(actualizado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el manejador al modificar el vehículo: " + ex.Message);
            }
        }

        // Método para listar todos los vehículos
        public List<clsVehiculos> ListarVehiculos()
        {
            lstVehiculos.Clear();
            lstVehiculos = clsMetodosGlobales.ObtenerVehiculos();
            return lstVehiculos;
        }

        #region Metodos sqlite
        public int AgregarSql(clsVehiculos vehiculo)
        {
            string sql = "INSERT INTO vehiculo (codigo_vehiculo, codigo_cliente, placa, marca, modelo, tipo, color, anio, estado) " +
                            "VALUES (@codigo, @propietario, @placa, @marca, @modelo, @tipo, @color, @anio, @estado)";

            using (var con = clsConexion.ObtenerConexion())
            using (var cmd = new SqliteCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@codigo", vehiculo.Codigo);
                cmd.Parameters.AddWithValue("@propietario", vehiculo.Propietario);
                cmd.Parameters.AddWithValue("@placa", vehiculo.Placa);
                cmd.Parameters.AddWithValue("@marca", vehiculo.Marca);
                cmd.Parameters.AddWithValue("@modelo", vehiculo.Modelo);
                cmd.Parameters.AddWithValue("@tipo", vehiculo.Tipo);
                cmd.Parameters.AddWithValue("@color", vehiculo.Color);
                cmd.Parameters.AddWithValue("@anio", vehiculo.Anio);
                cmd.Parameters.AddWithValue("@estado", vehiculo.Estado);
                return cmd.ExecuteNonQuery();
            }
        }

        public int EliminarSql(string strCodigo)
        {
            string sql = "DELETE FROM vehiculo WHERE codigo_vehiculo = @codigo";
            using (var con = clsConexion.ObtenerConexion())
            using (var cmd = new SqliteCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@codigo", strCodigo);
                return cmd.ExecuteNonQuery();
            }
        }

        public int ActualizarSql(clsVehiculos vehiculo)
        {
            string sql = "UPDATE vehiculo SET codigo_cliente = @propietario, placa = @placa, marca = @marca, modelo = @modelo, tipo = @tipo, color = @color, anio = @anio, estado = @estado " +
                            "WHERE codigo_vehiculo = @codigo";
            using (var con = clsConexion.ObtenerConexion())
            using (var cmd = new SqliteCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@codigo", vehiculo.Codigo);
                cmd.Parameters.AddWithValue("@propietario", vehiculo.Propietario);
                cmd.Parameters.AddWithValue("@placa", vehiculo.Placa);
                cmd.Parameters.AddWithValue("@marca", vehiculo.Marca);
                cmd.Parameters.AddWithValue("@modelo", vehiculo.Modelo);
                cmd.Parameters.AddWithValue("@tipo", vehiculo.Tipo);
                cmd.Parameters.AddWithValue("@color", vehiculo.Color);
                cmd.Parameters.AddWithValue("@anio", vehiculo.Anio);
                cmd.Parameters.AddWithValue("@estado", vehiculo.Estado);
                return cmd.ExecuteNonQuery();
            }
        }

        public int BuscarSql(string codigo, out clsVehiculos vehiculo)
        {
            string sql = "SELECT * FROM vehiculo WHERE codigo_vehiculo = @codigo";
            using (var con = clsConexion.ObtenerConexion())
            using (var cmd = new SqliteCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@codigo", codigo);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        vehiculo = new clsVehiculos
                        {
                            Codigo = reader["codigo_vehiculo"].ToString(),
                            Propietario = reader["codigo_cliente"].ToString(),
                            Placa = reader["placa"].ToString(),
                            Marca = reader["marca"].ToString(),
                            Modelo = reader["modelo"].ToString(),
                            Tipo = reader["tipo"].ToString(),
                            Color = reader["color"].ToString(),
                            Anio = reader["anio"].ToString(),
                            Estado = reader["estado"].ToString()
                        };
                        return 1; // encontrado
                    }
                    else
                    {
                        vehiculo = null;
                        return 0; // no encontrado
                    }
                }
            }
        }

        public int BuscarPropietarioSql(string propietario, out clsVehiculos vehiculo)
        {
            string sql = "SELECT * FROM vehiculo WHERE codigo_cliente = @propietario";
            using (var con = clsConexion.ObtenerConexion())
            using (var cmd = new SqliteCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@propietario", propietario);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        vehiculo = new clsVehiculos
                        {
                            Codigo = reader["codigo_vehiculo"].ToString(),
                            Propietario = reader["codigo_cliente"].ToString(),
                            Placa = reader["placa"].ToString(),
                            Marca = reader["marca"].ToString(),
                            Modelo = reader["modelo"].ToString(),
                            Tipo = reader["tipo"].ToString(),
                            Color = reader["color"].ToString(),
                            Anio = reader["anio"].ToString(),
                            Estado = reader["estado"].ToString()
                        };
                        return 1; // encontrado
                    }
                    else
                    {
                        vehiculo = null;
                        return 0; // no encontrado
                    }
                }
            }
        }
        #endregion
    }
}