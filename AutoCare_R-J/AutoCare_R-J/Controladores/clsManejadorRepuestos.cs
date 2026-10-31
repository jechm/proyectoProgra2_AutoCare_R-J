using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoCare_R_J.MetodosGlobales;
using AutoCare_R_J.Modelos;
using Microsoft.Data.Sqlite;

namespace AutoCare_R_J.Controladores
{
    public class clsManejadorRepuestos
    {
        //Atributos
        private IList<clsRepuesto> lstRepuestos;

        //Recuperar lista de repuestos
        public IList<clsRepuesto> ObtenerRepuestos()
        {
            return lstRepuestos;
        }

        //Constructor
        public clsManejadorRepuestos()
        {
            lstRepuestos = new List<clsRepuesto>();
        }

        #region Metodos Varios
        private bool ValidarDatos()
        {
            
            return true;

        }
        #endregion

        /*
 * 1. codigo
 * 2. nombre
 * 3. marca
 * 4. categoria
 * 5. costo
 * 6. precio
 * 7. existencia
 * 8. estado
 */

        #region Traer Todos Los Repuestos
        public IList<clsRepuesto> ObtenerRegsitros()
        {
            //crear solicitud sql
            string sql = @"SELECT codigo_repuesto, nombre, marca, categoria, costo, precio, existencia, estado 
FROM repuesto
ORDER BY codigo_repuesto";


            //hacer la conexion
            using(var con = clsConexion.ObtenerConexion())
            using(var cmd = new SqliteCommand(sql, con))
            using(var r= cmd.ExecuteReader())
            {
                while (r.Read())
                {
                    clsRepuesto repuestoTemporal = new clsRepuesto(
                        r.GetString(0),
                        r.GetString(1),
                        r.GetString(2),
                        r.GetString(3),
                        Convert.ToDecimal(r.GetString(4)),
                        Convert.ToDecimal(r.GetString(5)),
                        Convert.ToInt32(r.GetString(6)),
                        r.GetString(7)
                        );
                    lstRepuestos.Add(repuestoTemporal);
                }
            }

            return lstRepuestos;
        }

        #endregion

        #region Nuevos Registros y Actualizacioens

        #region Nuevo Registro
        private void nuevoRepuesto(string pCodigo,
 string pNombre,
 string pMarca,
 string pCategoria,
 decimal pCosto,
 decimal pPrecio,
 int pExistencia,
 string pEstado)
        {

            string sql = @"INSERT INTO repuesto
(codigo_repuesto, nombre, marca, categoria, costo, precio, existencia, estado)
VALUES (@codigo, @nombre, @marca, @categoria, @costo, @precio, @existencia, @estado)";

            using(var con = clsConexion.ObtenerConexion())
            using(var cmd = new SqliteCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@codigo", )
            }


        }


        #endregion
    }
}

