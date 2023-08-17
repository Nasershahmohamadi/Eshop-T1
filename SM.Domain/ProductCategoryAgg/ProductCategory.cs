using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.ProductCategoryAgg
{
    public class ProductCategory : EntityBase
    {
        public string Title { get;private set; }
        public string Picture { get; private set; }
        public string PictureTitle { get; private set; }
        public string PictureAlt { get; private set; }
        public string Slug { get; private set; }

        public ProductCategory(string title, string picture, string pictureTitle, string pictureAlt, string slug)
        {
            Title = title;
            Picture = picture;
            PictureTitle = pictureTitle;
            PictureAlt = pictureAlt;
            Slug = slug;
        }
        public void Edit(string title, string picture, string pictureTitle, string pictureAlt, string slug )
        {
            Title = title;
            Picture = picture;
            PictureTitle = pictureTitle;
            PictureAlt = pictureAlt;
            Slug = slug;
        }

    }

}
