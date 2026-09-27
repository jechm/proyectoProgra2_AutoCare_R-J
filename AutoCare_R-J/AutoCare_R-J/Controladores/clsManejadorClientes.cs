using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
        
using AutoCare_R_J.Modelos; 

namespace AutoCare_R_J.Controladores
{
    internal class clsManejadorClientes
    {
        //Atributos
        private IList<clsCliente> lstClientes;

        //Recuperar lista de clientes
        public IList<clsCliente> ObtenerClientes()
        {
            return lstClientes;
        }

        //Constructor
        public clsManejadorClientes()
        {
            lstClientes = new List<clsCliente>();
        }

        #region Modificadores
        //Metodos Modificadores de datos en memoria
        //Agregar nuevo cliente a la lista de clientes
        public void AgregarCliente(clsCliente pCliente)
        {
            lstClientes.Add(pCliente);
        }

        //Eliminar cliente de la lista de clientes
        public void EliminarCliente(clsCliente pCliente)
        {
            lstClientes.Remove(pCliente);
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

        #region Buscador
        //Buscar cliente por codigo
        public clsCliente BuscarClientePorCodigo(string pCodigoCliente)
        {
            int indice = -1;

            foreach (var cliente in lstClientes)
            {
                if (cliente.Codigo == pCodigoCliente)
                {
                    indice = lstClientes.IndexOf(cliente);
                    break;
                }
            }

            if (indice != -1)
            {
                return lstClientes[indice];
            }
            else
            {
                return null;
            }

        }
        #endregion

    }
}
