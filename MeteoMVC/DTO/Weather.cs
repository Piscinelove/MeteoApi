﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Weather
    {

        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public double TemperatureMin { get; set; }

        public double TemperatureMax { get; set; }

        public double Humidity { get; set; }

        public double Precipitation { get; set; }

        public City City { get; set; }

        public State State { get; set; }
    }
}
