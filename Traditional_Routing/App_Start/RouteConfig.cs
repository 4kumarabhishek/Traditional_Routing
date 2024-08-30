using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Traditional_Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //named argument
            routes.MapRoute(
                name: "about",
                url: "about-us",
                defaults: new {controller = "home", action = "about"}
                );


            //positional argument
            //routes.MapRoute("reverse", "{action}/{controller}");


            //constraints for routes
            routes.MapRoute(
                name : "display",
                url : "display/{cid}",
                constraints: new { cid = @"\d{1,4}" },
                defaults: new {controller="home", action="display"}
                ) ;

            routes.MapRoute(
                name: "courses",
                url: "courses/{title}",
                constraints: new { title = "c|cpp|java|cs|mvc" },
                defaults: new { controller = "home", action = "courses" }

                );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
