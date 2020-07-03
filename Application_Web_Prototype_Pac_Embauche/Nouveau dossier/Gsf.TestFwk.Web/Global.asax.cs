using Gsf.Framework.Web.MVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Gsf.TestFwk.Web

{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GsfGlobalMVC.Application_Start();
        }

        public static void Application_End()
        {
            GsfGlobalMVC.Application_End();
        }

        public static void Application_Error()
        {
            GsfGlobalMVC.Application_Error();
        }

        public static void Session_Start()
        {
            GsfGlobalMVC.Session_Start();
        }

        public static void Session_End()
        {
            GsfGlobalMVC.Session_End();
        }
    }
}
