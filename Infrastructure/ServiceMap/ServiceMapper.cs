using Infrastructure.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SM.Application.ProductApplication;
using SM.Application.ProductCategoryApplication;
using SM.Applicationcontracts.Product;
using SM.Applicationcontracts.ProductCategory;
using SM.Domain.ProductAgg;
using SM.Domain.ProductCategoryAgg;

namespace Infrastructure.Context.ServiceMap
{
    public class ServiceMapper
    {
        public static void map(IServiceCollection services , string connectionString)
        {
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddTransient<IProductCategoryApplication, ProductCategoryApplication>();

            services.AddTransient<IProductApplication, ProductApplication>();
            services.AddTransient<IproductRepository, productRepository>();



            services.AddDbContext<eShopContext>(options =>
            options.UseSqlServer(connectionString)
            );
        }
    }
}
