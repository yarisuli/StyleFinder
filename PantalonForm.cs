using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App_Ropa___Intento_1
{
    public partial class PantalonForm : App_Ropa___Intento_1.PadrePrendaForm
    {
        public PantalonForm()
        {
            InitializeComponent();
            InitializeVarianteButtons();
            setTipoPrenda(Constantes.TipoPrenda.Pantalon);
        }

        private void InitializeVarianteButtons()
        {
            this.buttonClasico.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Pantalon_Clasico); };
            this.buttonDeportivo.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Pantalon_Deportivo); };
            this.buttonCorto.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Pantalon_Corto); };
            this.buttonLargo.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Pantalon_Largo); };
            this.buttonElegante.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Pantalon_Elegante); };
        }
    }
}
