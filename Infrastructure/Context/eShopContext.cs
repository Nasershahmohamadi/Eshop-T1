using DM.Domain.ColleageAgg;
using DM.Domain.CustomerAgg;
using Infrastructure.ContextBinding;
using Microsoft.EntityFrameworkCore;
using SM.Domain.ProductAgg;
using SM.Domain.ProductCategoryAgg;
using SM.Domain.SlideAgg;

namespace Infrastructure.Context
{
    public class eShopContext : DbContext
    {
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slide> Slides { get; set; }

        public DbSet<ColleageDiscount> ColleageDiscounts { get; set; }

        public DbSet<CustomerDiscount> CustomerDiscounts { get; set; }

        public eShopContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ProductCategoryBinding).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
