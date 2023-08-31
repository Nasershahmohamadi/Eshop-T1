using DM.Application.ColleageApplication;
using DM.Application.CustomerApplication;
using DM.ApplicationContract.CollageContracts;
using DM.ApplicationContract.CustomerContracts;
using DM.Domain.ColleageAgg;
using DM.Domain.CustomerAgg;
using Infrastructure.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DM.Infrastructure.ServiceMap
{
    public class ServiceMapperDiscount
    {
        public static void map(IServiceCollection services, string connectionString)
        {
            services.AddTransient<ICustomerDiscountApplication, CustomerDiscountApplication>();
            services.AddTransient<ICustomerDiscountRepository, CustomerDiscountRepository>();

            services.AddTransient<IColleageDiscountApplication, ColleageDiscountApplication>();
            services.AddTransient<IColleageDiscountRepository, ColleageDiscountRepository>();


            services.AddDbContext<DiscountContext>(option =>option.UseSqlServer(connectionString));
        }
    }
}
