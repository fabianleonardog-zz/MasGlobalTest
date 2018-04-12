using MasGlobalTest.Web.App_Start;
using System;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace MasGlobalTest.Web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }        
    }
}