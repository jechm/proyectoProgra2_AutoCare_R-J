using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoCare_R_J.Modelos;

namespace AutoCare_R_J.Controladores
{
    internal class clsManejadorRepuestos
    {
        //Atributos
        private IList<clsRepuesto> lstRepuestos;
        private int intContadorRepuestos;

        //Recuperar lista de repuestos
        public IList<clsRepuesto> ObtenerRepuestos()
        {
            return lstRepuestos;
        }

        //Constructor
        public clsManejadorRepuestos()
        {
            lstRepuestos = new List<clsRepuesto>();
        }

        #region Modificadores
        //Metodos Modificadores de datos en memoria
        //Agregar nuevo repuesto a la lista de repuestos
        public void AgregarRepuesto(clsRepuesto pRepuesto)
        {
            lstRepuestos.Add(pRepuesto);
        }

        //Eliminar repuesto de la lista de repuestos
        public bool EliminarRepuesto(string pCodigo)
        {
            clsRepuesto repuestoExistente = BuscarRepuestoPorCodigo(pCodigo);
            if (repuestoExistente != null)
            {
                return lstRepuestos.Remove(repuestoExistente);
            }
            return false;
        }

        //Modificar repuesto de la lista de repuestos
        public bool ModificarRepuesto(clsRepuesto pRepuesto)
        {
            clsRepuesto repuestoExistente = BuscarRepuestoPorCodigo(pRepuesto.Codigo);
            if (repuestoExistente != null)
            {
                repuestoExistente.Nombre= pRepuesto.Nombre;
                repuestoExistente.Precio= pRepuesto.Precio;
                repuestoExistente.Costo = pRepuesto.Costo;
                repuestoExistente.Categoria = pRepuesto.Categoria;
                repuestoExistente.Marca = pRepuesto.Marca;
                repuestoExistente.Existencias = pRepuesto.Existencias;
                repuestoExistente.Estado = pRepuesto.Estado;
                
                return true;
            }
            return false;
        }

        #endregion
        #region Buscador
        //Buscador de repuesto por codigo
        public clsRepuesto BuscarRepuestoPorCodigo(string pCodigo)
        {
            return lstRepuestos.FirstOrDefault(r => r.Codigo == pCodigo);
        }

        public IList<clsRepuesto> BuscarRepuestosPorNombre(string pNombre)
        {
            return lstRepuestos.Where(r => r.Nombre.Contains(pNombre)).ToList();
        }

        public IList<clsRepuesto> BuscarRepuestosPorCategoria(string pCategoria)
        {
            return lstRepuestos.Where(r => r.Categoria.Contains(pCategoria)).ToList();
        }
        public IList<clsRepuesto> BuscarRepuestosPorMarca(string pMarca)
        {
            return lstRepuestos.Where(r => r.Marca.Contains(pMarca)).ToList();
        }
        #endregion

    }
}

