using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.SlideAgg
{
    public interface ISlideRepository : IRepository<long, Slide>
    {
        bool Edit(Slide command);
        bool Delete(long id);
    }
}
