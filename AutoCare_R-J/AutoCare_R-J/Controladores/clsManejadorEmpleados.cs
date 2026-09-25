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
        private IList<clsEmpleado> lstEmpleados;
        public clsManejadorEmpleados()
        {
            lstEmpleados = new List<clsEmpleado>();
        }

        //Recuperar lista de empleados
        public IList<clsEmpleado> ObtenerEmpleados()
        {
            return lstEmpleados;
        }

        //Metodos Modificadores de datos en memoria
        public void AgregarEmpleado(clsEmpleado pEmpleado)
        {
            lstEmpleados.Add(pEmpleado);
        }

        public void EliminarEmpleado(clsEmpleado pEmpleado)
        {
            lstEmpleados.Remove(pEmpleado);
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
            }
        }

        //Buscador de Empleado por codgio
        public clsEmpleado BuscarEmpleadoPorCodigo(string pCodigo)
        {
            int indice = -1;

            foreach (clsEmpleado empleado in lstEmpleados)
            {
                if (empleado.Codigo == pCodigo)
                {
                    indice = lstEmpleados.IndexOf(empleado);
                    break;
                }
            }

            if (indice != -1)
            {
                return lstEmpleados[indice];
            }
            else
            {
                return null;
            }
        }
    }
}
