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


        // Creación de método para agregar un servicio
        public void AgregarServicio(string strNombre, string strCategoria, double dblCosto, string strDescripcion, string strDuracion)
        {
            try
            {
                clsServicios nuevoServicio = new clsServicios();

                nuevoServicio.Codigo = clsMetodosGlobales.ObtenerSiguienteCodigo("servicio");
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
            BuscarSql(strCodigo, out clsServicios servicioEncontrado);
            if (servicioEncontrado == null)
            {
                throw new Exception("Servicio no encontrado");
            }

            return servicioEncontrado;
        }


        public void EliminarServicio(string strCodigo)
        {
            
            try
            {
                EliminarSql(strCodigo);                 
            }
            catch (SqliteException ex) when (ex.SqliteErrorCode == 19)
            {
                throw new Exception("No se puede eliminar: el servicio ya está usado en citas o facturas.");
            }
        }


        public void ModificarServicio(string strCodigo, string strNombre, string strCategoria,
                              double dblCosto, string strDescripcion, string strDuracion)
        {
            
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

        }

        public List<clsServicios> ListarServicios()
        {
            lstServicios.Clear();
            lstServicios = clsMetodosGlobales.ObtenerServicios();
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

        public int BuscarSql(string codigo, out clsServicios servicio)
        {
            string sql = "SELECT * FROM servicio WHERE codigo_servicio = @codigo";
            using (var con = clsConexion.ObtenerConexion())
            using (var cmd = new SqliteCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@codigo", codigo);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        servicio = new clsServicios
                        {
                            Codigo = reader["codigo_servicio"].ToString(),
                            Nombre = reader["nombre"].ToString(),
                            Categoria = reader["categoria"]?.ToString(),
                            Costo = Convert.ToDouble(reader["costo"]),
                            Descripcion = reader["descripcion"]?.ToString(),
                            Duracion = reader["duracion_min"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("duracion_min")).ToString() : "0"
                        };
                        return 1; // encontrado
                    }
                    else
                    {
                        servicio = null;
                        return 0; // no encontrado
                    }
                }
            }
        }

        #endregion
    }
}