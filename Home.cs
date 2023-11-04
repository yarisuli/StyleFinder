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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDefinirOutfit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var situacionOutfit = new SituacionOutfit();
            situacionOutfit.Show();
        }

        private void buttonCalendario_Click(object sender, EventArgs e)
        {
            this.Hide();
            var calendario = new Calendario();
            calendario.Show();
        }

        private void buttonSubirPrenda_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tipoPrenda = new TipoPrenda();
            tipoPrenda.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form17 = new Form17();
            form17.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var logIn = new LogIn();
            logIn.Show();
        }

        private void buttonBiblioteca_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Biblioteca = new Biblioteca();
            Biblioteca.Show();
        }
    }
}
