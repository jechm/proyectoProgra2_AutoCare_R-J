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
            txtDescripcion.Text = "";
            txtCategoria.Text = "";
            txtMarca.Text = "";
            txtPrecio.Text = "";
            nudExistencias.Value = 0;
            cmbEstado.TabIndex = 0;
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
            if (!listaRepuestos.EliminarRepuesto(txtCodigo.Text))
            {
                MessageBox.Show("No se pudo eliminar el repuesto, verifique que el código sea correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contadorRepuestos--;
                DibujarTabla();
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            clsRepuesto repuestoTemporal = new clsRepuesto
            (
                txtCodigo.Text,
                txtNombre.Text,
                txtDescripcion.Text,
                txtCategoria.Text,
                txtMarca.Text,
                Convert.ToDecimal(txtPrecio.Text),
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
                DibujarTabla();
            }
        }
    }
}
