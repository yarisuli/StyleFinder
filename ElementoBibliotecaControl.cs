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
    public partial class ElementoBiblioteca : UserControl
    {
        private bool favorito = false;
        private Int32 idElemento;
        private bool estaSeleccionado = false;

        public ElementoBiblioteca(int p_idElemento, bool favoritoHabilitado, bool esFavorito)
        {
            InitializeComponent();

            idElemento = p_idElemento;
            buttonSeleccionar.Hide();

            if(!favoritoHabilitado)
            {
                buttonFavorito.Hide();
               
            } else {
                favorito = esFavorito;
                buttonFavorito.Image = favorito ? Properties.Resources.Icono_Favorito_Seleccionado : Properties.Resources.Icono_Favorito;
            }            
        }

        public ElementoBiblioteca(int p_idElemento)
        {
            InitializeComponent();

            idElemento = p_idElemento;

            buttonFavorito.Hide();
            buttonEliminar.Hide();
            buttonSeleccionar.Show();
          
        }

        public int IdElemento { get => idElemento; set => idElemento = value; }
        public bool Favorito { get => favorito; set => favorito = value; }
        public bool EstaSeleccionado { get => estaSeleccionado; set => estaSeleccionado = value; }

        public void cambiarEstadoFavorito()
        {
            favorito = !favorito;
            buttonFavorito.Image = favorito ? Properties.Resources.Icono_Favorito_Seleccionado : Properties.Resources.Icono_Favorito;
        }

        private void elementImage_Click_1(object sender, EventArgs e)
        {

            using (Form popUpForm = new Form() ) {
                popUpForm.Text = "Visualizar";
                popUpForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                popUpForm.MaximizeBox = false;
                popUpForm.MinimizeBox = false;
            
                Image img = ((PictureBox)sender).Image;
                popUpForm.StartPosition = FormStartPosition.CenterParent;
                popUpForm.ClientSize = img.Size;

                PictureBox pb = new PictureBox();
                pb.Dock = DockStyle.Fill;
                pb.Image = img;
                popUpForm.Controls.Add(pb);

                popUpForm.ShowDialog();
            }
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            this.estaSeleccionado = true;
            this.buttonSeleccionar.Text = "Seleccionado";
            this.buttonSeleccionar.BackColor = Color.Aquamarine;

            foreach (ElementoBiblioteca element in this.Parent.Controls)
            {
                if (element.IdElemento != this.idElemento)
                {
                    element.EstaSeleccionado = false;
                    element.buttonSeleccionar.Text = "Seleccionar";
                    element.buttonSeleccionar.BackColor = Color.DarkGray;
                }
            }            
        }
    }
}
