﻿using Quality.Infrastructure.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Quality.WebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.Init();

            Log4NetLoggingService logger = (Log4NetLoggingService)DependencyResolver.Current.GetService(typeof(ILoggingService));
            logger.LogInfo(this, "Application start");
        }

        protected void Application_Error(Object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            //Context.ClearError();
            Log4NetLoggingService logger = (Log4NetLoggingService)DependencyResolver.Current.GetService(typeof(ILoggingService));
            logger.LogFatal(this, "", ex);
        }
    }
}
