using eShopQuery.Contracts.Slide;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.Pages.ViewComponents
{
    public class Slide : ViewComponent
    {
        private readonly ISlideQuery _slideQuery;

        public Slide(ISlideQuery slideQuery)
        {
            _slideQuery = slideQuery;
        }

        public IViewComponentResult Invoke()
        {
            var model = _slideQuery.Get();
            return View(model);
        }
    }
}
