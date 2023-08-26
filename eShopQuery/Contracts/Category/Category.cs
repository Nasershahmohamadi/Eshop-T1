namespace eShopQuery.Contracts.Category
{
    public class Category
    {
        public long Id { get; set; }
        public string Title { get;  set; }
        public string Picture { get;  set; }
        public string PictureTitle { get;  set; }
        public string PictureAlt { get;  set; }
        public string Slug { get;  set; }
        public string Description { get;  set; }
        public string MetaDescription { get;  set; }
        public string KeyWords { get;  set; }
    }

}
