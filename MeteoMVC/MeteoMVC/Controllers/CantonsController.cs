﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO;
using BLL;

namespace MeteoMVC.Controllers
{
    public class CantonsController : Controller
    {
        // GET: Cantons
        public ActionResult Index()
        {
            /*
            Canton c = new Canton();
            c.Id = 1;
            c.Name = "Wallis";
            c.CountryId = 1;


            AccessWebAPI access = new AccessWebAPI();
            access.PostCantons(c);
            */
            AccessWebAPI access = new AccessWebAPI();
            return View(access.GetCantons());
        }
    }
}