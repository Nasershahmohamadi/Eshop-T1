using eShopQuery.Contracts.Category;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopQuery.Query
{
    class CategoryQuery : ICategoryQuery
    {
        private readonly eShopContext _eShopContext;

        public CategoryQuery(eShopContext eShopContext)
        {
            _eShopContext = eShopContext;
        }

        public Contracts.Category.Category Get(long Id)
        {
            var category = _eShopContext.ProductCategories.Find(Id);
            var _res = new Category
            {
                Description = category.Description,
                KeyWords = category.KeyWords,
                MetaDescription = category.MetaDescription,
                Picture = category.Picture,
                PictureAlt = category.PictureAlt,
                PictureTitle = category.PictureTitle,
                Slug = category.Slug,
                Title = category.Title,
                Id=category.Id
            };
            return _res;
        }

        public List<Contracts.Category.Category> Get(int count = 0)
        {
            var list = _eShopContext.ProductCategories.OrderByDescending(x=>x.Id).Take(4).ToList();
            var _res = new List<Category>();
            foreach (var category in list)
            {
                _res.Add(new Category
                {
                Description = category.Description,
                KeyWords = category.KeyWords,
                MetaDescription = category.MetaDescription,
                Picture = category.Picture,
                PictureAlt = category.PictureAlt,
                PictureTitle = category.PictureTitle,
                Slug = category.Slug,
                Title = category.Title,
                Id=category.Id

                });
            }
            return _res;
        }
    }
}
