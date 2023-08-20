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
        public List<ProductCategoryVM> productCategories { get; set; }
        public IndexModel(IProductCategoryApplication productCategoryApplication)
        {
            _productCategoryApplication = productCategoryApplication;
        }

        public void OnGet(SearchProductCategoryVM model)
        {
            productCategories = _productCategoryApplication.Search(model)
                .Where(x=>x.IsDeleted!=true).ToList();
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
            return RedirectToPage("Index", ViewData["list"]);
        }
        public IActionResult OnGetEdit(long id)
        {
            var productCategory = _productCategoryApplication.Search(new SearchProductCategoryVM
            {
                Id = id
            }).Select(x => new EditProductCategoryVM
            {
                CreationDate = x.CreationDate,
                Description = x.Description,
                IsDeleted = x.IsDeleted,
                KeyWords = x.Keywords,
                MetaDescription = x.MetaDescription,
                Picture = x.Picture,
                PictureTitle = x.Title,
                Title = x.Title,
                Id = id
            }).FirstOrDefault();

            return Partial("Update", productCategory);
        }
        public IActionResult OnPostEdit(EditProductCategoryVM model)
        {
            _productCategoryApplication.Edit(model);
            productCategories = _productCategoryApplication.Get();
            return RedirectToPage("Index");
        }
        public IActionResult OnGetDelete(long Id)
        {
            _productCategoryApplication.Delete(Id);
            return RedirectToPage("Index");
        }


    }
}
