using RestSharp;
using System;

namespace App_Ropa___Intento_1
{
    public class ClimaAPIConnector
    {
        private static readonly string apiKey = System.Configuration.ConfigurationSettings.AppSettings["WeatherApi"];
        public static Pronostico getClima(DateTime diaHora, double latitud, double longitud)
        {
            // URL del servicio REST
            string baseApiUrl = "https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services";
            string metodo = "/timeline/${ubicacion}/${diaHora}?unitGroup=metric&key=${apiKey}&contentType=json&lang=es&include=current&nonulls";

            //string diaHoraStr = diaHora.ToString("yyyy-MM-ddTHH:mm:ss");
            string diaHoraStr = diaHora.ToString("yyyy-MM-dd");
            string ubicacionStr = latitud.ToString("0.#####").Replace(",", ".") + ", " + longitud.ToString("0.#####").Replace(",", ".");
            
            metodo = metodo.Replace("${ubicacion}", ubicacionStr).Replace("${diaHora}", diaHoraStr).Replace("${apiKey}", apiKey);

            var options = new RestClientOptions(baseApiUrl)
            {
                ThrowOnAnyError = true
            };
            var restClient = new RestClient(options);
            var request = new RestRequest(metodo);

            RestResponse<Pronostico> response = restClient.ExecuteGet<Pronostico>(request);
             
            if (!response.IsSuccessful)
            {
                Console.WriteLine("Error" + response.StatusDescription);
            }

            return response.Data;

        }
    }
}

