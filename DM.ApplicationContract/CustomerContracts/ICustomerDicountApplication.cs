using Framework.Application;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.ApplicationContract.CustomerContracts
{
    public interface ICustomerDiscountApplication
    {
        OperationResult Create(CreateCustomerDiscountVM command);
        OperationResult Edit(EditCustomerDiscountVM command);
        OperationResult Delete(long id);
        EditCustomerDiscountVM Get(long id);
        List<EditCustomerDiscountVM> Get();
    }
}
