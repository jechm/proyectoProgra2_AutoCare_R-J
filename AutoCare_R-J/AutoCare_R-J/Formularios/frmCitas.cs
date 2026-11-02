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
        private string[] valoresDeBusqueda = { "Codigo", "Cliente", "Tecnico", "Estado" };
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


            cmbEstado.DataSource = estadosCita;
            cmbValoresDeBusqueda.DataSource = valoresDeBusqueda;

            CargarListas();
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

            cmbValoresDeBusqueda.SelectedIndex = 0;
            txtValorAbuscar.Text = "CIT-";
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
            dtGvDatos.Columns["CodigoCliente"].HeaderText = "Cliente";
            dtGvDatos.Columns["CodigoVehiculo"].HeaderText = "Vehículo";
            dtGvDatos.Columns["CodigoTecnico"].HeaderText = "Técnico";
            limpiarFormulario();
        }

        private void cargarComboBox(System.Windows.Forms.ComboBox comboBox)
        {
            comboBox.Items.Clear();
            if (comboBox == cmbCliente)
            {

                foreach (clsCliente cliente in listaClientes.ObtenerClientes())
                {
                    comboBox.Items.Add($"{cliente.Nombre} {cliente.Apellido}");
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
            
            if (selectedIndex > -1)
            {
                string CodigoCliente = listaClientes.ObtenerClientes()[selectedIndex].Codigo;
                cargarComboBox(cmbVehiculo);
            }

            
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
            clsCita citaTemporal = null;
            string codigoCliente = string.IsNullOrWhiteSpace(cmbCliente.SelectedItem.ToString()) ? "" : listaClientes.ObtenerClientes()[cmbCliente.SelectedIndex].Codigo;
            string codigoVehiculo = string.IsNullOrWhiteSpace(cmbVehiculo.SelectedItem.ToString()) ? "" : listaVehiculos.ListarVehiculos()[cmbVehiculo.SelectedIndex].Codigo;
            string codigoTecnico = string.IsNullOrWhiteSpace(cmbEmpleado.SelectedItem.ToString()) ? "" : listaEmpleados.ObtenerEmpleados()[cmbEmpleado.SelectedIndex].Codigo;
            try
            {
                citaTemporal = new clsCita(
                txtCodigo.Text,
                codigoCliente,
                codigoVehiculo,
                codigoTecnico,
                dtFechaHora.Value,
                cmbEstado.SelectedItem.ToString(),
                txtObservaciones.Text
            );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

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

        private void cmbValoresDeBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbValorABuscar.Text = $"Ingrese el {cmbValoresDeBusqueda.SelectedItem} a buscar:";
            if (cmbValoresDeBusqueda.SelectedItem.ToString() == "Codigo")
            {
                txtValorAbuscar.Text = "CIT-";
            }
            else
            {
                txtValorAbuscar.Text = "";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IList<clsCita> listaCitasEncontrada = new List<clsCita>();
            listaCitasEncontrada = listaCitas.BuscarCitas(cmbValoresDeBusqueda.SelectedItem.ToString(), txtValorAbuscar.Text);
            if(listaCitasEncontrada.Count == 0)
            {
                MessageBox.Show("No se encontraron citas con el valor ingresado.");
            }
            else
            {
                dtGvDatos.DataSource = null;
                dtGvDatos.DataSource = listaCitasEncontrada;
                dtGvDatos.Columns["CodigoCliente"].HeaderText = "Cliente";
                dtGvDatos.Columns["CodigoVehiculo"].HeaderText = "Vehículo";
                dtGvDatos.Columns["CodigoTecnico"].HeaderText = "Técnico";
            }

        }

        private void dtGvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string codigoCliente = dtGvDatos.Rows[e.RowIndex].Cells["CodigoCliente"].Value.ToString();
            MessageBox.Show($"Cliente seleccionado: {cmbCliente.FindStringExact(codigoCliente)}");
            txtCodigo.Text = dtGvDatos.Rows[e.RowIndex].Cells["CodigoCita"].Value.ToString();

            cmbCliente.SelectedIndex = cmbCliente.FindStringExact(codigoCliente);

            cmbEmpleado.SelectedIndex = cmbEmpleado.FindStringExact(dtGvDatos.Rows[e.RowIndex].Cells["CodigoTecnico"].Value.ToString());
            cmbEstado.SelectedItem = dtGvDatos.Rows[e.RowIndex].Cells["EstadoCita"].Value.ToString();
            txtObservaciones.Text = dtGvDatos.Rows[e.RowIndex].Cells["Observaciones"].Value.ToString();
            dtFechaHora.Value = Convert.ToDateTime(dtGvDatos.Rows[e.RowIndex].Cells["FechaHoraCita"].Value);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }
    }
}



