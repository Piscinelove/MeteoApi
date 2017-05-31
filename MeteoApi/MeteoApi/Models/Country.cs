﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MeteoApi.Models
{
    public class Country
    {
        public int IdCountry { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }
}