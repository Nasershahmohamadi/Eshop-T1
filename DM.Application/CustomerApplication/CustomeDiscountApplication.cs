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
    public class CustomeDiscountApplication : ICustomerDiscountApplication
    {
        private readonly ICustomerDiscountRepository _repository;

        public CustomeDiscountApplication(ICustomerDiscountRepository repository)
        {
            _repository = repository;
        }

        public OperationResult Create(CreateCustomerDiscountVM command)
        {
            var operation = new OperationResult();
            try
            {
                var entity = new CustomerDiscount(command.DiscountRate, command.Reason, command.StartDate, command.EndDate, command.Description);
                var res = _repository.Create(entity);
                if (res)
                {
                    return operation.Success();

                }
                else
                {
                    return operation.Failed();
                }
            }
            catch (Exception)
            {

                return operation.Failed();
            }
        }

        public OperationResult Delete(long id)
        {
            var operation = new OperationResult();
            try
            {
                _repository.Get(id).Delete();
                return operation.Success();
            }
            catch (Exception)
            {

                return operation.Failed();
            }
        }

        public OperationResult Edit(EditCustomerDiscountVM command)
        {
            var operation = new OperationResult();
            try
            {
                var entity = _repository.Get(command.Id);
                entity.Edit(command.DiscountRate, command.Reason, command.StartDate, command.EndDate, command.Description);
                return operation.Success();
            }
            catch (Exception)
            {
                return operation.Failed();
            }
        }

        public EditCustomerDiscountVM Get(long id)
        {
            var entity = _repository.Get(id);
            var result = new EditCustomerDiscountVM
            {
                CreationDate = entity.CreationDate,
                Description = entity.Description,
                DiscountRate = entity.DiscountRate,
                EndDate = entity.EndDate,
                Id = entity.Id,
                IsActive = entity.IsActive,
                IsDeleted = entity.IsActive,
                Reason = entity.Reason,
                StartDate = entity.StartDate
            };
            return result;
        }

        public List<EditCustomerDiscountVM> Get()
        {
            var list = _repository.Get();
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
                    IsDeleted = entity.IsActive,
                    Reason = entity.Reason,
                    StartDate = entity.StartDate

                });
            }
            return result;
        }
    }
}
