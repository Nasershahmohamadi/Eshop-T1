using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopQuery.Contracts.Category
{
    public interface ICategoryQuery
    {
        Category Get(long Id);
        List<Category> Get(int count = 0);
    }

}
