using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoCare_R_J.Modelos;

namespace AutoCare_R_J.Controladores
{
    public class clsManejadorRepuestos
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
        public bool EliminarRepuesto(string pRepuesto)
        {
            clsRepuesto tempRepuesto = BuscarRepuestoPorCodigo(pRepuesto);
            if (tempRepuesto==null)
            {
                return false;
            }
            else
            {
                lstRepuestos.Remove(tempRepuesto);
                return true;
            }
            
        }

        //Modificar repuesto de la lista de repuestos
        public bool ModificarRepuesto(clsRepuesto pRepuesto)
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
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
        #region Buscador
        //Buscador de repuesto por codigo
        public clsRepuesto BuscarRepuestoPorCodigo(string pCodigo)
        {
            return lstRepuestos.FirstOrDefault(rp => rp.CodigoRepuesto.Equals(pCodigo, StringComparison.OrdinalIgnoreCase));
        }

        //public bool
        public List<clsRepuesto> BuscarRepuestosPorNombre(string pNombre)
        {
            return lstRepuestos.Where(rp => rp.NombreRepuesto.Contains(pNombre)).ToList();
        }

        public List<clsRepuesto> BuscarRepuestosPorCategoria(string pCategoria)
        {
            return lstRepuestos.Where(rp => rp.Categoria.Contains(pCategoria)).ToList();

        }

        public List<clsRepuesto> BuscarRepuestosPorMarca(string pMarca)
        {
            return lstRepuestos.Where(rp => rp.Marca.Contains(pMarca)).ToList();

        }



        #endregion
    }
}

