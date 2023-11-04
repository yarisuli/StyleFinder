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
    public partial class DefinirOutfit : Form
    {
        private int indice;
        private int situacion_id;
        public DefinirOutfit(Constantes.Situacion p_situacion)
        {
            InitializeComponent();
            indice = 0;
            situacion_id = ((int)p_situacion);
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            indice++;

            if (indice > 3)
                indice = 0;
            label1.ImageIndex = indice;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            indice++;

            if (indice > 3)
                indice = 0;
            label2.ImageIndex = indice;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            indice++;

            if (indice > 3)
                indice = 0;
            label3.ImageIndex = indice;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Home();
            form2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private static int CrearOutfit(int situacion_id)
        {

            string sql = "INSERT INTO outfit (user_id, situacion_id) VALUES (@user_id, @situacion_id)";
            OleDbParameter[] parameters = new OleDbParameter[]
            {
                new OleDbParameter("@user_id", LogInfo.UserID),
                new OleDbParameter("@situacion_id", situacion_id)
            };
            int outfit_id = DB.Insert(sql, parameters);
            return outfit_id;
        }
        private void Favoritos_Click(object sender, EventArgs e)
        {
            int outfit_id = CrearOutfit(situacion_id);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            indice++;

            if (indice > 3)
                indice = 0;
            label1.ImageIndex = indice;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            indice++;

            if (indice > 3)
                indice = 0;
            label2.ImageIndex = indice;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            indice++;

            if (indice > 3)
                indice = 0;
            label3.ImageIndex = indice;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            indice++;

            if (indice > 3)
                indice = 0;
            label5.ImageIndex = indice;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            indice++;

            if (indice > 3)
                indice = 0;
            label4.ImageIndex = indice;
        }
    }
}
