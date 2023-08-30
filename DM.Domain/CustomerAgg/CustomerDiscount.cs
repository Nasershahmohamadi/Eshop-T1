using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Domain.CustomerAgg
{
   public class CustomerDiscount : EntityBase
    {
        public int DiscountRate { get; private set; }
        public string Reason { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public bool IsActive { get; private set; }
        public string Description { get; private set; }

        public CustomerDiscount(int discountRate, string reason, DateTime startDate, DateTime endDate, string description)
        {
            DiscountRate = discountRate;
            Reason = reason;
            StartDate = startDate;
            EndDate = endDate;
            Description = description;
        }
        public void Edit(int discountRate, string reason, DateTime startDate, DateTime endDate, string description)
        {
            DiscountRate = discountRate;
            Reason = reason;
            StartDate = startDate;
            EndDate = endDate;
            Description = description;
        }
        public bool Active()
        {
            try
            {
                IsActive = true;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
