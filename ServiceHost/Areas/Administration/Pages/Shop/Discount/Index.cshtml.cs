using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DM.ApplicationContract.CollageContracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.Shop.Discount
{
    public class IndexModel : PageModel
    {
        public EditColleageDiscountVM editColleageDiscountVM { get; set; }
        public List<EditColleageDiscountVM> colleageDiscountList { get; set; }
        private readonly IColleageDiscountApplication _colleageDiscountApplication;

        public IndexModel(IColleageDiscountApplication colleageDiscountApplication)
        {
            _colleageDiscountApplication = colleageDiscountApplication;
        }

        public void OnGet()
        {
            colleageDiscountList = _colleageDiscountApplication.Get();
        }
    }
}
