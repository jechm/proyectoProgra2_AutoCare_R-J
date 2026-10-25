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

namespace AutoCare_R_J.Formularios     //borrar este comentario del 231026

{


    public partial class frmVentanaPrincipal : Form
    {

        private clsManejadorClientes listaClientes;
        private clsManejadorEmpleados listaEmpleados;


        private clsManejadorRepuestos listaRepuestos;
        private clsManejadorCitas listaCitas; //otro marcador


        //Formularios de Richar
        private clsManejadorServicios listaServicios;
        private clsManejadorVehiculos listaVehiculos;

        private clsManejadorFacturas listaFacturas;

        public frmVentanaPrincipal()

        {
            listaClientes = new clsManejadorClientes();
            listaEmpleados = new clsManejadorEmpleados();
            listaRepuestos = new clsManejadorRepuestos();

            //Formularios de Richar
            listaServicios = new clsManejadorServicios();
            listaVehiculos = new clsManejadorVehiculos();
            listaFacturas = new clsManejadorFacturas();

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


        private void btnOrdenesDeTrabajo_Click(object sender, EventArgs e)
        {
            if (!FormularioAbierto("frmOrdenesTrabajo"))
            {
                frmOrdenesTrabajo ordenesDeTrabajo = new frmOrdenesTrabajo();
                ordenesDeTrabajo.MdiParent = this;
                ordenesDeTrabajo.Show();
            }
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            if (!FormularioAbierto("frmFacturas"))
            {
                frmFacturas vFacturas = new frmFacturas();
                vFacturas.MdiParent = this;
                vFacturas.Show();
            }
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            if (!FormularioAbierto("frmCitas"))
            {
                
                frmCitas vCitas= new frmCitas();
                vCitas.MdiParent = this;
                vCitas.Show();
            }
        }

        private void btnRepuestos_Click(object sender, EventArgs e)
        {
            if (!FormularioAbierto("frmRepuestos"))
            {
                frmRepuestos vRepuestos = new frmRepuestos(listaRepuestos);
                vRepuestos.MdiParent = this;
                vRepuestos.Show();
            }
        }

        #endregion


    }
}
