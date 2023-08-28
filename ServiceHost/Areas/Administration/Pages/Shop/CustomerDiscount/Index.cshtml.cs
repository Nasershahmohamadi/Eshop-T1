using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DM.Application.CustomerApplication;
using DM.ApplicationContract.CustomerContracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.Shop.CustomerDiscount
{
    public class IndexModel : PageModel
    {
        public List<EditCustomerDiscountVM> DicountList { get; set; }
        private readonly CustomeDiscountApplication _customeDiscountApplication;
        public EditCustomerDiscountVM Discount { get; set; }

        public IndexModel(CustomeDiscountApplication customeDiscountApplication)
        {
            _customeDiscountApplication = customeDiscountApplication;
        }

        public void OnGet()
        {
            DicountList = _customeDiscountApplication.Get();
        }
    }
}
