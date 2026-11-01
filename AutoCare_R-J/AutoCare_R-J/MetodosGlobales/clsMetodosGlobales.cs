using AutoCare_R_J.Modelos;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCare_R_J.MetodosGlobales
{
    internal class clsMetodosGlobales
    {
        public static void DeshabilitarBoton(CustomButton boton)
        {
            boton.Enabled = false;
            boton.CustomBackColor = Color.Gray;
            boton.ForeColor = Color.Black;
            boton.Cursor = Cursors.No;
        }

        public static void HabilitarBoton(CustomButton boton, Color colorFondo, Color colorTexto, Cursor cursor)
        {
            boton.Enabled = true;
            boton.CustomBackColor = colorFondo;
            boton.ForeColor = colorTexto;
            boton.Cursor = cursor;
        }

        public static void CargarGrid(DataGridView dgv, object dataSource)
        {
            dgv.DataSource = null;
            dgv.DataSource = dataSource;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public static string ObtenerSiguienteCodigo(string tabla)
        {
            string sql = $"SELECT MAX(codigo_{tabla}) FROM {tabla}";

            using (var con = clsConexion.ObtenerConexion())
            using (var cmd = new SqliteCommand(sql, con))
            {
                object resultado = cmd.ExecuteScalar();

                if (resultado == null || resultado == DBNull.Value)
                    return "SRV-001";

                int numero = int.Parse(resultado.ToString().Substring(4)) + 1;
                return "SRV-" + numero.ToString("D3");
            }
        }

        #region Metodos de conversion
        public static string MinutosADuracion(int minutos)
        {
            int h = minutos / 60;
            int m = minutos % 60;
            return $"{h}h {m}min";
        }

        #endregion
        #region Metodos para obtener datos de la base de datos
        private static List<clsServicios> lstServicios = new List<clsServicios>();
        private static List<clsVehiculos> lstVehiculos = new List<clsVehiculos>();

        private static List<clsOrdenesDeTrabajo> lstOrdenesTrabajo = new List<clsOrdenesDeTrabajo>();
        private static List<clsRepuesto> lstRepuestos = new List<clsRepuesto>();
             
        // Método para obtener los servicios desde la base de datos
        public static List<clsServicios> ObtenerServicios()
        {
            lstServicios.Clear();
            try
            {
                string sql = @"SELECT codigo_servicio, nombre, categoria, costo, descripcion, duracion_min
                   FROM servicio ORDER BY codigo_servicio";

                using (var con = clsConexion.ObtenerConexion())
                using (var cmd = new SqliteCommand(sql, con))
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        lstServicios.Add(new clsServicios
                        {
                            Codigo = r.GetString(0),
                            Nombre = r.GetString(1),
                            Categoria = r.IsDBNull(2) ? null : r.GetString(2),
                            Costo = Convert.ToDouble(r.GetValue(3)),
                            Descripcion = r.IsDBNull(4) ? null : r.GetString(4),
                            Duracion = r.IsDBNull(5) ? "" : MinutosADuracion(r.GetInt32(5))
                        });
                    }
                }
                return lstServicios;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los servicios: " + ex.Message);
            }

        }

        public static List<clsRepuesto> ObtenerRepuestos()
        {
            lstRepuestos.Clear();
            try
            {
                string sql = @"SELECT codigo_repuesto, nombre, categoria, marca, precio, existencias, costo, estado
                    FROM repuesto WHERE existencias > 0 ORDER BY codigo_repuesto";
                using (var con = clsConexion.ObtenerConexion())
                using (var cmd = new SqliteCommand(sql, con))
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        lstRepuestos.Add(new clsRepuesto
                        {
                            CodigoRepuesto = r.GetString(0),
                            NombreRepuesto = r.GetString(1),
                            Categoria = r.GetString(2),
                            Marca = r.GetString(3),
                            Precio = r.GetDecimal(4),
                            Existencias = r.GetInt32(5),
                            Costo = r.GetDecimal(6),
                            Estado = r.GetString(7)

                        });
                    }
                    
                }

                    return lstRepuestos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los servicios: " + ex.Message);
            }
        }
        public static List<clsVehiculos> ObtenerVehiculos()
        {
            lstVehiculos.Clear();

            try
            {
                string sql = @"SELECT codigo_vehiculo, codigo_cliente, placa, marca, modelo, tipo, color, anio, estado
                    FROM vehiculo ORDER BY codigo_vehiculo";
                using (var con = clsConexion.ObtenerConexion())
                using (var cmd = new SqliteCommand(sql, con))
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        lstVehiculos.Add(new clsVehiculos
                        {
                            Codigo = r.GetString(0),
                            Propietario = r.GetString(1),
                            Placa = r.GetString(2),
                            Marca = r.GetString(3),
                            Modelo = r.GetString(4),
                            Tipo = r.GetString(5),
                            Color = r.GetString(6),
                            Anio = r.GetString(7),
                            Estado = r.GetString(8)
                        });
                    }
                    
                }
                return lstVehiculos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los servicios: " + ex.Message);
            }
        }

        public static List<clsOrdenesDeTrabajo> ObtenerOrdenesTrabajo()
        {
            lstOrdenesTrabajo.Clear();
            try
            {
                string sql = @"SELECT codigo_orden, fecha_recepcion, servicio, vehiculo, estado, repuestos
                   FROM orden_trabajo ORDER BY codigo_orden";
                using (var con = clsConexion.ObtenerConexion())
                using (var cmd = new SqliteCommand(sql, con))
                using (var r = cmd.ExecuteReader())

                {
                    while (r.Read())
                    {
                        lstOrdenesTrabajo.Add(new clsOrdenesDeTrabajo
                        {
                            Codigo = r.GetString(0),
                            FechaRecepcion = r.GetDateTime(1),
                            Servicio = r.GetString(2),
                            Vehiculo = r.GetString(3),
                            Estado = r.GetString(4),
                            Repuestos = r.IsDBNull(5) ? null : r.GetString(5)
                        });
                    }
                }
                return lstOrdenesTrabajo;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las órdenes de trabajo: " + ex.Message);
            }
        }
        #endregion
    }
}