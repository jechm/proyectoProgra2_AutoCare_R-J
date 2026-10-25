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
using AutoCare_R_J.Modelos;

namespace AutoCare_R_J.Formularios
{
    public partial class frmClientes : Form
    {
        private clsManejadorClientes manejadorClientes;
        private string[] strEstadosCliente = { "Activo", "Inactivo", "En Mora" };
        private string[] strValoresDeBusqueda = { "Codigo", "Nombre", "Apellido", "DPI", "Telefono", "Correo", "Direccion", "Estado", "Nit" };
        private int contadorClientes;
        public frmClientes()
        {

            InitializeComponent();
            manejadorClientes = new clsManejadorClientes();
            cmbEstado.DataSource = strEstadosCliente;
            cmbEstado.SelectedIndex = 0; // Selecciona Activo estado por defecto
            cmbValoresDeBusqueda.DataSource = strValoresDeBusqueda;
            dtGvDatos.DataSource = manejadorClientes.ObtenerClientes();
        }

        internal void AsignarListaclientes(ref clsManejadorClientes pManejadorClientes)
        {
            manejadorClientes = pManejadorClientes;
            contadorClientes = manejadorClientes.TotalClientes + 1;
            txtCodigo.Text = $"CL-{contadorClientes:000}";
            redibujarTabla();


        }

        #region Metodos de redibujado y limpieza de formulario
        private void redibujarTabla()
        {
            dtGvDatos.DataSource = null;
            dtGvDatos.DataSource = manejadorClientes.ObtenerClientes();
            reordenarColumnas();
        }

        private void redibujarTabla(IList<clsCliente> pClientesEncontrados)
        {
            dtGvDatos.DataSource = null;
            dtGvDatos.DataSource = pClientesEncontrados;
            reordenarColumnas();
        }


        private void reordenarColumnas()
        {
            int ultimo = dtGvDatos.Columns.Count - 1;
            dtGvDatos.Columns["Nit"].DisplayIndex = ultimo;
            dtGvDatos.Columns["Saldo"].DisplayIndex = ultimo;
        }

        #endregion


