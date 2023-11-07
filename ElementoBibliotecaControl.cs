﻿using System;
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

        public ElementoBiblioteca(int p_idElemento, bool favoritoHabilitado, bool esFavorito)
        {
            InitializeComponent();

            idElemento = p_idElemento;

            if(!favoritoHabilitado)
            {
                buttonFavorito.Hide();
            } else {
                favorito = esFavorito;
                buttonFavorito.Image = favorito ? Properties.Resources.Icono_Favorito_Seleccionado : Properties.Resources.Icono_Favorito;
            }            
        }

        public int IdElemento { get => idElemento; set => idElemento = value; }

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
    }
}
