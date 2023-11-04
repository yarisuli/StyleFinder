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
    public partial class CrearEvento : Form
    {
        public CrearEvento()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var calendario = new Calendario();
            calendario.Show();
            // ACA HACER INSERT EN EVENTOS
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var calendario = new Calendario();
            calendario.Show();
        }
    }
}
