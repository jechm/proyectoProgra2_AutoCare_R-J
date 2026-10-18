using AutoCare_R_J.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCare_R_J.Controladores
{
    internal class clsManejadorEmpleados
    {
        //Atributos
        private IList<clsEmpleado> lstEmpleados;
        private int intContadorEmpleados;


        //Recuperar lista de empleados
        public IList<clsEmpleado> ObtenerEmpleados()
        {
            return lstEmpleados;
        }

        public int TotalEmpleados
        {
            get { return intContadorEmpleados; }
            set { intContadorEmpleados = value; }
        }

        //Constructor
        public clsManejadorEmpleados()
        {
            lstEmpleados = new List<clsEmpleado>();
        }

        #region Modificadores

        //Metodos Modificadores de datos en memoria
        public void AgregarEmpleado(clsEmpleado pEmpleado)
        {
            lstEmpleados.Add(pEmpleado);
        }

        public bool EliminarEmpleado(string pCodigoEmpleado)
        {
            clsEmpleado empleadoAEliminar = BuscarEmpleadoPorCodigo(pCodigoEmpleado);
            if (empleadoAEliminar != null)
            {
                lstEmpleados.Remove(empleadoAEliminar);
                return true;
            }

            return false;

        }

        public void ModificarEmpleado(clsEmpleado pEmpleado)
        {
            clsEmpleado empleadoExistente = BuscarEmpleadoPorCodigo(pEmpleado.Codigo);
            if (empleadoExistente != null)
            {
                empleadoExistente.Nombre = pEmpleado.Nombre;
                empleadoExistente.Apellido = pEmpleado.Apellido;
                empleadoExistente.Correo = pEmpleado.Correo;
                empleadoExistente.Telefono = pEmpleado.Telefono;
                empleadoExistente.Direccion = pEmpleado.Direccion;
            }
        }

        #endregion


        #region Buscadores

        #region Busquedas por Valores Unicos

        public clsEmpleado BuscarEmpleadoPorCodigo(string pCodigoEmpleado)
        {
            return lstEmpleados.FirstOrDefault(cl => cl.Codigo.Equals(pCodigoEmpleado, StringComparison.OrdinalIgnoreCase));
        }


        public clsEmpleado BuscarEmpleadoPorDPI(string pDPIEmpleado)
        {
            return lstEmpleados.FirstOrDefault(cl => cl.DPI.Equals(pDPIEmpleado, StringComparison.OrdinalIgnoreCase));
        }

        public clsEmpleado BuscarEmpleadoPorUsuario(string pUsuarioEmpleado)
        {
            return lstEmpleados.FirstOrDefault(cl => cl.Usuario.Equals(pUsuarioEmpleado, StringComparison.OrdinalIgnoreCase));
        }

        public clsEmpleado BuscarEmpleadoPorTelefono(string pTelefono)
        {
            return lstEmpleados.FirstOrDefault(cl => cl.Telefono.Equals(pTelefono, StringComparison.OrdinalIgnoreCase));
        }

        public clsEmpleado BuscarEmpleadoPorCorreo(string pCorreo)
        {
            return lstEmpleados.FirstOrDefault(cl => cl.Correo.Equals(pCorreo, StringComparison.OrdinalIgnoreCase));
        }

        #endregion

        #region Busquedas por valores repetibles
        public IList<clsEmpleado> BuscarEmpleadosPorNombre(string pNombreEmpleado)
        {
            return lstEmpleados.Where(cl => cl.Nombre.Equals(pNombreEmpleado, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public IList<clsEmpleado> BuscarEmpleadosPorApellido(string pApellidoEmpleado)
        {
            return lstEmpleados.Where(cl => cl.Apellido.Equals(pApellidoEmpleado, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public IList<clsEmpleado> BuscarEmpleadosPorDireccion(string pDireccion)
        {
            return lstEmpleados.Where(cl => cl.Direccion.Equals(pDireccion, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public IList<clsEmpleado> BuscarEmpleadosPorEstado(string pEstado)
        {
            return lstEmpleados.Where(cl => cl.Estado.Equals(pEstado, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public IList<clsEmpleado> BuscarEmpleadosPorRol(string pRol)
        {
            return lstEmpleados.Where(cl => cl.Rol.Equals(pRol, StringComparison.OrdinalIgnoreCase)).ToList();
        }


        #endregion

        #endregion


    }
}
