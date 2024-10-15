using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Ropa___Intento_1
{
    public partial class CalendarioSemana : Form
    {
        private DateTime inicioSemana;
        public CalendarioSemana()
        {
            InitializeComponent();
            CompletarSemana(DateTime.Now);
        }

        public CalendarioSemana(DateTime fechaEvento)
        {
            InitializeComponent();
            CompletarSemana(fechaEvento);
        }

        private void CompletarSemana(DateTime fechaEvento)
        {
            int delta = DayOfWeek.Sunday - fechaEvento.DayOfWeek;
            //arreglo de delta por comienzo de semana en lunes en vez de domingo
            delta = delta == 0 ? delta : delta + 7;
            inicioSemana = fechaEvento.Date.AddDays(delta);

            layoutPanelSemana.Controls.Clear();
            for (int i = -7; i < 0 ; i++)
            {
                DateTime diaSemana = inicioSemana.AddDays(i+1);
                layoutPanelSemana.Controls.Add(new ElementoCalendario(diaSemana));
            }
            layoutPanelSemana.Refresh();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home = new Home();
            home.Show();
        }

        private void buttonCrearEvento_Click(object sender, EventArgs e)
        {
            this.Hide();
            var crearEvento = new CrearEvento();
            crearEvento.Show();
        }

        private void buttonSemanaSiguiente_Click(object sender, EventArgs e)
        {
            inicioSemana = inicioSemana.AddDays(7);
            CompletarSemana(inicioSemana);
        }

        private void buttonSemanaAnterior_Click(object sender, EventArgs e)
        {
            inicioSemana = inicioSemana.AddDays(-7);
            CompletarSemana(inicioSemana);
        }

        private void labelSemana_Click(object sender, EventArgs e)
        {

        }
    }
}
