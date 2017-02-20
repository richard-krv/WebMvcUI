using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interview.Validation
{
    using System;
    using System.Web.Routing;

    // Validation applied to an Action inside of Route[] attribute
    // targetng particular parts of a route
    // Must be registered in RouteConfig.RegisterRoutes()
    public class ValuesConstraint : IRouteConstraint
    {
        private readonly string[] validOptions;
        public ValuesConstraint(string options)
        {
            validOptions = options.Split('|');
        }

        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            object value;
            if (values.TryGetValue(parameterName, out value) && value != null)
            {
                return validOptions.Contains(value.ToString(), StringComparer.OrdinalIgnoreCase);
            }
            return false;
        }
    }
}