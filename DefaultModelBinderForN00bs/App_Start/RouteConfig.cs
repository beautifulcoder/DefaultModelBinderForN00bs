using System.Web.Mvc;
using System.Web.Routing;

namespace DefaultModelBinderForN00bs
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute("Default", "{controller}/{action}", new { Controller = "Person", Action = "Edit" });
        }
    }
}
