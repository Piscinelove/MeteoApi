﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MeteoApi.Models
{
    public class Canton
    {
        public int IdCanton { get; set; }

        public string Name { get; set; }

        public int IdCantonCountry { get; set; }

    }
}