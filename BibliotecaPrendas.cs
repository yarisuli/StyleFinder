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
    public partial class BibliotecaPrendas : Form
    {
        public BibliotecaPrendas()
        {
            InitializeComponent();
            InicializarPrendasPanel();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void InicializarPrendasPanel()
        {
            String sql = "Select articulo_id, imagen from articulo inner join tipo_articulo on articulo.tipo_id = tipo_articulo.tipo_id " +
                            "where user_id = @usuario";

            OleDbParameter[] parameters = new OleDbParameter[]
            {
               new OleDbParameter("@usuario", LogInfo.UserID),
            };

            DataTable dt = DB.GetDataTable(sql, parameters);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string base64Image = dt.Rows[i].Field<String>("imagen");
                int prendaId = dt.Rows[i].Field<Int32>("articulo_id");

                ElementoBiblioteca elemento = new ElementoBiblioteca(prendaId, false, false);
                elemento.ElementImage.Image = ImageUtils.Base64ToImage(base64Image);
                elemento.ButtonEliminar.Click += (sender, EventArgs) => { this.borrarPrenda(sender, EventArgs, elemento.IdElemento); };
                prendasLayoutPanel.Controls.Add(elemento);
            }
        }

        private void borrarPrenda(object sender, EventArgs e, int idPrenda)
        {
            MessageBox.Show("Se ha eliminado la prenda correctamente.");

            prendasLayoutPanel.Controls.Remove(((PictureBox)sender).Parent);
            prendasLayoutPanel.Refresh();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var biblioteca = new Biblioteca();
            biblioteca.Show();
        }

    }
}
