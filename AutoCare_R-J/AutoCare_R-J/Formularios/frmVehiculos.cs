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

        private List<clsVehiculos> lstVehiculos;
        private List<clsCliente> lstPropietarios;

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

            //cargar los el propietarios en el ComboBox al iniciar el formulario
            lstPropietarios = clsMetodosGlobales.ObtenerClientes();
            cbxPropietario.DataSource = lstPropietarios;
            cbxPropietario.DisplayMember = "Nombre";
            cbxPropietario.ValueMember = "Codigo";

            cbxBuscPropietario.DataSource = lstPropietarios;
            cbxBuscPropietario.DisplayMember = "Nombre";
            cbxBuscPropietario.ValueMember = "Codigo";

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
            tbxCodigo.Text = clsMetodosGlobales.ObtenerSiguienteCodigo("Vehiculo");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //obtener los valores de los campos de entrada
            string strPropietario = cbxPropietario.SelectedValue?.ToString();
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
                manejadorVehiculo.AgregarVehiculo(
                    strPropietario, 
                    strPlaca,
                    strEstado,
                    strColor,
                    strMarca,
                    strModelo,
                    strTipo,
                    strAnio
                    
                 );
                MessageBox.Show("¡Vehículo agregado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar los campos después de agregar el vehículo
                LimpiarCampos();

                tbxCodigo.Text = clsMetodosGlobales.ObtenerSiguienteCodigo("Vehiculo");

                //actualizar el DataGridView con la lista de vehículos
                clsMetodosGlobales.CargarGrid(dgvVehiculos, manejadorVehiculo.ListarVehiculos());
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string strCodigo = tbxCodigo.Text.Trim();
            string strPropietario = cbxPropietario.Text.Trim();

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
            cbxPropietario.SelectedIndex = -1;
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
                tbxCodigo.Text = clsMetodosGlobales.ObtenerSiguienteCodigo("Vehiculo");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string strCodigo = tbxCodigo.Text.Trim();

            // Capturamos el SelectedValue para obtener el código del cliente (ej: CL-001) y no su nombre
            string strPropietario = cbxPropietario.SelectedValue?.ToString();

            // Validar que exista un código de vehículo seleccionado/cargado
            if (string.IsNullOrEmpty(strCodigo))
            {
                MessageBox.Show("Por favor, seleccione o busque un vehículo para modificar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(strPropietario))
            {
                MessageBox.Show("Por favor, seleccione un propietario válido.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Llamada limpia usando los valores de los controles
                manejadorVehiculo.ModificarVehiculo(
                    strCodigo,
                    strPropietario,
                    tbxPlaca.Text.Trim(),
                    cbxEstado.Text.Trim(),
                    tbxColor.Text.Trim(),
                    tbxMarca.Text.Trim(),
                    tbxModelo.Text.Trim(),
                    cbxTipo.Text.Trim(),
                    tbxAnio.Text.Trim()
                );

                MessageBox.Show("¡Vehículo modificado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar controles y refrescar el DataGridView
                LimpiarCampos();
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
            tbxCodigo.Text = clsMetodosGlobales.ObtenerSiguienteCodigo("vehiculo");
            tbxCodigo.ReadOnly = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string strCodigo = tbxBuscCodigo.Text.Trim();
            string strPropietario = cbxBuscPropietario.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(strCodigo) && string.IsNullOrEmpty(strPropietario))
            {
                MessageBox.Show("Por favor, ingrese un código o propietario para buscar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if(strCodigo != "")
                {
                    try
                    {
                        clsVehiculos vehiculoEncontrado = manejadorVehiculo.BuscarVehiculo(strCodigo);
                        if (vehiculoEncontrado != null)
                        {
                            // Mostrar los datos del vehículo encontrado en los campos correspondientes
                            cbxPropietario.SelectedValue = vehiculoEncontrado.Propietario;
                            tbxPlaca.Text = vehiculoEncontrado.Placa;
                            cbxEstado.Text = vehiculoEncontrado.Estado;
                            tbxColor.Text = vehiculoEncontrado.Color;
                            tbxMarca.Text = vehiculoEncontrado.Marca;
                            tbxModelo.Text = vehiculoEncontrado.Modelo;
                            cbxTipo.Text = vehiculoEncontrado.Tipo;
                            tbxAnio.Text = vehiculoEncontrado.Anio;
                            // Habilitar los botones de modificar y eliminar
                            clsMetodosGlobales.HabilitarBoton(btnLimpiarCampos, Color.DeepSkyBlue, Color.White, Cursors.Hand);
                            clsMetodosGlobales.HabilitarBoton(btnEliminar, Color.Red, Color.White, Cursors.Hand);
                            clsMetodosGlobales.HabilitarBoton(btnModificar, Color.DeepSkyBlue, Color.White, Cursors.Hand);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún vehículo con ese código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al buscar: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (strPropietario != "")
                {
                    try
                    {
                        clsVehiculos vehiculoEncontrado = manejadorVehiculo.BuscarVehiculo("", strPropietario);
                        if (vehiculoEncontrado != null)
                        {
                            // Mostrar los datos del vehículo encontrado en los campos correspondientes
                            tbxCodigo.Text = vehiculoEncontrado.Codigo;
                            cbxPropietario.SelectedValue = vehiculoEncontrado.Propietario;
                            tbxPlaca.Text = vehiculoEncontrado.Placa;
                            cbxEstado.Text = vehiculoEncontrado.Estado;
                            tbxColor.Text = vehiculoEncontrado.Color;
                            tbxMarca.Text = vehiculoEncontrado.Marca;
                            tbxModelo.Text = vehiculoEncontrado.Modelo;
                            cbxTipo.Text = vehiculoEncontrado.Tipo;
                            tbxAnio.Text = vehiculoEncontrado.Anio;
                            // Habilitar los botones de modificar y eliminar
                            clsMetodosGlobales.HabilitarBoton(btnLimpiarCampos, Color.DeepSkyBlue, Color.White, Cursors.Hand);
                            clsMetodosGlobales.HabilitarBoton(btnEliminar, Color.Red, Color.White, Cursors.Hand);
                            clsMetodosGlobales.HabilitarBoton(btnModificar, Color.DeepSkyBlue, Color.White, Cursors.Hand);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún vehículo con ese propietario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al buscar: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
