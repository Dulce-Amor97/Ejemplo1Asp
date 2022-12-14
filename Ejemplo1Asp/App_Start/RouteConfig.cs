using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Ejemplo1Asp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute( //PERMITEN ALMACENAR COMO SI FUERAN OBJETOS, EL CUAL CONTIENE UN INDICE Y UN VALOR
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "OperasBas", action = "Sumar", id = UrlParameter.Optional }
            );
        }
    }
}
