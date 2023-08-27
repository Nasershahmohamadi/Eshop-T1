using System;

namespace DM.ApplicationContract.CollageContracts
{
    public class EditColleageDiscount
    {
        public long Id { get; set; }
        public int DiscountRate { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
