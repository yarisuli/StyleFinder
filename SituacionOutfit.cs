using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace App_Ropa___Intento_1
{
    public partial class SituacionOutfit : Form
    {
        private static readonly string weatherIconFolder = System.Configuration.ConfigurationSettings.AppSettings["WeatherIconFolder"];
        public SituacionOutfit()
        {
            InitializeComponent();
            this.buttonElegante.Click += (sender, EventArgs) => { this.buttonSituacion_Click(sender, EventArgs, Constantes.Situacion.Elegante); };
            this.buttonSalir.Click += (sender, EventArgs) => { this.buttonSituacion_Click(sender, EventArgs, Constantes.Situacion.Salir); };
            this.buttonCasual.Click += (sender, EventArgs) => { this.buttonSituacion_Click(sender, EventArgs, Constantes.Situacion.Casual); };
            this.buttonDeporte.Click += (sender, EventArgs) => { this.buttonSituacion_Click(sender, EventArgs, Constantes.Situacion.Deporte); };

            InicializarWidgetClima(this.weatherIcon);
        }

        private static void InicializarWidgetClima(PictureBox imagenCondition)
        {
            string sql = "SELECT nombre, capital, latitud, longitud FROM paises INNER JOIN usuario ON paises.nombre = usuario.pais WHERE user_id = @usuario";


            OleDbParameter[] parameters = new OleDbParameter[]
           {
               new OleDbParameter("@usuario", LogInfo.UserID),
           };

            DataTable dt = DB.GetDataTable(sql, parameters);

            string pais = dt.Rows[0].Field<String>("nombre");
            string capital = dt.Rows[0].Field<String>("capital");
            double latitud = dt.Rows[0].Field<Double>("latitud");
            double longitud = dt.Rows[0].Field<Double>("longitud");

            Pronostico pronostico = ClimaAPIConnector.getClima(DateTime.Now, latitud, longitud);

            // AILUCHIIII CREA LABELS Y LLENAR CON VARIABLES DE ARRIBA :D
            
            string imagenWeather = pronostico.days[0].icon + ".png";
            Image img = Image.FromFile(weatherIconFolder + imagenWeather);
            imagenCondition.Image =img;
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
 


