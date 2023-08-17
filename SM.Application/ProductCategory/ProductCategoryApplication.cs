using Framework.Application;
using SM.Applicationcontracts.ProductCategory;
using SM.Domain.ProductCategoryAgg;
using System;
using System.Collections.Generic;

namespace SM.Application.ProductCategoryApplication
{
    public class ProductCategoryApplication : IProductCategoryApplication
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryApplication(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public OperationResult Create(CreateProductCategoryVM command)
        {
            var _operation = new OperationResult();
            try
            {
                var entity = new ProductCategory(command.Title, command.PictureTitle, command.Title, command.PictureAlt, command.Slug);
                _productCategoryRepository.Create(entity);
                return _operation.Success();
            }
            catch (Exception)
            {

                return _operation.Failed();
            }
        }

        public OperationResult Delete(long Id)
        {
            var _operation = new OperationResult();
            try
            {
                var entity = Get(Id);
                _productCategoryRepository.Delete(Id);
                return _operation.Success();
            }
            catch (Exception)
            {
                return _operation.Failed();
            }
        }

        public OperationResult Edit(EditProductCategoryVM command)
        {
            var _operation = new OperationResult();
            try
            {
                var entity = new ProductCategory(command.Title, command.Picture, command.Title, command.PictureAlt, command.Slug);
                _productCategoryRepository.Edit(command.Id, entity);
                return _operation.Success();
            }
            catch (Exception)
            {

                return _operation.Failed();
            }
        }

        public ProductCategory Get(long Id)
        {
          return  _productCategoryRepository.Get(Id);
        }

        public List<ProductCategory> Get()
        {
            return _productCategoryRepository.Get();
        }
    }
}
