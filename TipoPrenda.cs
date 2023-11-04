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
    public partial class TipoPrenda : Form
    {
        public TipoPrenda()
        {
            InitializeComponent();
        }

 

        private void buttonRemera_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formRemera = new RemeraForm();
            formRemera.Show();
        }

        private void buttonVestido_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formVestido = new VestidoForm();
            formVestido.Show();
        }

        private void buttonAbrigo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formAbrigo = new AbrigoForm();
            formAbrigo.Show();
        }

        private void buttonAccesorio_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formAccesorio = new AccesorioForm();
            formAccesorio.Show();
        }

        private void buttonPantalon_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formPantalon = new PantalonForm();
            formPantalon.Show();
        }

        private void buttonPollera_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formPollera = new PolleraForm();
            formPollera.Show();
        }

        private void buttonCalzado_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCalzado = new CalzadoForm();
            formCalzado.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home = new Home();
            home.Show();
        }
    }
}
