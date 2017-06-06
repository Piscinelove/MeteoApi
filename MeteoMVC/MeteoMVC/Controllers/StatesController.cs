using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO;
using BLL;

namespace MeteoMVC.Controllers
{
    public class StatesController : Controller
    {
        // GET: States
        public ActionResult Index()
        {
            AccessWebAPI access = new AccessWebAPI();
            return View(access.GetStates());
        }
    }
}