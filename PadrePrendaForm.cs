using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Ropa___Intento_1
{
    public partial class PadrePrendaForm : Form
    {

        private Constantes.TipoPrenda tipoPrenda;
        private string base64Image;
        private Constantes.ColorPrenda colorPrenda;
        private Constantes.VariantePrenda variantePrenda;
        protected Dictionary<Constantes.VariantePrenda, int> variantesPrendaSeleccionadas = new Dictionary<Constantes.VariantePrenda, int>();

        public PadrePrendaForm()
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
            this.buttonNegro.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Negro); };
            this.buttonBlanco.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Blanco); };
            this.buttonGris.Click += (sender, EventArgs) => { this.buttonColor_Click(sender, EventArgs, Constantes.ColorPrenda.Gris); };
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
            string mensajeError = "";
            
            if (string.IsNullOrWhiteSpace(base64Image)){
                mensajeError += "Imagen ";
            }
            if(colorPrenda == Constantes.ColorPrenda.Ninguno)
            {
                mensajeError += "Color ";
            }
            if (variantesPrendaSeleccionadas.Count()==0)
            {
                mensajeError += "Opciones";
            }

            if(mensajeError != "")            {
                MessageBox.Show("Debe seleccionar : " + mensajeError);
            } else
            {
                string sql = "INSERT INTO articulo (imagen, color, tipo_id, user_id) VALUES (@imagen, @color, @tipoId, @userId)";

                OleDbParameter[] parameters = new OleDbParameter[]
                {
                        new OleDbParameter("@imagen", base64Image),
                        new OleDbParameter("@color", colorPrenda.ToString()),
                        new OleDbParameter("@tipoId", ((int)tipoPrenda)),
                        new OleDbParameter("@userId", LogInfo.UserID),
                };

                int idArticulo = DB.Insert(sql, parameters);

               sql = "INSERT INTO articulo_variante (variante_id, articulo_id) VALUES (@varianteId, @articuloId)";
           
                foreach (int idVariante in variantesPrendaSeleccionadas.Values)
                {
                    parameters = new OleDbParameter[]
                    {
                        new OleDbParameter("@varianteId", idVariante),
                        new OleDbParameter("@articuloId", idArticulo),
                     };

                   DB.Insert(sql, parameters);

                }

                MessageBox.Show("Se ha guardado su prenda correctamente.");
            
                this.Hide();
                var form2 = new Home();
                form2.Show();

            }
            

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tipoPrenda = new TipoPrenda();
            tipoPrenda.Show();
        }

        private void buttonSubirPrenda_Click(object sender, EventArgs e)
        {
            base64Image = ImageUtils.SelectImageBase64();
            ImageUtils.ShowBase64ImageInPictureBox(base64Image, pictureBox26);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }


    }
}
