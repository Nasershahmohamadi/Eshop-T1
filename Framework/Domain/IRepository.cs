using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Domain
{
    public interface IRepository<Tkey, T> where T : class
    {
        bool Create(T command);
        T Get(Tkey key);
        List<T> Get();
    }
}
