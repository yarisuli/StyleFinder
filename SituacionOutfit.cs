using System;
using System.Windows.Forms;

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

            //var client = new RestClient("http://api.weatherapi.com/v1");
            //var request = new RestRequest();
            //  request.AddHeader("key", "e8cccdccdeeb41dcb99114709230811");
            //  request.AddHeader("q","PAIS DEL USUARIO CON LATITUD ETC") ;


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
 


