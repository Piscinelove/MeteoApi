//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeteoApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Weather
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public double TemperatureMin { get; set; }
        public double TemperatureMax { get; set; }
        public double Humidity { get; set; }
        public double Precipitation { get; set; }
   

        public virtual City City { get; set; }
        public virtual State State { get; set; }
    }
}
