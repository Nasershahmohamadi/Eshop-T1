using Framework.Application;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DM.ApplicationContract.CustomerContracts
{
    public interface ICustomerDiscountApplication
    {
        OperationResult Create(CreateDisocuntCustomerVM command); 
        OperationResult Edit(EditCustomerDiscountVM command); 
        OperationResult Delete(long id); 
        EditCustomerDiscountVM Get(long id);
        List<EditCustomerDiscountVM> Get();

    }

}
