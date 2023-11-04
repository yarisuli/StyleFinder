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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var signUp = new SignUp();
            signUp.Show();
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txbusuario.Text;
            string contra = txbcontraseña.Text;

            string sql = "SELECT user_id, usuario, contra FROM usuario WHERE usuario = @usuario AND contra = @contra";

            OleDbParameter[] parameters = new OleDbParameter[]
            {
                    new OleDbParameter("@usuario", usuario),
                    new OleDbParameter("@contra", contra),
            };

            DataTable dt = DB.GetDataTable(sql, parameters);

            if (dt.Rows.Count > 0)
            {
                LogInfo.UserID = dt.Rows[0].Field<Int32>("user_id");
                this.Hide();
                var form2 = new Home();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos");

            }

        }
    }
}

