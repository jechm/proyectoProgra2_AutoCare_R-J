using AutoCare_R_J.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoCare_R_J.Modelos;

namespace AutoCare_R_J.Controladores
{
    internal class clsManejadorCitas
    {
        private IList<clsCita> lstCitas;

        public clsManejadorCitas()
        {
            lstCitas = new List<clsCita>();
        }

        //Recuperar lista de citas
        public IList<clsCita> ObtenerCitas()
        {
            return lstCitas;
        }


        //Metodos Modificadores de datos en memoria 
        public void AgregarCita(clsCita pCita)
        {
            lstCitas.Add(pCita);
        }

        public void EliminarCita(clsCita pCita)
        {
            lstCitas.Remove(pCita);
        }

        public void ModificarCita(clsCita pCita)
        {
            clsCita citaExistente = BuscarCitaPorCodigo(pCita.CodigoCita);
            if (citaExistente != null)
            {
                citaExistente.FechaCita = pCita.FechaCita;
                citaExistente.HoraCita = pCita.HoraCita;
                citaExistente.CodigoCliente = pCita.CodigoCliente;
                citaExistente.CodigoVehiculo = pCita.CodigoVehiculo;
                citaExistente.CodigoTecnico = pCita.CodigoTecnico;
                citaExistente.CodigoServiciosolicitado = pCita.CodigoServiciosolicitado;
                citaExistente.EstadoCita = pCita.EstadoCita;
            }
        }

        //Buscador de cita por codgio
        public clsCita BuscarCitaPorCodigo(string pCodigo)
        {
            int indice = -1;

            foreach (var cita in lstCitas)
            {
                if (cita.CodigoCita == pCodigo)
                {
                    indice = lstCitas.IndexOf(cita);
                    break;
                }
            }

            if (indice !=-1)
            {
                return lstCitas[indice];
            }
            else
            {
                return null;
            }
            
        }
    }
}
