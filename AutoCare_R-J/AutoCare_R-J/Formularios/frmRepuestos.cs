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

namespace AutoCare_R_J.Formularios  //borrar este comentario dle 231026
{ 
    public partial class frmRepuestos : Form
    {

        private clsManejadorRepuestos listaRepuestos;
        private string[] estados = { "Nuevo", "Usado", "Reacondicionado" };
        private string[] parametrosDeBusqueda = { "Codigo", "Nombre", "Categoria", "Marca" };

        public frmRepuestos()
        {
            InitializeComponent();
            listaRepuestos = new clsManejadorRepuestos();

            cmbEstado.DataSource = estados;
            cmbValoresDeBusqueda.DataSource = parametrosDeBusqueda ;
            DibujarTabla();
        }


        #region Botones del CRUD

        //Create
        private void bntNuevo_Click(object sender, EventArgs e)
        {

            if (listaRepuestos.nuevoRepuesto(txtCodigo.Text, txtNombre.Text, txtMarca.Text, txtCategoria.Text, nudCosto.Value, nudPrecio.Value, Convert.ToInt32(nudExistencias.Value), cmbEstado.SelectedItem.ToString()))
            {
                MessageBox.Show("Repuesto Agregado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DibujarTabla();
                
            }

        }

        //Read

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string strBuscarPor = cmbValoresDeBusqueda.SelectedItem.ToString();


            IList<clsRepuesto> repuestosEncontrados = new List<clsRepuesto>();

            if (strBuscarPor.Equals("Codigo"))
            {
                clsRepuesto repuestoTemporal = listaRepuestos.BuscarRepuestoPorCodigo(txtValorAbuscar.Text.Trim());
                if (repuestoTemporal != null)
                {
                    repuestosEncontrados.Add(repuestoTemporal);
                }

            }
            else if (!string.IsNullOrWhiteSpace(strBuscarPor))
            {
                repuestosEncontrados = listaRepuestos.BuscarRepuestos(strBuscarPor.ToLower(), txtValorAbuscar.Text.Trim());
            }

            if (repuestosEncontrados.Count > 0)
            {
                DibujarTabla(repuestosEncontrados);
            }
            else
            {
                MessageBox.Show($"No se encontraron repuestos por {strBuscarPor}.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DibujarTabla();
            }
        }


        //Update
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {

            if (listaRepuestos.ActualizarRegistro(txtCodigo.Text, txtNombre.Text, txtMarca.Text, txtCategoria.Text, nudCosto.Value, nudPrecio.Value, Convert.ToInt32(nudExistencias.Value), cmbEstado.SelectedItem.ToString()))
            {

                MessageBox.Show("Repuesto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            DibujarTabla();

        }


        //Delete
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (listaRepuestos.EliminarProductos(txtCodigo.Text))
            {
                limpiarFormulario();
                DibujarTabla();
                MessageBox.Show("Repuesto eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Repuesto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        #endregion

        #region Control de la Tabla
        //Evita que el programa cierre al hacer clic en la tabla
        private void dtGvDatos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
        }

        //Carga en el formulario los datos de un repuesto al hacer doble clic en una fila de la tabla
        private void dtGvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }


            txtCodigo.Text = dtGvDatos.Rows[e.RowIndex].Cells["CodigoRepuesto"].Value.ToString();
            txtNombre.Text = dtGvDatos.Rows[e.RowIndex].Cells["NombreRepuesto"].Value.ToString();
            txtMarca.Text = dtGvDatos.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
            txtCategoria.Text = dtGvDatos.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
            nudPrecio.Value = Convert.ToDecimal(dtGvDatos.Rows[e.RowIndex].Cells["Precio"].Value);
            nudCosto.Value = Convert.ToDecimal(dtGvDatos.Rows[e.RowIndex].Cells["Costo"].Value);
            nudExistencias.Value = Convert.ToInt32(dtGvDatos.Rows[e.RowIndex].Cells["Existencias"].Value);
            cmbEstado.SelectedItem = dtGvDatos.Rows[e.RowIndex].Cells["Estado"].Value.ToString();


            btnModificar.Enabled = true;
            btnModificar.CustomBackColor = Color.DeepSkyBlue; // Cambiar el color del botón a azul
            btnEliminar.Enabled = true;
            btnEliminar.CustomBackColor = Color.Red; // Cambiar el color del botón a rojo
        }

        #endregion

        #region Metodos modificadores de formulario (no DB)

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void limpiarFormulario()
        {

            txtCodigo.Text = listaRepuestos.ObtenerSiguienteCodigo();

            txtNombre.Text = "";
            txtCategoria.Text = "";
            txtMarca.Text = "";
            nudPrecio.Value = 0;
            nudCosto.Value = 0;
            nudExistencias.Value = 0;
            cmbEstado.TabIndex = 0;

            bloquearBotonesModificadores();
        }

        #region Metodos para dibujar la tabla de repuestos
        private void DibujarTabla()
        {

            dtGvDatos.DataSource = null;
            dtGvDatos.DataSource = listaRepuestos.ObtenerRegsitros();
            limpiarFormulario();
        }

        private void DibujarTabla(IList<clsRepuesto> repuestosFiltrados)
        {
            dtGvDatos.DataSource = null;
            dtGvDatos.DataSource = repuestosFiltrados;
            limpiarFormulario();
        }

        private void bloquearBotonesModificadores()
        {
            btnModificar.Enabled = false;
            btnModificar.CustomBackColor = Color.SlateGray; // Cambiar el color del botón a gris
            btnEliminar.Enabled = false;
            btnEliminar.CustomBackColor = Color.SlateGray; // Cambiar el color del botón a gris
        }
        #endregion

        //cambiar el parametro de busqueda
        private void cmbValoresDeBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbValoresDeBusqueda.SelectedItem.ToString() == "Codigo")
            {
                txtValorAbuscar.Text = "RP-";

            }
            else
            {
                txtValorAbuscar.Text = "";
            }

            gbValorABuscar.Text = $"Buscar por {cmbValoresDeBusqueda.SelectedItem.ToString()}";
        }

        #endregion
    }
}
