using AutoCare_R_J.Controladores;
using AutoCare_R_J.Modelos;
using AutoCare_R_J.MetodosGlobales;
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
    public partial class frmVehiculos : Form
    {
        private clsManejadorVehiculos manejadorVehiculo;

        public frmVehiculos()
        {
            

            InitializeComponent();

            //desactivar el botón de eliminar al iniciar el formulario
            clsMetodosGlobales.DeshabilitarBoton(btnEliminar);

            //desactivar el botón de modificar al iniciar el formulario
            clsMetodosGlobales.DeshabilitarBoton(btnModificar);

            //
            manejadorVehiculo = new clsManejadorVehiculos();
            clsMetodosGlobales.CargarGrid(dgvVehiculos, manejadorVehiculo.ListarVehiculos());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //metodo para cargar el manejador de vehiculos desde la ventana principal
        internal void CargarManejador(clsManejadorVehiculos pManejador)
        {
            //Asignar el manjador que viene desde la ventana principal
            manejadorVehiculo = pManejador;

            //actualizar el DataGridView con la lista de vehículos
            clsMetodosGlobales.CargarGrid(dgvVehiculos, manejadorVehiculo.ListarVehiculos());

            //Actualiza el siguiente código disponible para un nuevo vehículo
            tbxCodigo.Text = manejadorVehiculo.ObtenerSiguienteCodigo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //obtener los valores de los campos de entrada
            string strPropietario = tbxPropietario.Text.Trim();
            string strPlaca = tbxPlaca.Text.Trim();
            string strEstado = cbxEstado.Text.Trim();
            string strColor = tbxColor.Text.Trim();
            string strMarca = tbxMarca.Text.Trim();
            string strModelo = tbxModelo.Text.Trim();
            string strTipo = cbxTipo.Text.Trim();
            string strAnio = tbxAnio.Text.Trim();

            //validar que los campos no esten vacios
            if (string.IsNullOrEmpty(strPropietario) || string.IsNullOrEmpty(strPlaca) || string.IsNullOrEmpty(strEstado) || string.IsNullOrEmpty(strColor) || string.IsNullOrEmpty(strMarca) || string.IsNullOrEmpty(strModelo) || string.IsNullOrEmpty(strTipo) || string.IsNullOrEmpty(strAnio))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // Crear una instancia de clsVehiculos con los valores obtenidos
                clsVehiculos nuevoVehiculo = new clsVehiculos(manejadorVehiculo.ObtenerSiguienteCodigo(), strPropietario, strPlaca, strEstado, strColor, strMarca, strModelo, strTipo, strAnio);
                // Agregar el vehículo a la lista utilizando el manejador
                manejadorVehiculo.AgregarVehiculo(nuevoVehiculo.Propietario, nuevoVehiculo.Placa, nuevoVehiculo.Estado, nuevoVehiculo.Color, nuevoVehiculo.Marca, nuevoVehiculo.Modelo, nuevoVehiculo.Tipo, nuevoVehiculo.Año);
                MessageBox.Show("¡Vehículo agregado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar los campos después de agregar el vehículo
                LimpiarCampos();

                //actualizar el DataGridView con la lista de vehículos
                clsMetodosGlobales.CargarGrid(dgvVehiculos, manejadorVehiculo.ListarVehiculos());
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string strCodigo = tbxCodigo.Text.Trim();
            string strPropietario = tbxPropietario.Text.Trim();

            if (string.IsNullOrEmpty(strCodigo) && string.IsNullOrEmpty(strPropietario))
            {
                MessageBox.Show("Por favor, ingrese un código o propietario para eliminar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!string.IsNullOrEmpty(strCodigo))
                {
                    manejadorVehiculo.EliminarVehiculo(strCodigo);
                    MessageBox.Show("¡Vehículo eliminado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    clsVehiculos vehiculoEncontrado = manejadorVehiculo.BuscarVehiculo("", strPropietario);
                    if (vehiculoEncontrado != null)
                    {
                        manejadorVehiculo.EliminarVehiculo(vehiculoEncontrado.Codigo);
                        MessageBox.Show("¡Vehículo eliminado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún vehículo con ese propietario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                clsMetodosGlobales.CargarGrid(dgvVehiculos, manejadorVehiculo.ListarVehiculos());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarCampos()
        {
            tbxPropietario.Clear();
            tbxPlaca.Clear();
            cbxEstado.SelectedIndex = -1;
            tbxColor.Clear();
            tbxMarca.Clear();
            tbxModelo.Clear();
            cbxTipo.SelectedIndex = -1;
            tbxAnio.Clear();

            // Vuelve a asignar el código automático para que no quede vacío ni busque ""
            if (manejadorVehiculo != null)
            {
                tbxCodigo.Text = manejadorVehiculo.ObtenerSiguienteCodigo();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string strCodigo = tbxCodigo.Text.Trim();
            string strPropietario = tbxPropietario.Text.Trim();

            if (string.IsNullOrEmpty(strCodigo) && string.IsNullOrEmpty(strPropietario))
            {
                MessageBox.Show("Por favor, complete los campos necesarios para modificar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!string.IsNullOrEmpty(strCodigo))
                {
                    manejadorVehiculo.ModificarVehiculo(strCodigo, strPropietario, tbxPlaca.Text.Trim(), cbxEstado.Text.Trim(), tbxColor.Text.Trim(), tbxMarca.Text.Trim(), tbxModelo.Text.Trim(), cbxTipo.Text.Trim(), tbxAnio.Text.Trim());
                    MessageBox.Show("¡Vehículo modificado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    clsVehiculos vehiculoEncontrado = manejadorVehiculo.BuscarVehiculo("", strPropietario);
                    if (vehiculoEncontrado != null)
                    {
                        manejadorVehiculo.ModificarVehiculo(vehiculoEncontrado.Codigo, strPropietario, tbxPlaca.Text.Trim(), cbxEstado.Text.Trim(), tbxColor.Text.Trim(), tbxMarca.Text.Trim(), tbxModelo.Text.Trim(), cbxTipo.Text.Trim(), tbxAnio.Text.Trim());
                        MessageBox.Show("¡Vehículo modificado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el vehículo para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                clsMetodosGlobales.CargarGrid(dgvVehiculos, manejadorVehiculo.ListarVehiculos());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmVehiculos_Load(object sender, EventArgs e)
        {

        }
    }
}
