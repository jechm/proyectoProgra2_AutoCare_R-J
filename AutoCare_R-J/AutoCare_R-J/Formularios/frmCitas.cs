using AutoCare_R_J.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCare_R_J.Formularios
{
    public partial class frmCitas : Form
    {

        private clsManejadorCitas listaCitas;
        private clsManejadorClientes listaClientes;
        private clsManejadorVehiculos listaVehiculos;
        private clsManejadorEmpleados listaEmpleados;

        public frmCitas()
        {
            InitializeComponent();
            listaCitas = new clsManejadorCitas();
        }

        internal void asignarListas(ref clsManejadorCitas pListaCitas, ref clsManejadorClientes pListaClientes, ref clsManejadorVehiculos pListaVehiculos, ref clsManejadorEmpleados pListaEmpleados)
        {
            this.listaCitas = pListaCitas;
            this.listaClientes = pListaClientes;
            this.listaVehiculos = pListaVehiculos;
            this.listaEmpleados = pListaEmpleados;

        }


    }
}
