﻿using System;
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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonGrabar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contra = txtContra.Text;
            string pais = comboBoxPais.Text;
            string colorForm = comboBoxColor.Text;

            string sql = "INSERT INTO usuario (usuario, contra, pais, color) VALUES (@usuario, @contra, @pais, @colorForm)";

            OleDbParameter[] parameters = new OleDbParameter[]
            {
                    new OleDbParameter("@usuario", usuario),
                    new OleDbParameter("@contra", contra),
                    new OleDbParameter("@pais", pais),
                    new OleDbParameter("@color", colorForm)
            };

            DB.Insert(sql, parameters);

            this.Hide();
            var logIn = new LogIn();
            logIn.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var logIn = new LogIn();
            logIn.Show();
        }
    }
}
