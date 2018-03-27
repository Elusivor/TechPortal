using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Techportal
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "CustomersByCountryStatus",
                "customer/list/{country}/{status}",
                new { Controller = "Customer", Action = "ByCountryAndStatus" }
                );

            routes.MapRoute(
                "RandomLabRoute",
                "customer/YMD/{year}/{month}/{day}",
                new { Controller = "Customer", Action = "YMD" },
                new { year = @"\d{4}", month = @"\d{2}"}               
                );

            routes.MapRoute(
                "CustomersEdit",
                "customer/edit/{id}",
                new { Controller = "Customer", Action = "ByEditCustomers" }
                );
        }
    }
}
