using eShopQuery.Contracts.Category;
using eShopQuery.Contracts.Slide;
using eShopQuery.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Context.ServiceMap
{
    public class ServiceMapperQuery
    {
        public static void map(IServiceCollection services , string connectionString)
        {

            services.AddTransient<ISlideQuery, SlideQuery>();
            services.AddTransient<ICategoryQuery, CategoryQuery>();


            services.AddDbContext<eShopContext>(options =>
            options.UseSqlServer(connectionString)
            );
        }
    }
}
