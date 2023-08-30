using DM.Domain.ColleageAgg;
using Framework.Domain;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Domain
{
    public class ColleageDiscountRepository : RepositoryBase<long, ColleageDiscount>, IColleageDiscountRepository
    {
        private readonly eShopContext _eShopContext;

        public ColleageDiscountRepository(eShopContext eShopContext) : base(eShopContext)
        {
            _eShopContext = eShopContext;
        }

        public bool Active(long id)
        {
            try
            {
                Get(id).Active();
                SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Delete(long id)
        {
            try
            {
                Get(id).Delete();
                SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DisActive(long id)
        {
            try
            {
                Get(id).DisActive();
                SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Edit(ColleageDiscount command)
        {
            try
            {
                var entity = Get(command.Id);
                entity.Edit(command.DiscountRate, command.Description);
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
            _eShopContext.SaveChanges();
        }
    }
}
