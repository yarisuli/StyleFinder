using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App_Ropa___Intento_1
{
    public partial class AbrigoForm : App_Ropa___Intento_1.TipoPrendaForm
    {
        public AbrigoForm()
        {
            InitializeComponent();
            InitializeVarianteButtons();
            setTipoPrenda(Constantes.TipoPrenda.Abrigo);
        }

        private void InitializeVarianteButtons()
        {
            this.buttonBlazer.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Abrigo_Blazer); };
            this.buttonBuzo.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Abrigo_Buzo); };
            this.buttonCampera.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Abrigo_Campera); };
            this.buttonChaqueta.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Abrigo_Chaqueta); };
            this.buttonPullover.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Abrigo_Pullover); };
            this.buttonSaco.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Abrigo_Saco); };
        }

    }
}
