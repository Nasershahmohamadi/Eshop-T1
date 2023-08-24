using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SM.Applicationcontracts.Product;
using SM.Applicationcontracts.ProductCategory;

namespace ServiceHost.Areas.Administration.Pages.Shop.Product
{
    public class IndexModel : PageModel
    {
        public List<EditProductVM> products { get; set; }
        public List<ProductCategoryVM> categories { get; set; }
        private readonly IProductApplication _productApplication;
        private readonly IProductCategoryApplication _productcategoryApplication;

        public IndexModel(IProductApplication productApplication, IProductCategoryApplication productcategoryApplication)
        {
            _productApplication = productApplication;
            _productcategoryApplication = productcategoryApplication;
        }

        public void OnGet()
        {
            products = _productApplication.Get();
            categories = _productcategoryApplication.Get();

        }
        public IActionResult OnGetCreate()
        {
           ViewData["command"]  =  _productcategoryApplication.Get();
            return Partial("Create");
        }
        public IActionResult OnPostCreate(CreateProductVm model)
        {
            _productApplication.Create(model);
            return RedirectToPage("Index");
        }
        public IActionResult OnGetDelete(long id)
        {
            _productApplication.Delete(id);
            return RedirectToPage("Index");
        }
        public IActionResult OnGetEdit(long id)
        {
            return Partial("Edit", _productApplication.Get(id));
        }
        public IActionResult OnPostEdit(EditProductVM model)
        {
            _productApplication.Edit(model);
            return RedirectToPage("Index");
        }
    }
}
