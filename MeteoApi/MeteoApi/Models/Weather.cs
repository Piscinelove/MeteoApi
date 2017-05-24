using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeteoApi.Models
{
    public class Weather
    {
        public int IdTemperature { get; set; }

        public DateTime Date { get; set; }

        public double Temperature { get; set; }

        public double Humidity { get; set; }

        public string String { get; set; }

        public int IdWeatherCity { get; set; }
    }
}