using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App_Ropa___Intento_1
{
    public partial class RemeraForm : App_Ropa___Intento_1.PadrePrendaForm
    {
        public RemeraForm()
        {
            InitializeComponent();
            InitializeVarianteButtons();
            setTipoPrenda(Constantes.TipoPrenda.Remera);
        }

        private void InitializeVarianteButtons()
        {
            this.buttonClasica.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Remera_Clasica); };
            this.buttonCorta.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Remera_Corta); };
            this.buttonDeportiva.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Remera_Deportiva); };
            this.buttonLarga.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Remera_Larga); };
            this.buttonElegante.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Remera_Elegante); };
            this.buttonMusculosa.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Remera_Musculosa); };
            this.buttonOverzise.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Remera_Oversize); };
            this.buttonTop.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Remera_Top); };
        }
    }
}
