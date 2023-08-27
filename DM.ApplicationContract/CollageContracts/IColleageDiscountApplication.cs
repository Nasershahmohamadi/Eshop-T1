using DM.Domain.ColleageAgg;
using Framework.Application;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.ApplicationContract.CollageContracts
{
    public interface IColleageDiscountApplication
    {
        OperationResult Create(CreateColleageDiscount command);
        OperationResult Edit(EditColleageDiscount command);
        OperationResult Delete(long id);
        EditColleageDiscount Get(long id);
        List<EditColleageDiscount> Get();
    }
}
