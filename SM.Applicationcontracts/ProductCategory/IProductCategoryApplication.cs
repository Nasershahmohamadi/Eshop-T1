using Framework.Application;
using SM.Domain.ProductCategoryAgg;
using System.Collections.Generic;

namespace SM.Applicationcontracts.ProductCategory
{
    public interface IProductCategoryApplication
    {
        OperationResult Create(CreateProductCategoryVM command);
        OperationResult Edit(EditProductCategoryVM command);
        OperationResult Delete(long Id);
        ProductCategoryVM Get(long Id);
        List<ProductCategoryVM> Get();
        List<ProductCategoryVM> Search(SearchProductCategoryVM command);

    }
}
