using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FitPlanBuddy.Database.IoC
{
    public static class DatabaseRegistration
    {
        public static IServiceCollection RegisterDatabaseServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FPBDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("FPBdatabase"));
            });

            return services;
        }
    }
}
