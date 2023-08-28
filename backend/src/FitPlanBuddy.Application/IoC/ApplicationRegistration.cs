using AutoMapper;
using FitPlanBuddy.Application.Profiles;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FitPlanBuddy.Application.IoC
{
    public static class ApplicationRegistration
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.RegisterProfiles();

            return services;
        }

        private static IServiceCollection RegisterProfiles(this IServiceCollection services)
        {
            var config = new MapperConfiguration(options =>
            {
                options.AddProfile<ExerciseProfile>();
                options.AddProfile<MusclePartProfile>();
                options.AddProfile<WorkoutPlanProfile>();
            });

            services.AddSingleton(s => config.CreateMapper());

            return services;
        }


    }
}
