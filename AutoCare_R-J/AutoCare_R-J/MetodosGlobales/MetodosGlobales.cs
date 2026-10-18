using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCare_R_J
{
    internal class MetodosGlobales
    {
        public static void DeshabilitarBoton(CustomButton boton)
        {
            boton.Enabled = false;
            boton.CustomBackColor = Color.Gray;
            boton.ForeColor = Color.Black;
            boton.Cursor = Cursors.No;
        }

        public static void HabilitarBoton(CustomButton boton, Color colorFondo, Color colorTexto, Cursor cursor)
        {
            boton.Enabled = true;
            boton.CustomBackColor = colorFondo;
            boton.ForeColor = colorTexto;
            boton.Cursor = cursor;
        }

        public static void CargarGrid(DataGridView dgv, object dataSource)
        {
            dgv.DataSource = null;
            dgv.DataSource = dataSource;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}