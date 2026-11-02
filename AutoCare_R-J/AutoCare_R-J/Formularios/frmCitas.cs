using AutoCare_R_J.Controladores;
using AutoCare_R_J.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoCare_R_J.Formularios
{
    //borrar este comentario del 231026
    public partial class frmCitas : Form
    {
        private string[] estadosCita = { "Pendiente", "En Proceso", "Completada", "Cancelada" };
        private clsManejadorCitas listaCitas;
        private clsManejadorVehiculos listaVehiculos;
        private clsManejadorClientes listaClientes;
        private clsManejadorEmpleados listaEmpleados;

        public frmCitas()
        {
            InitializeComponent();
            listaCitas = new clsManejadorCitas();
            listaVehiculos = new clsManejadorVehiculos();
            listaClientes = new clsManejadorClientes();
            listaEmpleados = new clsManejadorEmpleados();


            CargarListas();

            cmbEstado.DataSource = estadosCita;
            cargarComboBox(cmbCliente);
            // cargarComboBox(cmbVehiculo) ;
            cargarComboBox(cmbEmpleado);

        }

        private void limpiarFormulario()
        {
            txtCodigo.Text = listaCitas.ObtenerSiguienteCodigo();
            cmbCliente.SelectedIndex = -1;
            cmbVehiculo.SelectedIndex = -1;
            cmbEmpleado.SelectedIndex = -1;
            dtFechaHora.Value = DateTime.Now;
            cmbEstado.SelectedIndex = -1;
            txtObservaciones.Clear();
        }


        public void CargarListas()
        {
            dibujarTabla();

            listaVehiculos.ListarVehiculos();
            listaClientes.ObtenerClientes();
            listaEmpleados.ObtenerEmpleados();


        }

        private void dibujarTabla()
        {
            
            dtGvDatos.DataSource = null;

            dtGvDatos.DataSource = listaCitas.ObtenerCitas();
            limpiarFormulario();
        }

        private void cargarComboBox(System.Windows.Forms.ComboBox comboBox)
        {
            comboBox.Items.Clear();
            if (comboBox == cmbCliente)
            {

                foreach (clsCliente cliente in listaClientes.ObtenerClientes())
                {
                    comboBox.Items.Add(cliente.Nombre);
                }
            }
            else if (comboBox == cmbVehiculo)
            {
                foreach (clsVehiculos vehiculo in listaVehiculos.ListarVehiculos())
                {

                    if (vehiculo.Propietario == listaClientes.ObtenerClientes()[cmbCliente.SelectedIndex].Codigo)
                    {
                        comboBox.Items.Add($"{vehiculo.Marca} {vehiculo.Modelo} - {vehiculo.Placa}");
                        comboBox.SelectedIndex = 0;
                    }


                }
            }
            else if (comboBox == cmbEmpleado)
            {
                foreach (clsEmpleado empleado in listaEmpleados.ObtenerEmpleados())
                {
                    comboBox.Items.Add(empleado.Nombre + " " + empleado.Apellido);
                }
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbCliente.SelectedIndex;
            string CodigoCliente = listaClientes.ObtenerClientes()[selectedIndex].Codigo;

            cargarComboBox(cmbVehiculo);
        }

        private void bntNuevo_Click(object sender, EventArgs e)
        {
            clsCita nuevaCita = citaParaMovimientos();

            if (listaCitas.AgregarCita(nuevaCita))
            {
                MessageBox.Show("Cita agregada correctamente.");
                dibujarTabla();
            }
            else
            {
                MessageBox.Show("Error al agregar la cita.");

            }
        }

        private clsCita citaParaMovimientos()
        {
            string codigoCliente = listaClientes.ObtenerClientes()[cmbCliente.SelectedIndex].Codigo;
            string codigoVehiculo = listaVehiculos.ListarVehiculos()[cmbVehiculo.SelectedIndex].Codigo;
            string codigoTecnico = listaEmpleados.ObtenerEmpleados()[cmbEmpleado.SelectedIndex].Codigo;

            clsCita citaTemporal = new clsCita(
                txtCodigo.Text,
                codigoCliente,
                codigoVehiculo,
                codigoTecnico,
                dtFechaHora.Value,
                cmbEstado.SelectedItem.ToString(),
                txtObservaciones.Text
            );

            return citaTemporal;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            clsCita citaModificada = citaParaMovimientos();

            if(listaCitas.ModificarCita(citaModificada))
            {
                MessageBox.Show("Cita modificada correctamente.");
                dibujarTabla();
            }
            else
            {
                MessageBox.Show("Error al modificar la cita.");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listaCitas.eliminarCita(txtCodigo.Text))
            {
                MessageBox.Show("Cita eliminada correctamente.");
                dibujarTabla();

            }
            else
            {
                MessageBox.Show("Error al eliminar la cita.");
            }
        }

    }
}



