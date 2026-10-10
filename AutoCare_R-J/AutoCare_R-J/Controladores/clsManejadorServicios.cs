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
                // Creamos una nueva instancia fresca cada vez que se agrega un servicio
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

            return servicioEncontrado; // ¡Aquí está la clave para que devuelva el objeto!
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

        // Método para listar si lo necesitas en tu DataGridView
        public List<clsServicios> ListarServicios()
        {
            return lstServicios;
        }
    }
}