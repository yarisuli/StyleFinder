﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Data.OleDb;

namespace App_Ropa___Intento_1
{
    public partial class SituacionOutfit : Form
    {

        public SituacionOutfit()
        {
            InitializeComponent();
            this.buttonElegante.Click += (sender, EventArgs) => { this.buttonSituacion_Click(sender, EventArgs, Constantes.Situacion.Elegante); };
            this.buttonSalir.Click += (sender, EventArgs) => { this.buttonSituacion_Click(sender, EventArgs, Constantes.Situacion.Salir); };
            this.buttonCasual.Click += (sender, EventArgs) => { this.buttonSituacion_Click(sender, EventArgs, Constantes.Situacion.Casual); };
            this.buttonDeporte.Click += (sender, EventArgs) => { this.buttonSituacion_Click(sender, EventArgs, Constantes.Situacion.Deporte); };


            //  string sql = "SELECT pais FROM usuario WHERE user_id = @usuario";
            //  OleDbParameter[] parameters = new OleDbParameter[]
            // {
            // new OleDbParameter("@usuario", LogInfo.UserID),};

            // DataTable dt = DB.GetDataTable(sql, parameters);

            // string dtString = Convert.ToString(dt);
            //  MessageBox.Show(dtString);


        }


        private void buttonSituacion_Click(object sender, EventArgs eventArgs, Constantes.Situacion situacion)
        {
            this.Hide();
            var definirOutfit = new DefinirOutfit(situacion);
            definirOutfit.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home = new Home();
            home.Show();
        }



    }
}
 


