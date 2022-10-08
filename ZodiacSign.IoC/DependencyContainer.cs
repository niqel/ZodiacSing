using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ZodiacSign.Persistence.Configurations;
using ZodiacSign.AppBusinessImplementations.Configuration;
using ZodiacSign.ConsolePresentation;

namespace ZodiacSign.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddZodiacSignDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddPersistencyContainer(configuration);
            services.AddUseCasesContainer();
            services.AddConsolePresentation();
            return services;
        }
    }
}
