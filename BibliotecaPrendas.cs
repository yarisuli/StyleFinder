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
            String sql = "SELECT articulo_id, imagen, favorito FROM articulo INNER JOIN tipo_articulo ON articulo.tipo_id = tipo_articulo.tipo_id " +
                            "WHERE user_id = @usuario";

            OleDbParameter[] parameters = new OleDbParameter[]
            {
               new OleDbParameter("@usuario", LogInfo.UserID),
            };

            DataTable dt = DB.GetDataTable(sql, parameters);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string base64Image = dt.Rows[i].Field<String>("imagen");
                int prendaId = dt.Rows[i].Field<Int32>("articulo_id");
                bool favorito = dt.Rows[i].Field<Boolean>("favorito");

                ElementoBiblioteca elemento = new ElementoBiblioteca(prendaId, true, favorito);
                elemento.ElementImage.Image = ImageUtils.Base64ToImage(base64Image);
                elemento.ButtonEliminar.Click += (sender, EventArgs) => { this.borrarPrenda(sender, EventArgs, elemento.IdElemento); };
                elemento.ButtonFavorito.Click += (sender, EventArgs) => { this.actualizarFavorito(sender, EventArgs, elemento.IdElemento); };
                prendasLayoutPanel.Controls.Add(elemento);
            }
        }

        private void actualizarFavorito(object sender, EventArgs e, int idPrenda)
        {
            ElementoBiblioteca control = (ElementoBiblioteca)((PictureBox)sender).Parent;

            string sql = "UPDATE articulo SET favorito = @favorito WHERE articulo_id = @articuloId";
            OleDbParameter[] parameters = new OleDbParameter[]
           {
               new OleDbParameter("@favorito", !control.Favorito),
               new OleDbParameter("@prendaId", idPrenda),
           };
            DB.Update(sql, parameters);


            control.cambiarEstadoFavorito();
            control.Refresh();
        }

        private void borrarPrenda(object sender, EventArgs e, int idPrenda)
        {

            string sql = "DELETE FROM articulo_variante WHERE articulo_id = @articuloId";
            OleDbParameter[] parameters = new OleDbParameter[]
           {
               new OleDbParameter("@articuloId", idPrenda),
           };
            DB.Delete(sql, parameters);

            sql = "DELETE FROM articulo WHERE articulo_id = @articuloId";
            parameters = new OleDbParameter[]
           {
               new OleDbParameter("@articuloId", idPrenda),
           };
            DB.Delete(sql, parameters);



            prendasLayoutPanel.Controls.Remove(((PictureBox)sender).Parent);
            prendasLayoutPanel.Refresh();
            MessageBox.Show("Se ha eliminado la prenda correctamente.");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var biblioteca = new Biblioteca();
            biblioteca.Show();
        }

        private void prendasLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
