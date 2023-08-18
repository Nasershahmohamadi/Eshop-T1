using Framework.Domain;
using Infrastructure.Context;
using SM.Domain.ProductCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Domain
{
    class ProductCategoryRepository : RepositoryBase<long, ProductCategory>, IProductCategoryRepository
    {
        private readonly eShopContext _context;

        public ProductCategoryRepository(eShopContext context) : base(context)
        {
            _context = context;
        }

        public bool Delete(long Id)
        {
            try
            {
                Get(Id).Delete();
                SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Edit(long Id, ProductCategory command)
        {
            try
            {
                var entity = Get(command.Id);
                entity.Edit(command.Title, command.Picture, command.Title,command.PictureAlt, command.Slug , command.Description,command.MetaDescription,command.KeyWords);
                SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<ProductCategory> Search(string command)
        {
            var query = _context.ProductCategories.Select(x=>x);
            if (!string.IsNullOrWhiteSpace(command))
            {
               query= query.Where(x => x.Title.Contains(command));
            }
            return query.ToList();
        }
    }
}
