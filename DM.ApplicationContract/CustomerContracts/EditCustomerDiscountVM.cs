﻿using System;

namespace DM.ApplicationContract.CustomerContracts
{
    public class EditCustomerDiscountVM : CreateDisocuntCustomerVM
    {
        public long Id { get; set; }
        public DateTime CreationDate { get; set; }
        public bool  IsDeleted { get; set; }
    }
}
