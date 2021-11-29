using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework;
using Nop.Web.Framework.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Packaging.Boxes.Infrastructure
{
    /// <summary>
    /// Represents plugin route provider
    /// </summary>
    public class RouteProvider : IRouteProvider
    {
        /// <summary>
        /// Register routes
        /// </summary>
        /// <param name="endpointRouteBuilder">Route builder</param>
        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
            endpointRouteBuilder.MapControllerRoute(PackagingBoxesDefaults.ConfigurationRouteName, "Admin/Plugins/PackagingBoxes/Configure",
                new { controller = "PackagingBoxes", action = "Configure", area = AreaNames.Admin });

            endpointRouteBuilder.MapControllerRoute(PackagingBoxesDefaults.ConfigurationRouteName, "Admin/Plugins/PackagingBoxes/AddBoxes",
                new { controller = "PackagingBoxes", action = "AddBoxes", area = AreaNames.Admin });

            endpointRouteBuilder.MapControllerRoute(PackagingBoxesDefaults.ConfigurationRouteName, "Admin/Plugins/PackagingBoxes/ManageBoxes",
                new { controller = "PackagingBoxes", action = "ManageBoxes", area = AreaNames.Admin });

        }
        /// <summary>
        /// Gets a priority of route provider
        /// </summary>
        public int Priority => 100;
    }
}
