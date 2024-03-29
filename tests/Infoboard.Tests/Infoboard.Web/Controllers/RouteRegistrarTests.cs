﻿using Infoboard.Web;
using Infoboard.Web.Controllers;
using NUnit.Framework;
using MvcContrib.TestHelper;
using System.Web.Routing;

namespace Tests.Infoboard.Web.Controllers
{
    [TestFixture]
    public class RouteRegistrarTests
    {
        [SetUp]
        public void SetUp()
        {
            RouteTable.Routes.Clear();
            RouteRegistrar.RegisterRoutesTo(RouteTable.Routes);
        }

        [Test]
        public void CanVerifyRouteMaps()
        {
            "~/".Route().ShouldMapTo<HomeController>(x => x.Index());
        }
    }
}