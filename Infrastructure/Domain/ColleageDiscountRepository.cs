using DM.Domain.ColleageAgg;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Domain
{
    public class ColleageDiscountRepository : IColleageDiscountRepository
    {
        private readonly eShopContext _eShopContext;

        public ColleageDiscountRepository(eShopContext eShopContext)
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

        public bool Create(ColleageDiscount command)
        {
            try
            {
                _eShopContext.ColleageDiscounts.Add(command);
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

        public ColleageDiscount Get(long key)
        {
            return _eShopContext.ColleageDiscounts.Find(key);
        }

        public List<ColleageDiscount> Get()
        {
            return _eShopContext.ColleageDiscounts.ToList();
        }

        public void SaveChanges()
        {
            _eShopContext.SaveChanges();
        }
    }
}
