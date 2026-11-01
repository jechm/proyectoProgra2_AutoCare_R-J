using AutoCare_R_J.MetodosGlobales;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            using(var con = clsConexion.ObtenerConexion())
            {
                if(con.State != System.Data.ConnectionState.Open)
                    con.Open();

                string sql = "SELECT contrasenia, estado FROM empleados WHERE usuario = @usuario";

                using (var cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    
                    using(var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            string contrasenia = r.GetString(0);
                            string estado = r.GetString(1);
                            if (estado.ToUpper() == "ACTIVO")
                            {
                                if (contrasenia == txtContrasenia.Text)
                                {
                                    MessageBox.Show("Bienvenido al sistema");
                                    this.DialogResult = DialogResult.OK;
                                }
                                else
                                {
                                    MessageBox.Show("Usuario o contraseña incorrectos");
                                }
                            }
                            else
                            {
                                MessageBox.Show("El usuario está inactivo. Contacte al administrador.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario Incorrecto");
                        }
                    }



                    /*  int count = Convert.ToInt32(cmd.ExecuteScalar());

                      if (count > 0)
                      {
                          MessageBox.Show("Bienvenido al sistema");
                          this.DialogResult = DialogResult.OK;
                      }
                      else
                      {
                          MessageBox.Show("Usuario o contraseña incorrectos");
                      }*/
                }
            }

        }
    }
}
