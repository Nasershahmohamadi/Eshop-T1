using SM.Applicationcontracts.ProductCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SM.Applicationcontracts.Product
{
    public interface IProductApplication
    {
        bool Create(CreateProductVm command);
        bool Edit(EditProductVM command);
        bool Delete(long Id);
        EditProductVM Get(long Id);
        List<EditProductVM> Get();
        List<EditProductVM> Search(string search = "");
    }
}
