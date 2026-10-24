using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using Microsoft.Data.Sqlite;

namespace AutoCare_R_J.MetodosGlobales
{
    internal static class clsConexion
    {
        private static readonly string Cadena =
            "Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "autocare.db");

        public static SqliteConnection Abrir()
        {
            var con = new SqliteConnection(Cadena);
            con.Open();

            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "PRAGMA foreign_keys = ON;";
                cmd.ExecuteNonQuery();
            }
            return con;
        }
    }
}
