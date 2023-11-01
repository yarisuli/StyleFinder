using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App_Ropa___Intento_1
{
    public partial class VestidoForm : App_Ropa___Intento_1.TipoPrendaForm
    {
        public VestidoForm()
        {
            InitializeComponent();
            InitializeVarianteButtons();
            setTipoPrenda(Constantes.TipoPrenda.Vestido);
        }
        private void InitializeVarianteButtons()
        {
            this.buttonCasual.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Vestido_Casual); };
            this.buttonConMangas.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Vestido_Con_Mangas); };
            this.buttonCorto.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Vestido_Corto); };
            this.buttonFormal.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Vestido_Formal); };
            this.buttonLargo.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Vestido_Largo); };
            this.buttonSinMangas.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Vestido_Sin_Mangas); }; 
         }
    }
}
