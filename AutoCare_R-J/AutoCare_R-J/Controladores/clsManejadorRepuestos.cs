using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        private bool ValidarDatos(string pCodigo, string pNombre, string pMarca, string pCategoria, decimal pPrecio, string pEstado)
        {
            //validaciones en codigo
            if (string.IsNullOrWhiteSpace(pCodigo))
            {
                MessageBox.Show("El campo Codigo no puede estar vacio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(pNombre))
            {
                MessageBox.Show("El campo Nombre no puede estar vacio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(pMarca))
            {
                MessageBox.Show("El campo Marca no puede estar vacio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(pCategoria))
            {
                MessageBox.Show("El campo Categoria no puede estar vacio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(pEstado))
            {
                MessageBox.Show("El campo Estado no puede estar vacio");
                return false;
            }

            if (pPrecio<=0)
            {
                MessageBox.Show("El campo Precio no puede ser  0 o negativo");
                return false;
            }

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

        //read
        #region Traer Todos Los Repuestos
        public IList<clsRepuesto> ObtenerRegsitros()
        {

            IList<clsRepuesto> repuestosEncontrados = new List<clsRepuesto>();
            //crear solicitud sql
            string sql = @"SELECT codigo_repuesto, nombre, marca, categoria, costo, precio, existencias, estado 
FROM repuesto
ORDER BY codigo_repuesto";


            //hacer la conexion
            using (var con = clsConexion.ObtenerConexion())
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                using (var cmd = new SqliteCommand(sql, con))
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        clsRepuesto repuestoTemporal = new clsRepuesto(
                            r.GetString(0),
                            r.GetString(1),
                            r.GetString(2),
                            r.GetString(3),
                            (r.GetDecimal(4)),
                            (r.GetDecimal(5)),
                            (r.GetInt32(6)),
                            r.GetString(7)
                            );
                        repuestosEncontrados.Add(repuestoTemporal);
                    }
                }
            }

            return repuestosEncontrados;
        }

        #endregion


        //Create y Update
        #region Nuevos Registros y Actualizacioens

        #region Nuevo Registro (bool)
        public bool nuevoRepuesto(string pCodigo, string pNombre, string pMarca, string pCategoria, decimal pCosto, decimal pPrecio, int pExistencia, string pEstado)
        {


            if (!ValidarDatos(pCodigo, pNombre, pMarca, pCategoria, pPrecio, pEstado))
                return false;

            //revisar si el codigo ya existe en la base de datos
            if (BuscarRepuestoPorCodigo(pCodigo) != null)
            {
                MessageBox.Show($"Ya Existe un repuesto con codigo {pCodigo}");
                return false;
            }

            clsRepuesto repuestoTemproral = new clsRepuesto(pCodigo, pNombre, pMarca, pCategoria, pCosto, pPrecio, pExistencia, pEstado);

            //Crear sentencia sql para nuevo registro
            string sql = @"INSERT INTO repuesto
(codigo_repuesto, nombre, marca, categoria, costo, precio, existencias, estado)
VALUES (@codigo, @nombre, @marca, @categoria, @costo, @precio, @existencia, @estado)";

            using(var con = clsConexion.ObtenerConexion()){

                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();


                using (var cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@codigo", repuestoTemproral.CodigoRepuesto);
                    cmd.Parameters.AddWithValue("@nombre", repuestoTemproral.NombreRepuesto);
                    cmd.Parameters.AddWithValue("@marca", repuestoTemproral.Marca);
                    cmd.Parameters.AddWithValue("@categoria", repuestoTemproral.Categoria);
                    cmd.Parameters.AddWithValue("@costo", repuestoTemproral.Costo);
                    cmd.Parameters.AddWithValue("@precio", repuestoTemproral.Precio);
                    cmd.Parameters.AddWithValue("@existencia", repuestoTemproral.Existencias);
                    cmd.Parameters.AddWithValue("@estado", repuestoTemproral.Estado);

                    return cmd.ExecuteNonQuery() > 0;

                }
                
            }


        }


        #endregion

        #region Actualizar Registro (bool)

        public bool ActualizarRegistro(string pCodigo, string pNombre, string pMarca, string pCategoria, decimal pCosto, decimal pPrecio, int pExistencia, string pEstado)
        {
            if (!ValidarDatos(pCodigo, pNombre, pMarca, pCategoria, pPrecio, pEstado))
                return false;

            //revisar si el codigo ya existe en la base de datos
            if (BuscarRepuestoPorCodigo(pCodigo) == null)
            {
                MessageBox.Show($"No Existe repuesto con codigo {pCodigo}");
                return false;
            }

            clsRepuesto repuestoTemproral = new clsRepuesto(pCodigo, pNombre, pMarca, pCategoria, pCosto, pPrecio, pExistencia, pEstado);

            //Crear sentencia sql para nuevo registro
            string sql = @"UPDATE repuesto
SET nombre = @nombre,
marca = @marca,
categoria = @categoria,
costo = @costo,
precio = @precio,
existencias = @existencia,
estado = @estado
WHERE codigo_repuesto = @codigo";

            using (var con = clsConexion.ObtenerConexion())
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                using (var cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@codigo", repuestoTemproral.CodigoRepuesto);
                    cmd.Parameters.AddWithValue("@nombre", repuestoTemproral.NombreRepuesto);
                    cmd.Parameters.AddWithValue("@marca", repuestoTemproral.Marca);
                    cmd.Parameters.AddWithValue("@categoria", repuestoTemproral.Categoria);
                    cmd.Parameters.AddWithValue("@costo", repuestoTemproral.Costo);
                    cmd.Parameters.AddWithValue("@precio", repuestoTemproral.Precio);
                    cmd.Parameters.AddWithValue("@existencia", repuestoTemproral.Existencias);
                    cmd.Parameters.AddWithValue("@estado", repuestoTemproral.Estado);

                    return cmd.ExecuteNonQuery() > 0;

                }
            }

        }

        #endregion

        #endregion

        //Delete
        #region Eliminar Productos

        public bool EliminarProductos(string pCodigo)
        {

            string sql = "DELETE FROM repuesto WHERE codigo_repuesto = @codigo";

            using (var con = clsConexion.ObtenerConexion())
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                using (var cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@codigo", pCodigo);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

        }

        #endregion

        #region Busquedas

        /*Orden Base de Datos
* 0. codigo
* 1. nombre
* 2. categoria
* 3. marca
* 4. precio
* 5. existencia
* 6. estado
* 7. costo
*/

        /* orden objeto
* 0. codigo     00
* 1. nombre     11
* 2. marca      23
* 3. categoria  32
* 4. costo      47
* 5. precio     54
* 6. existencia 65
* 7. estado     76
*/

        //Buscar repuesto por codigo
        public clsRepuesto BuscarRepuestoPorCodigo(string pCodigo)
        {
            clsRepuesto repuestoTemporal;
            try
            {
                string sql = @"SELECT * FROM repuesto WHERE codigo_repuesto = @codigo";

                //hacer la conexion
                using (var con = clsConexion.ObtenerConexion())
                {
                    if (con.State != System.Data.ConnectionState.Open)
                        con.Open();

                    using (var cmd = new SqliteCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@codigo", pCodigo);

                        using (var r = cmd.ExecuteReader())
                        {

                            if (r.Read())
                            {
                                repuestoTemporal = new clsRepuesto(
                                    r.GetString(0),
                                    r.GetString(1),
                                    r.GetString(3),
                                    r.GetString(2),
                                    Convert.ToDecimal(r.GetString(7)),
                                    Convert.ToDecimal(r.GetString(4)),
                                    Convert.ToInt32(r.GetString(5)),
                                    r.GetString(6)
                                    );
                            }
                            else
                            {
                                repuestoTemporal = null;
                            }

                        }
                    }
                }


            }
            catch(Exception e)
            {
                MessageBox.Show($"Error encontrado:\n{e}");
                repuestoTemporal = null;

            }


            return repuestoTemporal;
        }

        //Buscar repuesto por nombre
        public IList<clsRepuesto> BuscarRepuestos(string columnaDeBusqueda, string datoBusqueda)

        {

            IList<clsRepuesto> repuestosEncontrados = new List<clsRepuesto>();
            //crear solicitud sql
            string sql = $@"SELECT codigo_repuesto, nombre, marca, categoria, costo, precio, existencias, estado 
FROM repuesto WHERE {columnaDeBusqueda} LIKE @datoBusqueda";


            //hacer la conexion
            using (var con = clsConexion.ObtenerConexion())
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                using (var cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@datoBusqueda", $"%{datoBusqueda}%");

                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            clsRepuesto repuestoTemporal = new clsRepuesto(
                                r.GetString(0),
                                r.GetString(1),
                                r.GetString(2),
                                r.GetString(3),
                                (r.GetDecimal(4)),
                                (r.GetDecimal(5)),
                                (r.GetInt32(6)),
                                r.GetString(7)
                                );
                            repuestosEncontrados.Add(repuestoTemporal);
                        }
                    }
                }
            }

            return repuestosEncontrados;
        }

        #endregion


            //siguiente codigo  
        public string ObtenerSiguienteCodigo()
        {
            string sql = "SELECT MAX(codigo_repuesto) FROM repuesto";

            using (var con = clsConexion.ObtenerConexion())
            {

                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                using (var cmd = new SqliteCommand(sql, con))
                {
                    object resultado = cmd.ExecuteScalar();

                    if (resultado == null || resultado == DBNull.Value)
                        return "RP-001";

                    int numero = int.Parse(resultado.ToString().Substring(4)) + 1;
                    return $"RP-{numero:000}";
                }
            }
        }
    }
}

