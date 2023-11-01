﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Ropa___Intento_1
{
    public partial class TipoPrendaForm : Form
    {

        private Constantes.TipoPrenda tipoPrenda;
        private string base64Image;
        private Constantes.ColorPrenda colorPrenda;
        private Constantes.VariantePrenda variantePrenda;
        protected Dictionary<Constantes.VariantePrenda, int> variantesPrendaSeleccionadas = new Dictionary<Constantes.VariantePrenda, int>();

        public TipoPrendaForm()
        {
            InitializeComponent();
            InitializeColorButtons();
        }

        private void InitializeColorButtons()
        {
            this.buttonAmarillo.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Amarillo); };
            this.buttonAzul.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Azul); };
            this.buttonCeleste.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Celeste); };
            this.buttonCian.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Cian); };
            this.buttonNaranja.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Naranja); };
            this.buttonRojo.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Rojo); };
            this.buttonRosa.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Rosa); };
            this.buttonRosita.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Rosita); };
            this.buttonVerde.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Verde); };
            this.buttonVerdeClaro .Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Verde_Claro); };
            this.buttonVioleta.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Violeta); };
            this.buttonVioletaClaro.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Violeta_Claro); };

        }

        protected void buttonVariante_Click(object sender, EventArgs eventArgs, Constantes.VariantePrenda pVariantePrenda)
        {
            variantePrenda = pVariantePrenda;
            Boolean seleccionado = actualizarVariantePrenda(pVariantePrenda);
           // ((PictureBox)sender).BackColor = seleccionado ? Color.Aquamarine : Color.Transparent;
            ((PictureBox)sender).BorderStyle = seleccionado ? BorderStyle.Fixed3D : BorderStyle.None;
        }

        protected Boolean actualizarVariantePrenda(Constantes.VariantePrenda variantePrenda)
        {
            Boolean incluida = variantesPrendaSeleccionadas.ContainsKey(variantePrenda);
            if (incluida)
            {
                variantesPrendaSeleccionadas.Remove(variantePrenda);
            }
            else
            {
                variantesPrendaSeleccionadas.Add(variantePrenda, (int)variantePrenda);
            }

            return !incluida;

        }
        private void buttonColor_Click(object sender, EventArgs eventArgs, Constantes.ColorPrenda pColorPrenda)
        {
            colorPrenda = pColorPrenda;
            labelColorSeleccionado.Text = pColorPrenda.ToString().Replace("_"," ");
        }

        protected void setTipoPrenda(Constantes.TipoPrenda pTipoPrenda)
        {
            this.labelTitulo.Text = pTipoPrenda.ToString();
            tipoPrenda = pTipoPrenda;


        }

        private void buttonGrabar_Click(object sender, EventArgs e)
        {
            //llamar insert articulo, 
            this.Hide();
            var form2 = new Form2();
            form2.Show();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form7 = new Form7();
            form7.Show();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            base64Image = ImageUtils.SelectImageBase64();
            ImageUtils.ShowBase64ImageInPictureBox(base64Image, pictureBox26);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }


    }
}