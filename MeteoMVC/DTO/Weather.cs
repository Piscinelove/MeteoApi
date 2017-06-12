using System;
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

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Required]
        public double TemperatureMin { get; set; }

        [Required]
        public double TemperatureMax { get; set; }

        [Required]
        public double Humidity { get; set; }

        [Required]
        public double Precipitation { get; set; }

        [Required]
        public City City { get; set; }

        [Required]
        public State State { get; set; }
    }
}
