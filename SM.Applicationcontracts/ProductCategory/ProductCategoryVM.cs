using System;

namespace SM.Applicationcontracts.ProductCategory
{
    public class ProductCategoryVM
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Description { get; set; }
        public string MetaDescription { get; set; }
        public string Keywords { get; set; }


    }
}
