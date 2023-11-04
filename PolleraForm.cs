using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App_Ropa___Intento_1
{
    public partial class PolleraForm : App_Ropa___Intento_1.PadrePrendaForm
    {
        public PolleraForm()
        {
            InitializeComponent();
            InitializeVarianteButtons();
            setTipoPrenda(Constantes.TipoPrenda.Pollera);
        }

        private void InitializeVarianteButtons()
        {
            this.buttonCasual.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Pollera_Casual); };
            this.buttonCorta.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Pollera_Corta); };
            this.buttonFormal.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Pollera_Formal); };
            this.buttonLarga.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Pollera_Larga); };
        }
    }
}
