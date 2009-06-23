using Castle.Windsor;
using CommonServiceLocator.WindsorAdapter;
using Microsoft.Practices.ServiceLocation;
using MvcContrib.Castle;
using SharpArch.Data.NHibernate;
using SharpArch.Web.NHibernate;
using SharpArch.Web.Areas;
using SharpArch.Web.ModelBinder;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Reflection;
using Infoboard.Web.Controllers;
using Infoboard.Data.NHibernateMaps;
using Infoboard.Web.CastleWindsor;

namespace Infoboard.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            log4net.Config.XmlConfigurator.Configure();

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new AreaViewEngine());

            ModelBinders.Binders.DefaultBinder = new SharpModelBinder();

            InitializeServiceLocator();

            RouteRegistrar.RegisterRoutesTo(RouteTable.Routes);
        }

        /// <summary>
        /// Instantiate the container and add all Controllers that derive from 
        /// WindsorController to the container.  Also associate the Controller 
        /// with the WindsorContainer ControllerFactory.
        /// </summary>
        protected virtual void InitializeServiceLocator()
        {
            IWindsorContainer container = new WindsorContainer();
            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(container));

            container.RegisterControllers(typeof(HomeController).Assembly);
            ComponentRegistrar.AddComponentsTo(container);

            ServiceLocator.SetLocatorProvider(() => new WindsorServiceLocator(container));
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            // Useful for debugging
            Exception ex = Server.GetLastError();
            ReflectionTypeLoadException reflectionTypeLoadException = ex as ReflectionTypeLoadException;
        }

        /// <summary>
        /// Due to issues on IIS7, the NHibernate initialization must occur in Init().
        /// But Init() may be invoked more than once; accordingly, we introduce a thread-safe
        /// mechanism to ensure it's only initialized once.
        /// 
        /// See http://msdn.microsoft.com/en-us/magazine/cc188793.aspx for explanation details.
        /// </summary>
        public override void Init()
        {
            base.Init();

            // Only allow the NHibernate session to be initialized once
            if (WasNHibernateInitialized) {
                return;
            }

            lock (LockObject)
            {
                if (WasNHibernateInitialized) {
                    return;
                }

                NHibernateSession.Init(new WebSessionStorage(this),
                                       new[] { Server.MapPath("~/bin/Infoboard.Data.dll") },
                                       new AutoPersistenceModelGenerator().Generate(),
                                       Server.MapPath("~/NHibernate.config"));

                WasNHibernateInitialized = true;
            }
        }

        private static bool WasNHibernateInitialized;

        /// <summary>
        /// Private, static object used only for synchronization
        /// </summary>
        private static readonly object LockObject = new object();
    }
}