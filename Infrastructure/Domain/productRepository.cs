using Framework.Domain;
using Infrastructure.Context;
using SM.Domain.ProductAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Domain
{
   public class productRepository : RepositoryBase<long, Product>, IproductRepository
    {
        private readonly eShopContext _context;

        public productRepository(eShopContext context) : base(context)
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

        public bool Edit(Product command)
        {
            try
            {
            var _entity = Get(command.Id);
            _entity.Edit(command.Name, command.Code, command.ShortDescription, command.Description, command.Picture,
                command.PictureAlt, command.PictureTitle, command.Slug, command.Keywords, command.MetaDescription, command.CategoryId);
                SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Product> Get(Expression<Func<Product, bool>> expression)
        {
            var res = _context.Products.Where(expression);
            return res.ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
