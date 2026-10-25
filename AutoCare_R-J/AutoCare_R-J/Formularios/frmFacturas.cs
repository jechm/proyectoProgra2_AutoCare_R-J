using AutoCare_R_J.Controladores;
using System;
using AutoCare_R_J.MetodosGlobales;
using System.Collections.Generic;
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
        private clsManejadorFacturas manejadorFacturas;
        public frmFacturas()
        {
            InitializeComponent();
        }

        
        internal void CargarManejador(clsManejadorFacturas pFacturas)
        {
            manejadorFacturas = pFacturas; // Asigna el manejador que viene desde la ventana principal por referencia

            // Carga el grid con la lista compartida de la ventana principal
            clsMetodosGlobales.CargarGrid(dgvFacturas, manejadorFacturas.ListarFacturas());

            // Actualiza el siguiente código
            tbxCodigo.Text = manejadorFacturas.ObtenerSiguienteCodigo();
        }
        private void frmFacturas_Load(object sender, EventArgs e)
        {

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
    }
}
