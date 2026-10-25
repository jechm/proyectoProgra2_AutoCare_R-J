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

namespace AutoCare_R_J.Formularios     //borrar este comentario del 231026

{
    public partial class frmEmpleados : Form
    {
        private clsManejadorEmpleados manejadorEmpleados;
        private string[] strEstadosEmpleado = { "Activo", "Inactivo" };
        private string[] strValoresDeBusqueda = { "Codigo", "Nombre", "Apellido", "DPI","Usuario", "Telefono", "Correo", "Direccion","Puesto", "Estado" };
        private int contadorEmpleados;
        public frmEmpleados()
        {

            InitializeComponent();
            manejadorEmpleados = new clsManejadorEmpleados();
            cmbEstado.DataSource = strEstadosEmpleado;
            cmbEstado.SelectedIndex = 0; // Selecciona Activo estado por defecto
            cmbValoresDeBusqueda.DataSource = strValoresDeBusqueda;
            dtGvDatos.DataSource = manejadorEmpleados.ObtenerEmpleados();
        }

        internal void AsignarListaEmpleados(ref clsManejadorEmpleados pManejadorEmpleados)
        {
            manejadorEmpleados = pManejadorEmpleados;
            contadorEmpleados = manejadorEmpleados.TotalEmpleados + 1;
            txtCodigo.Text = $"EM-{contadorEmpleados:000}";
            redibujarTabla();


        }

        #region Metodos de redibujado y limpieza de formulario
        private void redibujarTabla()
        {
            dtGvDatos.DataSource = null;
            dtGvDatos.DataSource = manejadorEmpleados.ObtenerEmpleados();
            reordenarColumnas();
        }

        private void redibujarTabla(IList<clsEmpleado> pEmpleadosEncontrados)
        {
            dtGvDatos.DataSource = null;
            dtGvDatos.DataSource = pEmpleadosEncontrados;
            reordenarColumnas();
        }


        private void reordenarColumnas()
        {
            int ultimo = dtGvDatos.Columns.Count - 1;
            dtGvDatos.Columns["Usuario"].DisplayIndex = ultimo;
            dtGvDatos.Columns["Rol"].DisplayIndex = ultimo;
            dtGvDatos.Columns["Sueldo"].DisplayIndex = ultimo;
            
            
            dtGvDatos.Columns["Contraseña"].Visible = false;
        }

        #endregion


