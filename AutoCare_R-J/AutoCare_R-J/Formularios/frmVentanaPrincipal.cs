using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutoCare_R_J.Formularios;

namespace AutoCare_R_J.Formularios
{

    
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()

        {
            InitializeComponent();
        }

        
        private void btnClientes_Click(object sender, EventArgs e)
        {
            if(!FormularioAbierto("frmClientes"))
            {
                frmClientes clientes = new frmClientes();
                clientes.MdiParent = this;
                clientes.Show();
            }
        }

        //determinar si ya existe un formulario abierto
        private bool FormularioAbierto(string pNombreFormulario)
        {
            foreach (Form frmNombreFormulario in this.MdiChildren)
            {
                if (frmNombreFormulario.Name == pNombreFormulario)
                {
                    return true;
                }
            }
            return false;
        }

        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
