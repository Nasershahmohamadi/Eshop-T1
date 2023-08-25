using System.Collections.Generic;

namespace eShopQuery.Contracts.Slide
{
    public interface ISlideQuery
    {
        List<SlideQueryVM> Get();
    }
}
