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

namespace AutoCare_R_J.Formularios
{
    public partial class frmVehiculos : Form
    {
        private readonly clsManejadorVehiculos manejadorVehiculo = new clsManejadorVehiculos();

        public frmVehiculos()
        {
            

            InitializeComponent();

            //desactivar el botón de eliminar al iniciar el formulario
            MetodosGlobales.DeshabilitarBoton(btnEliminar);

            //desactivar el botón de modificar al iniciar el formulario
            MetodosGlobales.DeshabilitarBoton(btnModificar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
                MetodosGlobales.CargarGrid(dgvVehiculos, manejadorVehiculo.ListarVehiculos());
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //obtener el código del vehículo a eliminar
            string strCodigo = tbxCodigo.Text.Trim();

            //obtener el propietario del vehículo a eliminar
            string strPropietario = tbxPropietario.Text.Trim();

            //validar que los campos no esten vacios
            if (string.IsNullOrEmpty(strCodigo) || string.IsNullOrEmpty(strPropietario))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //verificar si es busqueda por código o por propietario
                if (!string.IsNullOrEmpty(strCodigo))
                {
                    //eliminar el vehículo por código
                    manejadorVehiculo.EliminarVehiculo(strCodigo);
                    MessageBox.Show("¡Vehículo eliminado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpiar los campos después de eliminar el vehículo
                    LimpiarCampos();
                }
                else if (!string.IsNullOrEmpty(strPropietario))
                {
                    //eliminar el vehículo por propietario
                    clsVehiculos vehiculoEncontrado = manejadorVehiculo.BuscarVehiculo("", strPropietario);
                    if (vehiculoEncontrado != null)
                    {
                        manejadorVehiculo.EliminarVehiculo(vehiculoEncontrado.Codigo);
                        MessageBox.Show("¡Vehículo eliminado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Limpiar los campos después de eliminar el vehículo
                        LimpiarCampos();
                    }
                }
                MetodosGlobales.CargarGrid(dgvVehiculos, manejadorVehiculo.ListarVehiculos());
            }
        }

        private void LimpiarCampos()
        {
            tbxCodigo.Clear();
            tbxPropietario.Clear();
            tbxPlaca.Clear();
            cbxEstado.SelectedIndex = -1;
            tbxColor.Clear();
            tbxMarca.Clear();
            tbxModelo.Clear();
            cbxTipo.SelectedIndex = -1;
            tbxAnio.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //optener los valores de los campos de entrada
            string strCodigo = tbxCodigo.Text.Trim();
            string strPropietario = tbxPropietario.Text.Trim();

            //validar que los campos no esten vacios
            if (string.IsNullOrEmpty(strCodigo) || string.IsNullOrEmpty(strPropietario))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //veroficar si es busqueda por código o por propietario
                if (!string.IsNullOrEmpty(strCodigo))
                {
                    //modificar el vehículo por código
                    manejadorVehiculo.ModificarVehiculo(strCodigo, strPropietario, tbxPlaca.Text.Trim(), cbxEstado.Text.Trim(), tbxColor.Text.Trim(), tbxMarca.Text.Trim(), tbxModelo.Text.Trim(), cbxTipo.Text.Trim(), tbxAnio.Text.Trim());
                    MessageBox.Show("¡Vehículo modificado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpiar los campos después de modificar el vehículo
                    LimpiarCampos();
                }
                else if (!string.IsNullOrEmpty(strPropietario))
                {
                    //modificar el vehículo por propietario
                    clsVehiculos vehiculoEncontrado = manejadorVehiculo.BuscarVehiculo("", strPropietario);
                    if (vehiculoEncontrado != null)
                    {
                        manejadorVehiculo.ModificarVehiculo(vehiculoEncontrado.Codigo, strPropietario, tbxPlaca.Text.Trim(), cbxEstado.Text.Trim(), tbxColor.Text.Trim(), tbxMarca.Text.Trim(), tbxModelo.Text.Trim(), cbxTipo.Text.Trim(), tbxAnio.Text.Trim());
                        MessageBox.Show("¡Vehículo modificado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Limpiar los campos después de modificar el vehículo
                        LimpiarCampos();
                    }
                }
                MetodosGlobales.CargarGrid(dgvVehiculos, manejadorVehiculo.ListarVehiculos());
            }
        }
    }
}
