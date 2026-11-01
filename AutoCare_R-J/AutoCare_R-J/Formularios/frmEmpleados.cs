using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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

        public frmEmpleados()
        {

            InitializeComponent();
            manejadorEmpleados = new clsManejadorEmpleados();
            cmbEstado.DataSource = strEstadosEmpleado;
            cmbEstado.SelectedIndex = 0; // Selecciona Activo estado por defecto
            cmbValoresDeBusqueda.DataSource = strValoresDeBusqueda;
            redibujarTabla();
            txtCodigo.Text = manejadorEmpleados.ObtenerSiguienteCodigo();
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
            
            
            dtGvDatos.Columns["Contrasenia"].Visible = false;
        }

        #endregion


        private void bntNuevoCliente_Click(object sender, EventArgs e)
        {

                    CrearEmpleado();

        }

        private void CrearEmpleado()
        {
            try
            {
                clsEmpleado nuevoEmpleado = new clsEmpleado(txtCodigo.Text,
                    txtNombre.Text,
                    txtApellido.Text,
                    txtDPI.Text,
                    txtTelefono.Text,
                    txtCorreo.Text,
                    txtDireccion.Text,
                    cmbEstado.SelectedItem.ToString(),
                    txtUsuario.Text,
                    txtContrasenia.Text,
                    txtRol.Text,
                    nudSueldo.Value);

                if (manejadorEmpleados.AgregarEmpleado(nuevoEmpleado))

                {
                    MessageBox.Show("Empleado creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiarFormulario();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
                        
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();

        }

        private void limpiarFormulario()
        {

            txtCodigo.Text = manejadorEmpleados.ObtenerSiguienteCodigo();

            txtNombre.Text = "";
            txtApellido.Text = "";

            txtUsuario.Text = "";
            txtContrasenia.Text = "";

            txtDPI.Text = "";
            txtDPI.Enabled = true; // Habilitar el campo DPI para que se pueda modificar

            txtTelefono.Text = "";
            txtCorreo.Text = "";

            nudSueldo.Value = 0;
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
            nudSueldo.Value = Convert.ToDecimal(dtGvDatos.Rows[e.RowIndex].Cells["Sueldo"].Value.ToString());
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
            try { 
            clsEmpleado empleadoModificado = new clsEmpleado(txtCodigo.Text,
                        txtNombre.Text,
                        txtApellido.Text,
                        txtDPI.Text,
                        txtTelefono.Text,
                        txtCorreo.Text,
                        txtDireccion.Text,
                        cmbEstado.SelectedItem.ToString(),
                        txtUsuario.Text,
                        txtContrasenia.Text,
                        txtRol.Text,
                        nudSueldo.Value);
        

                if (manejadorEmpleados.ModificarEmpleado(empleadoModificado)){ 
                    MessageBox.Show("Empleado modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarFormulario();


                }
                else
                {
                    MessageBox.Show("No se encontró un cliente con este código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }   
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
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

