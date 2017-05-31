using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO;
using BLL;


namespace MeteoMVC.Controllers
{
    public class CitiesController : Controller
    {
        // GET: Cities
        public ActionResult Index()
        {
            City c = new City();
            c.IdCity = 1;
            c.Name = "Sierre";
            c.IdCityCanton = 1;


            AccessWebAPI access = new AccessWebAPI();
            access.PostCities(c);

            return View(access.getCities());
        }
    }
}