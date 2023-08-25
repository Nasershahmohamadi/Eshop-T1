using eShopQuery.Contracts.Slide;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopQuery.Query
{
    public class SlideQuery : ISlideQuery
    {
        private readonly eShopContext _eShopContext;

        public SlideQuery(eShopContext eShopContext)
        {
            _eShopContext = eShopContext;
        }

        public List<SlideQueryVM> Get()
        {
            return _eShopContext.Slides.Select(x => new SlideQueryVM
            {
                BtnText=x.BtnText,
                Heading=x.Heading,
                Link=x.Link,
                Picture=x.Picture,
                PictureAlt=x.PictureAlt,
                PictureTitle=x.PictureTitle,
                Text=x.Text,
                Title=x.Title
            }).ToList();
        }
    }
}
