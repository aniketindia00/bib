using System.Web.Mvc;
using System.Web.Routing;
using SharpArch.Web.Areas;

namespace Infoboard.Web
{
    public class RouteRegistrar
    {
        public static void RegisterRoutesTo(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });

            routes.CreateArea("Root", "Infoboard.Web",
                routes.MapRoute(null, "{controller}/{action}", new { controller = "Home", action = "Index" }),
                routes.MapRoute(null, "{controller}/{action}/{id}"));
        }
    }
}