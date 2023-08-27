using DM.ApplicationContract.CollageContracts;
using DM.Domain.ColleageAgg;
using Framework.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Application.ColleageApplication
{
    public class ColleageDiscountApplication : IColleageDiscountApplication
    {
        private readonly IColleageDiscountRepository _colleageRepository;

        public ColleageDiscountApplication(IColleageDiscountRepository colleageRepository)
        {
            _colleageRepository = colleageRepository;
        }


        public OperationResult Create(CreateColleageDiscount command)
        {
            var _operation = new OperationResult();
            try
            {
                if (_colleageRepository.Create(new ColleageDiscount(10, "تخفیف همکاری")))
                {
                    return _operation.Success();
                }
                return _operation.Failed();
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
                _colleageRepository.Delete(id);
                return _operation.Success();
            }
            catch (Exception)
            {

                return _operation.Failed();
            }
        }

        public OperationResult Edit(EditColleageDiscountVM command)
        {
            var _operation = new OperationResult();
            try
            {
                var entity = _colleageRepository.Get(command.Id);
                entity.Edit(command.DiscountRate, command.Description);
                var result = _colleageRepository.Edit(entity);

                if (result)
                {
                    return _operation.Success();
                }
                return _operation.Failed();
            }
            catch (Exception)
            {

                return _operation.Failed();
            }
        }

        public EditColleageDiscountVM Get(long id)
        {
            var item = _colleageRepository.Get(id);
            return new EditColleageDiscountVM
            {
                CreationDate = item.CreationDate,
                Description = item.Description,
                DiscountRate = item.DiscountRate,
                Id = item.Id,
                IsActive = item.IsActive,
                IsDeleted = item.IsDeleted

            };
        }

        public List<EditColleageDiscountVM> Get()
        {
            var list = _colleageRepository.Get();
            var result = new List<EditColleageDiscountVM>();
            foreach (var item in list)
            {
                result.Add(new EditColleageDiscountVM
                {
                    CreationDate = item.CreationDate,
                    Description = item.Description,
                    DiscountRate = item.DiscountRate,
                    Id = item.Id,
                    IsActive = item.IsActive,
                    IsDeleted = item.IsDeleted
                });
            }
            return result;
        }
    }
}
