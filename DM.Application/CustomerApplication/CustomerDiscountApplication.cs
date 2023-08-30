using DM.ApplicationContract.CustomerContracts;
using DM.Domain.CustomerAgg;
using Framework.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Application.CustomerApplication
{
    public class CustomerDiscountApplication : ICustomerDiscountApplication
    {
        private readonly ICustomerDiscountRepository _customerDiscountRepository;
        public CustomerDiscountApplication(ICustomerDiscountRepository customerDiscountRepository)
        {
            _customerDiscountRepository = customerDiscountRepository;
        }

        public OperationResult Create(CreateDisocuntCustomerVM command)
        {
            var _operation = new OperationResult();
            try
            {
                var entity = new CustomerDiscount(command.DiscountRate, command.Reason, command.StartDate, command.EndDate, command.Description);
                _customerDiscountRepository.Create(entity);
                return _operation.Success();
            }
            catch (Exception)
            {

                return _operation.Failed();
            }
        }

        public OperationResult Delete(long id)
        {
            var _operation = new OperationResult();
            try
            {
                _customerDiscountRepository.Delete(id);
                return _operation.Success();
            }
            catch (Exception)
            {

                return _operation.Failed();
            }
        }

        public OperationResult Edit(EditCustomerDiscountVM command)
        {
            var _operation = new OperationResult();
            try
            {
                var entity = _customerDiscountRepository.Get(command.Id);
                entity.Edit(command.DiscountRate, command.Reason, command.StartDate, command.EndDate, command.Description);
                _customerDiscountRepository.Edit(entity);

                return _operation.Success();
            }
            catch (Exception)
            {

                return _operation.Failed();
            }
        }

        public EditCustomerDiscountVM Get(long id)
        {
            try
            {
                var entity = _customerDiscountRepository.Get(id);
                return new EditCustomerDiscountVM
                {
                    CreationDate = entity.CreationDate,
                    Description = entity.Description,
                    DiscountRate = entity.DiscountRate,
                    EndDate = entity.EndDate,
                    Id = entity.Id,
                    IsActive = entity.IsActive,
                    IsDeleted = entity.IsDeleted,
                    Reason = entity.Reason,
                    StartDate = entity.StartDate
                };

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<EditCustomerDiscountVM> Get()
        {
            try
            {
                var list = _customerDiscountRepository.Get();
                var result = new List<EditCustomerDiscountVM>();
                foreach (var entity in list)
                {
                    result.Add(new EditCustomerDiscountVM
                    {
                        CreationDate = entity.CreationDate,
                        Description = entity.Description,
                        DiscountRate = entity.DiscountRate,
                        EndDate = entity.EndDate,
                        Id = entity.Id,
                        IsActive = entity.IsActive,
                        IsDeleted = entity.IsDeleted,
                        Reason = entity.Reason,
                        StartDate = entity.StartDate

                    });
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
