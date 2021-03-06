using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LearnRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                  name: "Test",
                  url: "{controller}/{action}/{param}",
                  defaults: new { controller = "Home", action = "FirstAction" }
              );
            routes.MapRoute(
                name: "Testy",
                url: "{controller}/{action}/{secondparm}",
                defaults: new { controller = "Home", action = "SecondAction" }
            );

            routes.MapRoute(
              name: "Test2",
              url: "{controller}/{action}/{encodedparam}",
              defaults: new { controller = "User", action = "UserInfo" }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
