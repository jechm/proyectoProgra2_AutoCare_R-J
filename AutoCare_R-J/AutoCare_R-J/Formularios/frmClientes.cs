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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos del formulario
            string strCodigo = tbxCodigo.Text;
            string strNombre = tbxNombre.Text;
 

        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
