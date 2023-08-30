using DM.Domain.CustomerAgg;
using Framework.Domain;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Domain
{
    public class CustomerDiscountRepository : RepositoryBase<long, CustomerDiscount>, ICustomerDiscountRepository
    {
        private readonly eShopContext _context;

        public CustomerDiscountRepository(eShopContext context) : base(context)
        {
            _context = context;
        }

        public bool Delete(long id)
        {
            try
            {
                Get(id).Delete();
                saveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Edit(CustomerDiscount command)
        {
            if (command.Id == 0)
            {
                throw new Exception("Id is not fill.");
            }
            try
            {
                Get(command.Id).Edit(command.DiscountRate, command.Reason, command.StartDate, command.EndDate, command.Description);
                saveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void saveChanges()
        {
            _context.SaveChanges();
        }
    }
}
