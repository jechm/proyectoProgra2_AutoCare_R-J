using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
        
using AutoCare_R_J.Modelos; 

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

    }
}
