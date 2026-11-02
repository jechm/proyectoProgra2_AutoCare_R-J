using System;
using System.Collections.Generic;
using System.Linq;
using AutoCare_R_J.MetodosGlobales;
using AutoCare_R_J.Modelos;
using Microsoft.Data.Sqlite;

namespace AutoCare_R_J.Controladores
{
    internal class clsManejadorOrdenesTrabajo
    {
        // Creación de la lista de órdenes de trabajo
        private List<clsOrdenesDeTrabajo> lstOrdenesTrabajo = new List<clsOrdenesDeTrabajo>();



        // Creación de método para agregar una orden de trabajo
        public void AgregarOrdenTrabajo(DateTime dtFechaRecepcion, string strServicio, string strVehiculo, string strEstado, string strRepuestos)
        {
            try
            {
                clsOrdenesDeTrabajo nuevaOrden = new clsOrdenesDeTrabajo();

                nuevaOrden.Codigo = clsMetodosGlobales.ObtenerSiguienteCodigo("ordenes_trabajo");
                nuevaOrden.FechaRecepcion = dtFechaRecepcion;
                nuevaOrden.Servicio = strServicio;
                nuevaOrden.Vehiculo = strVehiculo;
                nuevaOrden.Estado = strEstado;
                nuevaOrden.Repuestos = strRepuestos;

                AgregarSql(nuevaOrden);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la orden de trabajo: " + ex.Message);
            }
        }

        // Método para buscar una orden de trabajo por código o por vehículo
        public clsOrdenesDeTrabajo BuscarOrdenTrabajo(string strCodigo, string strVehiculo = "")
        {
            try
            {
                BuscarSql(strCodigo, out clsOrdenesDeTrabajo ordenEncontrada);
                
                return ordenEncontrada;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar la orden de trabajo: " + ex.Message);
            }
        }

        // Método para eliminar una orden de trabajo
        public void EliminarOrdenTrabajo(string strCodigo)
        {
            try
            {
                EliminarSql(strCodigo);
            }
            catch (SqliteException ex) when (ex.SqliteErrorCode == 19)
            {
                throw new Exception("No se puede eliminar");
            }
        }

        // Método para modificar una orden de trabajo
        public void ModificarOrdenTrabajo(string strCodigo, DateTime dtFechaRecepcion, string strServicio, string strVehiculo, string strEstado, string strRepuestos)
        {
            try
            {
                var actualilzado = new clsOrdenesDeTrabajo
                {
                    Codigo = strCodigo,
                    FechaRecepcion = dtFechaRecepcion,
                    Servicio = strServicio,
                    Vehiculo = strVehiculo,
                    Estado = strEstado,
                    Repuestos = strRepuestos
                };
                ModificarSql(actualilzado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar la orden de trabajo: " + ex.Message);
            }
        }

        // Método para listar todas las órdenes de trabajo
        public List<clsOrdenesDeTrabajo> ListarOrdenesTrabajo()
        {
            lstOrdenesTrabajo.Clear();
            lstOrdenesTrabajo = clsMetodosGlobales.ObtenerOrdenesTrabajo();
            return lstOrdenesTrabajo;
        }

        #region Metodos sqlite
        public int AgregarSql(clsOrdenesDeTrabajo orden)
        {
            string sql = @"INSERT INTO ordenes_trabajo (codigo, fecha_recepcion, servicio, vehiculo, estado, repuestos) 
                           VALUES (@codigo, @fecha_recepcion, @servicio, @vehiculo, @estado, @repuestos)";
            using (var con = clsConexion.ObtenerConexion())
            using (var cmd = new SqliteCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@codigo", orden.Codigo);
                cmd.Parameters.AddWithValue("@fecha_recepcion", orden.FechaRecepcion.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@servicio", orden.Servicio);
                cmd.Parameters.AddWithValue("@vehiculo", orden.Vehiculo);
                cmd.Parameters.AddWithValue("@estado", orden.Estado);
                cmd.Parameters.AddWithValue("@repuestos", orden.Repuestos);
                return cmd.ExecuteNonQuery();
            }
        }

        public int EliminarSql(string codigo)
        {
            string sql = "DELETE FROM ordenes_trabajo WHERE codigo = @codigo";
            using (var con = clsConexion.ObtenerConexion())
            using (var cmd = new SqliteCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@codigo", codigo);
                return cmd.ExecuteNonQuery();
            }
        }

        public int ModificarSql(clsOrdenesDeTrabajo orden)
        {
            string sql = @"UPDATE ordenes_trabajo 
                           SET fecha_recepcion = @fecha_recepcion, 
                               servicio = @servicio, 
                               vehiculo = @vehiculo, 
                               estado = @estado, 
                               repuestos = @repuestos 
                           WHERE codigo = @codigo";
            using (var con = clsConexion.ObtenerConexion())
            using (var cmd = new SqliteCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@codigo", orden.Codigo);
                cmd.Parameters.AddWithValue("@fecha_recepcion", orden.FechaRecepcion.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@servicio", orden.Servicio);
                cmd.Parameters.AddWithValue("@vehiculo", orden.Vehiculo);
                cmd.Parameters.AddWithValue("@estado", orden.Estado);
                cmd.Parameters.AddWithValue("@repuestos", orden.Repuestos);
                return cmd.ExecuteNonQuery();
            }
        }

        private int BuscarSql(string strCodigo, out clsOrdenesDeTrabajo ordenEncontrada)
        {
            string sql = "SELECT * FROM ordenes_trabajo WHERE codigo = @codigo";
            using (var con = clsConexion.ObtenerConexion())
            using (var cmd = new SqliteCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@codigo", strCodigo);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ordenEncontrada = new clsOrdenesDeTrabajo
                        {
                            Codigo = reader.GetString(0),
                            FechaRecepcion = DateTime.Parse(reader.GetString(1)),
                            Servicio = reader.GetString(2),
                            Vehiculo = reader.GetString(3),
                            Estado = reader.GetString(4),
                            Repuestos = reader.GetString(5)
                        };
                        return 1; // Orden encontrada
                    }
                    else
                    {
                        ordenEncontrada = null;
                        return 0; // Orden no encontrada
                    }
                }
            }
        }
        #endregion
    }
}