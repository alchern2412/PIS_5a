using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace lab5a
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // // FOR TASK 1
            // routes.MapRoute(
            //     name: "ConditionV3",
            //     url: "V3/{controller}/X/{action}/{id}",
            //     defaults: new { controller = "MResearch", action = "M03", id = UrlParameter.Optional }
            // );


            // routes.MapRoute(
            //    name: "ConditionV3_1",
            //    url: "V3/{controller}/{action}/{id}",
            //    defaults: new { controller = "MResearch", action = "M03", id = UrlParameter.Optional }
            //);

            // routes.MapRoute(
            //     name: "ConditionV2",
            //     url: "V2/{controller}/{action}/{id}",
            //     defaults: new { controller = "MResearch", action = "M02", id = UrlParameter.Optional }
            // );

            // routes.MapRoute(
            //     name: "Default",
            //     url: "{controller}/{action}/{id}",
            //     defaults: new { controller = "MResearch", action = "M01", id = UrlParameter.Optional }
            // );


            // FOR TASK 2
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "CResearch", action = "C01", id = UrlParameter.Optional }
            );
        }
    }
}
