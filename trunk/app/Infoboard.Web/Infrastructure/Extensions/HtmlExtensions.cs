using System.Web;
using System.Web.Mvc;

namespace Infoboard.Web.Infrastructure.Extensions
{
    public static class HtmlExtensions
    {
        public static string ImagePath(this HtmlHelper helper, string fileName)
        {
            return VirtualPathUtility.ToAbsolute("~/content/images/" + fileName);
        }

        public static string CssPath(this HtmlHelper helper, string fileName)
        {
            return VirtualPathUtility.ToAbsolute("~/content/css/" + fileName);
        }
    }
}