﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Weather
    {

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public double TemperatureMin { get; set; }

        public double TemperatureMax { get; set; }

        public double Humidity { get; set; }

        public string State { get; set; }

        public int IdWeatherCity { get; set; }
    }
}