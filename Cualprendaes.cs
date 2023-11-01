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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

 

        private void buttonRemera_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form8 = new RemeraForm();
            form8.Show();
        }

        private void buttonVestido_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form9 = new VestidoForm();
            form9.Show();
        }

        private void buttonAbrigo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form10 = new AbrigoForm();
            form10.Show();
        }

        private void buttonAccesorio_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form12 = new AccesorioForm();
            form12.Show();
        }

        private void buttonPantalon_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form11 = new PantalonForm();
            form11.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form13 = new PolleraForm();
            form13.Show();
        }

        private void buttonCalzado_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form14 = new CalzadoForm();
            form14.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
