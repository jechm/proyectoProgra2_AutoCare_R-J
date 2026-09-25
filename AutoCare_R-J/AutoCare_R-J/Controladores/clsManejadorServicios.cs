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
        //Creacion de objeto de la clase servicios
        //Se agrego el prefijo ob para indicar que es un objeto
        clsServicios obServicio = new clsServicios();

        //Creacion de metodo para agregar un servicio
        public void AgregarServicio(string strCodigo, string strNombre, 
            string strCategoria, double dblCosto, 
            string strDescripcion, string strDuracion)
        {
            obServicio.Codigo = strCodigo;
            obServicio.Nombre = strNombre;
            obServicio.Categoria = strCategoria;
            obServicio.Costo = dblCosto;
            obServicio.Descripcion = strDescripcion;
            obServicio.Duracion = strDuracion;
            //Aqui se puede agregar la logica para guardar el servicio en una base de datos o lista
        }
    }
}
