using System.Web.Mvc;
using System.Web.Routing;

namespace CC.WEB
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                "ShopDetailsRoute",
                "{controller}/{alias}/{alias2}",
                new { area = "", controller = "Home", action = "Details" },
                new[] { "CC.WEB.Controllers" }
                );

            routes.MapRoute(
                "ShopRoute",
                "{controller}/{alias}",
                new { area = "", controller = "Home", action = "Index" },
                new[] { "CC.WEB.Controllers" }
                );

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new {area = "", controller = "Home", action = "Index", id = UrlParameter.Optional},
                new[] {"CC.WEB.Controllers"}
                );

            
        }
    }
}
