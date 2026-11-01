        
using AutoCare_R_J.MetodosGlobales;
using AutoCare_R_J.Modelos;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCare_R_J.Controladores
{
    internal class clsManejadorClientes
    {
        //Atributos
        private IList<clsCliente> lstClientes;


        //Recuperar lista de clientes
        public IList<clsCliente> ObtenerClientes()
        {
            lstClientes = TraerClientesDB();
            return lstClientes;
        }


        //Constructor
        public clsManejadorClientes()
        {
            lstClientes = new List<clsCliente>();

        }

        #region Modificadores

        #endregion

        #region Buscadores

        #region Busquedas por Valores Unicos

        //Buscar cliente recibe la columna de busqueda y el parametro de busqueda, devuelve un objeto cliente si lo encuentra, de lo contrario devuelve null
        public IList<clsCliente> BuscarClienteParaValidaciones(string[] parametroDeBusqueda)
        {
            IList<clsCliente> clientesEncontrados = new List<clsCliente>();
            clsCliente clienteTemporal;
            try
            {
                // Codigo, DPI,  Nit,  Correo, Telefono
                string sql = @"SELECT * FROM clientes WHERE 
codigo = @pCodigo OR
dpi = @pDPI OR
nit = @pNit OR
correo = @pCorreo OR
telefono = @pTelefono";

                //hacer la conexion
                using (var con = clsConexion.ObtenerConexion())
                {
                    if (con.State != System.Data.ConnectionState.Open)
                        con.Open();

                    using (var cmd = new SqliteCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@pCodigo", parametroDeBusqueda[0]);
                        cmd.Parameters.AddWithValue("@pDPI", parametroDeBusqueda[1]);
                        cmd.Parameters.AddWithValue("@pNit", parametroDeBusqueda[2]);
                        cmd.Parameters.AddWithValue("@pCorreo", parametroDeBusqueda[3]);
                        cmd.Parameters.AddWithValue("@pTelefono", parametroDeBusqueda[4]);

                        using (var r = cmd.ExecuteReader())
                        {

                            while (r.Read())
                            {
                                clienteTemporal = new clsCliente(
                                    r.GetString(0),
                                    r.GetString(1),
                                    r.GetString(2),
                                    r.GetString(3),
                                    r.GetString(4),
                                    r.GetString(5),
                                    r.GetString(6),
                                    r.GetString(7),
                                    r.GetString(8)
                                    );

                                clientesEncontrados.Add(clienteTemporal);
                            }


                        }
                    }
                }


            }
            catch (Exception e)
            {
                MessageBox.Show($"Error encontrado:\n{e}");

            }


            return clientesEncontrados;
        }


        //buscar clientes por un solo parametro
        public clsCliente BuscarClientePorParametroUnico(string columna, string parametroDebusqueda)
        {
            
            using (var con = clsConexion.ObtenerConexion())
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                //Crear sentencia sql para actualizar registro
                string sql = $@"SELECT * FROM clientes WHERE {columna} = @parametroDebusqueda";

                using (var cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@parametroDebusqueda", parametroDebusqueda);

                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            return new clsCliente(
                                r.GetString(0), //codigo
                                r.GetString(1), //nombres
                                r.GetString(2), //apellidos
                                r.GetString(3), //dpi
                                r.GetString(4),//telefono
                                r.GetString(5),//correo
                                r.GetString(6),//direccion
                                r.GetString(7), //estado
                                r.GetString(8) //nit
                            );
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }

           // throw new ArgumentException("Cliente no encontrado");
        }

        #endregion

        #region Busquedas por valores repetibles
        public IList<clsCliente> BuscarClientePorParametroRepetibles(string columna, string parametroDebusqueda)
        {
            var clientesEncontrados = new List<clsCliente>();

            using (var con = clsConexion.ObtenerConexion())
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                //Crear sentencia sql para actualizar registro
                string sql = $@"SELECT * FROM clientes WHERE {columna} LIKE @parametroDebusqueda";

                using (var cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@parametroDebusqueda", $"%{parametroDebusqueda}%");

                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            clientesEncontrados.Add(new clsCliente(
                                r.GetString(0), //codigo
                                r.GetString(1), //nombres
                                r.GetString(2), //apellidos
                                r.GetString(3), //dpi
                                r.GetString(4),//telefono
                                r.GetString(5),//correo
                                r.GetString(6),//direccion
                                r.GetString(7), //estado
                                r.GetString(8) //nit
                            ));


                        }
                    }
                }
            }

            return clientesEncontrados;
        }

        #endregion



        #region Validaciones

        //validar datos
        private bool ValidarDatos(string pCodigo, string pNombres, string pApellidos, string pDpi, string pTelefono, string pCorreo, string pEstado, string pNit)
        {
            //validaciones en codigo
            if (string.IsNullOrWhiteSpace(pCodigo))
            {
                MessageBox.Show("El campo Codigo no puede estar vacio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(pNombres))
            {
                MessageBox.Show("El campo Nombre no puede estar vacio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(pApellidos))
            {
                MessageBox.Show("El campo Apellidos no puede estar vacio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(pDpi) || pDpi.Length != 13)
            {
                MessageBox.Show("El DPI ingresado no es valido");
                return false;
            }

            if (string.IsNullOrWhiteSpace(pTelefono) || pTelefono.Length != 8)
            {
                MessageBox.Show("El Teléfono ingresado no es valido");
                return false;
            }

            if (string.IsNullOrWhiteSpace(pCorreo) || !pCorreo.Contains("@"))
            {
                MessageBox.Show("El Correo Ingresado no es valido");
                return false;
            }

            if (string.IsNullOrWhiteSpace(pEstado))
            {
                MessageBox.Show("El campo Estado no puede estar vacio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(pNit) || pNit.Length < 6)
            {
                MessageBox.Show("El campo NIT no puede estar vacio y debe tener al menos 6 caracteres");
                return false;
            }

            return true;

        }

        //validar si el cliente existe
        private bool ValidarClienteExistente(string pCodigo, string pDPI, string pNit, string pCorreo, string pTelefono)
        {
            string[] parametrosDeBusqueda = new string[] { pCodigo, pDPI, pNit, pCorreo, pTelefono };
            IList<clsCliente> listaClientesTemporal = BuscarClienteParaValidaciones(parametrosDeBusqueda);

            foreach (clsCliente cliente in listaClientesTemporal)
            {
                if (cliente.Codigo == pCodigo)
                {
                    MessageBox.Show("Ya existe un cliente con el mismo código");
                    return false;
                }
                if (cliente.DPI == pDPI)
                {
                    MessageBox.Show("Ya existe un cliente con el mismo DPI");
                    return false;
                }
                if (cliente.Nit == pNit)
                {
                    MessageBox.Show("El Nit no es valido");
                    return false;
                }
                if (cliente.Correo == pCorreo)
                {
                    MessageBox.Show("Ya existe un cliente con el mismo correo");
                    return false;
                }
                if (cliente.Telefono == pTelefono)
                {
                    MessageBox.Show("Ya existe un cliente con el mismo teléfono");
                    return false;
                }
            }

            return true; // No hay clientes existentes con los mismos datos
        }


        #endregion


        #region Operaciones SQL 
        public bool AgregarCliente(string pCodigo, string pNombres, string pApellidos, string pDpi, string pTelefono, string pCorreo, string pDireccion, string pEstado, string pNit, decimal pSaldo)
        {

            if (!ValidarDatos(pCodigo, pNombres, pApellidos, pDpi, pTelefono, pCorreo, pEstado, pNit))
                return false;

            if (!ValidarClienteExistente(pCodigo, pDpi, pNit, pCorreo, pTelefono))
                return false;

            //si la direccion esta vacia, se asigna un valor por defecto
            pDireccion = string.IsNullOrWhiteSpace(pDireccion) ? "No Indicada" : pDireccion;

            using (var con = clsConexion.ObtenerConexion())
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                clsCliente clienteTemporal = new clsCliente(pCodigo, pNombres, pApellidos, pDpi, pTelefono, pCorreo, pDireccion, pEstado, pNit);

                //Crear sentencia sql para nuevo registro
                string sql = @"INSERT INTO clientes
VALUES (@Codigo, @Nombres, @Apellidos, @Dpi, @Telefono, @Correo, @Direccion, @Estado, @Nit, @Saldo)";

                using (var cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Codigo", clienteTemporal.Codigo);
                    cmd.Parameters.AddWithValue("@Nombres", clienteTemporal.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", clienteTemporal.Apellido);
                    cmd.Parameters.AddWithValue("@Dpi", clienteTemporal.DPI);
                    cmd.Parameters.AddWithValue("@Telefono", clienteTemporal.Telefono);
                    cmd.Parameters.AddWithValue("@Correo", clienteTemporal.Correo);
                    cmd.Parameters.AddWithValue("@Direccion", clienteTemporal.Direccion);
                    cmd.Parameters.AddWithValue("@Estado", clienteTemporal.Estado);
                    cmd.Parameters.AddWithValue("@Nit", clienteTemporal.Nit);
                    cmd.Parameters.AddWithValue("@Saldo", clienteTemporal.Saldo);

                    return cmd.ExecuteNonQuery() > 0;

                }

            }


        }


        public bool ActualizarCliente(string pCodigo, string pNombres, string pApellidos, string pDpi, string pTelefono, string pCorreo, string pDireccion, string pEstado, string pNit)
        {

            if (!ValidarDatos(pCodigo, pNombres, pApellidos, pDpi, pTelefono, pCorreo, pEstado, pNit))
                return false;

            clsCliente clienteTemporal = new clsCliente(pCodigo, pNombres, pApellidos, pDpi, pTelefono, pCorreo, pDireccion, pEstado, pNit);

            if (clienteTemporal == null)
            {
                MessageBox.Show("No se encontró el cliente con el código proporcionado.");
                return false;
            }

            using (var con = clsConexion.ObtenerConexion())
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                //Crear sentencia sql para actualizar registro
                string sql = @"UPDATE clientes SET nombres = @Nombres, apellidos = @Apellidos, telefono = @Telefono, correo = @Correo, direccion = @Direccion, estado = @Estado, saldo = @Saldo WHERE codigo = @Codigo";

                using (var cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Codigo", clienteTemporal.Codigo);
                    cmd.Parameters.AddWithValue("@Nombres", clienteTemporal.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", clienteTemporal.Apellido);
                    //  cmd.Parameters.AddWithValue("@Dpi", clienteTemporal.DPI); no se cambia
                    cmd.Parameters.AddWithValue("@Telefono", clienteTemporal.Telefono);
                    cmd.Parameters.AddWithValue("@Correo", clienteTemporal.Correo);
                    cmd.Parameters.AddWithValue("@Direccion", clienteTemporal.Direccion);
                    cmd.Parameters.AddWithValue("@Estado", clienteTemporal.Estado);
                    //  cmd.Parameters.AddWithValue("@Nit", clienteTemporal.Nit); no se cambia
                    cmd.Parameters.AddWithValue("@Saldo", clienteTemporal.Saldo);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool ActualizarSaldoCliente(string pCodigo, decimal pNuevoSaldo)
        {
            using (var con = clsConexion.ObtenerConexion())
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                //Crear sentencia sql para actualizar registro
                string sql = @"UPDATE clientes SET saldo = @Saldo WHERE codigo = @Codigo";
                using (var cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Codigo", pCodigo);
                    cmd.Parameters.AddWithValue("@Saldo", pNuevoSaldo);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


        //obtener todos los clientes de la base de datos
        private IList<clsCliente> TraerClientesDB()
        {
            IList<clsCliente> clientesEncontrados = new List<clsCliente>();

            using (var con = clsConexion.ObtenerConexion())
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                string sql = "SELECT * FROM clientes ORDER BY codigo";

                using (var cmd = new SqliteCommand(sql, con))
                {
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            clsCliente clienteTemporal = new clsCliente(
                                r.GetString(0), //codigo
                                r.GetString(1), //nombres
                                r.GetString(2), //apellidos
                                r.GetString(3), //dpi
                                r.GetString(4),//telefono
                                r.GetString(5),//correo
                                r.GetString(6),//direccion
                                r.GetString(7), //estado
                                r.GetString(8) //nit

                                );

                            clientesEncontrados.Add(clienteTemporal);

                        }
                    }
                }

                return clientesEncontrados;
            }

        }
        #endregion

        //Delete
        #region Eliminar Clientes

        public bool EliminarCliente(string pCodigo)
        {

            string sql = "DELETE FROM clientes WHERE codigo = @codigo";

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

        //siguiente codigo  
        public string ObtenerSiguienteCodigo()
        {
            string sql = "SELECT MAX(codigo) FROM clientes";

            using (var con = clsConexion.ObtenerConexion())
            {

                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                using (var cmd = new SqliteCommand(sql, con))
                {
                    object resultado = cmd.ExecuteScalar();

                    if (resultado == null || resultado == DBNull.Value)
                        return "CL-001";

                    int numero = int.Parse(resultado.ToString().Substring(3)) + 1;
                    return $"CL-{numero:000}";
                }
            }
        }

        #endregion
    }
}


