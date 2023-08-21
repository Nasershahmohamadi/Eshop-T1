using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.ProductAgg
{
    public interface IproductRepository : IRepository<long, Product>
    {
        bool Edit(Product command);
        bool Delete(long Id);
        List<Product> Get(Expression<Func<Product , bool>> expression);
        void SaveChanges();

    }
}
