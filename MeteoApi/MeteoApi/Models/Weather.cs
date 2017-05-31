using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MeteoApi.Models
{
    public class Weather
    {
        public int IdTemperature { get; set; }

        public DateTime Date { get; set; }

        [Display(Name = "°C")]
        public double Temperature { get; set; }

        [Display(Name = "%")]
        public double Humidity { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        public int IdWeatherCity { get; set; }
    }
}