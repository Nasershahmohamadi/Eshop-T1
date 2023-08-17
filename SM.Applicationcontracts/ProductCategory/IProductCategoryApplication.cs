﻿using Framework.Application;
using System.Collections.Generic;

namespace SM.Applicationcontracts.ProductCategory
{
    public interface IProductCategoryApplication
    {
        OperationResult Create(CreateProductCategoryVM command);
        OperationResult Edit(EditProductCategoryVM command);
        OperationResult Delete(long Id);
        Domain.ProductCategoryAgg.ProductCategory Get(long Id);
        List<Domain.ProductCategoryAgg.ProductCategory> Get();
    }
}