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
        //creacion de la lista de servicios
        List<clsServicios> lstServicios = new List<clsServicios>();

        //Creacion de objeto de la clase servicios
        //Se agrego el prefijo ob para indicar que es un objeto
        clsServicios obServicio = new clsServicios();

        //Creacion de metodo para agregar un servicio
        public void AgregarServicio(string strCodigo, string strNombre,
            string strCategoria, double dblCosto,
            string strDescripcion, string strDuracion)
        {
            try
            {
                //Aqui se agrego la logica de creacion de un servicio
                obServicio.Codigo = strCodigo;
                obServicio.Nombre = strNombre;
                obServicio.Categoria = strCategoria;
                obServicio.Costo = dblCosto;
                obServicio.Descripcion = strDescripcion;
                obServicio.Duracion = strDuracion;

                //Se agregara el objeto servicio a la lista de servicios
                lstServicios.Add(obServicio);
            }
            catch (Exception ex)
            {
                //Aqui se agrego la logica para manejar la excepcion
                throw new Exception("Error al agregar el servicio: " + ex.Message);


            }
        }

        public void BuscarServicio(string strCodigo)
        {
            //Aqui se puede agregar la logica para buscar un servicio en una basey si  de datos o lista
            Producto servicioEncontrado = lstServicios.FirstOrDefault(s => s.Codigo == strCodigo);
            if (servicioEncontrado != null)
            {
            }
            else
            {
                //Aqui se puede agregar la logica para manejar el caso en que no se encuentre el servicio
                throw new Exception("Servicio no encontrado");
            }
        }
    }
}
