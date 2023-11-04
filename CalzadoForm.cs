using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App_Ropa___Intento_1
{
    public partial class CalzadoForm : App_Ropa___Intento_1.PadrePrendaForm
    {
        public CalzadoForm()
        {
            InitializeComponent();
            InitializeVarianteButtons();
            setTipoPrenda(Constantes.TipoPrenda.Calzado);
        }
        private void InitializeVarianteButtons()
        {
            this.buttonBotas.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Calzado_Botas); };
            this.buttonDeportivo.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Calzado_Deportivo); };
            this.buttonFormal.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Calzado_Formal); };
            this.buttonSandalias.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Calzado_Sandalias); };
            this.buttonZapatillas.Click += (sender, EventArgs) => { this.buttonVariante_Click(sender, EventArgs, Constantes.VariantePrenda.Calzado_Zapatillas); };
        }
    }
}
