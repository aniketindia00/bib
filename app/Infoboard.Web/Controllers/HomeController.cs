﻿using System.Web.Mvc;

namespace Infoboard.Web.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["currentViewBoard"] = "current";
            ViewData["currentMyBoard"] = "";

            return View();
        }

        public ActionResult MyBoard()
        {
            ViewData["currentMyBoard"] = "current";
            ViewData["currentViewBoard"] = "";

            return View();
        }
        public ActionResult AddBoard()
        {

            return View();
        }
    }
}
