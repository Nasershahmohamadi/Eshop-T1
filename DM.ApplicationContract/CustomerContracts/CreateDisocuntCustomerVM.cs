using System;

namespace DM.ApplicationContract.CustomerContracts
{
    public class CreateDisocuntCustomerVM
    {
        public int DiscountRate { get;  set; }
        public string Reason { get;  set; }
        public DateTime StartDate { get;  set; }
        public DateTime EndDate { get;  set; }
        public bool IsActive { get;  set; }
        public string Description { get;  set; }

    }

}
