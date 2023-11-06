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
    public partial class Biblioteca : Form
    {
        public Biblioteca()
        {
            InitializeComponent();
        }

        private void Biblioteca_Load(object sender, EventArgs e)
        {

        }

        private void buttonPrendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            var BibliotecaPrendas = new BibliotecaPrendas();
            BibliotecaPrendas.Show();
        }

        private void buttonOutfits_Click(object sender, EventArgs e)
        {
            this.Hide();
            var BibliotecaOutfits = new BibliotecaOutfits();
            BibliotecaOutfits.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home = new Home();
            home.Show();
        }
    }
}
