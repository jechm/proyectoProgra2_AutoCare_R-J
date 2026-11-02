using AutoCare_R_J.Controladores;
using AutoCare_R_J.MetodosGlobales;
using AutoCare_R_J.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AutoCare_R_J.Formularios
{
    public partial class frmOrdenesTrabajo : Form
    {

        //Lista para obtener los servicios desde la base de datos
        private List<clsServicios> lstServicios;

        //Obtener los Vehiculos desde la base de datos
        private List<clsVehiculos> lstVehiculos;

        //Lista para repuestos
        private List<clsRepuesto> lstRepuestos;
        private List<string> lstRepuestosSeleccionados = new List<string>();

        private readonly clsManejadorOrdenesTrabajo manejadorOrdenes = new clsManejadorOrdenesTrabajo();
        public frmOrdenesTrabajo()
        {
            InitializeComponent();
            //desabilitar el botón de eliminar al inicio
            clsMetodosGlobales.DeshabilitarBoton(btnEliminar);

            //desabilitar el botón de modificar al inicio
            clsMetodosGlobales.DeshabilitarBoton(btnModificar);

            //Crargar datos en el DataGridView al iniciar el formulario
            clsMetodosGlobales.CargarGrid(dgvOrdenesTrabajo, manejadorOrdenes.ListarOrdenesTrabajo());

            // Cargar los servicios en el ComboBox al iniciar el formulario
            lstServicios = clsMetodosGlobales.ObtenerServicios();
            cbxServicio.DataSource = lstServicios;
            cbxServicio.DisplayMember = "Nombre";
            cbxServicio.ValueMember = "Codigo";

            //Cargar los vehiculos en el ComboBox al inciar el formulario
            lstVehiculos = clsMetodosGlobales.ObtenerVehiculos();
            cbxVehiculo.DataSource = lstVehiculos;
            cbxVehiculo.DisplayMember = "TipoModelo";
            cbxVehiculo.ValueMember = "Codigo";

            //Cargar los repuestos en el ConboBox al inicar el formulario
            lstRepuestos = clsMetodosGlobales.ObtenerRepuestos();
            cbxRepuestos.DataSource = lstRepuestos;
            cbxRepuestos.DisplayMember = "NombreRepuesto";
            cbxRepuestos.ValueMember = "CodigoRepuesto";



        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // obtener los valores de los campos de entrada
            string dateFechaRecepcion = dtpFechaRecepcion.Value.ToString("yyyy-MM-dd");
            string strServicio = cbxServicio.Text.Trim();
            string strVehiculo = cbxVehiculo.Text.Trim();
            string strEstado = cbxEstado.Text.Trim();
            string strRepuestos = tbxRepuestos.Text.Trim();

            //validar que los campos no esten vacios
            if (string.IsNullOrEmpty(strServicio) || string.IsNullOrEmpty(strVehiculo) || string.IsNullOrEmpty(strEstado))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                manejadorOrdenes.AgregarOrdenTrabajo(DateTime.Parse(dateFechaRecepcion), strServicio, strVehiculo, strEstado, strRepuestos);
                MessageBox.Show("¡Orden de trabajo agregada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar los campos después de agregar la orden
                LimpiarCampos();
                clsMetodosGlobales.CargarGrid(dgvOrdenesTrabajo, manejadorOrdenes.ListarOrdenesTrabajo());
            }
        }

        public void LimpiarCampos()
        {
            tbxCodigo.Clear();
            cbxServicio.SelectedIndex = -1;
            cbxVehiculo.SelectedIndex = -1;
            cbxEstado.SelectedIndex = -1;
            tbxRepuestos.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // obtener los valores de los campos de entrada
            string strCodigo = tbxCodigo.Text.Trim();
            string dateFechaRecepcion = dtpFechaRecepcion.Value.ToString("yyyy-MM-dd");
            string strServicio = cbxServicio.Text.Trim();
            string strVehiculo = cbxVehiculo.Text.Trim();
            string strEstado = cbxEstado.Text.Trim();
            string strRepuestos = tbxRepuestos.Text.Trim();

            //validar que los campos no esten vacios
            if (string.IsNullOrEmpty(strCodigo) || string.IsNullOrEmpty(strServicio) || string.IsNullOrEmpty(strVehiculo) || string.IsNullOrEmpty(strEstado))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //Llamar al método ModificarOrdenTrabajo del manejador de órdenes de trabajo
                manejadorOrdenes.ModificarOrdenTrabajo(strCodigo, DateTime.Parse(dateFechaRecepcion), strServicio, strVehiculo, strEstado, strRepuestos);
                MessageBox.Show("¡Orden de trabajo modificada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsMetodosGlobales.CargarGrid(dgvOrdenesTrabajo, manejadorOrdenes.ListarOrdenesTrabajo());
            }
            ;

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // obtener el código de la orden de trabajo a eliminar
            string strCodigo = tbxCodigo.Text.Trim();

            // validar que el código no esté vacío
            if (string.IsNullOrEmpty(strCodigo))
            {
                MessageBox.Show("Por favor, seleccione una orden de trabajo para eliminar.", "Código no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // Llamar al método EliminarOrdenTrabajo del manejador de órdenes de trabajo
                manejadorOrdenes.EliminarOrdenTrabajo(strCodigo);
                MessageBox.Show("¡Orden de trabajo eliminada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar los campos después de eliminar la orden
                LimpiarCampos();

                clsMetodosGlobales.CargarGrid(dgvOrdenesTrabajo, manejadorOrdenes.ListarOrdenesTrabajo());
            }

            clsMetodosGlobales.CargarGrid(dgvOrdenesTrabajo, manejadorOrdenes.ListarOrdenesTrabajo());
        }

        private void frmOrdenesTrabajo_Load(object sender, EventArgs e)
        {
            tbxCodigo.Text = clsMetodosGlobales.ObtenerSiguienteCodigo("ordenes_trabajo");
            tbxCodigo.ReadOnly = true;

            clsMetodosGlobales.CargarGrid(dgvOrdenesTrabajo, manejadorOrdenes.ListarOrdenesTrabajo());
        }

        private void btnAgregarRepuesto_Click(object sender, EventArgs e)
        {
            string strCodigoRepuesto = cbxRepuestos.Text.Trim();
            

            if (string.IsNullOrEmpty(strCodigoRepuesto))
            {
                MessageBox.Show("Por favor, seleccione un repuesto", "Código no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (!lstRepuestosSeleccionados.Contains(strCodigoRepuesto))
                {
                    lstRepuestosSeleccionados.Add(strCodigoRepuesto);
                    tbxRepuestos.Text = string.Join(Environment.NewLine, lstRepuestosSeleccionados);
                }
                else
                {
                    MessageBox.Show("Este repuesto ya fue agregado a la lista", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string strCodigo = tbxBuscCodigo.Text.Trim();

            if (string.IsNullOrEmpty(strCodigo))
            {
                MessageBox.Show("Por favor, ingrese un código de orden de trabajo para buscar.", "Código no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    clsOrdenesDeTrabajo ordenEncontrada = manejadorOrdenes.BuscarOrdenTrabajo(strCodigo);
                    // Mostrar los datos de la orden encontrada en los campos correspondientes

                    if (ordenEncontrada == null)
                    {
                        MessageBox.Show("No se encontró ninguna orden de trabajo con ese código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        dtpFechaRecepcion.Value = ordenEncontrada.FechaRecepcion;
                        cbxServicio.SelectedItem = ordenEncontrada.Servicio;
                        cbxVehiculo.SelectedItem = ordenEncontrada.Vehiculo;
                        cbxEstado.SelectedItem = ordenEncontrada.Estado;
                        tbxRepuestos.Text = ordenEncontrada.Repuestos;
                        // Habilitar los botones de modificar y eliminar
                        clsMetodosGlobales.HabilitarBoton(btnModificar, Color.DeepSkyBlue, Color.White, Cursors.Hand);
                        clsMetodosGlobales.HabilitarBoton(btnEliminar, Color.Red, Color.White, Cursors.Hand);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
