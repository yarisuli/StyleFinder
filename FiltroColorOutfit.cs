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
    public partial class FiltroColorOutfit : Form
    {
        private Constantes.ColorPrenda colorPrenda;
        private DefinirOutfit parentForm;
        public FiltroColorOutfit(DefinirOutfit parent)
        {
            InitializeComponent();
            parentForm = parent;
            this.buttonAmarillo.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Amarillo); };
            this.buttonAzul.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Azul); };
            this.buttonCeleste.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Celeste); };
            this.buttonCian.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Cian); };
            this.buttonNaranja.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Naranja); };
            this.buttonRojo.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Rojo); };
            this.buttonRosa.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Rosa); };
            this.buttonRosita.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Rosita); };
            this.buttonVerde.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Verde); };
            this.buttonVerdeClaro.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Verde_Claro); };
            this.buttonVioleta.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Violeta); };
            this.buttonVioletaClaro.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Violeta_Claro); };
            this.buttonNegro.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Negro); };
            this.buttonBlanco.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Blanco); };
            this.buttonGris.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Gris); };
        }

        private void buttonColor_Click(object sender, EventArgs eventArgs, Constantes.ColorPrenda pColorPrenda)
        {
            colorPrenda = pColorPrenda;
            labelColorSeleccionado.Text = pColorPrenda.ToString().Replace("_", " ");
            if (colorPrenda.Equals(Constantes.ColorPrenda.Negro))
            {
                checkNegro.Checked = false;
                checkNegro.Enabled = false;
            } else
            {
                checkNegro.Enabled = true;
            }

            if (colorPrenda.Equals(Constantes.ColorPrenda.Blanco))
            {
                checkBlanco.Checked = false;
                checkBlanco.Enabled = false;
            }
            else
            {
                checkBlanco.Enabled = true;
            }

            if (colorPrenda.Equals(Constantes.ColorPrenda.Gris))
            {
                checkGris.Checked = false;
                checkGris.Enabled = false;
            }
            else
            {
                checkGris.Enabled = true;
            }
        }
        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            if (colorPrenda == Constantes.ColorPrenda.Ninguno)
            {
                MessageBox.Show("Debe seleccionar un color a filtrar.");
            }
            else {

                parentForm.FiltroColores.Add(((int)colorPrenda));

            if (checkBlanco.Checked)
            {
                    parentForm.FiltroColores.Add(((int)Constantes.ColorPrenda.Blanco));
            }
            
            if (checkNegro.Checked)
            {
                    parentForm.FiltroColores.Add(((int)Constantes.ColorPrenda.Negro));
            }
            
            if (checkGris.Checked)
            {
                    parentForm.FiltroColores.Add(((int)Constantes.ColorPrenda.Gris));
            }

                if (checkComplementario.Checked)
                {
                    int colorComplementario = 0;

                    switch (colorPrenda)
                    {
                        case Constantes.ColorPrenda.Naranja:
                            colorComplementario = ((int)Constantes.ColorPrenda.Azul);
                            break;
                        case Constantes.ColorPrenda.Amarillo:
                            colorComplementario = ((int)Constantes.ColorPrenda.Violeta);
                            break;
                        case Constantes.ColorPrenda.Verde_Claro:
                            colorComplementario = ((int)Constantes.ColorPrenda.Violeta_Claro);
                            break;
                        case Constantes.ColorPrenda.Verde:
                            colorComplementario = ((int)Constantes.ColorPrenda.Rojo);
                            break;
                        case Constantes.ColorPrenda.Cian:
                            colorComplementario = ((int)Constantes.ColorPrenda.Naranja);
                            break;
                        case Constantes.ColorPrenda.Rosita:
                            colorComplementario = ((int)Constantes.ColorPrenda.Verde_Claro);
                            break;
                        case Constantes.ColorPrenda.Rosa:
                            colorComplementario = ((int)Constantes.ColorPrenda.Verde);
                            break;
                        case Constantes.ColorPrenda.Violeta_Claro:
                            colorComplementario = ((int)Constantes.ColorPrenda.Amarillo);
                            break;
                        case Constantes.ColorPrenda.Violeta:
                            colorComplementario = ((int)Constantes.ColorPrenda.Amarillo);
                            break;
                        case Constantes.ColorPrenda.Azul:
                            colorComplementario = ((int)Constantes.ColorPrenda.Naranja);
                            break;
                        case Constantes.ColorPrenda.Celeste:
                            colorComplementario = ((int)Constantes.ColorPrenda.Naranja);
                            break;
                        case Constantes.ColorPrenda.Rojo:
                            colorComplementario = ((int)Constantes.ColorPrenda.Verde);
                            break;

                        default:
                            colorComplementario = 0;
                            break;
                    }
                    if (colorComplementario != 0)
                    {
                        parentForm.FiltroColores.Add(colorComplementario);
                    }
                }

                this.Hide();
                parentForm.InicializarImageLists();
                parentForm.deshabilitarBotonFiltro();
                parentForm.Show();
            }
        }
    }
}
