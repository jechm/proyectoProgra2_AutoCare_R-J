using AutoCare_R_J.MetodosGlobales;
using AutoCare_R_J.Modelos;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoCare_R_J.Controladores
{
    internal class clsManejadorFacturas
    {
        // Creación de la lista de facturas
        private List<clsFacturas> lstFacturas = new List<clsFacturas>();

        //Creacion de lista para ordenes de trabajo
        private List<clsOrdenesDeTrabajo> lstOrdenesTrabajo = new List<clsOrdenesDeTrabajo>();

        //Creaciom de lista para servicios
        private List<clsServicios> lstServicios = new List<clsServicios>();

        //Creacion de lista para repuestos
        private List<clsRepuesto> lstRepuestos = new List<clsRepuesto>();



        // Creación de método para agregar una factura
        public void AgregarFactura(string strCodigoFactura, string strDescripcionServicio, string strCodigoOrden, string strDescuento)
        {
            // 1. Cargar y buscar la orden de trabajo seleccionada usando el código del ComboBox
            var lstOrdenesTrabajo = clsMetodosGlobales.ObtenerOrdenesTrabajo();
            clsOrdenesDeTrabajo ordenTrabajo = lstOrdenesTrabajo.FirstOrDefault(o => o.Codigo == strCodigoOrden);

            if (ordenTrabajo == null)
            {
                throw new Exception("No se encontró la orden de trabajo especificada.");
            }

            // 2. Cargar y buscar el servicio asociado a la orden
            var lstServicios = clsMetodosGlobales.ObtenerServicios();
            clsServicios servicio = lstServicios.FirstOrDefault(s => s.Nombre == ordenTrabajo.Servicio || s.Codigo == ordenTrabajo.Servicio);

            double dblPrecioServicio = servicio != null ? Convert.ToDouble(servicio.Costo) : 0.0;
            string nombreServicio = servicio != null ? servicio.Nombre : ordenTrabajo.Servicio;

            // 3. Cargar todos los repuestos para extraer sus nombres y precios unitarios
            var lstRepuestos = clsMetodosGlobales.ObtenerRepuestos();
            List<string> nombresRepuestosList = new List<string>();
            List<string> preciosRepuestosList = new List<string>();
            double dblTotalRepuestos = 0.0;

            if (!string.IsNullOrEmpty(ordenTrabajo.Repuestos))
            {
                string[] repuestosSeparados = ordenTrabajo.Repuestos.Split(new[] { "\r\n", "\n", "," }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string repName in repuestosSeparados)
                {
                    string nombreLimpio = repName.Trim();
                    clsRepuesto repEncontrado = lstRepuestos.FirstOrDefault(r => r.NombreRepuesto.Equals(nombreLimpio, StringComparison.OrdinalIgnoreCase));

                    nombresRepuestosList.Add(nombreLimpio);

                    if (repEncontrado != null)
                    {
                        preciosRepuestosList.Add(repEncontrado.Precio.ToString());
                        dblTotalRepuestos += Convert.ToDouble(repEncontrado.Precio);
                    }
                    else
                    {
                        preciosRepuestosList.Add("0.00");
                    }
                }
            }

            string strRepuestosConcatenados = string.Join(", ", nombresRepuestosList);
            string strPreciosRepuestosConcatenados = string.Join(", ", preciosRepuestosList);

            // 4. Cálculos de Subtotal, Descuento y Total Final
            double dblDescuento = double.TryParse(strDescuento, out double desc) ? desc : 0.0;
            double dblSubtotal = dblPrecioServicio + dblTotalRepuestos;
            double dblTotalFinal = dblSubtotal - dblDescuento;

            // 5. Construir el objeto factura listo para SQLite (usando tipos double y string correctos)
            clsFacturas nuevaFactura = new clsFacturas
            {
                Codigo = strCodigoFactura,
                Precio = dblPrecioServicio,
                Descuento = dblDescuento,
                Subtotal = dblSubtotal,
                Total = dblTotalFinal,
                DescripcionServicio = strDescripcionServicio,
                Servicio = nombreServicio,
                Vehiculo = ordenTrabajo.Vehiculo,
                Fecha = DateTime.Now.ToString("yyyy-MM-dd"),
                Repuesto = strRepuestosConcatenados,
                PrecioRepuesto = strPreciosRepuestosConcatenados
            };

            // 6. Ejecutar la inserción usando tu método SQL
            AgregarSql(nuevaFactura);
        }

        // Método para listar todas las facturas
        public List<clsFacturas> ListarFacturas()
        {
            lstFacturas.Clear();
            lstFacturas = clsMetodosGlobales.ObtenerFacturas();
            return lstFacturas;
        }

        #region Metodos sqlite
        public int AgregarSql(clsFacturas factura)
        {
            string sql = "INSERT INTO factura (codigo_factura, precio, descuento, subtotal, total, descripcion_servicio, servicio, vehiculo, fecha, repuesto, precio_repuesto) " +
                         "VALUES (@Codigo, @Precio, @Descuento, @Subtotal, @Total, @DescripcionServicio, @Servicio, @Vehiculo, @Fecha, @Repuesto, @PrecioRepuesto)";
            using (var con = clsConexion.ObtenerConexion())
            using (var cmd = new SqliteCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Codigo", factura.Codigo);
                cmd.Parameters.AddWithValue("@Precio", factura.Precio);
                cmd.Parameters.AddWithValue("@Descuento", factura.Descuento);
                cmd.Parameters.AddWithValue("@Subtotal", factura.Subtotal);
                cmd.Parameters.AddWithValue("@Total", factura.Total);
                cmd.Parameters.AddWithValue("@DescripcionServicio", factura.DescripcionServicio);
                cmd.Parameters.AddWithValue("@Servicio", factura.Servicio);
                cmd.Parameters.AddWithValue("@Vehiculo", factura.Vehiculo);
                cmd.Parameters.AddWithValue("@Fecha", factura.Fecha);
                cmd.Parameters.AddWithValue("@Repuesto", factura.Repuesto);
                cmd.Parameters.AddWithValue("@PrecioRepuesto", factura.PrecioRepuesto);
                return cmd.ExecuteNonQuery();
            }
        }
        #endregion
    }
}