using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Packaging.Boxes.Services;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Models.DataTables;
using Nop.Web.Framework.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Nop.Plugin.Packaging.Boxes.Models.Boxes;

namespace Nop.Plugin.Packaging.Boxes.Controllers
{
    [AuthorizeAdmin]
    [Area(AreaNames.Admin)]
    [AutoValidateAntiforgeryToken]
    public class ManagePackagingBoxes : BasePluginController
    {
        private readonly IPackagingBoxesSearch _service;
        public ManagePackagingBoxes(IPackagingBoxesSearch service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Configure()
        {
            PackagingBoxesSearchModel packagingSearchModel = new PackagingBoxesSearchModel
            {
                AvailablePageSizes = "10"
            };
            return View("~/Plugins/Packaging.Boxes/Views/Configure.cshtml", packagingSearchModel);
        }
        [HttpPost]
        public async Task<IActionResult> GetCustomersCountByCountry()
        {
            try
            {
                return Ok(new DataTablesModel { Data = await _service.GetCustomersDistributionByCountryAsync() });
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
