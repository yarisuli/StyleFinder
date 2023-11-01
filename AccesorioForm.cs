using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App_Ropa___Intento_1
{
    public partial class AccesorioForm : App_Ropa___Intento_1.TipoPrendaForm
    {
        public AccesorioForm()
        {
            InitializeComponent();
            InitializeVarianteButtons();
            setTipoPrenda(Constantes.TipoPrenda.Accesorio);
        }

        private void InitializeVarianteButtons()
        {
            this.buttonAnteojos .Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Accesorio_Anteojos); };
            this.buttonAros.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Accesorio_Aros); };
            this.buttonBolso.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Accesorio_Bolso); };
            this.buttonCartera.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Accesorio_Cartera); };
            this.buttonCollar.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Accesorio_Collar); };
            this.buttonPulsera.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Accesorio_Pulsera); };
        }
    }
}
