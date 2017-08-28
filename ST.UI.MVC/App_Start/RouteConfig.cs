using System.Web.Mvc;
using System.Web.Routing;

namespace ST.UI.MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            routes.LowercaseUrls = true;
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Ana", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "ST.UI.MVC.Controllers" }
            );

        }
    }
}
