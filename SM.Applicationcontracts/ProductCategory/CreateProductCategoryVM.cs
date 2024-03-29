﻿using Microsoft.AspNetCore.Http;
using System;

namespace SM.Applicationcontracts.ProductCategory
{
    public class CreateProductCategoryVM

{
        public string Title { get; set; }
        public string Picture { get; set; }
        public string PictureTitle { get; set; }
        public string PictureAlt { get; set; }
        public string Slug { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Description { get; set; }
        public string MetaDescription { get; set; }
        public string KeyWords { get; set; }
    }
}
