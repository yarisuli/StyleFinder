using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Ropa___Intento_1
{
    public partial class DefinirOutfit : Form
    {
        private int situacion_id;
        private List<int> filtroColores = new List<int>();

        public List<int> FiltroColores { get => filtroColores; set => filtroColores = value; }

        public DefinirOutfit(Constantes.Situacion p_situacion)
        {
            InitializeComponent();
            situacion_id = ((int)p_situacion);
            
            InitializeSiguienteButtons();
            InicializarImageLists();
        }

        private void InitializeSiguienteButtons()
        {
            this.buttonSiguienteArriba.Click += (sender, EventArgs) => { this.buttonSiguientePrenda_Click(sender, EventArgs, labelArriba); };
            this.buttonSiguienteAbajo.Click += (sender, EventArgs) => { this.buttonSiguientePrenda_Click(sender, EventArgs, labelAbajo); };
            this.buttonSiguienteCalzado.Click += (sender, EventArgs) => { this.buttonSiguientePrenda_Click(sender, EventArgs, labelCalzado); };
            this.buttonSiguienteAccesorio.Click += (sender, EventArgs) => { this.buttonSiguientePrenda_Click(sender, EventArgs, labelAccesorio); };
            this.buttonSiguienteOtroAccesorio.Click += (sender, EventArgs) => { this.buttonSiguientePrenda_Click(sender, EventArgs, labelOtrosAccesorio); };
        }

        public void InicializarImageLists()
        {
            InicializarImageList(arribaImageList, labelArriba, Constantes.Parte.Arriba);
            InicializarImageList(abajoImageList, labelAbajo, Constantes.Parte.Abajo);
            InicializarImageList(calzadoImageList, labelCalzado, Constantes.Parte.Calzado);
            InicializarImageList(accesoriosImageList, labelAccesorio, Constantes.Parte.Accesorios);
            InicializarImageList(otrosAccesoriosImageList, labelOtrosAccesorio, Constantes.Parte.Accesorios);
        }

        private void InicializarImageList(ImageList imageList, Label p_label, Constantes.Parte parte)
        {

            imageList.Images.Clear();
            p_label.ImageKey = "";

            String sql = "SELECT articulo_id, imagen FROM articulo INNER JOIN tipo_articulo ON articulo.tipo_id = tipo_articulo.tipo_id " +
                            "WHERE tipo_articulo.parte_id = @parteId and user_id = @usuario ";

            if (filtroColores.Count != 0)
            {
                string inStr = " AND articulo.color in (";
                foreach (int color in filtroColores)
                {
                    inStr += Convert.ToString(color) + ",";
                }
                inStr = inStr.Substring(0, inStr.Length - 1) + ")";

                sql += inStr;
            } 

            OleDbParameter[] parameters = new OleDbParameter[]
            {
                    new OleDbParameter("@parteId", (int)parte),
                    new OleDbParameter("@usuario", LogInfo.UserID),
            };

            DataTable dt = DB.GetDataTable(sql, parameters);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string base64Image = dt.Rows[i].Field<String>("imagen");
                int prendaId = dt.Rows[i].Field<Int32>("articulo_id");

                imageList.Images.Add(prendaId.ToString(), ImageUtils.Base64ToImage(base64Image));
            }


        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Home();
            form2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSiguientePrenda_Click(object sender, EventArgs e, Label p_Label)
        {
            string imageKey = p_Label.ImageKey;
            //con el key busca el indice de la imagen 
            int indice = p_Label.ImageList.Images.IndexOfKey(imageKey);
            indice++;
            //if verifica si la anterior es la ultima imagen, vuelve a estar deseleccionado.
            
            if (indice == p_Label.ImageList.Images.Count)
            {
                p_Label.ImageKey = "";
            } else
            {
                p_Label.ImageKey = p_Label.ImageList.Images.Keys[indice];
            }
         }


        private void buttonGrabar_Click(object sender, EventArgs e)
        {

            string error = ValidarOutfit();
            if (!error.Equals(string.Empty))
            {
                MessageBox.Show(error);

            }
            else
            { 

                List<Int32> listaPrendasOutfit = new List<Int32>();

                if (!labelArriba.ImageKey.Equals(""))
                    listaPrendasOutfit.Add(Convert.ToInt32(labelArriba.ImageKey));
                if (!labelAbajo.ImageKey.Equals(""))
                    listaPrendasOutfit.Add(Convert.ToInt32(labelAbajo.ImageKey));
                if (!labelCalzado.ImageKey.Equals(""))
                    listaPrendasOutfit.Add(Convert.ToInt32(labelCalzado.ImageKey));
                if (!labelAccesorio.ImageKey.Equals(""))
                    listaPrendasOutfit.Add(Convert.ToInt32(labelAccesorio.ImageKey));
                if (!labelOtrosAccesorio.ImageKey.Equals(""))
                    listaPrendasOutfit.Add(Convert.ToInt32(labelOtrosAccesorio.ImageKey));

                string imagenOutfitBase64 = CrearImagenBase64Outfit(); 

                CrearOutfit(situacion_id, imagenOutfitBase64, listaPrendasOutfit);
                               
                MessageBox.Show("El outfit se ha guardado correctamente.");

                this.Hide();
                var form2 = new Home();
                form2.Show();
            }

        }

        private string ValidarOutfit()
        {
            string error = string.Empty;

            if (labelArriba.ImageKey.Equals("") && labelAbajo.ImageKey.Equals("")
                    && labelCalzado.ImageKey.Equals("")
                        && labelAccesorio.ImageKey.Equals("")
                            && labelOtrosAccesorio.ImageKey.Equals(""))
            {
                error = "No ha seleccionado ninguna prenda para el outfit.";
            }
            else
            {
                if (labelAccesorio.ImageKey.Equals(labelOtrosAccesorio.ImageKey))
                {
                    error = "No se puede elegir dos veces el mismo accesario";
                }
            }

            return error;


        }

        private int CrearOutfit(int situacion_id, string imageOutfit, List<Int32> listaPrendasOutfit)
        {

            string sql = "INSERT INTO outfit (user_id, situacion_id, imagen, favorito) VALUES (@user_id, @situacion_id, @imagen, @favorito)";
            OleDbParameter[] parameters = new OleDbParameter[]
            {
                new OleDbParameter("@user_id", LogInfo.UserID),
                new OleDbParameter("@situacion_id", situacion_id),
                new OleDbParameter("@imagen", imageOutfit),
                new OleDbParameter("@favorito", false)
            };
            int outfit_id = DB.Insert(sql, parameters);

            
           sql = "INSERT INTO articulo_outfit (outfit_id, articulo_id) VALUES (@outfitId, @articuloId)";

            //recorre listaPrendasOutfit, por cada elemento lo inserta en articulo_outfit
            foreach (int articulo_id in listaPrendasOutfit)
            {
                parameters = new OleDbParameter[]
                {
                        new OleDbParameter("@outfitId", outfit_id),
                        new OleDbParameter("@articuloId", articulo_id),
                 };

                DB.Insert(sql, parameters);

            }
            return outfit_id;
        }
        
        //crea el screenshot del outfit (me lo copie de google :D)
        private String CrearImagenBase64Outfit()
        {
            Bitmap formCompleto = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(formCompleto, new Rectangle(0, 0, this.Width, this.Height));
            //Bitmap recorteOutfit = formCompleto.Clone(new Rectangle(220, 30, 327, 449), System.Drawing.Imaging.PixelFormat.DontCare);
            Bitmap recorteOutfit = formCompleto.Clone(new Rectangle(491, 34, 400, 650), System.Drawing.Imaging.PixelFormat.DontCare);
            ImageConverter converter = new ImageConverter();
            var bytes = (byte[])converter.ConvertTo(recorteOutfit, typeof(byte[]));
            return Convert.ToBase64String(bytes);
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("En caso de continuar se eliminaran todas sus selecciones.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                filtroColores.Clear();
                using (Form popUpForm = new FiltroColorOutfit(this))
                {
                    popUpForm.Text = "Filtro Color";
                    popUpForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                    popUpForm.MaximizeBox = false;
                    popUpForm.MinimizeBox = false;

                    popUpForm.StartPosition = FormStartPosition.CenterParent;

                    popUpForm.ShowDialog();
                }
            }
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            seleccionarPrendaRandom(labelArriba, arribaImageList);
            seleccionarPrendaRandom(labelAbajo, abajoImageList);
            seleccionarPrendaRandom(labelCalzado, calzadoImageList);
            seleccionarPrendaRandom(labelAccesorio, accesoriosImageList);
            seleccionarPrendaRandom(labelOtrosAccesorio, otrosAccesoriosImageList);
        }

        private void seleccionarPrendaRandom(Label p_Label, ImageList imageList)
        {
            if (imageList.Images.Count > 0)
            {
                Random rnd = new Random(DateTime.Now.Millisecond);
                int indice = rnd.Next(0, imageList.Images.Count - 1);
                p_Label.ImageKey = p_Label.ImageList.Images.Keys[indice];
            } else
            {
                p_Label.ImageKey = "";
            }

        }

        private void buttonQuitarFiltro_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("En caso de continuar se eliminaran todas sus selecciones.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                filtroColores.Clear();
                InicializarImageLists();
                buttonQuitarFiltro.Hide();
                buttonFiltrar.Show();
            }
        }

        public void deshabilitarBotonFiltro()
        {
            buttonFiltrar.Hide() ;
            buttonQuitarFiltro.Show();
        }

        private void buttonSiguienteArriba_Click(object sender, EventArgs e)
        {

        }

        private void buttonSiguienteAbajo_Click(object sender, EventArgs e)
        {

        }

        private void buttonSiguienteCalzado_Click(object sender, EventArgs e)
        {

        }

        private void buttonSiguienteOtroAccesorio_Click(object sender, EventArgs e)
        {

        }

        private void buttonSiguienteAccesorio_Click(object sender, EventArgs e)
        {

        }

        private void labelCalzado_Click(object sender, EventArgs e)
        {

        }

        private void labelAbajo_Click(object sender, EventArgs e)
        {

        }

        private void labelArriba_Click(object sender, EventArgs e)
        {

        }
    }
}
