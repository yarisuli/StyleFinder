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
            string evento, fecha;
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

            //string evento = txtBoxEvento.Text;
            // string fecha = SeleccionFecha.Text;

            //string sql = "SELECT outfit_id, image FROM outfit WHERE user_id = @usuario";

            // OleDbParameter[] parameters = new OleDbParameter[]
            // {
            //  new OleDbParameter("@usuario", LogInfo.UserID),
            //  };

            //  DataTable dt = DB.GetDataTable(sql, parameters);

            //  for (int i = 0; i < dt.Rows.Count; i++)
            // {
            //  string base64Image = dt.Rows[i].Field<String>("imagen");
            //  int outfitId = dt.Rows[i].Field<Int32>("outfit_id");
            //   bool favorito = dt.Rows[i].Field<Boolean>("favorito");

            //   ElementoBiblioteca elemento = new ElementoBiblioteca(outfitId, true, favorito);
            //   elemento.ElementImage.Image = ImageUtils.Base64ToImage(base64Image);
            //   flowLayoutPanel.Controls.Add(elemento);
            // }


            //  sql = "INSERT INTO evento (fecha, descripcion, outfit_id, user_id) VALUES (@fecha, @descripcion, @outfitId, @userId)";

            //  parameters = new OleDbParameter[]
            //  {
            //   new OleDbParameter("@fecha", fecha),
            //    new OleDbParameter("@descripcion", evento),
            // new OleDbParameter("@outfitId", )
            //   new OleDbParameter("@userId", LogInfo.UserID),
            // };

            //  DB.Insert(sql, parameters);

            this.Hide();
            var calendario = new Calendario();
            calendario.Show();
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
