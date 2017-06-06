using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO;
using BLL;


namespace MeteoMVC.Controllers
{
    public class CountriesController : Controller
    {
        // GET: Countries
        public ActionResult Index()
        {
            Country c = new Country();
            c.Id = 1;
            c.Name = "Switzerland";


            AccessWebAPI access = new AccessWebAPI();
            access.PostCountries(c);

            return View(access.getCountries());
        }
    }
}