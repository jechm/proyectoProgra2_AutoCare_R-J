using Microsoft.Data.Sqlite;
using System;
using System.IO;

namespace AutoCare_R_J.MetodosGlobales
{
    internal class clsConexion
    {
        // Ruta
        private static readonly string rutaDb =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "autocare");

        private static readonly string cadenaConexion = $"Data Source={rutaDb}";

        // Devuelve una conexión ya abierta
        public static SqliteConnection ObtenerConexion()
        {
            var conexion = new SqliteConnection(cadenaConexion);
            conexion.Open();

            // Activa las llaves foráneas
            using (var cmd = conexion.CreateCommand())
            {
                cmd.CommandText = "PRAGMA foreign_keys = ON;";
                cmd.ExecuteNonQuery();
            }

            return conexion;
        }
    }
}