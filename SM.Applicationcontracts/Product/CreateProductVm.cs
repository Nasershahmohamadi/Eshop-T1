﻿using SM.Applicationcontracts.ProductCategory;
using System.Collections.Generic;

namespace SM.Applicationcontracts.Product
{
    public class CreateProductVm
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Slug { get; set; }
        public string Keywords { get; set; }
        public string MetaDescription { get; set; }
        public long CategoryId { get; set; }
        public long CreationDate { get; set; }
        public List<ProductCategoryVM> Categories { get; set; }
    }

}
