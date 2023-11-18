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
    public partial class CrearEvento : Form
    {
        public CrearEvento()
        {
            InitializeComponent();

            flowLayoutPanel.HorizontalScroll.Visible = true;
            flowLayoutPanel.VerticalScroll.Visible = false;
            flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel.AutoSize = false;
            flowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel.WrapContents = false;
            flowLayoutPanel.AutoScroll = true;

            string sql = "SELECT outfit_id, imagen FROM outfit WHERE user_id = @usuario";

            OleDbParameter[] parameters = new OleDbParameter[]
            {
              new OleDbParameter("@usuario", LogInfo.UserID),
            };

            DataTable dt = DB.GetDataTable(sql, parameters);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string base64Image = dt.Rows[i].Field<String>("imagen");
                int outfitId = dt.Rows[i].Field<Int32>("outfit_id");

                ElementoBiblioteca elemento = new ElementoBiblioteca(outfitId);
                elemento.ElementImage.Image = ImageUtils.Base64ToImage(base64Image);
                flowLayoutPanel.Controls.Add(elemento);

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            ElementoBiblioteca elementoSeleccionado = flowLayoutPanel.Controls.Cast<ElementoBiblioteca>().FirstOrDefault(el => el.EstaSeleccionado);
            int selectedOutFit = elementoSeleccionado.IdElemento;
            if (elementoSeleccionado != null)
            {

                MessageBox.Show("Se selecciono el Outfit : " + selectedOutFit);

                //  string evento = txtBoxEvento.Text;
                //  string fecha = SeleccionFecha.Text;

                //  string sql = "INSERT INTO evento (fecha, descripcion, outfit_id, user_id) VALUES (@fecha, @descripcion, @outfitId, @userId)";

                //  OleDbParameter[] parameters = new OleDbParameter[]
                // {
                //new OleDbParameter("@fecha", fecha),
                //new OleDbParameter("@descripcion", evento),
                //new OleDbParameter("@outfitId", selectedOutFit),
                //new OleDbParameter("@userId", LogInfo.UserID),
                //};

                //  DB.Insert(sql, parameters);

                //  this.Hide();
                //  var calendario = new Calendario();
                //  calendario.Show();
            } else
            {
                MessageBox.Show("Debe seleccionar un Outfit.");
            }


           
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var calendario = new Calendario();
            calendario.Show();
        }

        private void txtBoxEvento_TextChanged(object sender, EventArgs e)
        {
            string evento = txtBoxEvento.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string fecha = SeleccionFecha.Text;
        }
    }
}
