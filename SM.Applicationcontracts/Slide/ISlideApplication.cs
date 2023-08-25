using Framework.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Applicationcontracts.Slide
{
    public interface ISlideApplication
    {
        OperationResult Create(CreateSlideVM command);
        OperationResult Edit(EditeSlideVM command);
        OperationResult Delete(long id);
        EditeSlideVM Get(long id);
        List<EditeSlideVM> Get();
    }
}
