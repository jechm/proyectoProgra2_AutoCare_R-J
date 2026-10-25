        
using AutoCare_R_J.Modelos;
using AutoCare_R_J.MetodosGlobales;
using System;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AutoCare_R_J.Controladores
{
    internal class clsManejadorClientes
    {
        //Atributos
        private IList<clsCliente> lstClientes;
        private int intContadorClientes;

        //Recuperar lista de clientes
        public IList<clsCliente> ObtenerClientes()
        {
            return new List<clsCliente>(lstClientes);
        }

        public int TotalClientes
        {
            get { return intContadorClientes; }
            set { intContadorClientes = value; }
        }

        //Constructor
        public clsManejadorClientes()
        {
            lstClientes = new List<clsCliente>();
            TotalClientes = 0;
        }

        #region Modificadores
        //Metodos Modificadores de datos en memoria
        //Agregar nuevo cliente a la lista de clientes
        public void AgregarCliente(clsCliente pCliente)
        {
            AgregarSql(pCliente);
            lstClientes.Add(pCliente);
        }

        //Eliminar cliente de la lista de clientes
        public bool EliminarCliente(string pCodigoCliente)
        {
            clsCliente clienteAEliminar = BuscarClientePorCodigo(pCodigoCliente);
            if (clienteAEliminar != null)
            {
                lstClientes.Remove(clienteAEliminar);
                return true;
            }
             
            return false;
            
        }

        //Modificar cliente de la lista de clientes
        public void ModificarCliente(clsCliente pCliente)
        {
            clsCliente clienteExistente = BuscarClientePorCodigo(pCliente.Codigo);
            if (clienteExistente != null)
            {
                clienteExistente.Nombre = pCliente.Nombre;
                clienteExistente.Apellido = pCliente.Apellido;
                clienteExistente.Telefono = pCliente.Telefono;
                clienteExistente.Correo = pCliente.Correo;
                clienteExistente.Direccion= pCliente.Direccion;
            }
        }

        #endregion

        #region Buscadores
        
        #region Busquedas por Valores Unicos

        public clsCliente BuscarClientePorCodigo(string pCodigoCliente)
        {
            return lstClientes.FirstOrDefault(cl => cl.Codigo.Equals(pCodigoCliente, StringComparison.OrdinalIgnoreCase));
        }


        public clsCliente BuscarClientePorDPI(string pDPICliente)
        {
            return lstClientes.FirstOrDefault(cl => cl.DPI.Equals(pDPICliente));
        }

        public clsCliente BuscarClientePorNit(string pNitCliente)
        {
            return lstClientes.FirstOrDefault(cl => cl.Nit.Equals(pNitCliente));
        }

        public clsCliente BuscarClientePorTelefono(string pTelefono)
        {
            return lstClientes.FirstOrDefault(cl => cl.Telefono.Equals(pTelefono));
        }

        public clsCliente BuscarClientePorCorreo(string pCorreo)
        {
            return lstClientes.FirstOrDefault(cl => cl.Correo.Equals(pCorreo, StringComparison.OrdinalIgnoreCase));
        }

        #endregion

        #region Busquedas por valores repetibles
        public IList<clsCliente> BuscarClientesPorNombre(string pNombreCliente)
        {
            return lstClientes.Where(cl => cl.Nombre.Equals(pNombreCliente, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public IList<clsCliente> BuscarClientesPorApellido(string pApellidoCliente)
        {
            return lstClientes.Where(cl => cl.Apellido.Equals(pApellidoCliente, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public IList<clsCliente> BuscarClientesPorDireccion(string pDireccion)
        {
            return lstClientes.Where(cl => cl.Direccion.Equals(pDireccion, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public IList<clsCliente> BuscarClientesPorEstado(string pEstado)
        {
            return lstClientes.Where(cl => cl.Estado.Equals(pEstado, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        #endregion

        #endregion


        #region Operaciones SQL 
        public void AgregarSql(clsCliente c)
        {
            using (var con = clsConexion.ObtenerConexion())
            using (var tx = con.BeginTransaction())
            {
                using (var cmd = con.CreateCommand())
                {
                    cmd.Transaction = tx;
                    cmd.CommandText = @"
                INSERT INTO persona
                (codigo_persona, nombre, apellido, dpi, telefono, correo, direccion, estado)
                VALUES
                (@codigo, @nombre, @apellido, @dpi, @telefono, @correo, @direccion, @estado)";
                    cmd.Parameters.AddWithValue("@codigo", c.Codigo);
                    cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", c.Apellido);
                    cmd.Parameters.AddWithValue("@dpi", c.DPI);
                    cmd.Parameters.AddWithValue("@telefono", (object)c.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@correo", (object)c.Correo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@direccion", (object)c.Direccion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@estado", c.Estado);
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = con.CreateCommand())
                {
                    cmd.Transaction = tx;
                    cmd.CommandText = @"
                INSERT INTO cliente (codigo_persona, nit, saldo)
                VALUES (@codigo, @nit, @saldo)";
                    cmd.Parameters.AddWithValue("@codigo", c.Codigo);
                    cmd.Parameters.AddWithValue("@nit", c.Nit);
                    cmd.Parameters.AddWithValue("@saldo", c.Saldo);
                    cmd.ExecuteNonQuery();
                }

                tx.Commit();
            }
        }
        public void CargarClientesDesdeSql()
        {
            lstClientes.Clear();

            string sql = @"
        SELECT p.codigo_persona, p.nombre, p.apellido, p.dpi, p.telefono,
               p.correo, p.direccion, p.estado, c.nit, c.saldo
        FROM persona p
        JOIN cliente c ON c.codigo_persona = p.codigo_persona
        ORDER BY p.codigo_persona";

            using (var con = clsConexion.ObtenerConexion())
            using (var cmd = new SqliteCommand(sql, con))
            using (var r = cmd.ExecuteReader())
            {
                while (r.Read())
                {
                    lstClientes.Add(new clsCliente(
                        r.GetString(0), r.GetString(1), r.GetString(2), r.GetString(3),
                        r.IsDBNull(4) ? "" : r.GetString(4),
                        r.IsDBNull(5) ? "" : r.GetString(5),
                        r.IsDBNull(6) ? "" : r.GetString(6),
                        r.GetString(7), r.GetString(8),
                        Convert.ToDecimal(r.GetValue(9))));  
                }
            }
        }
        #endregion
    }
}
