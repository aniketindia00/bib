using System.Web.Mvc;

namespace Infoboard.Web.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyBoard()
        {
            return View();
        }
    }
}
