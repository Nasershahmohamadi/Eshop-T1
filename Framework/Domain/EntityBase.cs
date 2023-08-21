using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Domain
{
  public class EntityBase
    {
        public long Id { get; private set; }
        public DateTime CreationDate { get; private set; }
        public bool IsDeleted { get; private set; }

        public EntityBase()
        {
            CreationDate = DateTime.Now;
            IsDeleted = false;
        }

      public  void Delete()
        {
            IsDeleted = true;
        }

        public void Restore()
        {
            IsDeleted = false;
        }
    }
}
