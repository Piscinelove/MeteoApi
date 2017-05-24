using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeteoApi.Models
{
    public class City
    {
        public int IdCity { get; set; }

        public string Name { get; set; }

        public int IdCityCanton { get; set; }
    }
}