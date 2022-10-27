using Ejemplo1Asp.Models;
using Ejemplo1Asp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo1Asp.Controllers
{
    public class OperasBasController : Controller
    {
        // GET: OperasBas
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MuestraPeliculas()
        {
            var PeliculasService = new peliculasServices();
            var model = PeliculasService.ObtenerPelicula();

            return View(model);
        }

        public ActionResult Sumar() //ActionResult no importa lo que se utilizace, este resuelve lo que uno quiere
        {
            var tem = new Calculos();
            return View(tem);
        }
        [HttpPost]
        public ActionResult Sumar(Calculos calculos, string r1) //objeto del tipo de la clase
          
        {
            var tem = new Calculos();
            tem = calculos;
          
            if (r1.Equals ("Sumar"))
            {
               tem.Sumar();
            }            
            if (r1.Equals ("Restar"))
            {
                tem.Restar();
            }
           
            ViewBag.res = tem.Resultado;//ViewBag crear una variable que poidemos utilizarla en la vista
            return View();
        }

        public RedirectToRouteResult Temporal()
        {
            return RedirectToAction("About", "Home"); //RedirectResult RedirectToAction=rediccionamiento

            //var alumno1 = new alumnos() { Nombre = "Iza", Edad = 15 }; //Json para mandar info en ese formato
            //var alumno2 = new alumnos() { Nombre = "Sofía", Edad = 16 };
            //return Json(new List<alumnos>() { alumno1, alumno2 }, JsonRequestBehavior.AllowGet);

            //devolución de datos ViewResult, ContentResult y ActionResult
            //return View(); //VIEW intenta regresar una vista
        }

        public ActionResult vista()
        {
            ViewBag.Nombre = "Sofía";
            ViewData["Nom"] = "Iza";
            return View();
        }
    }
}