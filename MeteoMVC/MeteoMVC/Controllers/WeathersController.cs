using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DTO;

namespace MeteoMVC.Controllers
{
    public class WeathersController : Controller
    {
        // GET: Weathers
        public ActionResult Index()
        {
                Weather w = new Weather();
                w.IdTemperature =1;
                w.Date=new DateTime(2017,05,31);
                w.Temperature = 30.5;
                w.Humidity = 50.4;
                w.State = "sunny";
                w.IdWeatherCity=1;

          
                AccessWebAPI access = new AccessWebAPI();
                access.PostWeathers(w);
              
                return View(access.getWeathers());
        }
    }
}