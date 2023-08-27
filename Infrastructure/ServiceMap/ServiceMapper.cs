using DM.Application.ColleageApplication;
using DM.ApplicationContract.CollageContracts;
using DM.Domain.ColleageAgg;
using Infrastructure.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SM.Application.ProductApplication;
using SM.Application.ProductCategoryApplication;
using SM.Application.SlideApplication;
using SM.Applicationcontracts.Product;
using SM.Applicationcontracts.ProductCategory;
using SM.Applicationcontracts.Slide;
using SM.Domain.ProductAgg;
using SM.Domain.ProductCategoryAgg;
using SM.Domain.SlideAgg;

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

            services.AddTransient<ISlideRepository, SlideRepository>();
            services.AddTransient<ISlideApplication, SlideApplication>();

            services.AddTransient<IColleageDiscountApplication, ColleageDiscountApplication>();
            services.AddTransient<IColleageDiscountRepository, ColleageDiscountRepository>();



            services.AddDbContext<eShopContext>(options =>
            options.UseSqlServer(connectionString)
            );
        }
    }
}
