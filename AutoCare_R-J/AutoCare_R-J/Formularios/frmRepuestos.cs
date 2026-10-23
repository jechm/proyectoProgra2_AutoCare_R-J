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
        private int contadorRepuestos;
        private string[] estados = { "Nuevo", "Usado", "Reacondicionado" };

        public frmRepuestos()
        {
            InitializeComponent();
            listaRepuestos = new clsManejadorRepuestos();
            contadorRepuestos = listaRepuestos.ObtenerRepuestos().Count;

            cmbEstado.DataSource = estados;
            cmbValoresDeBusqueda.DataSource = new string[] { "Codigo", "Nombre", "Categoria", "Marca" };
            DibujarTabla();
        }

        internal void AsignarListaRepuestos(ref clsManejadorRepuestos listaRepuestos)
        {
            this.listaRepuestos = listaRepuestos;
        }


        #region Metodos para dibujar la tabla de repuestos
        private void DibujarTabla()
        {
            dtGvDatos.DataSource = null;
            dtGvDatos.DataSource = listaRepuestos.ObtenerRepuestos();
            limpiarFormulario();
        }

        private void DibujarTabla(IList<clsRepuesto> repuestosFiltrados)
        {
            dtGvDatos.DataSource = null;
            dtGvDatos.DataSource = repuestosFiltrados;
            limpiarFormulario();
        }

        private void limpiarFormulario()
        {
            txtCodigo.Text = $"RP-{contadorRepuestos + 1:000}";

            txtNombre.Text = "";
            txtCategoria.Text = "";
            txtMarca.Text = "";
            nudPrecio.Value = 0;
            nudCosto.Value = 0;
            nudExistencias.Value = 0;
            cmbEstado.TabIndex = 0;

            bloquearBotonesModificadores();
        }

        private void bloquearBotonesModificadores()
        {
            btnModificar.Enabled = false;
            btnModificar.CustomBackColor = Color.SlateGray; // Cambiar el color del botón a gris
            btnEliminar.Enabled = false;
            btnEliminar.CustomBackColor = Color.SlateGray; // Cambiar el color del botón a gris
        }
        #endregion

        private void dtGvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

        }

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigoRepuesto = dtGvDatos.SelectedRows[0].Cells["Codigo"].Value.ToString();
            if (listaRepuestos.EliminarRepuesto(codigoRepuesto))
            {
                contadorRepuestos--;
                limpiarFormulario();
                DibujarTabla();
                MessageBox.Show("Repuesto eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el repuesto, verifique que el código sea correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (!validarDatos())
            {
                return;
            }

            clsRepuesto repuestoTemporal = new clsRepuesto
            (
                txtCodigo.Text,
                txtNombre.Text,
                txtCategoria.Text,
                txtMarca.Text,
                nudPrecio.Value,
                nudCosto.Value,
                (int)nudExistencias.Value,
                cmbEstado.SelectedItem.ToString()
            );

            if (!listaRepuestos.ModificarRepuesto(repuestoTemporal))
            {
                MessageBox.Show("No se pudo modificar el repuesto, verifique que el código sea correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Repuesto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            DibujarTabla();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void cstmPnlDatosCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private bool validarDatos()
        {
            // Campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("El campo Categoría es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("El campo Marca es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Precio y costo deben ser decimales válidos y no negativos
            if (nudPrecio.Value == 0m)
            {
                MessageBox.Show("El precio indicado no es valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void dtGvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }


            txtCodigo.Text = dtGvDatos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
            txtNombre.Text = dtGvDatos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
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
            else if (strBuscarPor.Equals("Nombre"))
            {
                repuestosEncontrados = listaRepuestos.BuscarRepuestosPorNombre(txtValorAbuscar.Text.Trim());
            }
            else if (strBuscarPor.Equals("Categoria"))
            {
                repuestosEncontrados = listaRepuestos.BuscarRepuestosPorCategoria(txtValorAbuscar.Text.Trim());
            }
            else if (strBuscarPor.Equals("Marca"))
            {
                repuestosEncontrados = listaRepuestos.BuscarRepuestosPorMarca(txtValorAbuscar.Text.Trim());
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

        private void bntNuevo_Click(object sender, EventArgs e)
        {
            if (listaRepuestos.BuscarRepuestoPorCodigo(txtCodigo.Text)!=null)
            {
                MessageBox.Show("Este codigo ya existe");
                return;

            }

                if (validarDatos())
                {
                    clsRepuesto nuevoRepuesto = new clsRepuesto
                    (
                        txtCodigo.Text,
                        txtNombre.Text,
                        txtCategoria.Text,
                        txtMarca.Text,
                        nudPrecio.Value,
                        nudCosto.Value,
                        (int)nudExistencias.Value,
                        cmbEstado.SelectedItem.ToString()
                    );
                    listaRepuestos.AgregarRepuesto(nuevoRepuesto);
                    contadorRepuestos++;
                    DibujarTabla();

                }
        }
    }
}
