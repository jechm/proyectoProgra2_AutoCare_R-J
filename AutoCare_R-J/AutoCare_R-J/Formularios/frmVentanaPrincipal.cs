using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoCare_R_J.Controladores;
using AutoCare_R_J.Formularios;
using AutoCare_R_J.Modelos;

namespace AutoCare_R_J.Formularios
{

    
    public partial class frmVentanaPrincipal : Form
    {

        private  clsManejadorClientes listaClientes;

        public frmVentanaPrincipal()

        {
            listaClientes = new clsManejadorClientes();
            
            InitializeComponent();
        }

        
        private void btnClientes_Click(object sender, EventArgs e)
        {
            if(!FormularioAbierto("frmClientes"))
            {
                frmClientes clientes = new frmClientes();
                clientes.AsignarListaclientes(ref listaClientes);
                clientes.MdiParent = this;
                clientes.Show();
            }
        }

        //determinar si ya existe un formulario abierto
        private bool FormularioAbierto(string pNombreFormulario)
        {
            foreach (Form frmNombreFormulario in this.MdiChildren)
            {
                if (frmNombreFormulario.Name == pNombreFormulario)
                {
                    return true;
                }
            }
            return false;
        }

        

        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {

           

        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            if(!FormularioAbierto("Servicios"))
            {
                Servicios servicios = new Servicios();
                servicios.MdiParent = this;
                servicios.Show();
            }   
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            if(!FormularioAbierto("frmVehiculos"))
            {
                frmVehiculos vehiculos = new frmVehiculos();
                vehiculos.MdiParent = this;
                vehiculos.Show();
            }
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            if(!FormularioAbierto("frmFacturas"))
            {
                frmFacturas facturas = new frmFacturas();
                facturas.MdiParent = this;
                facturas.Show();
            }
        }

        private void btnOrdenesDeTrabajo_Click(object sender, EventArgs e)
        {
            if(!FormularioAbierto("frmOrdenesTrabajo"))
            {
                frmOrdenesTrabajo ordenesDeTrabajo = new frmOrdenesTrabajo();
                ordenesDeTrabajo.MdiParent = this;
                ordenesDeTrabajo.Show();
            }
        }
    }
}
