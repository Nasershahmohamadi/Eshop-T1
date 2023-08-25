using eShopQuery.Contracts.Slide;
using eShopQuery.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Context.ServiceMap
{
    public class ServiceMapper2
    {
        public static void map(IServiceCollection services , string connectionString)
        {

            services.AddTransient<ISlideQuery, SlideQuery>();


            services.AddDbContext<eShopContext>(options =>
            options.UseSqlServer(connectionString)
            );
        }
    }
}