        private void bntNuevoCliente_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                // Crear el cliente si los datos son válidos
                if (ValidarClienteExistente())
                {
                    CrearCliente();
                }
                
            }

        }

        #region Validaciones de datos
        private bool ValidarClienteExistente()
        {

            bool clienteExistenteDPI = manejadorClientes.BuscarClientePorDPI(txtDPI.Text) != null;
            bool clienteExistenteNit = manejadorClientes.BuscarClientePorNit(txtNit.Text) != null && txtNit.Text != "C/F";
            bool clienteExistenteCorreo = manejadorClientes.BuscarClientePorCorreo(txtCorreo.Text) != null;
            bool clienteExistenteTelefono = manejadorClientes.BuscarClientePorTelefono(txtTelefono.Text) != null;
            
            if (clienteExistenteDPI)
            {
                MessageBox.Show("Ya existe un cliente con este DPI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (clienteExistenteNit)
            {
                MessageBox.Show("Ya existe un cliente con este NIT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (clienteExistenteCorreo)
            {
                MessageBox.Show("Ya existe un cliente con este correo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (clienteExistenteTelefono)
            {
                MessageBox.Show("Ya existe un cliente con este teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // No hay clientes existentes con los mismos datos
        }

        private bool validarDatos()
        {
            bool elDPIesValido = !string.IsNullOrWhiteSpace(txtDPI.Text) && txtDPI.Text.Length == 13;
            bool elTelefonoEsValido = !string.IsNullOrWhiteSpace(txtTelefono.Text) && txtTelefono.Text.Length == 8;
            string correo = txtCorreo.Text;

            if (
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text)
            )
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (elDPIesValido == false)
            {
                MessageBox.Show("El DPI debe contener 13 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (elTelefonoEsValido == false)
            {
                MessageBox.Show("El teléfono debe contener 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (correo.Length > 0 && !correo.Contains("@"))
            {
                MessageBox.Show("El correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Si todos los campos están completos, se puede proceder a crear el cliente
            return true;
        }
        #endregion
        private void CrearCliente()
        {
            string codigo = txtCodigo.Text;
            string direccion = string.IsNullOrWhiteSpace(txtDireccion.Text) ? "Sin especificar" : txtDireccion.Text;
            string nit = string.IsNullOrWhiteSpace(txtNit.Text) ? "C/F" : txtNit.Text;

            clsCliente clienteTemporal = new clsCliente(
                codigo,
                txtNombre.Text,
                txtApellido.Text,
                txtDPI.Text,
                txtTelefono.Text,
                txtCorreo.Text,
                direccion,
                cmbEstado.SelectedItem.ToString(),
                nit,
                0
                );
            manejadorClientes.AgregarCliente(clienteTemporal);
            redibujarTabla();

            MessageBox.Show("Cliente creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            contadorClientes++;

            limpiarFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();

        }

        private void limpiarFormulario()
        {

            txtCodigo.Text = $"CL-{contadorClientes:000}";

            txtNombre.Text = "";
            txtApellido.Text = "";

            txtDPI.Text = "";
            txtDPI.Enabled = true; // Habilitar el campo DPI para que se pueda modificar

            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            cmbEstado.SelectedIndex = 0;

            txtNit.Text = "";
            txtNit.Enabled = true; // Habilitar el campo Nit para que se pueda modificar

            txtValorAbuscar.Text = "";

            bloquearBotonesModificadores();
            redibujarTabla();
        }

        private void bloquearBotonesModificadores()
        {
            btnModificarCliente.Enabled = false;
            btnModificarCliente.CustomBackColor = Color.SlateGray; // Cambiar el color del botón a gris
            btnEliminarCliente.Enabled = false;
            btnEliminarCliente.CustomBackColor = Color.SlateGray; // Cambiar el color del botón a gris
        }


        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void dtGvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                return;
            }
            txtNit.Enabled = false; // Deshabilitar el campo Nit para que no se pueda modificar
            txtDPI.Enabled = false; // Deshabilitar el campo DPI para que no se pueda modificar

            txtCodigo.Text = dtGvDatos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
            txtNombre.Text = dtGvDatos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txtApellido.Text = dtGvDatos.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            txtDPI.Text = dtGvDatos.Rows[e.RowIndex].Cells["DPI"].Value.ToString();
            txtTelefono.Text = dtGvDatos.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
            txtCorreo.Text = dtGvDatos.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
            txtDireccion.Text = dtGvDatos.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
            cmbEstado.SelectedItem = dtGvDatos.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
            txtNit.Text = dtGvDatos.Rows[e.RowIndex].Cells["Nit"].Value.ToString();

            btnModificarCliente.Enabled = true;
            btnModificarCliente.CustomBackColor = Color.DeepSkyBlue; // Cambiar el color del botón a azul
            btnEliminarCliente.Enabled = true;
            btnEliminarCliente.CustomBackColor = Color.Red; // Cambiar el color del botón a rojo


        }

        private void dtGvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= 0)
            {
                return;
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)

        {
            if (validarDatos())
            {
                clsCliente clienteExistente = manejadorClientes.BuscarClientePorCodigo(txtCodigo.Text);

                if (clienteExistente != null)
                {
                    clienteExistente.ActualizarCliente(
                        txtNombre.Text,
                        txtApellido.Text,
                        txtTelefono.Text,
                        txtCorreo.Text,
                        txtDireccion.Text,
                        cmbEstado.SelectedItem.ToString(),
                        clienteExistente.Saldo // Mantener el saldo actual
                    );
                    // redibujarTabla();
                    MessageBox.Show("Cliente modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarFormulario();


                }
                else
                {
                    MessageBox.Show("No se encontró un cliente con este código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            string codigoCliente = dtGvDatos.SelectedRows[0].Cells["Codigo"].Value.ToString();
            bool eliminado = manejadorClientes.EliminarCliente(codigoCliente);
            if (eliminado)
            {
                redibujarTabla();
                MessageBox.Show("Cliente eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarFormulario();
                contadorClientes--; // Disminuir el contador de clientes


            }
            else
            {
                MessageBox.Show("No se encontró un cliente con este código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //Modificar el texto del groupbox de valor a buscar cuando se cambia el valor seleccionado en el combobox
        private void cmbValoresDeBusqueda_SelectedValueChanged(object sender, EventArgs e)
        {
            gbValorABuscar.Text = $"Ingrese {cmbValoresDeBusqueda.SelectedItem.ToString()}";
            if(cmbValoresDeBusqueda.SelectedItem.ToString() == "Codigo")
            {
                txtValorAbuscar.Text = "CL-";
            }
            else
            {
                txtValorAbuscar.Text = "";
            }
        }


        //Buscar clientes por el valor ingresado en el textbox y el valor seleccionado en el combobox
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string strBuscarPor = cmbValoresDeBusqueda.SelectedItem.ToString();

            IList<clsCliente> clientesEncontrados = new List<clsCliente>();

            if (strBuscarPor.Equals("Codigo"))
            {
                clsCliente clienteTemporal = manejadorClientes.BuscarClientePorCodigo(txtValorAbuscar.Text.Trim());
                if (clienteTemporal != null)
                {
                    clientesEncontrados.Add(clienteTemporal);
                }

            }
            else if (strBuscarPor.Equals("Nombre"))
            {
                clientesEncontrados = manejadorClientes.BuscarClientesPorNombre(txtValorAbuscar.Text.Trim());

            }
            else if (strBuscarPor.Equals("Apellido"))
            {
                clientesEncontrados = manejadorClientes.BuscarClientesPorApellido(txtValorAbuscar.Text.Trim());

            }
            else if (strBuscarPor.Equals("DPI"))
            {

                clsCliente clienteTemporal = manejadorClientes.BuscarClientePorDPI(txtValorAbuscar.Text.Trim());
                if (clienteTemporal != null)
                {
                    clientesEncontrados.Add(clienteTemporal);
                }

            }
            else if (strBuscarPor.Equals("Telefono"))
            {

                clsCliente clienteTemporal = manejadorClientes.BuscarClientePorTelefono(txtValorAbuscar.Text.Trim());
                if (clienteTemporal != null)
                {
                    clientesEncontrados.Add(clienteTemporal);
                }
            }
            else if (strBuscarPor.Equals("Correo"))
            {
                clsCliente clienteTemporal = manejadorClientes.BuscarClientePorCorreo(txtValorAbuscar.Text.Trim());
                if (clienteTemporal != null)
                {
                    clientesEncontrados.Add(clienteTemporal);
                }
            }
            else if (strBuscarPor.Equals("Direccion"))
            {
                clientesEncontrados = manejadorClientes.BuscarClientesPorDireccion(txtValorAbuscar.Text.Trim());
            }
            else if (strBuscarPor.Equals("Estado"))
            {
                clientesEncontrados = manejadorClientes.BuscarClientesPorEstado(txtValorAbuscar.Text.Trim());
            }
            else if (strBuscarPor.Equals("Nit"))
            {
                clsCliente clienteTemporal = manejadorClientes.BuscarClientePorNit(txtValorAbuscar.Text.Trim());
                if (clienteTemporal != null)
                {
                    clientesEncontrados.Add(clienteTemporal);
                }
            }


            if (clientesEncontrados.Count > 0)
            {
                redibujarTabla(clientesEncontrados);
            }
            else
            {
                MessageBox.Show($"No se encontraron clientes por {strBuscarPor}.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                redibujarTabla();
            }
        }

        private void txtDPI_KeyPress(object sender, KeyPressEventArgs e)
        {
            //evitar el ingreso de letras en el campo DPI
            EvitarLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            EvitarLetras(e);
        }

        private void EvitarLetras(KeyPressEventArgs e)
        {
            //evitar el ingreso de letras en el campo Telefono
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter ingresado
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

