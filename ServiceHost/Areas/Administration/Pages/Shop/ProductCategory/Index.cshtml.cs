using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SM.Applicationcontracts.ProductCategory;

namespace ServiceHost.Areas.Administration.Pages.Shop.ProductCategory
{
    public class IndexModel : PageModel
    {
        private readonly IProductCategoryApplication _productCategoryApplication;
        public SearchProductCategoryVM productcategory { get; set; }
        public IndexModel(IProductCategoryApplication productCategoryApplication)
        {
            _productCategoryApplication = productCategoryApplication;
        }

        public void OnGet(SearchProductCategoryVM model)
        {        
                ViewData["list"] = _productCategoryApplication.Search(model);
        }
        public IActionResult OnGetCreate()
        {
            return Partial("Create");
        }
        public IActionResult OnPostCreate(CreateProductCategoryVM model)
        {
          var result = _productCategoryApplication.Create(model);
            return RedirectToPage();
        }
        public IActionResult OnPostSearch(string Title)
        {
            ViewData["list"] = _productCategoryApplication.Get().Where(x => x.Title == Title);
            return RedirectToPage("Index" , ViewData["list"]);
        }
       
    }
}
