using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SM.Applicationcontracts.Product;

namespace ServiceHost.Areas.Administration.Pages.Shop.Product
{
    public class IndexModel : PageModel
    {
        public List<EditProductVM> products { get; set; }
        private readonly IProductApplication _productApplication;

        public IndexModel(IProductApplication productApplication)
        {
            _productApplication = productApplication;
        }

        public void OnGet()
        {
            products = _productApplication.Get();
        }

        public IActionResult OnGetCreate()
        {
            return Partial("Create");
        }

        public IActionResult OnPostCreate(CreateProductVm model)
        {
            _productApplication.Create(model);
            return RedirectToPage("Index");
        }
    }
}
