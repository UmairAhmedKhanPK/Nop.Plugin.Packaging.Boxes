using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Core;
using Nop.Core.Infrastructure;
using Nop.Plugin.Packaging.Boxes.Models;
using Nop.Services.Catalog;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Media;
using Nop.Services.Messages;
using Nop.Services.Security;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Plugin.Packaging.Boxes.Controllers
{
    [AuthorizeAdmin]
    [Area(AreaNames.Admin)]
    [AutoValidateAntiforgeryToken]
    public class PackagingBoxesController : BasePluginController
    {
        //public ActionResult Configure(ConfigurePlugin model)
        //{
        //    return View("/Plugins/Packaging.Boxes/Views/Configure.cshtml", model);
        //}
        public ActionResult AddBoxes(Nop.Plugin.Packaging.Boxes.Models.Boxes model)
        {
            return View("/Plugins/Packaging.Boxes/Views/AddBoxes.cshtml", model);
        }
        public ActionResult ManageBoxes(Nop.Plugin.Packaging.Boxes.Models.Boxes model)
        {
            return View("/Plugins/Packaging.Boxes/Views/ManageBoxes.cshtml", model);
        }

    }
}