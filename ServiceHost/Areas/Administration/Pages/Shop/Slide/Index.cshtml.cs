using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SM.Applicationcontracts.Slide;

namespace ServiceHost.Areas.Administration.Pages.Shop.Slide
{
    public class IndexModel : PageModel
    {
        public List<EditeSlideVM> SlideModel{ get; set; }

        private readonly ISlideApplication _slideApplication;

        public IndexModel(ISlideApplication slideApplication)
        {
            _slideApplication = slideApplication;
        }

        public void OnGet()
        {
            SlideModel = _slideApplication.Get();
        }
        
        public IActionResult OnGetCreate()
        {
            return Partial("Create");
        }
        public IActionResult OnPostCreate(CreateSlideVM model)
        {
            _slideApplication.Create(model);
            return RedirectToPage("Index");
        }
        
        public IActionResult OnGetEdit(long id)
        {
            var entity = _slideApplication.Get(id);
            return Partial("Edit", entity);
        }
        public IActionResult OnPostEdit(EditeSlideVM model)
        {
            _slideApplication.Edit(model);
            return RedirectToPage("Index");
        }
    }
}
