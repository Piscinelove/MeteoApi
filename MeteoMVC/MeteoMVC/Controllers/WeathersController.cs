using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DTO;
using MeteoMVC.Models;

namespace MeteoMVC.Controllers
{
    public class WeathersController : Controller
    {
        // GET: Weathers
        public ActionResult Index()
        {
            /*
                Weather w = new Weather();
                w.Id =1;
                w.Date=new DateTime(2017,05,31);
                w.TemperatureMin = 30.5;
                w.Humidity = 50.4;
                w.State = "sunny";
                w.IdWeatherCity=1;

          

                access.PostWeathers(w);
            */
            AccessWebAPI access = new AccessWebAPI();
            return View(access.GetWeathers());
        }

        public ActionResult Create()
        {
            AccessWebAPI access = new AccessWebAPI();
            CreateWeatherVM vm = new CreateWeatherVM();
            vm.Cities = access.GetCities();
            vm.States = access.GetStates();

            return View(vm);
        }

        [HttpPost]
        public ActionResult Create(CreateWeatherVM vm)
        {
            AccessWebAPI access = new AccessWebAPI();
            Weather newWeather = new Weather();
            newWeather.Date = vm.Weather.Date;
            newWeather.TemperatureMin = vm.Weather.TemperatureMin;
            newWeather.TemperatureMax = vm.Weather.TemperatureMax;
            newWeather.Humidity = vm.Weather.Humidity;
            newWeather.Precipitation = vm.Weather.Precipitation;
            newWeather.City = access.GetCity(vm.CheckedCity);
            newWeather.State = access.GetState(vm.CheckedState);
            access.PostWeathers(newWeather);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            AccessWebAPI access = new AccessWebAPI();
            return View(access.GetWeather(id));
        }

        public ActionResult Details(int id)
        {
            AccessWebAPI access = new AccessWebAPI();
            return View(access.GetWeather(id));
        }

        public ActionResult Delete(int id)
        {
            AccessWebAPI access = new AccessWebAPI();
            return View(access.DeleteWeathers(id));
        }


    }
}