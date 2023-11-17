using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Ropa___Intento_1
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Day
    {
        public string datetime { get; set; }
        public int datetimeEpoch { get; set; }
        public Double temp { get; set; }
        public Double feelslike { get; set; }
        public string conditions { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Pronostico
    {
        public int queryCost { get; set; }
        public Double latitude { get; set; }
        public Double longitude { get; set; }
        public string resolvedAddress { get; set; }
        public string address { get; set; }
        public string timezone { get; set; }
        public Double tzoffset { get; set; }
        public List<Day> days { get; set; }
        public Day currentConditions { get; set; }
    }
}
