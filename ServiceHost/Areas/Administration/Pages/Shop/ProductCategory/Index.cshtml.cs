using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SM.Applicationcontracts.ProductCategory;

namespace ServiceHost.Areas.Administration.Pages.Shop.ProductCategory
{
    public class IndexModel : PageModel
    {
        private readonly IProductCategoryApplication _productCategoryApplication;
        public ProductCategoryVM productcategory { get; set; }
        public IndexModel(IProductCategoryApplication productCategoryApplication)
        {
            _productCategoryApplication = productCategoryApplication;
        }

        public void OnGet()
        {
            ViewData["list"] = _productCategoryApplication.Get();
        }

        public IActionResult OnGetCreate()
        {
            return Partial("Create");
        }
        public IActionResult OnPostCreate()
        {
            return Partial("Create");
        }
    }
}
