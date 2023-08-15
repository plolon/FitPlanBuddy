using FitPlanBuddy.Database.Repositories;
using FitPlanBuddy.Domain.Repositories;
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
                options.UseSqlServer(configuration.GetConnectionString("CoreDatabase"));
            });
            services.RegisterRepositories();

            return services;
        }

        private static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IExerciseRepository, ExerciseRepository>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;
        }
    }
}
