using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace cis237InClass6
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            //This is a route that we made. It must be above the other one because
            //the url: my/own/route can and will match {controller}/{action}/{id}.
            //Therefore it must be declared above the more generic one with placeholders
            //if we want to use it.
            routes.MapRoute(
                name: "Mine",
                url: "my/own/route",
                defaults: new { controller = "Cars", action = "Index" }
            );
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
