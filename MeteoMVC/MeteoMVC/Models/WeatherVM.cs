using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;

namespace MeteoMVC.Models
{
    public class WeatherVM
    {

        public Weather Weather { get; set; }
        public IEnumerable<City> Cities { get; set; }

        public IEnumerable<State> States { get; set; }

        public int CheckedCity { get; set; }

        public int CheckedState { get; set; }
    }
}