using Interview.ModelMapping;
using Interview.Services;
using Interview.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Interview
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            // doesn't work due to automapper issue - now works when initialize
            // immediately before mapping, not here
            AutoMapper.Mapper.Initialize(config => config.AddProfile<ManufacturerRangeServiceToViewMappingProfile>());

            Database.SetInitializer<ManufacturerDataContext>(null);

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

    }
}
