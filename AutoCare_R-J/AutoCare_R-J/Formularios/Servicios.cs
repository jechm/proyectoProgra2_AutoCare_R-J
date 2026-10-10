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
    public partial class Servicios : Form
    {
        private readonly clsManejadorServicios manejadorServicios = new clsManejadorServicios();

        public Servicios()
        {
            InitializeComponent();

            //desabilitar el botón de limpiar campo al inicio
            DeshabilitarBoton(btnLimpiarCampos);

            //desabilitar el botón de eliminar al inicio
            DeshabilitarBoton(btnEliminar);

            //desabilitar el botón de modificar al inicio
            DeshabilitarBoton(btnModificar);
        }


        private void AumentarTiempo_Click(object sender, EventArgs e)
        {
            //Minutos a aumentar
            int intMinutosAumentar = 15;
            // Obtener los valores de las cajas de texto
            string strDuracionHoras = tbxDuracionHoras.Text;
            string strDuracionMinutos = tbxDuracionMinutos.Text;
            // Convertir las horas y minutos a enteros
            int intHoras = int.Parse(strDuracionHoras);
            int intMinutos = int.Parse(strDuracionMinutos);
            //Sumar los minutos a aumentar
            intMinutos = intMinutos + intMinutosAumentar;
            // Verificar si los minutos superan los 60 y ajustar las horas en consecuencia
            if (intMinutos >= 60)
            {
                intHoras += intMinutos / 60; // Incrementar las horas según los minutos
                intMinutos = intMinutos % 60; // Obtener los minutos restantes
            }
            // Actualizar las cajas de texto con los nuevos valores
            tbxDuracionHoras.Text = intHoras.ToString();
            tbxDuracionMinutos.Text = intMinutos.ToString();
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            // Muestra el primer código (srv-001) al abrir
            tbxCodigo.Text = manejadorServicios.ObtenerSiguienteCodigo();
            tbxCodigo.ReadOnly = true; // Bloqueado para que el usuario no lo modifique
        }

        private void cpDatosServicio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAumentarTiempo_Click(object sender, EventArgs e)
        {
            AumentarTiempo_Click(sender, e);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string strNombre = tbxNombre.Text.Trim();
            string strCategoria = cbxCategoria.Text.Trim();
            double dblCosto = Convert.ToDouble(nmCosto.Value);
            string strDescripcion = tbxDescripcion.Text.Trim();
            string strDuracion = $"{tbxDuracionHoras.Text}h {tbxDuracionMinutos.Text}m";

            if (string.IsNullOrEmpty(strNombre) || string.IsNullOrEmpty(strCategoria) || dblCosto <= 0 || string.IsNullOrEmpty(strDescripcion) || string.IsNullOrEmpty(tbxDuracionHoras.Text) || string.IsNullOrEmpty(tbxDuracionMinutos.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    // llamar al método AgregarServicio del manejador de servicios para agregar un nuevo servicio
                    manejadorServicios.AgregarServicio(
                        tbxNombre.Text,
                        cbxCategoria.Text,
                        Convert.ToDouble(nmCosto.Value),
                        tbxDescripcion.Text,
                        $"{tbxDuracionHoras.Text}h {tbxDuracionMinutos.Text}m"
                    );

                    MessageBox.Show("¡Servicio guardado con éxito!");

                    //actualizar el código automáticamente para el siguiente servicio
                    tbxCodigo.Text = manejadorServicios.ObtenerSiguienteCodigo();

                    //limpiar los campos después de guardar
                    LimpiarCampos();

                    //Actualizar el DataGridView para reflejar los cambios
                    ActualizarGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            

        }
        private void ActualizarGrid()
        {
            // Limpia la fuente de datos actual para evitar duplicados
            dgvServicios.DataSource = null;

            // Asigna la lista actualizada que viene de tu manejador
            dgvServicios.DataSource = manejadorServicios.ListarServicios();

            // Ajusta el tamaño de las columnas para que se ajusten al contenido
            dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string strCodigoABuscar = tbxBuscCodigo.Text.Trim();
            string strNombreABuscar = tbxBuscNombre.Text.Trim();

            // Se verifica si alguno de los campos no está vacío antes de proceder con la búsqueda
            if (!string.IsNullOrEmpty(strCodigoABuscar) || !string.IsNullOrEmpty(strNombreABuscar))
            {
                try
                {
                    clsServicios servicioEncontrado = manejadorServicios.BuscarServicio(strCodigoABuscar, strNombreABuscar);

                    // Cargar los datos del servicio encontrado en los campos correspondientes
                    tbxCodigo.Text = servicioEncontrado.Codigo;
                    tbxNombre.Text = servicioEncontrado.Nombre;
                    cbxCategoria.Text = servicioEncontrado.Categoria;
                    nmCosto.Value = Convert.ToDecimal(servicioEncontrado.Costo);
                    tbxDescripcion.Text = servicioEncontrado.Descripcion;
                    // Separar la duración en horas y minutos
                    string[] duracionPartes = servicioEncontrado.Duracion.Split(new char[] { 'h', 'm' }, StringSplitOptions.RemoveEmptyEntries);
                    if (duracionPartes.Length == 2)
                    {
                        tbxDuracionHoras.Text = duracionPartes[0].Trim();
                        tbxDuracionMinutos.Text = duracionPartes[1].Trim();
                    }
                    else
                    {
                        tbxDuracionHoras.Clear();
                        tbxDuracionMinutos.Clear();
                    }

                    MessageBox.Show("¡Servicio encontrado y cargado en pantalla!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Habilitar el botones
                    HabilitarBoton(btnLimpiarCampos, Color.DeepSkyBlue, Color.White, Cursors.Hand);
                    HabilitarBoton(btnEliminar, Color.Red, Color.White, Cursors.Hand);
                    HabilitarBoton(btnModificar, Color.DeepSkyBlue, Color.White, Cursors.Hand);

                    //Deshabilitar el botón de agregar
                    DeshabilitarBoton(btnAgregar);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un código o un nombre para buscar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            tbxNombre.Clear();
            cbxCategoria.SelectedIndex = -1;
            nmCosto.Value = 0;
            tbxDescripcion.Clear();
            tbxDuracionHoras.Clear();
            tbxDuracionMinutos.Clear();

            // Actualiza al siguiente código correlativo automáticamente (ej. srv-003)
            tbxCodigo.Text = manejadorServicios.ObtenerSiguienteCodigo();
            tbxNombre.Focus(); // Pone el cursor listo para escribir el próximo
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            //habilitar el botón de agregar
            HabilitarBoton(btnAgregar, Color.Green, Color.White, Cursors.Hand);

            // Deshabilitar el botón de limpiar campo
            DeshabilitarBoton(btnLimpiarCampos);
        }

        private void DeshabilitarBoton(CustomButton boton) 
        {
            boton.Enabled = false;
            boton.CustomBackColor = Color.Gray;
            boton.ForeColor = Color.Black;
            boton.Cursor = Cursors.No;
        }

        private void HabilitarBoton(CustomButton boton, Color colorFondo, Color colorTexto, Cursor cursor)
        {
            boton.Enabled = true;
            boton.CustomBackColor = colorFondo;
            boton.ForeColor = colorTexto;
            boton.Cursor = cursor;
        }
    }
}
