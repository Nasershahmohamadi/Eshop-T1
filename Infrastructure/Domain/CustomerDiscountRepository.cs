using DM.Domain.CustomerAgg;
using Framework.Domain;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Domain
{
    public class CustomerDiscountRepository : RepositoryBase<long,CustomerDiscount>, ICustomerDiscountRepository
    {
        private readonly eShopContext _eShopContext;

        public CustomerDiscountRepository(eShopContext eShopContext) : base(eShopContext)
        {
            _eShopContext = eShopContext;
        }

        public bool Active(long id)
        {
            try
            {

                if (_eShopContext.CustomerDiscounts.Find(id).Active())
                {
                    SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }

        //public bool Create(CustomerDiscount command)
        //{
        //    try
        //    {
        //        var entity = new CustomerDiscount(command.DiscountRate, command.Reason, command.StartDate, command.EndDate, 
        //            command.Description);
        //        var result = _eShopContext.CustomerDiscounts.Add(entity);
        //        SaveChanges();
        //        return true;
        //    }
        //    catch (Exception)
        //    {

        //        return false;
        //    }
        //}

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

        public bool Edit(CustomerDiscount command)
        {
            try
            {
                Get(command.Id).Edit(command.DiscountRate , command.Reason , command.StartDate , command.EndDate , command.Description);
                SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        //public CustomerDiscount Get(long key)
        //{
        //    return _eShopContext.CustomerDiscounts.Find(key);
        //}

        //public List<CustomerDiscount> Get()
        //{
        //    return _eShopContext.CustomerDiscounts.ToList();
        //}

        public void SaveChanges()
        {
            _eShopContext.SaveChanges();
        }
    }
}
