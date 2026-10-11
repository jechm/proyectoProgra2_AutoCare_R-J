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
        private int contadorClientes;
        public frmClientes()
        {
           
            InitializeComponent();
            
            cmbEstado.DataSource = strEstadosCliente;
            cmbEstado.SelectedIndex = 0; // Selecciona Activo estado por defecto
           //dtGvDatos.DataSource = manejadorClientes.ObtenerClientes();
        }

        internal void AsignarListaclientes(ref clsManejadorClientes pManejadorClientes)
        {
            manejadorClientes = pManejadorClientes;
            contadorClientes = manejadorClientes.TotalClientes+1;
            txtCodigo.Text = $"CL-{contadorClientes:000}";
            redibujarTabla();
            

        }

        private void redibujarTabla()
        {
            dtGvDatos.DataSource = null;
            dtGvDatos.DataSource = manejadorClientes.ObtenerClientes();
            int ultimo = dtGvDatos.Columns.Count - 1;
            dtGvDatos.Columns["Nit"].DisplayIndex = ultimo;
            dtGvDatos.Columns["Saldo"].DisplayIndex = ultimo;
        }


        private void bntNuevoCliente_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                // Crear el cliente si los datos son válidos
                if(manejadorClientes.BuscarClientePorCodigo(txtCodigo.Text) != null)
                {
                    MessageBox.Show("Ya existe un cliente con este código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                CrearCliente();
            }
        }

        private void CrearCliente()
        {
            string codigo = txtCodigo.Text;
            clsCliente clienteTemporal = new clsCliente(
                codigo,
                txtNombre.Text, 
                txtApellido.Text, 
                txtDPI.Text, 
                txtTelefono.Text, 
                txtCorreo.Text, 
                txtDireccion.Text, 
                cmbEstado.SelectedItem.ToString(), 
                txtNit.Text, 
                0
                );
            manejadorClientes.AgregarCliente(clienteTemporal);
            redibujarTabla();
            
            MessageBox.Show("Cliente creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            contadorClientes++;
            txtCodigo.Text = $"CL-{contadorClientes:000}";
            limpiarFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
            
        }

        private void limpiarFormulario()
        {

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDPI.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            cmbEstado.SelectedIndex = 0;
            txtNit.Text = "";
        }

        private bool validarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDPI.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(cmbEstado.Text) ||
                string.IsNullOrWhiteSpace(txtNit.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Si todos los campos están completos, se puede proceder a crear el cliente
            return true;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void dtGvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNit.Enabled = false; // Deshabilitar el campo Nit para que no se pueda modificar
            txtDPI.Enabled = false; // Deshabilitar el campo DPI para que no se pueda modificar
            if (e.RowIndex < 0)
            {
                return;
            }
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
            btnEliminarCliente.Enabled = true;

        }

        private void dtGvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
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
                    redibujarTabla();
                    MessageBox.Show("Cliente modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNit.Enabled = true; // Habilitar el campo Nit para que se pueda modificar
                    txtDPI.Enabled = true; // Habilitar el campo DPI para que se pueda modificar
                    limpiarFormulario();
                }
                else
                {
                    MessageBox.Show("No se encontró un cliente con este código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            btnModificarCliente.Enabled = false;
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            btnEliminarCliente.Enabled = false;
        }
    }
}

