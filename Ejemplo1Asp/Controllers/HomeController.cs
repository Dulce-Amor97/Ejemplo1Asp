﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo1Asp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "IEVN 1001.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult MuestraPeliculas()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Sumar()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}