using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Domain.CustomerAgg
{
    public interface ICustomerDiscountRepository : IRepository<long , CustomerDiscount>
    {
        bool Edit(CustomerDiscount command);
        bool Delete(long id);
        void saveChanges();

    }
}
