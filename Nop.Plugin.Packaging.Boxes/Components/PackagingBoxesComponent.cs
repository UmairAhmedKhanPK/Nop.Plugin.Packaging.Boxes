using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Plugin.Packaging.Boxes.Domains;
using Nop.Plugin.Packaging.Boxes.Services;
using Nop.Services.Catalog;
using Nop.Services.Customers;
using Nop.Web.Framework.Components;
using System.Threading.Tasks;

namespace Nop.Plugin.Packaging.Boxes.Components
{
    [ViewComponent(Name = "PackagingBoxesView")]
    public class PackagingBoxesComponent : NopViewComponent
    {
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;
        private readonly IPackagingBoxesServices _packagingBoxesService;
        private readonly IWorkContext _workContext;

        public PackagingBoxesComponent(ICustomerService customerService,
            IProductService productService,
            IPackagingBoxesServices productViewTrackerService,
            IWorkContext workContext)
        {
            _customerService = customerService;
            _productService = productService;
            _packagingBoxesService = productViewTrackerService;
            _workContext = workContext;
        }

        //public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData)
        //{
        //    if (!(additionalData is ProductDetailsModel model))
        //        return Content("");

        //    //Read from the product service
        //    var productById = await _productService.GetProductByIdAsync(model.Id);
        //    //If the product exists we will log it
        //    if (productById != null)
        //    {
        //        var currentCustomer = await _workContext.CurrentCustomerAsync();
        //        //Setup the product to save
        //        var record = new PackagingBoxesRecords
        //        {
        //            BoxID = model.BoxID,
        //            CategoryID = model.CategoryID,
        //            BoxName = model.BoxName,
        //            BoxDetails = model.BoxDetails,
        //            Height = model.Height,
        //            Width = model.Width,
        //            Length = model.Length,
        //            AddedDateTime = model.AddedDateTime,
        //            IsRegistered = await _customerService.Async(currentCustomer)
        //        };
        //        //Map the values we're interested in to our new entity
        //        _packagingBoxesService.Log(record);
        //    }

        //    return Content("");
        //}
    }
}
