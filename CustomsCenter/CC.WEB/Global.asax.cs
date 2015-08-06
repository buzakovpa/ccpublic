using System;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.Routing;

namespace CC.WEB
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        private void Application_BeginRequest(Object source, EventArgs e)
        {
            var environment = WebConfigurationManager.AppSettings.Get("ENVIRONMENT");

            if (environment == "close") {
                var application = (HttpApplication) source;
                var context = application.Context;
                if (context.Request.FilePath != "/Home/InDeveloping") {
                    context.Response.Redirect(@"/Home/InDeveloping");
                }
            }
        }
    }
}