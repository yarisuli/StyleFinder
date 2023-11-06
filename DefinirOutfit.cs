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

        private void InicializarImageLists()
        {
            InicializarImageList(arribaImageList, Constantes.Parte.Arriba);
            InicializarImageList(abajoImageList, Constantes.Parte.Abajo);
            InicializarImageList(calzadoImageList, Constantes.Parte.Calzado);
            InicializarImageList(accesoriosImageList, Constantes.Parte.Accesorios);
            InicializarImageList(otrosAccesoriosImageList, Constantes.Parte.Accesorios);
        }

        private void InicializarImageList(ImageList imageList, Constantes.Parte parte)
        {
            String sql = "Select articulo_id, imagen from articulo inner join tipo_articulo on articulo.tipo_id = tipo_articulo.tipo_id " +
                            "where tipo_articulo.parte_id = @parteId and user_id = @usuario";

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
            int indice = p_Label.ImageList.Images.IndexOfKey(imageKey);
            indice++;
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

            //Convert.ToInt32(labelOtrosAccesorio.ImageKey) ;
            //Convert.ToInt32(labelArriba.ImageKey;
            //Convert.ToInt32(labelAbajo.ImageKey;
            //Convert.ToInt32(labelCalzado.ImageKey;
            //Convert.ToInt32(labelAccesorio.ImageKey;

            int outfit_id = CrearOutfit(situacion_id, CrearImagenBase64Outfit());
        }

        private int CrearOutfit(int situacion_id, string imageOutfit)
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

            //Solo falta grabar los articulos outfit

            return outfit_id;
        }

        private String CrearImagenBase64Outfit()
        {
            Bitmap formCompleto = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(formCompleto, new Rectangle(0, 0, this.Width, this.Height));
            Bitmap recorteOutfit = formCompleto.Clone(new Rectangle(220, 30, 327, 449), System.Drawing.Imaging.PixelFormat.DontCare);
            ImageConverter converter = new ImageConverter();
            var bytes = (byte[])converter.ConvertTo(recorteOutfit, typeof(byte[]));
            return Convert.ToBase64String(bytes);
        }
    }
}
