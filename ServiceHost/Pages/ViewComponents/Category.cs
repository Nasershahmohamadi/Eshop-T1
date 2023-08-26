using eShopQuery.Contracts.Category;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceHost.Pages.ViewComponents
{
    public class Category : ViewComponent
    {
        private readonly ICategoryQuery _categoryQuery;

        public Category(ICategoryQuery categoryQuery)
        {
            _categoryQuery = categoryQuery;
        }

        public IViewComponentResult Invoke()
        {
            var model = _categoryQuery.Get();
            return View(model);
        }
    }
}
