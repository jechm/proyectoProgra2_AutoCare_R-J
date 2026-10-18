using System;
using System.Collections.Generic;
using AutoCare_R_J.Controladores;
using AutoCare_R_J.Modelos;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoCare_R_J.Controladores;
using AutoCare_R_J.Modelos;

namespace AutoCare_R_J.Formularios
{
    public partial class frmOrdenesTrabajo : Form
    {

        private readonly clsManejadorOrdenesTrabajo manejadorOrdenes = new clsManejadorOrdenesTrabajo();
        public frmOrdenesTrabajo()
        {
            InitializeComponent();
            //desabilitar el botón de eliminar al inicio
            MetodosGlobales.DeshabilitarBoton(btnEliminar);

            //desabilitar el botón de modificar al inicio
            MetodosGlobales.DeshabilitarBoton(btnModificar);

        }
      
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // obtener los valores de los campos de entrada
            string strCodigo = tbxCodigo.Text.Trim();
            string dateFechaRecepcion = dtpFechaRecepcion.Value.ToString("yyyy-MM-dd");
            string strServicio = cbxServicio.Text.Trim();
            string strVehiculo = cbxVehiculo.Text.Trim();
            string strEstado = cbxEstado.Text.Trim();
            string strRepuestos = tbxRepuestos.Text.Trim();

            //validar que los campos no esten vacios
            if (string.IsNullOrEmpty(strCodigo) || string.IsNullOrEmpty(strServicio) || string.IsNullOrEmpty(strVehiculo) || string.IsNullOrEmpty(strEstado))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // Crear una instancia de clsOrdenesDeTrabajo con los valores obtenidos
                clsOrdenesDeTrabajo nuevaOrden = new clsOrdenesDeTrabajo(strCodigo, DateTime.Parse(dateFechaRecepcion), strServicio, strVehiculo, strEstado, strRepuestos);
                MessageBox.Show("¡Orden de trabajo agregada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar los campos después de agregar la orden
                LimpiarCampos();
                MetodosGlobales.CargarGrid(dgvOrdenesTrabajo, manejadorOrdenes.ListarOrdenesTrabajo());
            }
        }

        public void LimpiarCampos()
        {
            tbxCodigo.Clear();
            cbxServicio.SelectedIndex = -1;
            cbxVehiculo.SelectedIndex = -1;
            cbxEstado.SelectedIndex = -1;
            tbxRepuestos.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // obtener los valores de los campos de entrada
            string strCodigo = tbxCodigo.Text.Trim();
            string dateFechaRecepcion = dtpFechaRecepcion.Value.ToString("yyyy-MM-dd");
            string strServicio = cbxServicio.Text.Trim();
            string strVehiculo = cbxVehiculo.Text.Trim();
            string strEstado = cbxEstado.Text.Trim();
            string strRepuestos = tbxRepuestos.Text.Trim();

            //validar que los campos no esten vacios
            if (string.IsNullOrEmpty(strCodigo) || string.IsNullOrEmpty(strServicio) || string.IsNullOrEmpty(strVehiculo) || string.IsNullOrEmpty(strEstado))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //Llamar al método ModificarOrdenTrabajo del manejador de órdenes de trabajo
                manejadorOrdenes.ModificarOrdenTrabajo(strCodigo, DateTime.Parse(dateFechaRecepcion), strServicio, strVehiculo, strEstado, strRepuestos);
                MessageBox.Show("¡Orden de trabajo modificada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MetodosGlobales.CargarGrid(dgvOrdenesTrabajo, manejadorOrdenes.ListarOrdenesTrabajo());
            }
            ;

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // obtener el código de la orden de trabajo a eliminar
            string strCodigo = tbxCodigo.Text.Trim();

            // validar que el código no esté vacío
            if (string.IsNullOrEmpty(strCodigo))
            {
                MessageBox.Show("Por favor, seleccione una orden de trabajo para eliminar.", "Código no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // Llamar al método EliminarOrdenTrabajo del manejador de órdenes de trabajo
                manejadorOrdenes.EliminarOrdenTrabajo(strCodigo);
                MessageBox.Show("¡Orden de trabajo eliminada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar los campos después de eliminar la orden
                LimpiarCampos();
            }

            MetodosGlobales.CargarGrid(dgvOrdenesTrabajo, manejadorOrdenes.ListarOrdenesTrabajo());
        }
    }
}
