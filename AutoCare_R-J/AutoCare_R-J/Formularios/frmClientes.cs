using AutoCare_R_J.Controladores;     //borrar este comentario del 231026
using AutoCare_R_J.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AutoCare_R_J.Formularios
{
    public partial class frmClientes : Form
    {
        private clsManejadorClientes listaClientes;
        private string[] strEstadosCliente = { "Activo", "Inactivo", "En Mora" };
        private string[] strValoresDeBusqueda = { "Codigo", "Nombres", "Apellidos", "DPI", "Telefono", "Correo", "Direccion", "Estado", "Nit" };

        public frmClientes()
        {

            InitializeComponent();
            listaClientes = new clsManejadorClientes();

            cmbEstado.DataSource = strEstadosCliente;
            cmbValoresDeBusqueda.DataSource = strValoresDeBusqueda;

            redibujarTabla();
        }


        #region Metodos de redibujado y limpieza de formulario
        private void redibujarTabla()
        {
            limpiarFormulario();
            dtGvDatos.DataSource = null;
            dtGvDatos.DataSource = listaClientes.ObtenerClientes();

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

                    CrearCliente();

        }

        #region Validaciones de datos
        

        #endregion
        private void CrearCliente()
        {
            if(listaClientes.AgregarCliente(txtCodigo.Text, txtNombre.Text, txtApellido.Text, txtDPI.Text, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, cmbEstado.SelectedItem.ToString(), txtNit.Text, 0))
            {
                redibujarTabla();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            redibujarTabla();

        }

        private void limpiarFormulario()
        {

            txtCodigo.Text = listaClientes.ObtenerSiguienteCodigo();

            txtNombre.Text = "";
            txtApellido.Text = "";

            txtDPI.Text = "";
            txtDPI.Enabled = true; // Habilitar el campo DPI para que se pueda modificar

            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";


            txtNit.Text = "";
            txtNit.Enabled = true; // Habilitar el campo Nit para que se pueda modificar

            
            cmbEstado.SelectedIndex = 0; // Selecciona Activo estado por defecto
            cmbValoresDeBusqueda.SelectedIndex = 0; // Selecciona Codigo por defecto
            txtValorAbuscar.Text = "CL-";

            bloquearBotonesModificadores();
    
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
            ModificarCliente();


        }

        private void ModificarCliente()
        {
             

            if (listaClientes.ActualizarCliente(txtCodigo.Text, txtNombre.Text, txtApellido.Text, txtDPI.Text, txtTelefono.Text, txtCorreo.Text, 
                txtDireccion.Text, cmbEstado.SelectedItem.ToString(), txtNit.Text))
            {
                
                redibujarTabla();
                MessageBox.Show("Cliente modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarFormulario();
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                EliminarCliente();
                redibujarTabla();
                limpiarFormulario();
            }
        }

        private void EliminarCliente()
        {
            if(listaClientes.EliminarCliente(txtCodigo.Text))
            {
                MessageBox.Show("Cliente eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //Modificar el texto del groupbox de valor a buscar cuando se cambia el valor seleccionado en el combobox
        private void cmbValoresDeBusqueda_SelectedValueChanged(object sender, EventArgs e)
        {
            gbValorABuscar.Text = $"Ingrese {cmbValoresDeBusqueda.SelectedItem.ToString()}";
            if (cmbValoresDeBusqueda.SelectedItem.ToString() == "Codigo")
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
            string strBuscarPor = cmbValoresDeBusqueda.SelectedItem.ToString().ToLower();
            string parametroBusqueda = txtValorAbuscar.Text.Trim();

            IList<clsCliente> clientesEncontrados = new List<clsCliente>();

            if (strBuscarPor.Equals("codigo") || strBuscarPor.Equals("dpi") || strBuscarPor.Equals("nit") || strBuscarPor.Equals("correo") || strBuscarPor.Equals("telefono"))//
            {
                clsCliente clienteTemporal = listaClientes.BuscarClientePorParametroUnico(strBuscarPor, parametroBusqueda);
                if (clienteTemporal != null)
                {
                    clientesEncontrados.Add(clienteTemporal);
                }

            }
            else 
            {
                clientesEncontrados = listaClientes.BuscarClientePorParametroRepetibles(strBuscarPor, parametroBusqueda);

            }

            if (clientesEncontrados.Count > 0)
            {
                redibujarTabla(clientesEncontrados);
            }
            else
            {
                MessageBox.Show($"No se encontraron clientes con {strBuscarPor} = {parametroBusqueda}.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
//pendiente de revision metodos vacios

        private void txtCodigo_TextChanged(object sender, EventArgs e){}

        private void dtGvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {

        }
    }
}

