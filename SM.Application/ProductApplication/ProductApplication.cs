using SM.Applicationcontracts.Product;
using SM.Domain.ProductAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.ProductApplication
{
    public class ProductApplication : IProductApplication
    {
        private readonly IproductRepository _productRepository;

        public ProductApplication(IproductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool Create(CreateProductVm command)
        {
            try
            {
                var entity = new Product(command.Name, command.Code, command.ShortDescription, command.Description,
                    command.Picture, command.PictureAlt, command.PictureTitle, command.Slug, command.Keywords,
                    command.MetaDescription, command.CategoryId);
                _productRepository.Create(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(long Id)
        {
            try
            {
                _productRepository.Delete(Id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Edit(EditProductVM command)
        {
            try
            {
                var entity = _productRepository.Get(command.Id);
                entity.Edit(command.Name, command.Code, command.ShortDescription, command.Description,
                    command.Picture, command.PictureAlt, command.PictureTitle, command.Slug, command.Keywords,
                    command.MetaDescription, command.CategoryId);

                _productRepository.Edit(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public EditProductVM Get(long Id)
        {
            var _entity = _productRepository.Get(Id);
            var _result = new EditProductVM
            {
                Id = _entity.Id,
                CategoryId = _entity.CategoryId,
                Code = _entity.Code,
                Description = _entity.Description,
                Keywords = _entity.Keywords,
                MetaDescription = _entity.MetaDescription,
                Name = _entity.Name,
                Picture = _entity.Picture,
                PictureAlt = _entity.PictureAlt,
                PictureTitle = _entity.PictureTitle,
                ShortDescription = _entity.ShortDescription,
                Slug = _entity.Slug

            };
            return _result;
        }

        public List<EditProductVM> Get()
        {
            var _entity = _productRepository.Get();
            var result = new List<EditProductVM>();
            foreach (var item in _entity)
            {
                result.Add(new EditProductVM
                {
                    Id = item.Id,
                    CategoryId = item.CategoryId,
                    Code = item.Code,
                    Description = item.Description,
                    Keywords = item.Keywords,
                    MetaDescription = item.MetaDescription,
                    Name = item.Name,
                    Picture = item.Picture,
                    PictureAlt = item.PictureAlt,
                    PictureTitle = item.PictureTitle,
                    ShortDescription = item.ShortDescription,
                    Slug = item.Slug

                });
            }       
            return result;

        }

        public List<EditProductVM> Search(string search = "")
        {
            return null;
        }
    }
}
