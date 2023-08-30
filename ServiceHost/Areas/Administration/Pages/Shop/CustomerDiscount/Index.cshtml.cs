using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DM.ApplicationContract.CustomerContracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.Shop.CustomerDiscount
{
    public class IndexModel : PageModel
    {
        public List<EditCustomerDiscountVM> editCustomerDiscountVMList { get; set; }
        public EditCustomerDiscountVM editCustomerDiscountVM { get; set; }
        private readonly ICustomerDiscountApplication _customerDiscountApplication;
        public IndexModel(ICustomerDiscountApplication customerDiscountApplication)
        {
            _customerDiscountApplication = customerDiscountApplication;
        }

        public void OnGet()
        {
            editCustomerDiscountVMList = _customerDiscountApplication.Get();
        }

        public IActionResult OnGetCreate()
        {
            return Partial("Create");
        }

        public IActionResult OnGetEdit(long id)
        {
            return Partial("Edit" , _customerDiscountApplication.Get(id));
        }
        public IActionResult OnPostEdit(EditCustomerDiscountVM command)
        {
            _customerDiscountApplication.Edit(command);
            return RedirectToPage("Index");
        }

        public IActionResult OnPostCreate( CreateDisocuntCustomerVM command)
        {
            _customerDiscountApplication.Create(command);
            return RedirectToPage("Index");
        }
    }
}