        private void bntNuevoCliente_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                // Crear el cliente si los datos son válidos
                if (ValidarEmpleadoExistente())
                {
                    CrearEmpleado();
                }
                
            }

        }

        #region Validaciones de datos
        private bool ValidarEmpleadoExistente()
        {

            bool empleadoExistenteDPI = manejadorEmpleados.BuscarEmpleadoPorDPI(txtDPI.Text) != null;
            bool empleadoExistenteUsuario = manejadorEmpleados.BuscarEmpleadoPorUsuario(txtUsuario.Text) != null;
            bool empleadoExistenteCorreo = manejadorEmpleados.BuscarEmpleadoPorCorreo(txtCorreo.Text) != null;
            bool empleadoExistenteTelefono = manejadorEmpleados.BuscarEmpleadoPorTelefono(txtTelefono.Text) != null;

            if (empleadoExistenteDPI)
            {
                MessageBox.Show("Ya existe un empleado con este DPI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (empleadoExistenteUsuario)
            {
                MessageBox.Show("Ya existe un empleado con este usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (empleadoExistenteCorreo)
            {
                MessageBox.Show("Ya existe un empleado con este correo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (empleadoExistenteTelefono)
            {
                MessageBox.Show("Ya existe un empleado con este teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // No hay empleados existentes con los mismos datos
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

            // Si todos los campos están completos, se puede proceder a crear el empleado
            return true;
        }
        #endregion
        private void CrearEmpleado()
        {
            string codigo = txtCodigo.Text;
            string direccion = string.IsNullOrWhiteSpace(txtDireccion.Text) ? "Sin especificar" : txtDireccion.Text;
            

            clsEmpleado empleadoTemporal = new clsEmpleado(
                codigo,
                txtNombre.Text,
                txtApellido.Text,
                txtDPI.Text,
                txtTelefono.Text,
                txtCorreo.Text,
                direccion,
                cmbEstado.SelectedItem.ToString(),
                txtRol.Text, //rol
                Convert.ToDecimal(txtSueldo.Text),           // sueldo decimal
                txtUsuario.Text, //usuario      
                txtContrasenia.Text //contraseña
                );

            manejadorEmpleados.AgregarEmpleado(empleadoTemporal);
            redibujarTabla();

            MessageBox.Show("Empleado creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            contadorEmpleados++;

            limpiarFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();

        }

        private void limpiarFormulario()
        {

            txtCodigo.Text = $"EM-{contadorEmpleados:000}";

            txtNombre.Text = "";
            txtApellido.Text = "";

            txtUsuario.Text = "";
            txtContrasenia.Text = "";

            txtDPI.Text = "";
            txtDPI.Enabled = true; // Habilitar el campo DPI para que se pueda modificar

            txtTelefono.Text = "";
            txtCorreo.Text = "";

            txtSueldo.Text = "";
            txtRol.Text = "";

            txtDireccion.Text = "";

            cmbEstado.SelectedIndex = 0;
            txtValorAbuscar.Text = "";

            bloquearBotonesModificadores();
            redibujarTabla();
        }

        private void bloquearBotonesModificadores()
        {
            btnModificarEmpleado.Enabled = false;
            btnModificarEmpleado.CustomBackColor = Color.SlateGray; // Cambiar el color del botón a gris
            btnEliminarEmpleado.Enabled = false;
            btnEliminarEmpleado.CustomBackColor = Color.SlateGray; // Cambiar el color del botón a gris
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

            txtDPI.Enabled = false; // Deshabilitar el campo DPI para que no se pueda modificar

            txtCodigo.Text = dtGvDatos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
            txtNombre.Text = dtGvDatos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txtApellido.Text = dtGvDatos.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            txtUsuario.Text = dtGvDatos.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
            txtContrasenia.Text = dtGvDatos.Rows[e.RowIndex].Cells["Contrasenia"].Value.ToString();
            txtDPI.Text = dtGvDatos.Rows[e.RowIndex].Cells["DPI"].Value.ToString();
            txtTelefono.Text = dtGvDatos.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
            txtCorreo.Text = dtGvDatos.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
            txtDireccion.Text = dtGvDatos.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
            txtRol.Text = dtGvDatos.Rows[e.RowIndex].Cells["Rol"].Value.ToString();
            txtSueldo.Text = dtGvDatos.Rows[e.RowIndex].Cells["Sueldo"].Value.ToString();
            cmbEstado.SelectedItem = dtGvDatos.Rows[e.RowIndex].Cells["Estado"].Value.ToString();


            btnModificarEmpleado.Enabled = true;
            btnModificarEmpleado.CustomBackColor = Color.DeepSkyBlue; // Cambiar el color del botón a azul
            btnEliminarEmpleado.Enabled = true;
            btnEliminarEmpleado.CustomBackColor = Color.Red; // Cambiar el color del botón a rojo


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
                clsEmpleado empleadoExistente = manejadorEmpleados.BuscarEmpleadoPorCodigo(txtCodigo.Text);

                if (empleadoExistente != null)
                {
                    empleadoExistente.actualizarEmpleado(
                        txtNombre.Text,
                        txtApellido.Text,
                        txtTelefono.Text,
                        txtCorreo.Text,
                        txtDireccion.Text,
                        cmbEstado.SelectedItem.ToString(),
                        txtRol.Text,
                        Convert.ToDecimal(txtSueldo.Text),
                        txtUsuario.Text,
                        txtContrasenia.Text 
                    );
                    // redibujarTabla();
                    MessageBox.Show("Empleado modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string codigoEmpleado = dtGvDatos.SelectedRows[0].Cells["Codigo"].Value.ToString();
            bool eliminado = manejadorEmpleados.EliminarEmpleado(codigoEmpleado);
            if (eliminado)
            {
                redibujarTabla();
                MessageBox.Show("Empleado eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarFormulario();
                contadorEmpleados--; // Disminuir el contador de empleados


            }
            else
            {
                MessageBox.Show("No se encontró un empleado con este código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //Modificar el texto del groupbox de valor a buscar cuando se cambia el valor seleccionado en el combobox
        private void cmbValoresDeBusqueda_SelectedValueChanged(object sender, EventArgs e)
        {
            gbValorABuscar.Text = $"Ingrese {cmbValoresDeBusqueda.SelectedItem.ToString()}";
            if(cmbValoresDeBusqueda.SelectedItem.ToString() == "Codigo")
            {
                txtValorAbuscar.Text = "EM-";
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

            IList<clsEmpleado> empleadosEncontrados = new List<clsEmpleado>();

            if (strBuscarPor.Equals("Codigo"))
            {
                clsEmpleado empleadoTemporal = manejadorEmpleados.BuscarEmpleadoPorCodigo(txtValorAbuscar.Text.Trim());
                if (empleadoTemporal != null)
                {
                    empleadosEncontrados.Add(empleadoTemporal);
                }

            }
            else if (strBuscarPor.Equals("Nombre"))
            {
                empleadosEncontrados = manejadorEmpleados.BuscarEmpleadosPorNombre(txtValorAbuscar.Text.Trim());    
            }
            else if (strBuscarPor.Equals("Apellido"))
            {
                empleadosEncontrados = manejadorEmpleados.BuscarEmpleadosPorApellido(txtValorAbuscar.Text.Trim());
            }
            else if (strBuscarPor.Equals("DPI"))
            {

                clsEmpleado empleadoTemporal = manejadorEmpleados.BuscarEmpleadoPorDPI(txtValorAbuscar.Text.Trim());
                if (empleadoTemporal != null)
                {
                    empleadosEncontrados.Add(empleadoTemporal);
                }

            }
            else if (strBuscarPor.Equals("Telefono"))
            {

                clsEmpleado empleadoTemporal = manejadorEmpleados.BuscarEmpleadoPorTelefono(txtValorAbuscar.Text.Trim());
                if (empleadoTemporal != null)
                {
                    empleadosEncontrados.Add(empleadoTemporal);
                }
            }
            else if (strBuscarPor.Equals("Correo"))
            {
                clsEmpleado empleadoTemporal = manejadorEmpleados.BuscarEmpleadoPorCorreo(txtValorAbuscar.Text.Trim());
                if (empleadoTemporal != null)
                {
                    empleadosEncontrados.Add(empleadoTemporal);
                }
            }
            else if (strBuscarPor.Equals("Direccion"))
            {
                empleadosEncontrados = manejadorEmpleados.BuscarEmpleadosPorDireccion(txtValorAbuscar.Text.Trim());
            }
            else if (strBuscarPor.Equals("Estado"))
            {
                empleadosEncontrados = manejadorEmpleados.BuscarEmpleadosPorEstado(txtValorAbuscar.Text.Trim());
            }
            else if (strBuscarPor.Equals("Rol"))
            {
                empleadosEncontrados = manejadorEmpleados.BuscarEmpleadosPorRol(txtValorAbuscar.Text.Trim());
            }


            if (empleadosEncontrados.Count > 0)
            {
                redibujarTabla(empleadosEncontrados);
            }
            else
            {
                MessageBox.Show($"No se encontraron empleados por {strBuscarPor}.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}

