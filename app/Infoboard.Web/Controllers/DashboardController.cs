using System.Web.Mvc;
using Infoboard.ApplicationServices;

namespace Infoboard.Web.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IDashboardService _dashboardService;

        public DashboardController(IDashboardService dashboardService) {
            _dashboardService = dashboardService;
        }
    }
}
