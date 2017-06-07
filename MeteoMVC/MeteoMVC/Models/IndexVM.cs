using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;

namespace MeteoMVC.Models
{
    public class IndexVM
    {
        public IEnumerable<Weather> Weathers { get; set; }
        public IEnumerable<City> Cities { get; set; }
        public IEnumerable<Canton> Cantons { get; set; }

        public string SearchedText { get; set; }
    }
}