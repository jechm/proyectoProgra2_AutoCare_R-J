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
        public void EliminarRepuesto(clsRepuesto pRepuesto)
        {
            lstRepuestos.Remove(pRepuesto);
        }

        //Modificar repuesto de la lista de repuestos
        public void ModificarRepuesto(clsRepuesto pRepuesto)
        {
            clsRepuesto repuestoExistente = BuscarRepuestoPorCodigo(pRepuesto.CodigoRepuesto);
            if (repuestoExistente != null)
            {
                repuestoExistente.NombreRepuesto = pRepuesto.NombreRepuesto;
                repuestoExistente.Precio= pRepuesto.Precio;
                repuestoExistente.Categoria = pRepuesto.Categoria;
                repuestoExistente.Marca = pRepuesto.Marca;
                repuestoExistente.Existencias = pRepuesto.Existencias;
                repuestoExistente.Estado = pRepuesto.Estado;
                repuestoExistente.Descripcion = pRepuesto.Descripcion;
            }
        }

        #endregion
        #region Buscador
        //Buscador de repuesto por codigo
        public clsRepuesto BuscarRepuestoPorCodigo(string pCodigo)
        {
            int indice = -1;
            for (int i = 0; i < lstRepuestos.Count; i++)
            {
                if (lstRepuestos[i].CodigoRepuesto == pCodigo)
                {
                    indice = i;
                    break;
                }
            }
            if (indice != -1)
            {
                return lstRepuestos[indice];
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
