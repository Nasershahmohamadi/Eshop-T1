using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Domain.ColleageAgg
{
    public class ColleageDiscount : EntityBase
    {
        public int DiscountRate { get; private set; }
        public bool IsActive { get; private set; }
        public string Description { get; private set; }

        public ColleageDiscount(int discountRate, string description = "")
        {
            DiscountRate = discountRate;
            IsActive = true;
            Description = description;
        }
        public void Edit(int discountRate, string description)
        {
            DiscountRate = discountRate;
            Description = description;
        }
        public void Active()
        {
            IsActive = true;
        }
        public void DisActive()
        {
            IsActive = false;
        }

    }
}
