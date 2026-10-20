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

        private clsManejadorClientes listaClientes;
        private clsManejadorEmpleados listaEmpleados;


        //Formularios de Richar
        private clsManejadorServicios listaServicios;
        private clsManejadorVehiculos listaVehiculos;

        public frmVentanaPrincipal()

        {
            listaClientes = new clsManejadorClientes();
            listaEmpleados = new clsManejadorEmpleados();

            //Formularios de Richar
            listaServicios = new clsManejadorServicios();
            listaVehiculos = new clsManejadorVehiculos();

            InitializeComponent();
        }

        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {



        }


        #region Formularios

        #region Validar si ya existe un formulario abierto con el mismo nombre
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
        #endregion


        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (!FormularioAbierto("frmClientes"))
            {
                frmClientes clientes = new frmClientes();
                clientes.AsignarListaclientes(ref listaClientes);
                clientes.MdiParent = this;
                clientes.Show();
            }
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (!FormularioAbierto("frmEmpleados"))
            {
                frmEmpleados empleados = new frmEmpleados();
                empleados.AsignarListaEmpleados(ref listaEmpleados);
                empleados.MdiParent = this;
                empleados.Show();
            }
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            if (!FormularioAbierto("Servicios"))
            {
                Servicios servicios = new Servicios();
                servicios.MdiParent = this;

                // Inyeccion del manejador compartido
                servicios.CargarManejador(listaServicios);

                servicios.Show();
            }
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            if (!FormularioAbierto("frmVehiculos"))
            {
                frmVehiculos vehiculos = new frmVehiculos();
                vehiculos.MdiParent = this;

                // Inyeccion del manejador compartido
                vehiculos.CargarManejador(listaVehiculos);

                vehiculos.Show();
            }
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            if (!FormularioAbierto("frmFacturas"))
            {
                frmFacturas facturas = new frmFacturas();
                facturas.MdiParent = this;
                facturas.Show();
            }
        }

        private void btnOrdenesDeTrabajo_Click(object sender, EventArgs e)
        {
            if (!FormularioAbierto("frmOrdenesTrabajo"))
            {
                frmOrdenesTrabajo ordenesDeTrabajo = new frmOrdenesTrabajo();
                ordenesDeTrabajo.MdiParent = this;
                ordenesDeTrabajo.Show();
            }
        }

        #endregion
    }
}
