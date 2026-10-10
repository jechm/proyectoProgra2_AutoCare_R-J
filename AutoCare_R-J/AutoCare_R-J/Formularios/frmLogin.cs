using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCare_R_J
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }


        //Cerrar el formulario de login
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        //mover hacia arriba estos atributos
        private int primerUsuario = 0;

        private int primerContrasenia = 0;


        private void txtContrasenia_Enter(object sender, EventArgs e)
        {

            if(primerContrasenia == 0)
            {
                txtContrasenia.Text = "";
                txtContrasenia.PasswordChar = '*';
                primerContrasenia++;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {

            if(primerUsuario == 0)
            {
                txtUsuario.Text = "";
                primerUsuario++;
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "admin" && txtContrasenia.Text == "admin")
            {
                MessageBox.Show("Bienvenido al sistema");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
