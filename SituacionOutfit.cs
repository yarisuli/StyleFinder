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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.buttonElegante.Click += (sender, EventArgs) => { this.buttonSituacion_Click(sender, EventArgs, Constantes.Situacion.Elegante); };
            this.buttonSalir.Click += (sender, EventArgs) => { this.buttonSituacion_Click(sender, EventArgs, Constantes.Situacion.Salir); };
            this.buttonCasual.Click += (sender, EventArgs) => { this.buttonSituacion_Click(sender, EventArgs, Constantes.Situacion.Casual); };
            this.buttonDeporte.Click += (sender, EventArgs) => { this.buttonSituacion_Click(sender, EventArgs, Constantes.Situacion.Deporte); };
        }


        //private void pictureBox2_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    var form5 = new Form5(Constantes.Situacion.Deporte);
        //    form5.Show();
        //}

        //private void pictureBox4_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    var form5 = new Form5(Constantes.Situacion.Salir);
        //    form5.Show();
        //}

        //private void pictureBox3_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    var form5 = new Form5(Constantes.Situacion.Elegante);
        //    form5.Show();
        //}

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    var form5 = new Form5(Constantes.Situacion.Casual);
        //    form5.Show();
        //}

        private void buttonSituacion_Click(object sender, EventArgs eventArgs, Constantes.Situacion situacion)
        {
            this.Hide();
            var form5 = new Form5(situacion);
            form5.Show();
        }
    }
}
