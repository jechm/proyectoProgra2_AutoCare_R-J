using AutoCare_R_J.Controladores;
using System;
using AutoCare_R_J.MetodosGlobales;
using System.Collections.Generic;
using AutoCare_R_J.Modelos;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;//comentario marcador unicam
using System.Windows.Forms;

namespace AutoCare_R_J.Formularios
{
    
    public partial class frmFacturas : Form
    {
        private clsManejadorFacturas manejadorFacturas = new clsManejadorFacturas();

        private List<clsOrdenesDeTrabajo> lstOrdenesTrabajo;
        public frmFacturas()
        {
            InitializeComponent();

            
            clsMetodosGlobales.CargarGrid(dgvFacturas, manejadorFacturas.ListarFacturas());


            lstOrdenesTrabajo = clsMetodosGlobales.ObtenerOrdenesTrabajo();
            cbxOrdenes.DataSource = lstOrdenesTrabajo;
            cbxOrdenes.DisplayMember = "OrdenTrabajo";
            cbxOrdenes.ValueMember = "Codigo";

        }


        
        internal void CargarManejador(clsManejadorFacturas pFacturas)
        {
            manejadorFacturas = pFacturas; // Asigna el manejador que viene desde la ventana principal por referencia

            // Carga el grid con la lista compartida de la ventana principal
            clsMetodosGlobales.CargarGrid(dgvFacturas, manejadorFacturas.ListarFacturas());

            // Actualiza el siguiente código
            tbxCodigo.Text = clsMetodosGlobales.ObtenerSiguienteCodigo("factura");
        }


        private void frmFacturas_Load(object sender, EventArgs e)
        {
            tbxCodigo.Text = clsMetodosGlobales.ObtenerSiguienteCodigo("factura");
            tbxCodigo.ReadOnly = true;
            clsMetodosGlobales.CargarGrid(dgvFacturas, manejadorFacturas.ListarFacturas());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string strCodigo = tbxCodigo.Text.Trim();
            string strDescripcionServicio = tbxDescripcion.Text.Trim();
            string strServicio = cbxOrdenes.SelectedValue?.ToString() ?? "";
            string strDescuento = cbxDescuento.Text.Trim();

            if (string.IsNullOrEmpty(strCodigo) || string.IsNullOrEmpty(strDescripcionServicio) || string.IsNullOrEmpty(strServicio) || string.IsNullOrEmpty(strDescuento))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    
                    manejadorFacturas.AgregarFactura(strCodigo, strDescripcionServicio, strServicio, strDescuento);

                    MessageBox.Show("¡Factura agregada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    LimpiarCampos();
                    clsMetodosGlobales.CargarGrid(dgvFacturas, manejadorFacturas.ListarFacturas());
                    tbxCodigo.Text = clsMetodosGlobales.ObtenerSiguienteCodigo("factura");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LimpiarCampos()
        {
            tbxDescripcion.Clear();
            cbxOrdenes.SelectedIndex = -1;
            cbxDescuento.Text = string.Empty; 
        }
    }
}
