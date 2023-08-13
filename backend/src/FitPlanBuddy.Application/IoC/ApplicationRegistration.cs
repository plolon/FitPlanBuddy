using FitPlanBuddy.Application.Repositories;
using FitPlanBuddy.Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FitPlanBuddy.Application.IoC
{
    public static class ApplicationRegistration
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            services.RegisterRepositories();

            return services;
        }

        private static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;
        }
    }
}
