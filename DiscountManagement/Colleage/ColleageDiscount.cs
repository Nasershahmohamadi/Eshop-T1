using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountManagement.Colleage
{
    public class ColleageDiscount : EntityBase
    {
        public int DiscountRate { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }

    }
}
