using AutoCare_R_J.Modelos;
using AutoCare_R_J.MetodosGlobales;
using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.Linq;

namespace AutoCare_R_J.Controladores
{
    internal class clsManejadorServicios
    {
        // Creación de la lista de servicios
        private List<clsServicios> lstServicios = new List<clsServicios>();

        // Método para generar el siguiente código automático (ej. srv-001)
        public string ObtenerSiguienteCodigo()
        {
            string sql = "SELECT MAX(codigo_servicio) FROM servicio";

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

        // Creación de método para agregar un servicio
        public void AgregarServicio(string strNombre, string strCategoria, double dblCosto, string strDescripcion, string strDuracion)
        {
            try
            {
                clsServicios nuevoServicio = new clsServicios();

                nuevoServicio.Codigo = ObtenerSiguienteCodigo();
                nuevoServicio.Nombre = strNombre;
                nuevoServicio.Categoria = strCategoria;
                nuevoServicio.Costo = dblCosto;
                nuevoServicio.Descripcion = strDescripcion;
                nuevoServicio.Duracion = strDuracion;

                lstServicios.Add(nuevoServicio);

                AgregarSql(nuevoServicio);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el servicio: " + ex.ToString());
            }
        }

        public clsServicios BuscarServicio(string strCodigo, string strNombre)
        {
            clsServicios servicioEncontrado = lstServicios.FirstOrDefault(s => s.Codigo == strCodigo || s.Nombre == strNombre);
            if (servicioEncontrado == null)
            {
                throw new Exception("Servicio no encontrado");
            }

            return servicioEncontrado;
        }


        public void EliminarServicio(string strCodigo)
        {
            clsServicios servicioEncontrado = lstServicios.FirstOrDefault(s => s.Codigo == strCodigo);
            if (servicioEncontrado == null)
                throw new Exception("Servicio no encontrado");

            try
            {
                EliminarSql(strCodigo);                 
                lstServicios.Remove(servicioEncontrado);
            }
            catch (SqliteException ex) when (ex.SqliteErrorCode == 19)
            {
                throw new Exception("No se puede eliminar: el servicio ya está usado en citas o facturas.");
            }
        }


        public void ModificarServicio(string strCodigo, string strNombre, string strCategoria,
                              double dblCosto, string strDescripcion, string strDuracion)
        {
            clsServicios servicioEncontrado = lstServicios.FirstOrDefault(s => s.Codigo == strCodigo);
            if (servicioEncontrado == null)
                throw new Exception("Servicio no encontrado");

            // Objeto con los datos nuevos, para guardarlo antes de tocar la lista
            var actualizado = new clsServicios
            {
                Codigo = strCodigo,
                Nombre = strNombre,
                Categoria = strCategoria,
                Costo = dblCosto,
                Descripcion = strDescripcion,
                Duracion = strDuracion
            };

            ActualizarSql(actualizado);   // si falla, la lista no cambia

            servicioEncontrado.Nombre = strNombre;
            servicioEncontrado.Categoria = strCategoria;
            servicioEncontrado.Costo = dblCosto;
            servicioEncontrado.Descripcion = strDescripcion;
            servicioEncontrado.Duracion = strDuracion;
        }

        public List<clsServicios> ListarServicios()
        {
            return lstServicios;
        }

        private int? DuracionAMinutos(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return null;

            var nums = System.Text.RegularExpressions.Regex.Matches(texto, @"\d+");

            if (nums.Count == 2)   // horas y minutos
                return int.Parse(nums[0].Value) * 60 + int.Parse(nums[1].Value);
            if (nums.Count == 1)   // solo un número: se toma como minutos
                return int.Parse(nums[0].Value);

            return null;
        }
        private string MinutosADuracion(int minutos)
        {
            int h = minutos / 60;
            int m = minutos % 60;
            return $"{h}h {m}min";
        }

        #region operaciones con la base de datos
        public int AgregarSql(clsServicios s)
        {
            string sql = @"
        INSERT INTO servicio
        (codigo_servicio, nombre, categoria, costo, descripcion, duracion_min)
        VALUES
        (@codigo, @nombre, @categoria, @costo, @descripcion, @duracion)";

            using (var con = clsConexion.ObtenerConexion())
            using (var cmd = new SqliteCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@codigo", s.Codigo);
                cmd.Parameters.AddWithValue("@nombre", s.Nombre);
                cmd.Parameters.AddWithValue("@categoria", (object)s.Categoria ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@costo", s.Costo);
                cmd.Parameters.AddWithValue("@descripcion", (object)s.Descripcion ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@duracion", (object)DuracionAMinutos(s.Duracion) ?? DBNull.Value);

                return cmd.ExecuteNonQuery();
            }
        }

        public void CargarServiciosDesdeSql()
        {
            lstServicios.Clear();

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
        }
        public int EliminarSql(string codigo)
        {
            string sql = "DELETE FROM servicio WHERE codigo_servicio = @codigo";

            using (var con = clsConexion.ObtenerConexion())
            using (var cmd = new SqliteCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@codigo", codigo);
                return cmd.ExecuteNonQuery();
            }
        }

        public int ActualizarSql(clsServicios s)
        {
            string sql = @"
        UPDATE servicio
        SET nombre = @nombre,
            categoria = @categoria,
            costo = @costo,
            descripcion = @descripcion,
            duracion_min = @duracion
        WHERE codigo_servicio = @codigo";

            using (var con = clsConexion.ObtenerConexion())
            using (var cmd = new SqliteCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@codigo", s.Codigo);
                cmd.Parameters.AddWithValue("@nombre", s.Nombre);
                cmd.Parameters.AddWithValue("@categoria", (object)s.Categoria ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@costo", s.Costo);
                cmd.Parameters.AddWithValue("@descripcion", (object)s.Descripcion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@duracion", (object)DuracionAMinutos(s.Duracion) ?? DBNull.Value);
                return cmd.ExecuteNonQuery();
            }
        }

        #endregion
    }
}