using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TMDT_Buoi5
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
           "Sitemap",
           "sitemap.xml",
           new { controller = "Sitemap", action = "Index" }
           );
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "chuyen muc nha dat",
                url: "nha-dat/{alias}",
                defaults: new { controller = "ChuyenMucNhaDat", action = "Index" }
         
            
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

            );
        }
    }
}
