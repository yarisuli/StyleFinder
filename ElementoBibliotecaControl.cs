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
    }
}