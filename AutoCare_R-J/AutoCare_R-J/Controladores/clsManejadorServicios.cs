using AutoCare_R_J.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCare_R_J.Controladores
{
    internal class clsManejadorServicios
    {
        // Creación de la lista de servicios
        private List<clsServicios> lstServicios = new List<clsServicios>();

        // Método para generar el siguiente código automático (ej. srv-001)
        public string ObtenerSiguienteCodigo()
        {
            int siguienteNumero = lstServicios.Count + 1;
            return $"SRV-{siguienteNumero:D3}"; // Formatea con ceros a la izquierda: srv-001, srv-002...
        }

        // Creación de método para agregar un servicio
        public void AgregarServicio(string strNombre, string strCategoria, double dblCosto, string strDescripcion, string strDuracion)
        {
            try
            {
                clsServicios nuevoServicio = new clsServicios();

                nuevoServicio.Codigo = ObtenerSiguienteCodigo();
                nuevoServicio.Nombre = strNombre;
                nuevoServicio.Categoria = strCategoria;
                nuevoServicio.Costo = dblCosto;
                nuevoServicio.Descripcion = strDescripcion;
                nuevoServicio.Duracion = strDuracion;

                lstServicios.Add(nuevoServicio);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el servicio: " + ex.Message);
            }
        }

        public clsServicios BuscarServicio(string strCodigo, string strNombre)
        {
            clsServicios servicioEncontrado = lstServicios.FirstOrDefault(s => s.Codigo == strCodigo || s.Nombre == strNombre);
            if (servicioEncontrado == null)
            {
                throw new Exception("Servicio no encontrado");
            }

            return servicioEncontrado;
        }


        public void EliminarServicio(string strCodigo)
        {
            clsServicios servicioEncontrado = lstServicios.FirstOrDefault(s => s.Codigo == strCodigo);
            if (servicioEncontrado != null)
            {
                lstServicios.Remove(servicioEncontrado);
            }
            else
            {
                throw new Exception("Servicio no encontrado");
            }
        }

        public void ModificarServicio(string strCodigo, string strNombre, string strCategoria, double dblCosto, string strDescripcion, string strDuracion)
        {
            clsServicios servicioEncontrado = lstServicios.FirstOrDefault(s => s.Codigo == strCodigo);
            if (servicioEncontrado != null)
            {
                servicioEncontrado.Nombre = strNombre;
                servicioEncontrado.Categoria = strCategoria;
                servicioEncontrado.Costo = dblCosto;
                servicioEncontrado.Descripcion = strDescripcion;
                servicioEncontrado.Duracion = strDuracion;
            }
            else
            {
                throw new Exception("Servicio no encontrado");
            }
        }

        public List<clsServicios> ListarServicios()
        {
            return lstServicios;
        }
    }
}