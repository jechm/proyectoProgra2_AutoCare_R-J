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
        public Servicios()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAumentarTiempo_Click(object sender, EventArgs e)
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
    }
}
