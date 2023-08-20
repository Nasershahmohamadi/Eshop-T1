using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.ProductCategoryAgg
{
    public interface IProductCategoryRepository : IRepository<long , ProductCategory>
    {
        bool Edit(long Id, ProductCategory command);
        bool Delete(long Id);
        List<ProductCategory> Search(string command , long Id);
        void SaveChanges();
    }
}
