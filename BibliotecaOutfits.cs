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
    public partial class BibliotecaOutfits : Form
    {
        public BibliotecaOutfits()
        {
            InitializeComponent();
            InicializarOutfitsPanel();

        }

        private void BibliotecaOutfits_Load(object sender, EventArgs e)
        {

        }

        private void InicializarOutfitsPanel()
        {
            string sql = "SELECT outfit_id, imagen, favorito FROM outfit where user_id = @usuario";

            OleDbParameter[] parameters = new OleDbParameter[]
            {
               new OleDbParameter("@usuario", LogInfo.UserID),
            };

            DataTable dt = DB.GetDataTable(sql, parameters);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string base64Image = dt.Rows[i].Field<String>("imagen");
                int outfitId = dt.Rows[i].Field<Int32>("outfit_id");
                bool favorito = dt.Rows[i].Field<Boolean>("favorito");

                ElementoBiblioteca elemento = new ElementoBiblioteca(outfitId, true, favorito);
                elemento.ElementImage.Image = ImageUtils.Base64ToImage(base64Image);
                elemento.ButtonEliminar.Click += (sender, EventArgs) => { this.borrarOutfit(sender, EventArgs, elemento.IdElemento); };
                elemento.ButtonFavorito.Click += (sender, EventArgs) => { this.actualizarFavorito(sender, EventArgs, elemento.IdElemento); };
                outfitLayoutPanel.Controls.Add(elemento);
            }
        }

        private void actualizarFavorito(object sender, EventArgs e, int idOutfit)
        {
            ElementoBiblioteca control = (ElementoBiblioteca) ((PictureBox)sender).Parent;

            string sql = "UPDATE outfit SET favorito = @favorito WHERE outfit_id = @outfitId";
            OleDbParameter[] parameters = new OleDbParameter[]
           {
               new OleDbParameter("@favorito", !control.Favorito),
               new OleDbParameter("@outfitId", idOutfit),
           };
            DB.Update(sql, parameters);

            control.cambiarEstadoFavorito();
            control.Refresh();
        }

        private void borrarOutfit(object sender, EventArgs e, int idOutfit)
        {
            string sql = "DELETE FROM articulo_outfit WHERE outfit_id = @outfitId";
            OleDbParameter[] parameters = new OleDbParameter[]
           {
               new OleDbParameter("@outfitId", idOutfit),
           };
            DB.Delete(sql, parameters);


            sql = "DELETE FROM outfit WHERE outfit_id = @outfitId";
            parameters = new OleDbParameter[]
           {
               new OleDbParameter("@outfitId", idOutfit),
           };
            DB.Delete(sql, parameters);


            outfitLayoutPanel.Controls.Remove(((PictureBox)sender).Parent);
            outfitLayoutPanel.Refresh();
            MessageBox.Show("Se ha eliminado el outfit correctamente.");
        }

        private void  buttonBack_Click (object sender, EventArgs e)
        {
            this.Hide();
            var biblioteca = new Biblioteca();
            biblioteca.Show();
        }
    }
}
